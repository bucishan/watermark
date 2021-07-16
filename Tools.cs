using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace WaterMark
{
    /// <summary>
    /// 水印工具类
    /// </summary>
    public static class Tools
    {
        /// <summary>
        /// 将实际位置中的照片转化为byte[]类型
        /// </summary>
        /// <param name="strFile">string图片地址</param>
        /// <returns>byte[]</returns>
        public static byte[] GetBytesByImagePath(string strFile)
        {
            byte[] bytes = null;
            try
            {
                using (FileStream fs = new FileStream(strFile, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        bytes = br.ReadBytes((int)fs.Length);
                        br.Dispose();
                        br.Close();
                    }
                    fs.Dispose();
                    fs.Close();
                }
                return bytes;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 读取byte[]并转化为图片
        /// </summary>
        /// <param name="bytes">byte[]</param>
        /// <returns>Image</returns>
        public static Image GetImageByBytes(byte[] bytes)
        {
            Image img = null;
            if (bytes == null || bytes.Length <= 0)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                ms.Write(bytes, 0, bytes.Length);
                img = Image.FromStream(ms, true);
            }
            GC.Collect();
            return img;
        }
        /// <summary>
        /// 图片旋转
        /// </summary>
        /// <param name="AngleValue">旋转角度</param>
        /// <returns></returns>
        public static Bitmap Rotate(Bitmap ImageOriginal, float AngleValue)
        {
            AngleValue = AngleValue % 360;
            double radian = AngleValue * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
            int w = ImageOriginal.Width;
            int h = ImageOriginal.Height;
            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));
            Bitmap ImageBaseOriginal = new Bitmap(W, H, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(ImageBaseOriginal);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Point Offset = new Point((W - w) / 2, (H - h) / 2);
            Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            g.Clear(Color.Transparent);
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(360 - AngleValue);
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(ImageOriginal, rect);
            g.ResetTransform();
            g.Save();
            g.Dispose();
            return ImageBaseOriginal;
        }

        /// <summary>
        /// 根据参数生成平铺水印遮罩层
        /// </summary>
        /// <param name="markText">水印文本</param>
        /// <param name="markLayerSize">遮罩层size</param>
        /// <param name="wordSpace">词间距</param>
        /// <param name="rowSpace">行间距</param>
        /// <param name="evenRowSpace">偶数行间距</param>
        /// <param name="markAlpha">颜色透明度</param>
        /// <param name="markFont">字体</param>
        /// <param name="markColor">颜色</param>
        /// <returns></returns>
        public static Image CreateWaterMarkLayer(string markText, int markLayerSize, int wordSpace, int rowSpace, int evenRowSpace, int markAlpha, Font markFont, Color markColor)
        {
            markText = markText.Trim();
            int textByteCount = System.Text.Encoding.Default.GetByteCount(markText);
            float wordWidth = markFont.Size * textByteCount;
            int cloCount = Convert.ToInt32(markLayerSize / (wordWidth + wordSpace));
            int rowCount = Convert.ToInt32(markLayerSize / (markFont.Size + rowSpace));

            Color color = Color.FromArgb(markAlpha, markColor);
            Bitmap layerBmp = new Bitmap(markLayerSize, markLayerSize, PixelFormat.Format32bppArgb);
            Graphics gMark = Graphics.FromImage(layerBmp);
            gMark.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            SolidBrush brush = new SolidBrush(color);
            //gMark.Clear(Color.Black);
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < cloCount; j++)
                {
                    int addSpace = (i + 1) % 2 == 0 ? evenRowSpace : 0;
                    gMark.DrawString(markText, markFont, brush, j * (wordWidth + wordSpace) + addSpace, i * (markFont.Size + rowSpace));
                }
            }
            return Rotate(layerBmp, 45);
        }

        /// <summary>
        /// 给图像添加文本水印
        /// </summary>
        /// <param name="img">图像</param>
        /// <param name="markText">水印文本</param>
        /// <param name="markAlpha">颜色透明度</param>
        /// <param name="markFont">字体</param>
        /// <param name="markColor">颜色</param>
        /// <param name="markPoint">水印位置</param>
        /// <returns>处理后图像</returns>
        public static Image AddWordWaterMark(Image img, string markText, int markAlpha, Font markFont, Color markColor, Point markPoint)
        {
            Color color = Color.FromArgb(markAlpha, markColor);
            using (Graphics g = Graphics.FromImage(img))
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    g.DrawString(markText, markFont, brush, markPoint);
                }
            }
            return img;
        }

        /// <summary>
        /// 给图像添加平铺水印
        /// </summary>
        /// <param name="img">图像</param>
        /// <param name="markLayerImg">遮罩图像</param>
        /// <returns>处理后图像</returns>
        public static Image AddTiledWaterMark(Image img, Image markLayerImg)
        {
            int x = (markLayerImg.Width / 2) - (img.Width / 2);
            int y = (markLayerImg.Height / 2) - (img.Height / 2);
            using (Graphics g = Graphics.FromImage(img))
            {
                g.DrawImage(markLayerImg, new Rectangle(-x, -y, markLayerImg.Width, markLayerImg.Height),
                    0, 0, markLayerImg.Width, markLayerImg.Height, GraphicsUnit.Pixel);
            }
            return img;
        }

    }
}
