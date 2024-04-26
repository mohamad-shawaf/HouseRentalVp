namespace HouseRentalVp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noAccount = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.loginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passwordTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.emailTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.showPassImage = new System.Windows.Forms.PictureBox();
            this.hidePassImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassImage)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.ForeColor = System.Drawing.Color.IndianRed;
            this.password.Location = new System.Drawing.Point(117, 267);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(91, 21);
            this.password.TabIndex = 18;
            this.password.Text = "Password:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.ForeColor = System.Drawing.Color.IndianRed;
            this.email.Location = new System.Drawing.Point(117, 181);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(59, 21);
            this.email.TabIndex = 16;
            this.email.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(111, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login to your account to continue to the dashboard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(271, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login";
            // 
            // noAccount
            // 
            this.noAccount.AutoSize = true;
            this.noAccount.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noAccount.ForeColor = System.Drawing.Color.IndianRed;
            this.noAccount.Location = new System.Drawing.Point(172, 447);
            this.noAccount.Name = "noAccount";
            this.noAccount.Size = new System.Drawing.Size(251, 21);
            this.noAccount.TabIndex = 13;
            this.noAccount.Text = "Don\'t have an account? register!";
            this.noAccount.Click += new System.EventHandler(this.no_account);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(541, -2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 41);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 23;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.ActiveBorderThickness = 2;
            this.loginButton.ActiveCornerRadius = 20;
            this.loginButton.ActiveFillColor = System.Drawing.Color.Brown;
            this.loginButton.ActiveForecolor = System.Drawing.Color.White;
            this.loginButton.ActiveLineColor = System.Drawing.Color.White;
            this.loginButton.BackColor = System.Drawing.Color.Silver;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.ButtonText = "Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.IdleBorderThickness = 2;
            this.loginButton.IdleCornerRadius = 20;
            this.loginButton.IdleFillColor = System.Drawing.Color.IndianRed;
            this.loginButton.IdleForecolor = System.Drawing.Color.White;
            this.loginButton.IdleLineColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(115, 388);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(386, 54);
            this.loginButton.TabIndex = 22;
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsReturn = false;
            this.passwordTextBox.AcceptsTab = false;
            this.passwordTextBox.AnimationSpeed = 200;
            this.passwordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.passwordTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.BackgroundImage")));
            this.passwordTextBox.BorderColorActive = System.Drawing.Color.Brown;
            this.passwordTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordTextBox.BorderColorHover = System.Drawing.Color.Brown;
            this.passwordTextBox.BorderColorIdle = System.Drawing.Color.White;
            this.passwordTextBox.BorderRadius = 1;
            this.passwordTextBox.BorderThickness = 2;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultFont = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.FillColor = System.Drawing.Color.IndianRed;
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.IconLeft = null;
            this.passwordTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.IconPadding = 10;
            this.passwordTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.IconRight")));
            this.passwordTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(115, 291);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordTextBox.Modified = false;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            stateProperties25.BorderColor = System.Drawing.Color.Brown;
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.OnActiveState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.OnDisabledState = stateProperties26;
            stateProperties27.BorderColor = System.Drawing.Color.Brown;
            stateProperties27.FillColor = System.Drawing.Color.Empty;
            stateProperties27.ForeColor = System.Drawing.Color.Empty;
            stateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.OnHoverState = stateProperties27;
            stateProperties28.BorderColor = System.Drawing.Color.White;
            stateProperties28.FillColor = System.Drawing.Color.IndianRed;
            stateProperties28.ForeColor = System.Drawing.Color.Empty;
            stateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.OnIdleState = stateProperties28;
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordTextBox.PlaceholderText = "Enter your password";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(386, 40);
            this.passwordTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordTextBox.TabIndex = 19;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TextMarginBottom = 0;
            this.passwordTextBox.TextMarginLeft = 3;
            this.passwordTextBox.TextMarginTop = 0;
            this.passwordTextBox.TextPlaceholder = "Enter your password";
            this.passwordTextBox.UseSystemPasswordChar = false;
            this.passwordTextBox.WordWrap = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.AcceptsReturn = false;
            this.emailTextBox.AcceptsTab = false;
            this.emailTextBox.AnimationSpeed = 200;
            this.emailTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emailTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emailTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.emailTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailTextBox.BackgroundImage")));
            this.emailTextBox.BorderColorActive = System.Drawing.Color.Brown;
            this.emailTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.emailTextBox.BorderColorHover = System.Drawing.Color.Brown;
            this.emailTextBox.BorderColorIdle = System.Drawing.Color.White;
            this.emailTextBox.BorderRadius = 1;
            this.emailTextBox.BorderThickness = 2;
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultFont = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.FillColor = System.Drawing.Color.IndianRed;
            this.emailTextBox.HideSelection = true;
            this.emailTextBox.IconLeft = null;
            this.emailTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.IconPadding = 10;
            this.emailTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("emailTextBox.IconRight")));
            this.emailTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(115, 205);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.emailTextBox.Modified = false;
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            stateProperties29.BorderColor = System.Drawing.Color.Brown;
            stateProperties29.FillColor = System.Drawing.Color.Empty;
            stateProperties29.ForeColor = System.Drawing.Color.Empty;
            stateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailTextBox.OnActiveState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.emailTextBox.OnDisabledState = stateProperties30;
            stateProperties31.BorderColor = System.Drawing.Color.Brown;
            stateProperties31.FillColor = System.Drawing.Color.Empty;
            stateProperties31.ForeColor = System.Drawing.Color.Empty;
            stateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailTextBox.OnHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.White;
            stateProperties32.FillColor = System.Drawing.Color.IndianRed;
            stateProperties32.ForeColor = System.Drawing.Color.Empty;
            stateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailTextBox.OnIdleState = stateProperties32;
            this.emailTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.emailTextBox.PlaceholderText = "Enter your email";
            this.emailTextBox.ReadOnly = false;
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(386, 40);
            this.emailTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.emailTextBox.TabIndex = 17;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextBox.TextMarginBottom = 0;
            this.emailTextBox.TextMarginLeft = 3;
            this.emailTextBox.TextMarginTop = 0;
            this.emailTextBox.TextPlaceholder = "Enter your email";
            this.emailTextBox.UseSystemPasswordChar = false;
            this.emailTextBox.WordWrap = true;
            // 
            // showPassImage
            // 
            this.showPassImage.BackColor = System.Drawing.Color.IndianRed;
            this.showPassImage.Image = ((System.Drawing.Image)(resources.GetObject("showPassImage.Image")));
            this.showPassImage.Location = new System.Drawing.Point(425, 296);
            this.showPassImage.Name = "showPassImage";
            this.showPassImage.Size = new System.Drawing.Size(39, 30);
            this.showPassImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPassImage.TabIndex = 24;
            this.showPassImage.TabStop = false;
            this.showPassImage.Click += new System.EventHandler(this.showPassImage_Click);
            // 
            // hidePassImage
            // 
            this.hidePassImage.BackColor = System.Drawing.Color.IndianRed;
            this.hidePassImage.Image = ((System.Drawing.Image)(resources.GetObject("hidePassImage.Image")));
            this.hidePassImage.Location = new System.Drawing.Point(425, 296);
            this.hidePassImage.Name = "hidePassImage";
            this.hidePassImage.Size = new System.Drawing.Size(39, 30);
            this.hidePassImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePassImage.TabIndex = 25;
            this.hidePassImage.TabStop = false;
            this.hidePassImage.Click += new System.EventHandler(this.hidePassImage_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(599, 517);
            this.Controls.Add(this.hidePassImage);
            this.Controls.Add(this.showPassImage);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.noAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 loginButton;
        private Bunifu.UI.WinForms.BunifuTextBox passwordTextBox;
        private System.Windows.Forms.Label password;
        private Bunifu.UI.WinForms.BunifuTextBox emailTextBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label noAccount;
        private System.Windows.Forms.PictureBox showPassImage;
        private System.Windows.Forms.PictureBox hidePassImage;
    }
}