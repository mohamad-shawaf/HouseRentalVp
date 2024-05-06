using Bunifu.Framework.UI;
using System;

namespace HouseRentalVp
{
    partial class Tenants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenants));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label8 = new System.Windows.Forms.Label();
            this.GenCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TenantsDGV = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RegisterButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PhoneTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TNameTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TenantsDG = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.TenantsDGV)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenantsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(374, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tenants list";
            // 
            // GenCb
            // 
            this.GenCb.FormattingEnabled = true;
            this.GenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenCb.Location = new System.Drawing.Point(817, 226);
            this.GenCb.Name = "GenCb";
            this.GenCb.Size = new System.Drawing.Size(177, 20);
            this.GenCb.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(266, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(521, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Phone";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TenantsDGV
            // 
            this.TenantsDGV.BackgroundColor = System.Drawing.Color.White;
            this.TenantsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TenantsDGV.Location = new System.Drawing.Point(269, 367);
            this.TenantsDGV.Name = "TenantsDGV";
            this.TenantsDGV.Size = new System.Drawing.Size(857, 264);
            this.TenantsDGV.TabIndex = 13;
            this.TenantsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.TenantsDGV.Click += new System.EventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(200, 69);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(993, 80);
            this.bunifuGradientPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tenants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 3;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Brown;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Delete";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 3;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.IndianRed;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(670, 268);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(114, 42);
            this.bunifuThinButton21.TabIndex = 12;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.ActiveBorderThickness = 3;
            this.RegisterButton.ActiveCornerRadius = 20;
            this.RegisterButton.ActiveFillColor = System.Drawing.Color.Brown;
            this.RegisterButton.ActiveForecolor = System.Drawing.Color.White;
            this.RegisterButton.ActiveLineColor = System.Drawing.Color.White;
            this.RegisterButton.BackColor = System.Drawing.Color.White;
            this.RegisterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.BackgroundImage")));
            this.RegisterButton.ButtonText = "Edit";
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RegisterButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.RegisterButton.IdleBorderThickness = 3;
            this.RegisterButton.IdleCornerRadius = 20;
            this.RegisterButton.IdleFillColor = System.Drawing.Color.IndianRed;
            this.RegisterButton.IdleForecolor = System.Drawing.Color.White;
            this.RegisterButton.IdleLineColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(515, 268);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(5);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(107, 42);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.AcceptsReturn = false;
            this.PhoneTb.AcceptsTab = false;
            this.PhoneTb.AnimationSpeed = 200;
            this.PhoneTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PhoneTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PhoneTb.BackColor = System.Drawing.Color.Transparent;
            this.PhoneTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhoneTb.BackgroundImage")));
            this.PhoneTb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PhoneTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PhoneTb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PhoneTb.BorderColorIdle = System.Drawing.Color.Silver;
            this.PhoneTb.BorderRadius = 1;
            this.PhoneTb.BorderThickness = 1;
            this.PhoneTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PhoneTb.DefaultText = "";
            this.PhoneTb.FillColor = System.Drawing.Color.White;
            this.PhoneTb.HideSelection = true;
            this.PhoneTb.IconLeft = null;
            this.PhoneTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.IconPadding = 10;
            this.PhoneTb.IconRight = null;
            this.PhoneTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.Lines = new string[0];
            this.PhoneTb.Location = new System.Drawing.Point(515, 219);
            this.PhoneTb.MaxLength = 32767;
            this.PhoneTb.MinimumSize = new System.Drawing.Size(1, 1);
            this.PhoneTb.Modified = false;
            this.PhoneTb.Multiline = false;
            this.PhoneTb.Name = "PhoneTb";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PhoneTb.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PhoneTb.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PhoneTb.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PhoneTb.OnIdleState = stateProperties12;
            this.PhoneTb.Padding = new System.Windows.Forms.Padding(3);
            this.PhoneTb.PasswordChar = '\0';
            this.PhoneTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PhoneTb.PlaceholderText = "Enter text";
            this.PhoneTb.ReadOnly = false;
            this.PhoneTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneTb.SelectedText = "";
            this.PhoneTb.SelectionLength = 0;
            this.PhoneTb.SelectionStart = 0;
            this.PhoneTb.ShortcutsEnabled = true;
            this.PhoneTb.Size = new System.Drawing.Size(220, 37);
            this.PhoneTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PhoneTb.TabIndex = 11;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PhoneTb.TextMarginBottom = 0;
            this.PhoneTb.TextMarginLeft = 3;
            this.PhoneTb.TextMarginTop = 0;
            this.PhoneTb.TextPlaceholder = "Enter text";
            this.PhoneTb.UseSystemPasswordChar = false;
            this.PhoneTb.WordWrap = true;
            // 
            // TNameTb
            // 
            this.TNameTb.AcceptsReturn = false;
            this.TNameTb.AcceptsTab = false;
            this.TNameTb.AnimationSpeed = 200;
            this.TNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TNameTb.BackColor = System.Drawing.Color.Transparent;
            this.TNameTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TNameTb.BackgroundImage")));
            this.TNameTb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TNameTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TNameTb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TNameTb.BorderColorIdle = System.Drawing.Color.Silver;
            this.TNameTb.BorderRadius = 1;
            this.TNameTb.BorderThickness = 1;
            this.TNameTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TNameTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TNameTb.DefaultText = "";
            this.TNameTb.FillColor = System.Drawing.Color.White;
            this.TNameTb.HideSelection = true;
            this.TNameTb.IconLeft = null;
            this.TNameTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TNameTb.IconPadding = 10;
            this.TNameTb.IconRight = null;
            this.TNameTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TNameTb.Lines = new string[0];
            this.TNameTb.Location = new System.Drawing.Point(260, 218);
            this.TNameTb.MaxLength = 32767;
            this.TNameTb.MinimumSize = new System.Drawing.Size(1, 1);
            this.TNameTb.Modified = false;
            this.TNameTb.Multiline = false;
            this.TNameTb.Name = "TNameTb";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TNameTb.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TNameTb.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TNameTb.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TNameTb.OnIdleState = stateProperties16;
            this.TNameTb.Padding = new System.Windows.Forms.Padding(3);
            this.TNameTb.PasswordChar = '\0';
            this.TNameTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TNameTb.PlaceholderText = "Enter text";
            this.TNameTb.ReadOnly = false;
            this.TNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TNameTb.SelectedText = "";
            this.TNameTb.SelectionLength = 0;
            this.TNameTb.SelectionStart = 0;
            this.TNameTb.ShortcutsEnabled = true;
            this.TNameTb.Size = new System.Drawing.Size(220, 37);
            this.TNameTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TNameTb.TabIndex = 11;
            this.TNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TNameTb.TextMarginBottom = 0;
            this.TNameTb.TextMarginLeft = 3;
            this.TNameTb.TextMarginTop = 0;
            this.TNameTb.TextPlaceholder = "Enter text";
            this.TNameTb.UseSystemPasswordChar = false;
            this.TNameTb.WordWrap = true;
            this.TNameTb.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1130, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(63, 39);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 6;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox6);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox5);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox4);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox7);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Brown;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(200, 643);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(74, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Logout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Landlords";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apartments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tenants";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-9, 559);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-9, 437);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-7, 358);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-8, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-9, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(24, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(145, 96);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TenantsDG
            // 
            this.TenantsDG.AllowFocused = false;
            this.TenantsDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TenantsDG.AutoSizeHeight = true;
            this.TenantsDG.BorderRadius = 12;
            this.TenantsDG.Image = ((System.Drawing.Image)(resources.GetObject("TenantsDG.Image")));
            this.TenantsDG.IsCircle = true;
            this.TenantsDG.Location = new System.Drawing.Point(1016, 226);
            this.TenantsDG.Name = "TenantsDG";
            this.TenantsDG.Size = new System.Drawing.Size(24, 24);
            this.TenantsDG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TenantsDG.TabIndex = 0;
            this.TenantsDG.TabStop = false;
            this.TenantsDG.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.TenantsDG.Click += new System.EventHandler(this.bunifuPictureBox8_Click);
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 643);
            this.Controls.Add(this.TenantsDGV);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.TNameTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GenCb);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.TenantsDG);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tenants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenants";
            ((System.ComponentModel.ISupportInitialize)(this.TenantsDGV)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenantsDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox CloseButton;
        private BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GenCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.UI.WinForms.BunifuPictureBox TenantsDG;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuTextBox TNameTb;
        private Bunifu.UI.WinForms.BunifuTextBox PhoneTb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BunifuThinButton2 RegisterButton;
        private BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TenantsDGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}