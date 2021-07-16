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
            this.panelCtrl = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPreviewConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.groupTiled = new System.Windows.Forms.GroupBox();
            this.tbEvenRowSpaceTiledVal = new System.Windows.Forms.NumericUpDown();
            this.tbRowSpaceTiledVal = new System.Windows.Forms.NumericUpDown();
            this.tbWordSpaceTiledVal = new System.Windows.Forms.NumericUpDown();
            this.btnFontTiled = new System.Windows.Forms.Button();
            this.btnColorTiled = new System.Windows.Forms.Button();
            this.tbAlphaTiledVal = new System.Windows.Forms.NumericUpDown();
            this.lblContentTiled = new System.Windows.Forms.Label();
            this.lblAlphaTiled = new System.Windows.Forms.Label();
            this.tbAlphaTiled = new System.Windows.Forms.TrackBar();
            this.tbEvenRowSpaceTiled = new System.Windows.Forms.TrackBar();
            this.tbRowSpaceTiled = new System.Windows.Forms.TrackBar();
            this.txtContentTiled = new System.Windows.Forms.TextBox();
            this.tbWordSpaceTiled = new System.Windows.Forms.TrackBar();
            this.lblWordSpaceTiled = new System.Windows.Forms.Label();
            this.lblEvenRowSpaceTiled = new System.Windows.Forms.Label();
            this.lblRowSpaceTiled = new System.Windows.Forms.Label();
            this.groupWord = new System.Windows.Forms.GroupBox();
            this.tbYSingleVal = new System.Windows.Forms.NumericUpDown();
            this.tbXSingleVal = new System.Windows.Forms.NumericUpDown();
            this.tbAlphaSingleVal = new System.Windows.Forms.NumericUpDown();
            this.btnFontSingle = new System.Windows.Forms.Button();
            this.btnColorSingle = new System.Windows.Forms.Button();
            this.txtContentSingle = new System.Windows.Forms.TextBox();
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
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.panelCtrl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupTiled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEvenRowSpaceTiledVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRowSpaceTiledVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordSpaceTiledVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaTiledVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaTiled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEvenRowSpaceTiled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRowSpaceTiled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordSpaceTiled)).BeginInit();
            this.groupWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYSingleVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSingleVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaSingleVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCtrl
            // 
            this.panelCtrl.Controls.Add(this.groupBox3);
            this.panelCtrl.Controls.Add(this.groupTiled);
            this.panelCtrl.Controls.Add(this.groupWord);
            this.panelCtrl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCtrl.Location = new System.Drawing.Point(0, 0);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.Size = new System.Drawing.Size(234, 478);
            this.panelCtrl.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveImage);
            this.groupBox3.Controls.Add(this.btnPreviewConfig);
            this.groupBox3.Controls.Add(this.btnSaveConfig);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(3, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 86);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "结果";
            // 
            // btnPreviewConfig
            // 
            this.btnPreviewConfig.Location = new System.Drawing.Point(9, 20);
            this.btnPreviewConfig.Name = "btnPreviewConfig";
            this.btnPreviewConfig.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewConfig.TabIndex = 1;
            this.btnPreviewConfig.Text = "预览参数";
            this.btnPreviewConfig.UseVisualStyleBackColor = true;
            this.btnPreviewConfig.Click += new System.EventHandler(this.btnPreviewConfig_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(9, 57);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 0;
            this.btnSaveConfig.Text = "保存参数";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // groupTiled
            // 
            this.groupTiled.Controls.Add(this.tbEvenRowSpaceTiledVal);
            this.groupTiled.Controls.Add(this.tbRowSpaceTiledVal);
            this.groupTiled.Controls.Add(this.tbWordSpaceTiledVal);
            this.groupTiled.Controls.Add(this.btnFontTiled);
            this.groupTiled.Controls.Add(this.btnColorTiled);
            this.groupTiled.Controls.Add(this.tbAlphaTiledVal);
            this.groupTiled.Controls.Add(this.lblContentTiled);
            this.groupTiled.Controls.Add(this.lblAlphaTiled);
            this.groupTiled.Controls.Add(this.tbAlphaTiled);
            this.groupTiled.Controls.Add(this.tbEvenRowSpaceTiled);
            this.groupTiled.Controls.Add(this.tbRowSpaceTiled);
            this.groupTiled.Controls.Add(this.txtContentTiled);
            this.groupTiled.Controls.Add(this.tbWordSpaceTiled);
            this.groupTiled.Controls.Add(this.lblWordSpaceTiled);
            this.groupTiled.Controls.Add(this.lblEvenRowSpaceTiled);
            this.groupTiled.Controls.Add(this.lblRowSpaceTiled);
            this.groupTiled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupTiled.Location = new System.Drawing.Point(3, 192);
            this.groupTiled.Name = "groupTiled";
            this.groupTiled.Size = new System.Drawing.Size(228, 181);
            this.groupTiled.TabIndex = 0;
            this.groupTiled.TabStop = false;
            this.groupTiled.Text = "平铺水印";
            // 
            // tbEvenRowSpaceTiledVal
            // 
            this.tbEvenRowSpaceTiledVal.Location = new System.Drawing.Point(168, 124);
            this.tbEvenRowSpaceTiledVal.Name = "tbEvenRowSpaceTiledVal";
            this.tbEvenRowSpaceTiledVal.Size = new System.Drawing.Size(54, 21);
            this.tbEvenRowSpaceTiledVal.TabIndex = 5;
            this.tbEvenRowSpaceTiledVal.ValueChanged += new System.EventHandler(this.tbEvenRowSpaceTiledVal_ValueChanged);
            // 
            // tbRowSpaceTiledVal
            // 
            this.tbRowSpaceTiledVal.Location = new System.Drawing.Point(168, 97);
            this.tbRowSpaceTiledVal.Name = "tbRowSpaceTiledVal";
            this.tbRowSpaceTiledVal.Size = new System.Drawing.Size(54, 21);
            this.tbRowSpaceTiledVal.TabIndex = 5;
            this.tbRowSpaceTiledVal.ValueChanged += new System.EventHandler(this.tbRowSpaceTiledVal_ValueChanged);
            // 
            // tbWordSpaceTiledVal
            // 
            this.tbWordSpaceTiledVal.Location = new System.Drawing.Point(168, 71);
            this.tbWordSpaceTiledVal.Name = "tbWordSpaceTiledVal";
            this.tbWordSpaceTiledVal.Size = new System.Drawing.Size(54, 21);
            this.tbWordSpaceTiledVal.TabIndex = 5;
            this.tbWordSpaceTiledVal.ValueChanged += new System.EventHandler(this.tbWordSpaceTiledVal_ValueChanged);
            // 
            // btnFontTiled
            // 
            this.btnFontTiled.Location = new System.Drawing.Point(150, 152);
            this.btnFontTiled.Name = "btnFontTiled";
            this.btnFontTiled.Size = new System.Drawing.Size(75, 23);
            this.btnFontTiled.TabIndex = 4;
            this.btnFontTiled.Text = "选择字体";
            this.btnFontTiled.UseVisualStyleBackColor = true;
            this.btnFontTiled.Click += new System.EventHandler(this.btnFontTiled_Click);
            // 
            // btnColorTiled
            // 
            this.btnColorTiled.Location = new System.Drawing.Point(67, 152);
            this.btnColorTiled.Name = "btnColorTiled";
            this.btnColorTiled.Size = new System.Drawing.Size(75, 23);
            this.btnColorTiled.TabIndex = 4;
            this.btnColorTiled.Text = "选择颜色";
            this.btnColorTiled.UseVisualStyleBackColor = true;
            this.btnColorTiled.Click += new System.EventHandler(this.btnColorTiled_Click);
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
            this.tbAlphaTiledVal.ValueChanged += new System.EventHandler(this.tbAlphaTiledVal_ValueChanged);
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
            this.tbAlphaTiled.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbAlphaTiled_MouseUp);
            // 
            // tbEvenRowSpaceTiled
            // 
            this.tbEvenRowSpaceTiled.AutoSize = false;
            this.tbEvenRowSpaceTiled.Location = new System.Drawing.Point(62, 124);
            this.tbEvenRowSpaceTiled.Maximum = 1;
            this.tbEvenRowSpaceTiled.Name = "tbEvenRowSpaceTiled";
            this.tbEvenRowSpaceTiled.Size = new System.Drawing.Size(99, 20);
            this.tbEvenRowSpaceTiled.TabIndex = 1;
            this.tbEvenRowSpaceTiled.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbEvenRowSpaceTiled.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbEvenRowSpaceTiled_MouseUp);
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
            this.tbRowSpaceTiled.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbRowSpaceTiled_MouseUp);
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
            this.tbWordSpaceTiled.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbWordSpaceTiled_MouseUp);
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
            // lblEvenRowSpaceTiled
            // 
            this.lblEvenRowSpaceTiled.AutoSize = true;
            this.lblEvenRowSpaceTiled.ForeColor = System.Drawing.Color.Teal;
            this.lblEvenRowSpaceTiled.Location = new System.Drawing.Point(4, 129);
            this.lblEvenRowSpaceTiled.Name = "lblEvenRowSpaceTiled";
            this.lblEvenRowSpaceTiled.Size = new System.Drawing.Size(51, 12);
            this.lblEvenRowSpaceTiled.TabIndex = 0;
            this.lblEvenRowSpaceTiled.Text = "偶行距:";
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
            // groupWord
            // 
            this.groupWord.Controls.Add(this.tbYSingleVal);
            this.groupWord.Controls.Add(this.tbXSingleVal);
            this.groupWord.Controls.Add(this.tbAlphaSingleVal);
            this.groupWord.Controls.Add(this.btnFontSingle);
            this.groupWord.Controls.Add(this.btnColorSingle);
            this.groupWord.Controls.Add(this.txtContentSingle);
            this.groupWord.Controls.Add(this.tbYSingle);
            this.groupWord.Controls.Add(this.tbXSingle);
            this.groupWord.Controls.Add(this.tbAlphaSingle);
            this.groupWord.Controls.Add(this.lblContentSingle);
            this.groupWord.Controls.Add(this.lblYSingle);
            this.groupWord.Controls.Add(this.lblXSingle);
            this.groupWord.Controls.Add(this.lblAlphaSingle);
            this.groupWord.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupWord.Location = new System.Drawing.Point(3, 3);
            this.groupWord.Name = "groupWord";
            this.groupWord.Size = new System.Drawing.Size(228, 183);
            this.groupWord.TabIndex = 0;
            this.groupWord.TabStop = false;
            this.groupWord.Text = "文字水印";
            // 
            // tbYSingleVal
            // 
            this.tbYSingleVal.Location = new System.Drawing.Point(167, 97);
            this.tbYSingleVal.Name = "tbYSingleVal";
            this.tbYSingleVal.Size = new System.Drawing.Size(54, 21);
            this.tbYSingleVal.TabIndex = 5;
            this.tbYSingleVal.ValueChanged += new System.EventHandler(this.tbYSingleVal_ValueChanged);
            // 
            // tbXSingleVal
            // 
            this.tbXSingleVal.Location = new System.Drawing.Point(167, 71);
            this.tbXSingleVal.Name = "tbXSingleVal";
            this.tbXSingleVal.Size = new System.Drawing.Size(54, 21);
            this.tbXSingleVal.TabIndex = 5;
            this.tbXSingleVal.ValueChanged += new System.EventHandler(this.tbXSingleVal_ValueChanged);
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
            this.tbAlphaSingleVal.ValueChanged += new System.EventHandler(this.tbAlphaSingleVal_ValueChanged);
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
            this.btnColorSingle.Location = new System.Drawing.Point(146, 125);
            this.btnColorSingle.Name = "btnColorSingle";
            this.btnColorSingle.Size = new System.Drawing.Size(75, 23);
            this.btnColorSingle.TabIndex = 4;
            this.btnColorSingle.Text = "选择颜色";
            this.btnColorSingle.UseVisualStyleBackColor = true;
            this.btnColorSingle.Click += new System.EventHandler(this.btnColorSingle_Click);
            // 
            // txtContentSingle
            // 
            this.txtContentSingle.Location = new System.Drawing.Point(64, 18);
            this.txtContentSingle.Name = "txtContentSingle";
            this.txtContentSingle.Size = new System.Drawing.Size(158, 21);
            this.txtContentSingle.TabIndex = 2;
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
            this.tbYSingle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbYSingle_MouseUp);
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
            this.tbXSingle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbXSingle_MouseUp);
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
            this.tbAlphaSingle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbAlphaSingle_MouseUp);
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
            this.picExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExample.TabIndex = 1;
            this.picExample.TabStop = false;
            this.picExample.DragDrop += new System.Windows.Forms.DragEventHandler(this.picExample_DragDrop);
            this.picExample.DragEnter += new System.Windows.Forms.DragEventHandler(this.picExample_DragEnter);
            // 
            // dialogColorSingle
            // 
            this.dialogColorSingle.FullOpen = true;
            // 
            // dialogColorTiled
            // 
            this.dialogColorTiled.FullOpen = true;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(146, 20);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 60);
            this.btnSaveImage.TabIndex = 2;
            this.btnSaveImage.Text = "保存图像";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // FWaterMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 478);
            this.Controls.Add(this.picExample);
            this.Controls.Add(this.panelCtrl);
            this.Name = "FWaterMark";
            this.Text = "图像水印添加工具";
            this.panelCtrl.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupTiled.ResumeLayout(false);
            this.groupTiled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEvenRowSpaceTiledVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRowSpaceTiledVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordSpaceTiledVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaTiledVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaTiled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEvenRowSpaceTiled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRowSpaceTiled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWordSpaceTiled)).EndInit();
            this.groupWord.ResumeLayout(false);
            this.groupWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYSingleVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSingleVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaSingleVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlphaSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCtrl;
        private System.Windows.Forms.PictureBox picExample;
        private System.Windows.Forms.GroupBox groupTiled;
        private System.Windows.Forms.GroupBox groupWord;
        private System.Windows.Forms.Label lblAlphaSingle;
        private System.Windows.Forms.TrackBar tbAlphaSingle;
        private System.Windows.Forms.TextBox txtContentSingle;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnPreviewConfig;
        private System.Windows.Forms.NumericUpDown tbEvenRowSpaceTiledVal;
        private System.Windows.Forms.TrackBar tbEvenRowSpaceTiled;
        private System.Windows.Forms.Label lblEvenRowSpaceTiled;
        private System.Windows.Forms.Button btnSaveImage;
    }
}

