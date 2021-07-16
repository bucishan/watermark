using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterMark
{
    public partial class FWaterMark : Form
    {
        public FWaterMark()
        {
            InitializeComponent();
            this.panelCtrl.Enabled = false;
            this.picExample.AllowDrop = true;
            InitializeConfig();
        }

        //Font  类型转换
        private FontConverter FontConvert = new FontConverter();
        //Color 类型转换
        private ColorConverter ColorConvert = new ColorConverter();

        //当前操作图像的源数据
        byte[] OriPicture = null;

        //当前操作图像平铺水印遮罩层尺寸
        int layerSize = 0;

        /// <summary>
        /// 初始化配置参数
        /// </summary>
        private void InitializeConfig()
        {
            this.txtContentSingle.Text = INIHelper.ReadString("word", "content", this.txtContentSingle.Text, INIHelper.path);
            this.tbAlphaSingleVal.Value = this.tbAlphaSingle.Value = INIHelper.ReadInteger("word", "alpha", this.tbAlphaSingle.Value, INIHelper.path);
            //this.tbXSingle.Value = INIHelper.ReadInteger("word", "x", this.tbXSingle.Value, INIHelper.path);
            //this.tbYSingle.Value = INIHelper.ReadInteger("word", "y", this.tbYSingle.Value, INIHelper.path);
            this.dialogFontSingle.Font = (Font)FontConvert.ConvertFromString(INIHelper.ReadString("word", "font", "", INIHelper.path));
            this.dialogColorSingle.Color = (Color)ColorConvert.ConvertFromString(INIHelper.ReadString("word", "color", "", INIHelper.path));

            this.txtContentTiled.Text = INIHelper.ReadString("tiled", "content", this.txtContentTiled.Text, INIHelper.path);
            this.tbAlphaTiledVal.Value = this.tbAlphaTiled.Value = INIHelper.ReadInteger("tiled", "alpha", this.tbAlphaTiled.Value, INIHelper.path);
            //this.tbWordSpaceTiled.Value = INIHelper.ReadInteger("tiled", "wordspace", this.tbWordSpaceTiled.Value, INIHelper.path);
            //this.tbRowSpaceTiled.Value = INIHelper.ReadInteger("tiled", "rowspace", this.tbRowSpaceTiled.Value, INIHelper.path);
            //this.tbEvenRowSpaceTiled.Value = INIHelper.ReadInteger("tiled", "evenrowspace", this.tbEvenRowSpaceTiled.Value, INIHelper.path);
            this.dialogFontTiled.Font = (Font)FontConvert.ConvertFromString(INIHelper.ReadString("tiled", "font", "", INIHelper.path));
            this.dialogColorTiled.Color = (Color)ColorConvert.ConvertFromString(INIHelper.ReadString("tiled", "color", "", INIHelper.path));
        }

        /// <summary>
        /// 刷新参数控制器属性值
        /// </summary>
        private void RefreshConfigCtrl()
        {
            if (OriPicture == null) return;

            int textByteCount = System.Text.Encoding.Default.GetByteCount(this.txtContentTiled.Text.Trim());
            float wordWidth = this.dialogFontTiled.Font.Size * textByteCount;

            this.tbWordSpaceTiledVal.Maximum = this.tbWordSpaceTiled.Maximum = (int)wordWidth;
            this.tbRowSpaceTiledVal.Maximum = this.tbRowSpaceTiled.Maximum = Convert.ToInt32(Math.Ceiling((layerSize - this.dialogFontTiled.Font.Size) / 10f));
            this.tbEvenRowSpaceTiledVal.Maximum = this.tbEvenRowSpaceTiled.Maximum = Convert.ToInt32(Math.Ceiling((layerSize - this.dialogFontTiled.Font.Size) / 10f));
        }

        #region ---------------图像拖拽---------------

        private void picExample_DragDrop(object sender, DragEventArgs e)
        {
            string fileName = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            OriPicture = Tools.GetBytesByImagePath(fileName);
            Image img = Tools.GetImageByBytes(OriPicture);
            this.picExample.Image = img;

            layerSize = (int)Math.Ceiling(Math.Sqrt(Math.Pow(img.Width, 2) + Math.Pow(img.Height, 2)));

            this.tbXSingleVal.Maximum = this.tbXSingle.Maximum = img.Width;
            this.tbYSingleVal.Maximum = this.tbYSingle.Maximum = img.Height;
            RefreshConfigCtrl();
            this.panelCtrl.Enabled = true;
        }

        private void picExample_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion

        #region ---------------文字水印---------------

        /// <summary>
        /// 文字颜色透明度
        /// </summary>

        private void tbAlphaSingle_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbAlphaSingleVal.Value = this.tbAlphaSingle.Value;
        }
        private void tbAlphaSingleVal_ValueChanged(object sender, EventArgs e)
        {
            this.tbAlphaSingle.Value = (int)this.tbAlphaSingleVal.Value;
            btnPreviewConfig.PerformClick();
        }
        /// <summary>
        /// 坐标X
        /// </summary>
        private void tbXSingle_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbXSingleVal.Value = this.tbXSingle.Value;
        }
        private void tbXSingleVal_ValueChanged(object sender, EventArgs e)
        {
            this.tbXSingle.Value = (int)this.tbXSingleVal.Value;
            btnPreviewConfig.PerformClick();
        }

        /// <summary>
        /// 坐标Y
        /// </summary>
        /// 
        private void tbYSingle_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbYSingleVal.Value = this.tbYSingle.Value;
        }
        private void tbYSingleVal_ValueChanged(object sender, EventArgs e)
        {
            this.tbYSingle.Value = (int)this.tbYSingleVal.Value;
            btnPreviewConfig.PerformClick();
        }
        /// <summary>
        /// 选择颜色
        /// </summary>
        private void btnColorSingle_Click(object sender, EventArgs e)
        {
            if (dialogColorSingle.ShowDialog() == DialogResult.OK)
            {
                btnPreviewConfig.PerformClick();
            }
        }
        /// <summary>
        /// 选择字体
        /// </summary>
        private void btnFontSingle_Click(object sender, EventArgs e)
        {
            if (dialogFontSingle.ShowDialog() == DialogResult.OK)
            {
                btnPreviewConfig.PerformClick();
            }
        }

        #endregion


        #region ---------------平铺水印---------------
        /// <summary>
        /// 颜色透明度
        /// </summary>
        private void tbAlphaTiled_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbAlphaTiledVal.Value = this.tbAlphaTiled.Value;

        }
        private void tbAlphaTiledVal_ValueChanged(object sender, EventArgs e)
        {
            this.tbAlphaTiled.Value = (int)this.tbAlphaTiledVal.Value;
            btnPreviewConfig.PerformClick();
        }
        /// <summary>
        /// 词间距
        /// </summary>
        private void tbWordSpaceTiled_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbWordSpaceTiledVal.Value = this.tbWordSpaceTiled.Value;
        }
        private void tbWordSpaceTiledVal_ValueChanged(object sender, EventArgs e)
        {
            this.tbWordSpaceTiled.Value = (int)this.tbWordSpaceTiledVal.Value;
            btnPreviewConfig.PerformClick();
        }
        /// <summary>
        /// 行间距
        /// </summary>
        private void tbRowSpaceTiled_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbRowSpaceTiledVal.Value = this.tbRowSpaceTiled.Value;
        }
        private void tbRowSpaceTiledVal_ValueChanged(object sender, EventArgs e)
        {
            this.tbRowSpaceTiled.Value = (int)this.tbRowSpaceTiledVal.Value;
            btnPreviewConfig.PerformClick();
        }
        /// <summary>
        /// 偶数行间距
        /// </summary>
        private void tbEvenRowSpaceTiled_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbEvenRowSpaceTiledVal.Value = this.tbEvenRowSpaceTiled.Value;
        }
        private void tbEvenRowSpaceTiledVal_ValueChanged(object sender, EventArgs e)
        {
            this.tbEvenRowSpaceTiled.Value = (int)this.tbEvenRowSpaceTiledVal.Value;
            btnPreviewConfig.PerformClick();
        }

        private void btnColorTiled_Click(object sender, EventArgs e)
        {
            if (dialogColorTiled.ShowDialog() == DialogResult.OK)
            {
                btnPreviewConfig.PerformClick();
            }
        }

        private void btnFontTiled_Click(object sender, EventArgs e)
        {
            if (dialogFontTiled.ShowDialog() == DialogResult.OK)
            {
                btnPreviewConfig.PerformClick();
            }
        }
        #endregion

        /// <summary>
        /// 预览参数配置
        /// </summary>
        private void btnPreviewConfig_Click(object sender, EventArgs e)
        {
            if (OriPicture == null) return;

            Image img = Tools.GetImageByBytes(OriPicture);
            this.picExample.Image = img;

            //分数水印配置是否开启
            if (txtContentSingle.Text.Trim() != "")
            {
                this.picExample.Image = Tools.AddWordWaterMark(this.picExample.Image,
                this.txtContentSingle.Text.Trim(), this.tbAlphaSingle.Value,
                this.dialogFontSingle.Font, this.dialogColorSingle.Color,
                new Point(this.tbXSingle.Value, this.tbYSingle.Value));
            }

            //平铺水印配置是否开启
            if (txtContentTiled.Text.Trim() != "")
            {
                Image markLayerImg = Tools.CreateWaterMarkLayer(txtContentTiled.Text.Trim(), layerSize,
                    this.tbWordSpaceTiled.Value, this.tbRowSpaceTiled.Value, this.tbEvenRowSpaceTiled.Value,
                    this.tbAlphaTiled.Value, this.dialogFontTiled.Font, this.dialogColorTiled.Color);
                this.picExample.Image = Tools.AddTiledWaterMark(this.picExample.Image, markLayerImg);
                //this.picExample.Image = markLayerImg;
                this.picExample.Refresh();
            }
        }

        /// <summary>
        /// 保存参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            INIHelper.WriteString("word", "content", this.txtContentSingle.Text, INIHelper.path);
            INIHelper.WriteInteger("word", "alpha", this.tbAlphaSingle.Value, INIHelper.path);
            INIHelper.WriteInteger("word", "x", this.tbXSingle.Value, INIHelper.path);
            INIHelper.WriteInteger("word", "y", this.tbYSingle.Value, INIHelper.path);
            INIHelper.WriteString("word", "font", FontConvert.ConvertToString(this.dialogFontSingle.Font), INIHelper.path);
            INIHelper.WriteString("word", "color", ColorConvert.ConvertToString(this.dialogColorSingle.Color), INIHelper.path);


            INIHelper.WriteString("tiled", "content", this.txtContentTiled.Text, INIHelper.path);
            INIHelper.WriteInteger("tiled", "alpha", this.tbAlphaTiled.Value, INIHelper.path);
            //INIHelper.WriteInteger("tiled", "wordspace", this.tbWordSpaceTiled.Value, INIHelper.path);
            //INIHelper.WriteInteger("tiled", "rowspace", this.tbRowSpaceTiled.Value, INIHelper.path);
            //INIHelper.WriteInteger("tiled", "evenrowspace", this.tbEvenRowSpaceTiled.Value, INIHelper.path);
            INIHelper.WriteString("tiled", "font", FontConvert.ConvertToString(this.dialogFontTiled.Font), INIHelper.path);
            INIHelper.WriteString("tiled", "color", ColorConvert.ConvertToString(this.dialogColorTiled.Color), INIHelper.path);

            // Font sss = FontConvert.ConvertFromString(fontstr) as Font;
        }

        /// <summary>
        /// 保存图像
        /// </summary>
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "图像（*.png）|*.png|图像（*.jpg）|*.jpg|图像（*.jpeg）|*.jpeg";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.picExample.Image.Save(sfd.FileName.ToString());
            }
        }
    }
}
