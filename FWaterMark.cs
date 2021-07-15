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
        }
        #region ---------------文字水印---------------

        /// <summary>
        /// 文字颜色透明度
        /// </summary>
        private void tbAlphaSingle_Scroll(object sender, EventArgs e)
        {
            this.tbAlphaSingleVal.Value = this.tbAlphaSingle.Value;
        }
        /// <summary>
        /// 选择颜色
        /// </summary>
        private void btnColorSingle_Click(object sender, EventArgs e)
        {
            if (dialogColorSingle.ShowDialog() == DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// 选择字体
        /// </summary>
        private void btnFontSingle_Click(object sender, EventArgs e)
        {
            if (dialogFontSingle.ShowDialog() == DialogResult.OK)
            {

            }
        }

        #endregion


        #region ---------------平铺水印---------------

        private void btnColorTiled_Click(object sender, EventArgs e)
        {
            if (dialogColorTiled.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnFontTiled_Click(object sender, EventArgs e)
        {
            if (dialogFontTiled.ShowDialog() == DialogResult.OK)
            {

            }
        } 
        #endregion
    }
}
