namespace WaterMark
{
    partial class FWaterMark
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFontTiled = new System.Windows.Forms.Button();
            this.btnColorTiled = new System.Windows.Forms.Button();
            this.lblContentTiled = new System.Windows.Forms.Label();
            this.lblAlphaTiled = new System.Windows.Forms.Label();
            this.tbAlphaTiled = new System.Windows.Forms.TrackBar();
            this.tbRowSpaceTiled = new System.Windows.Forms.TrackBar();
            this.txtContentTiled = new System.Windows.Forms.TextBox();
            this.tbWordSpaceTiled = new System.Windows.Forms.TrackBar();
            this.lblWordSpaceTiled = new System.Windows.Forms.Label();
            this.lblRowSpaceTiled = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFontSingle = new System.Windows.Forms.Button();
            this.btnColorSingle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbYSingle = new System.Windows.Forms.TrackBar();
            this.tbXSingle = new System.Windows.Forms.TrackBar();
            this.tbAlphaSingle = new System.Windows.Forms.TrackBar();
            this.lblContentSingle = new System.Windows.Forms.Label();
            this.lblYSingle = new System.Windows.Forms.Label();
            this.lblXSingle = new System.Windows.Forms.Label();
            this.lblAlphaSingle = new System.Windows.Forms.Label();
            this.picExample = new System.Windows.Forms.PictureBox();
            this.dialogColorSingle = new System.Windows.Forms.ColorDialog();
            this.dialogFontSingle = new System.Windows.Forms.FontDialog();
            this.dialogColorTiled = new System.Windows.Forms.ColorDialog();
            this.dialogFontTiled = new System.Windows.Forms.FontDialog();
            this.tbAlphaSingleVal = new System.Windows.Forms.NumericUpDown();
            this.tbXSingleVal = new System.Windows.Forms.NumericUpDown();
            this.tbYSingleVal = new System.Windows.Forms.NumericUpDown();
            this.tbAlphaTiledVal = new System.Windows.Forms.NumericUpDown();
            this.tbWordSpaceTiledVal = new System.Windows.Forms.NumericUpDown();
            this.tbRowSpaceTiledVal = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaTiled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRowSpaceTiled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordSpaceTiled)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaSingleVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSingleVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYSingleVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaTiledVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordSpaceTiledVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRowSpaceTiledVal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 478);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRowSpaceTiledVal);
            this.groupBox2.Controls.Add(this.tbWordSpaceTiledVal);
            this.groupBox2.Controls.Add(this.btnFontTiled);
            this.groupBox2.Controls.Add(this.btnColorTiled);
            this.groupBox2.Controls.Add(this.tbAlphaTiledVal);
            this.groupBox2.Controls.Add(this.lblContentTiled);
            this.groupBox2.Controls.Add(this.lblAlphaTiled);
            this.groupBox2.Controls.Add(this.tbAlphaTiled);
            this.groupBox2.Controls.Add(this.tbRowSpaceTiled);
            this.groupBox2.Controls.Add(this.txtContentTiled);
            this.groupBox2.Controls.Add(this.tbWordSpaceTiled);
            this.groupBox2.Controls.Add(this.lblWordSpaceTiled);
            this.groupBox2.Controls.Add(this.lblRowSpaceTiled);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(3, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 161);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "平铺水印";
            // 
            // btnFontTiled
            // 
            this.btnFontTiled.Location = new System.Drawing.Point(147, 129);
            this.btnFontTiled.Name = "btnFontTiled";
            this.btnFontTiled.Size = new System.Drawing.Size(75, 23);
            this.btnFontTiled.TabIndex = 4;
            this.btnFontTiled.Text = "选择字体";
            this.btnFontTiled.UseVisualStyleBackColor = true;
            this.btnFontTiled.Click += new System.EventHandler(this.btnFontTiled_Click);
            // 
            // btnColorTiled
            // 
            this.btnColorTiled.Location = new System.Drawing.Point(64, 129);
            this.btnColorTiled.Name = "btnColorTiled";
            this.btnColorTiled.Size = new System.Drawing.Size(75, 23);
            this.btnColorTiled.TabIndex = 4;
            this.btnColorTiled.Text = "选择颜色";
            this.btnColorTiled.UseVisualStyleBackColor = true;
            this.btnColorTiled.Click += new System.EventHandler(this.btnColorTiled_Click);
            // 
            // lblContentTiled
            // 
            this.lblContentTiled.AutoSize = true;
            this.lblContentTiled.ForeColor = System.Drawing.Color.Teal;
            this.lblContentTiled.Location = new System.Drawing.Point(5, 21);
            this.lblContentTiled.Name = "lblContentTiled";
            this.lblContentTiled.Size = new System.Drawing.Size(52, 12);
            this.lblContentTiled.TabIndex = 0;
            this.lblContentTiled.Text = "内  容:";
            // 
            // lblAlphaTiled
            // 
            this.lblAlphaTiled.AutoSize = true;
            this.lblAlphaTiled.ForeColor = System.Drawing.Color.Teal;
            this.lblAlphaTiled.Location = new System.Drawing.Point(5, 48);
            this.lblAlphaTiled.Name = "lblAlphaTiled";
            this.lblAlphaTiled.Size = new System.Drawing.Size(51, 12);
            this.lblAlphaTiled.TabIndex = 0;
            this.lblAlphaTiled.Text = "透明度:";
            // 
            // tbAlphaTiled
            // 
            this.tbAlphaTiled.AutoSize = false;
            this.tbAlphaTiled.Location = new System.Drawing.Point(63, 45);
            this.tbAlphaTiled.Maximum = 255;
            this.tbAlphaTiled.Name = "tbAlphaTiled";
            this.tbAlphaTiled.Size = new System.Drawing.Size(98, 20);
            this.tbAlphaTiled.TabIndex = 1;
            this.tbAlphaTiled.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAlphaTiled.Value = 255;
            // 
            // tbRowSpaceTiled
            // 
            this.tbRowSpaceTiled.AutoSize = false;
            this.tbRowSpaceTiled.Location = new System.Drawing.Point(62, 97);
            this.tbRowSpaceTiled.Maximum = 1;
            this.tbRowSpaceTiled.Name = "tbRowSpaceTiled";
            this.tbRowSpaceTiled.Size = new System.Drawing.Size(99, 20);
            this.tbRowSpaceTiled.TabIndex = 1;
            this.tbRowSpaceTiled.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // txtContentTiled
            // 
            this.txtContentTiled.Location = new System.Drawing.Point(63, 18);
            this.txtContentTiled.Name = "txtContentTiled";
            this.txtContentTiled.Size = new System.Drawing.Size(158, 21);
            this.txtContentTiled.TabIndex = 2;
            // 
            // tbWordSpaceTiled
            // 
            this.tbWordSpaceTiled.AutoSize = false;
            this.tbWordSpaceTiled.Location = new System.Drawing.Point(62, 71);
            this.tbWordSpaceTiled.Maximum = 1;
            this.tbWordSpaceTiled.Name = "tbWordSpaceTiled";
            this.tbWordSpaceTiled.Size = new System.Drawing.Size(99, 20);
            this.tbWordSpaceTiled.TabIndex = 1;
            this.tbWordSpaceTiled.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblWordSpaceTiled
            // 
            this.lblWordSpaceTiled.AutoSize = true;
            this.lblWordSpaceTiled.ForeColor = System.Drawing.Color.Teal;
            this.lblWordSpaceTiled.Location = new System.Drawing.Point(4, 75);
            this.lblWordSpaceTiled.Name = "lblWordSpaceTiled";
            this.lblWordSpaceTiled.Size = new System.Drawing.Size(51, 12);
            this.lblWordSpaceTiled.TabIndex = 0;
            this.lblWordSpaceTiled.Text = "词间距:";
            // 
            // lblRowSpaceTiled
            // 
            this.lblRowSpaceTiled.AutoSize = true;
            this.lblRowSpaceTiled.ForeColor = System.Drawing.Color.Teal;
            this.lblRowSpaceTiled.Location = new System.Drawing.Point(4, 102);
            this.lblRowSpaceTiled.Name = "lblRowSpaceTiled";
            this.lblRowSpaceTiled.Size = new System.Drawing.Size(51, 12);
            this.lblRowSpaceTiled.TabIndex = 0;
            this.lblRowSpaceTiled.Text = "行间距:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbYSingleVal);
            this.groupBox1.Controls.Add(this.tbXSingleVal);
            this.groupBox1.Controls.Add(this.tbAlphaSingleVal);
            this.groupBox1.Controls.Add(this.btnFontSingle);
            this.groupBox1.Controls.Add(this.btnColorSingle);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tbYSingle);
            this.groupBox1.Controls.Add(this.tbXSingle);
            this.groupBox1.Controls.Add(this.tbAlphaSingle);
            this.groupBox1.Controls.Add(this.lblContentSingle);
            this.groupBox1.Controls.Add(this.lblYSingle);
            this.groupBox1.Controls.Add(this.lblXSingle);
            this.groupBox1.Controls.Add(this.lblAlphaSingle);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文字水印";
            // 
            // btnFontSingle
            // 
            this.btnFontSingle.Location = new System.Drawing.Point(147, 154);
            this.btnFontSingle.Name = "btnFontSingle";
            this.btnFontSingle.Size = new System.Drawing.Size(75, 23);
            this.btnFontSingle.TabIndex = 4;
            this.btnFontSingle.Text = "选择字体";
            this.btnFontSingle.UseVisualStyleBackColor = true;
            this.btnFontSingle.Click += new System.EventHandler(this.btnFontSingle_Click);
            // 
            // btnColorSingle
            // 
            this.btnColorSingle.Location = new System.Drawing.Point(64, 154);
            this.btnColorSingle.Name = "btnColorSingle";
            this.btnColorSingle.Size = new System.Drawing.Size(75, 23);
            this.btnColorSingle.TabIndex = 4;
            this.btnColorSingle.Text = "选择颜色";
            this.btnColorSingle.UseVisualStyleBackColor = true;
            this.btnColorSingle.Click += new System.EventHandler(this.btnColorSingle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 21);
            this.textBox1.TabIndex = 2;
            // 
            // tbYSingle
            // 
            this.tbYSingle.AutoSize = false;
            this.tbYSingle.Location = new System.Drawing.Point(64, 97);
            this.tbYSingle.Maximum = 1;
            this.tbYSingle.Name = "tbYSingle";
            this.tbYSingle.Size = new System.Drawing.Size(97, 20);
            this.tbYSingle.TabIndex = 1;
            this.tbYSingle.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbXSingle
            // 
            this.tbXSingle.AutoSize = false;
            this.tbXSingle.Location = new System.Drawing.Point(64, 71);
            this.tbXSingle.Maximum = 1;
            this.tbXSingle.Name = "tbXSingle";
            this.tbXSingle.Size = new System.Drawing.Size(97, 20);
            this.tbXSingle.TabIndex = 1;
            this.tbXSingle.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbAlphaSingle
            // 
            this.tbAlphaSingle.AutoSize = false;
            this.tbAlphaSingle.Location = new System.Drawing.Point(64, 45);
            this.tbAlphaSingle.Maximum = 255;
            this.tbAlphaSingle.Name = "tbAlphaSingle";
            this.tbAlphaSingle.Size = new System.Drawing.Size(97, 20);
            this.tbAlphaSingle.TabIndex = 1;
            this.tbAlphaSingle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAlphaSingle.Value = 255;
            this.tbAlphaSingle.Scroll += new System.EventHandler(this.tbAlphaSingle_Scroll);
            // 
            // lblContentSingle
            // 
            this.lblContentSingle.AutoSize = true;
            this.lblContentSingle.ForeColor = System.Drawing.Color.Teal;
            this.lblContentSingle.Location = new System.Drawing.Point(6, 21);
            this.lblContentSingle.Name = "lblContentSingle";
            this.lblContentSingle.Size = new System.Drawing.Size(52, 12);
            this.lblContentSingle.TabIndex = 0;
            this.lblContentSingle.Text = "内  容:";
            // 
            // lblYSingle
            // 
            this.lblYSingle.AutoSize = true;
            this.lblYSingle.ForeColor = System.Drawing.Color.Teal;
            this.lblYSingle.Location = new System.Drawing.Point(6, 102);
            this.lblYSingle.Name = "lblYSingle";
            this.lblYSingle.Size = new System.Drawing.Size(52, 12);
            this.lblYSingle.TabIndex = 0;
            this.lblYSingle.Text = "坐标 Y:";
            // 
            // lblXSingle
            // 
            this.lblXSingle.AutoSize = true;
            this.lblXSingle.ForeColor = System.Drawing.Color.Teal;
            this.lblXSingle.Location = new System.Drawing.Point(6, 75);
            this.lblXSingle.Name = "lblXSingle";
            this.lblXSingle.Size = new System.Drawing.Size(52, 12);
            this.lblXSingle.TabIndex = 0;
            this.lblXSingle.Text = "坐标 X:";
            // 
            // lblAlphaSingle
            // 
            this.lblAlphaSingle.AutoSize = true;
            this.lblAlphaSingle.ForeColor = System.Drawing.Color.Teal;
            this.lblAlphaSingle.Location = new System.Drawing.Point(6, 48);
            this.lblAlphaSingle.Name = "lblAlphaSingle";
            this.lblAlphaSingle.Size = new System.Drawing.Size(51, 12);
            this.lblAlphaSingle.TabIndex = 0;
            this.lblAlphaSingle.Text = "透明度:";
            // 
            // picExample
            // 
            this.picExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picExample.Location = new System.Drawing.Point(234, 0);
            this.picExample.Name = "picExample";
            this.picExample.Size = new System.Drawing.Size(537, 478);
            this.picExample.TabIndex = 1;
            this.picExample.TabStop = false;
            // 
            // dialogColorSingle
            // 
            this.dialogColorSingle.FullOpen = true;
            // 
            // dialogColorTiled
            // 
            this.dialogColorTiled.FullOpen = true;
            // 
            // tbAlphaSingleVal
            // 
            this.tbAlphaSingleVal.Location = new System.Drawing.Point(167, 44);
            this.tbAlphaSingleVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tbAlphaSingleVal.Name = "tbAlphaSingleVal";
            this.tbAlphaSingleVal.Size = new System.Drawing.Size(55, 21);
            this.tbAlphaSingleVal.TabIndex = 2;
            this.tbAlphaSingleVal.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // tbXSingleVal
            // 
            this.tbXSingleVal.Location = new System.Drawing.Point(167, 71);
            this.tbXSingleVal.Name = "tbXSingleVal";
            this.tbXSingleVal.Size = new System.Drawing.Size(54, 21);
            this.tbXSingleVal.TabIndex = 5;
            // 
            // tbYSingleVal
            // 
            this.tbYSingleVal.Location = new System.Drawing.Point(167, 97);
            this.tbYSingleVal.Name = "tbYSingleVal";
            this.tbYSingleVal.Size = new System.Drawing.Size(54, 21);
            this.tbYSingleVal.TabIndex = 5;
            // 
            // tbAlphaTiledVal
            // 
            this.tbAlphaTiledVal.Location = new System.Drawing.Point(167, 45);
            this.tbAlphaTiledVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tbAlphaTiledVal.Name = "tbAlphaTiledVal";
            this.tbAlphaTiledVal.Size = new System.Drawing.Size(55, 21);
            this.tbAlphaTiledVal.TabIndex = 2;
            this.tbAlphaTiledVal.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // tbWordSpaceTiledVal
            // 
            this.tbWordSpaceTiledVal.Location = new System.Drawing.Point(168, 71);
            this.tbWordSpaceTiledVal.Name = "tbWordSpaceTiledVal";
            this.tbWordSpaceTiledVal.Size = new System.Drawing.Size(54, 21);
            this.tbWordSpaceTiledVal.TabIndex = 5;
            // 
            // tbRowSpaceTiledVal
            // 
            this.tbRowSpaceTiledVal.Location = new System.Drawing.Point(168, 97);
            this.tbRowSpaceTiledVal.Name = "tbRowSpaceTiledVal";
            this.tbRowSpaceTiledVal.Size = new System.Drawing.Size(54, 21);
            this.tbRowSpaceTiledVal.TabIndex = 5;
            // 
            // FWaterMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 478);
            this.Controls.Add(this.picExample);
            this.Controls.Add(this.panel1);
            this.Name = "FWaterMark";
            this.Text = "图像水印添加工具";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaTiled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRowSpaceTiled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordSpaceTiled)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaSingleVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSingleVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYSingleVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaTiledVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordSpaceTiledVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRowSpaceTiledVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picExample;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAlphaSingle;
        private System.Windows.Forms.TrackBar tbAlphaSingle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblContentSingle;
        private System.Windows.Forms.TrackBar tbYSingle;
        private System.Windows.Forms.TrackBar tbXSingle;
        private System.Windows.Forms.Label lblYSingle;
        private System.Windows.Forms.Label lblXSingle;
        private System.Windows.Forms.Button btnFontSingle;
        private System.Windows.Forms.Button btnColorSingle;
        private System.Windows.Forms.Button btnFontTiled;
        private System.Windows.Forms.Button btnColorTiled;
        private System.Windows.Forms.Label lblContentTiled;
        private System.Windows.Forms.Label lblAlphaTiled;
        private System.Windows.Forms.TrackBar tbAlphaTiled;
        private System.Windows.Forms.TrackBar tbRowSpaceTiled;
        private System.Windows.Forms.TextBox txtContentTiled;
        private System.Windows.Forms.TrackBar tbWordSpaceTiled;
        private System.Windows.Forms.Label lblWordSpaceTiled;
        private System.Windows.Forms.Label lblRowSpaceTiled;
        private System.Windows.Forms.ColorDialog dialogColorSingle;
        private System.Windows.Forms.FontDialog dialogFontSingle;
        private System.Windows.Forms.ColorDialog dialogColorTiled;
        private System.Windows.Forms.FontDialog dialogFontTiled;
        private System.Windows.Forms.NumericUpDown tbAlphaSingleVal;
        private System.Windows.Forms.NumericUpDown tbRowSpaceTiledVal;
        private System.Windows.Forms.NumericUpDown tbWordSpaceTiledVal;
        private System.Windows.Forms.NumericUpDown tbAlphaTiledVal;
        private System.Windows.Forms.NumericUpDown tbYSingleVal;
        private System.Windows.Forms.NumericUpDown tbXSingleVal;
    }
}

