namespace GSMTurkey_TWRP_DownLoader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Logo = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.theme_krypton = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonDockableNavigator1 = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.page_Qualcomm = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.combo_Sunucu = new System.Windows.Forms.ComboBox();
            this.lbl_Sunucu = new System.Windows.Forms.Label();
            this.combo_Surum = new System.Windows.Forms.ComboBox();
            this.lbl_Surum = new System.Windows.Forms.Label();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.combo_MarkaModel = new System.Windows.Forms.ComboBox();
            this.kryptonPage6 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Link = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Download = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).BeginInit();
            this.kryptonDockableNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page_Qualcomm)).BeginInit();
            this.page_Qualcomm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage6)).BeginInit();
            this.kryptonPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Logo
            // 
            // 
            // 
            // 
            this.label_Logo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_Logo.Location = new System.Drawing.Point(149, 3);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(332, 50);
            this.label_Logo.TabIndex = 0;
            this.label_Logo.Text = "<b><font size=\"+6\" color=\"Black\"><i>GSMTurkey </i> <font color=\"#C28C32\"> TWRP Do" +
    "wnLoader</font></font></b>";
            this.label_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label_Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // theme_krypton
            // 
            this.theme_krypton.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black;
            this.theme_krypton.GlobalStrings.Abort = "Hata";
            this.theme_krypton.GlobalStrings.Cancel = "Iptal";
            this.theme_krypton.GlobalStrings.Close = "Kapat";
            this.theme_krypton.GlobalStrings.Ignore = "Atla";
            this.theme_krypton.GlobalStrings.No = "Hayır";
            this.theme_krypton.GlobalStrings.OK = "Tamam";
            this.theme_krypton.GlobalStrings.Retry = "Tekrar Dene";
            this.theme_krypton.GlobalStrings.Today = "Bugün";
            this.theme_krypton.GlobalStrings.Yes = "Evet";
            // 
            // kryptonDockableNavigator1
            // 
            this.kryptonDockableNavigator1.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.kryptonDockableNavigator1.Bar.ItemAlignment = ComponentFactory.Krypton.Toolkit.RelativePositionAlign.Center;
            this.kryptonDockableNavigator1.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.kryptonDockableNavigator1.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidthAndHeight;
            this.kryptonDockableNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonDockableNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.HidePage;
            this.kryptonDockableNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator1.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.kryptonDockableNavigator1.Header.HeaderPositionBar = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom;
            this.kryptonDockableNavigator1.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Custom1;
            this.kryptonDockableNavigator1.Location = new System.Drawing.Point(1, 53);
            this.kryptonDockableNavigator1.Name = "kryptonDockableNavigator1";
            this.kryptonDockableNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.kryptonDockableNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabDock;
            this.kryptonDockableNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.page_Qualcomm,
            this.kryptonPage6});
            this.kryptonDockableNavigator1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonDockableNavigator1.SelectedIndex = 0;
            this.kryptonDockableNavigator1.Size = new System.Drawing.Size(595, 152);
            this.kryptonDockableNavigator1.TabIndex = 9;
            this.kryptonDockableNavigator1.Text = "kryptonDockableNavigator1";
            // 
            // page_Qualcomm
            // 
            this.page_Qualcomm.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.page_Qualcomm.Controls.Add(this.combo_Sunucu);
            this.page_Qualcomm.Controls.Add(this.lbl_Sunucu);
            this.page_Qualcomm.Controls.Add(this.combo_Surum);
            this.page_Qualcomm.Controls.Add(this.lbl_Surum);
            this.page_Qualcomm.Controls.Add(this.lbl_Marka);
            this.page_Qualcomm.Controls.Add(this.combo_MarkaModel);
            this.page_Qualcomm.Flags = 65534;
            this.page_Qualcomm.LastVisibleSet = true;
            this.page_Qualcomm.MinimumSize = new System.Drawing.Size(50, 50);
            this.page_Qualcomm.Name = "page_Qualcomm";
            this.page_Qualcomm.Size = new System.Drawing.Size(593, 123);
            this.page_Qualcomm.Text = "TWRP";
            this.page_Qualcomm.ToolTipImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(164)))));
            this.page_Qualcomm.ToolTipTitle = "Page ToolTip";
            this.page_Qualcomm.UniqueName = "17C29AD175BF4C0121B37FD02911FFF7";
            this.page_Qualcomm.Click += new System.EventHandler(this.kryptonPage1_Click);
            // 
            // combo_Sunucu
            // 
            this.combo_Sunucu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Sunucu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Sunucu.FormattingEnabled = true;
            this.combo_Sunucu.Location = new System.Drawing.Point(10, 99);
            this.combo_Sunucu.Name = "combo_Sunucu";
            this.combo_Sunucu.Size = new System.Drawing.Size(580, 21);
            this.combo_Sunucu.TabIndex = 21;
            // 
            // lbl_Sunucu
            // 
            this.lbl_Sunucu.AutoSize = true;
            this.lbl_Sunucu.BackColor = System.Drawing.Color.White;
            this.lbl_Sunucu.Location = new System.Drawing.Point(7, 83);
            this.lbl_Sunucu.Name = "lbl_Sunucu";
            this.lbl_Sunucu.Size = new System.Drawing.Size(50, 13);
            this.lbl_Sunucu.TabIndex = 20;
            this.lbl_Sunucu.Text = "Sunucu :";
            // 
            // combo_Surum
            // 
            this.combo_Surum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Surum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Surum.FormattingEnabled = true;
            this.combo_Surum.Location = new System.Drawing.Point(10, 59);
            this.combo_Surum.Name = "combo_Surum";
            this.combo_Surum.Size = new System.Drawing.Size(580, 21);
            this.combo_Surum.TabIndex = 19;
            // 
            // lbl_Surum
            // 
            this.lbl_Surum.AutoSize = true;
            this.lbl_Surum.BackColor = System.Drawing.Color.White;
            this.lbl_Surum.Location = new System.Drawing.Point(7, 43);
            this.lbl_Surum.Name = "lbl_Surum";
            this.lbl_Surum.Size = new System.Drawing.Size(43, 13);
            this.lbl_Surum.TabIndex = 18;
            this.lbl_Surum.Text = "Sürüm :";
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.BackColor = System.Drawing.Color.White;
            this.lbl_Marka.Location = new System.Drawing.Point(7, 3);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(43, 13);
            this.lbl_Marka.TabIndex = 17;
            this.lbl_Marka.Text = "Marka :";
            // 
            // combo_MarkaModel
            // 
            this.combo_MarkaModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_MarkaModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_MarkaModel.FormattingEnabled = true;
            this.combo_MarkaModel.Location = new System.Drawing.Point(10, 19);
            this.combo_MarkaModel.Name = "combo_MarkaModel";
            this.combo_MarkaModel.Size = new System.Drawing.Size(580, 21);
            this.combo_MarkaModel.Sorted = true;
            this.combo_MarkaModel.TabIndex = 16;
            this.combo_MarkaModel.SelectedIndexChanged += new System.EventHandler(this.Combo_MarkaModel_SelectedIndexChanged);
            // 
            // kryptonPage6
            // 
            this.kryptonPage6.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage6.Controls.Add(this.bunifuFlatButton2);
            this.kryptonPage6.Controls.Add(this.bunifuFlatButton1);
            this.kryptonPage6.Flags = 65534;
            this.kryptonPage6.LastVisibleSet = true;
            this.kryptonPage6.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage6.Name = "kryptonPage6";
            this.kryptonPage6.Size = new System.Drawing.Size(593, 123);
            this.kryptonPage6.Text = "Update DB";
            this.kryptonPage6.ToolTipTitle = "Page ToolTip";
            this.kryptonPage6.UniqueName = "7F1C1E99EC734E7AAC838117E55C8F16";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "VeriTabanı Güncellemesi";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(306, 19);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(279, 74);
            this.bunifuFlatButton2.TabIndex = 24;
            this.bunifuFlatButton2.Text = "VeriTabanı Güncellemesi";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Uygulama Güncelleme Denetle";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(10, 19);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(279, 74);
            this.bunifuFlatButton1.TabIndex = 23;
            this.bunifuFlatButton1.Text = "Uygulama Güncelleme Denetle";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.btn_Minimize.Location = new System.Drawing.Point(542, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btn_Minimize.Size = new System.Drawing.Size(27, 25);
            this.btn_Minimize.TabIndex = 8;
            this.btn_Minimize.Values.Text = "__";
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.btn_Close.Location = new System.Drawing.Point(569, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btn_Close.Size = new System.Drawing.Size(27, 25);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Values.Text = "X";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Location = new System.Drawing.Point(441, 463);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(31, 13);
            this.lbl_Link.TabIndex = 14;
            this.lbl_Link.Text = "LINK";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 282);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(584, 157);
            this.data.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 456);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // btn_Download
            // 
            this.btn_Download.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btn_Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Download.BorderRadius = 0;
            this.btn_Download.ButtonText = "İndirme İşlemini Başlat";
            this.btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Download.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Download.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Download.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Download.Iconimage")));
            this.btn_Download.Iconimage_right = null;
            this.btn_Download.Iconimage_right_Selected = null;
            this.btn_Download.Iconimage_Selected = null;
            this.btn_Download.IconMarginLeft = 0;
            this.btn_Download.IconMarginRight = 0;
            this.btn_Download.IconRightVisible = true;
            this.btn_Download.IconRightZoom = 0D;
            this.btn_Download.IconVisible = true;
            this.btn_Download.IconZoom = 90D;
            this.btn_Download.IsTab = false;
            this.btn_Download.Location = new System.Drawing.Point(3, 235);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btn_Download.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.btn_Download.OnHoverTextColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Download.selected = false;
            this.btn_Download.Size = new System.Drawing.Size(592, 23);
            this.btn_Download.TabIndex = 19;
            this.btn_Download.Text = "İndirme İşlemini Başlat";
            this.btn_Download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Download.Textcolor = System.Drawing.Color.Black;
            this.btn_Download.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Download.Click += new System.EventHandler(this.Btn_Download_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(121, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Toplam Dosya Boyutu : 0 MB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(348, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Anlık İndirilen Veri : 0 KB";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Silver;
            this.progressBar.BorderRadius = 5;
            this.progressBar.Location = new System.Drawing.Point(3, 221);
            this.progressBar.MaximumValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(186)))), ((int)(((byte)(111)))));
            this.progressBar.Size = new System.Drawing.Size(592, 10);
            this.progressBar.TabIndex = 22;
            this.progressBar.Value = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(513, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Barış MIZRAKLI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(599, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.lbl_Link);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.kryptonDockableNavigator1);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.label_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).EndInit();
            this.kryptonDockableNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.page_Qualcomm)).EndInit();
            this.page_Qualcomm.ResumeLayout(false);
            this.page_Qualcomm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage6)).EndInit();
            this.kryptonPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel label_Logo;
        private ComponentFactory.Krypton.Toolkit.KryptonManager theme_krypton;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator kryptonDockableNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage page_Qualcomm;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private System.Windows.Forms.ComboBox combo_Sunucu;
        private System.Windows.Forms.Label lbl_Sunucu;
        private System.Windows.Forms.ComboBox combo_Surum;
        private System.Windows.Forms.Label lbl_Surum;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.ComboBox combo_MarkaModel;
        private System.Windows.Forms.Label lbl_Link;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuProgressBar progressBar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label3;
    }
}

