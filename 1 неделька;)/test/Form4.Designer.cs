namespace WindowsFormsApp4
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.enterButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.regButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.SlateBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
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
            this.bunifuFlatButton1.IconZoom = 30D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(322, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.SlateBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(56, 26);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.SlateBlue;
            this.passwordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.HintText = "";
            this.passwordTextBox.isPassword = false;
            this.passwordTextBox.LineFocusedColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordTextBox.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.passwordTextBox.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.passwordTextBox.LineThickness = 3;
            this.passwordTextBox.Location = new System.Drawing.Point(176, 66);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(162, 21);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginTextBox.ForeColor = System.Drawing.Color.SlateBlue;
            this.loginTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.loginTextBox.HintText = "";
            this.loginTextBox.isPassword = false;
            this.loginTextBox.LineFocusedColor = System.Drawing.Color.MediumSlateBlue;
            this.loginTextBox.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.loginTextBox.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.loginTextBox.LineThickness = 3;
            this.loginTextBox.Location = new System.Drawing.Point(175, 33);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(162, 21);
            this.loginTextBox.TabIndex = 10;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // enterButton
            // 
            this.enterButton.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.enterButton.BackColor = System.Drawing.Color.SlateBlue;
            this.enterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterButton.BorderRadius = 0;
            this.enterButton.ButtonText = "Авторизоваться";
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.DisabledColor = System.Drawing.Color.Gray;
            this.enterButton.Iconcolor = System.Drawing.Color.Transparent;
            this.enterButton.Iconimage = null;
            this.enterButton.Iconimage_right = null;
            this.enterButton.Iconimage_right_Selected = null;
            this.enterButton.Iconimage_Selected = null;
            this.enterButton.IconMarginLeft = 0;
            this.enterButton.IconMarginRight = 0;
            this.enterButton.IconRightVisible = true;
            this.enterButton.IconRightZoom = 0D;
            this.enterButton.IconVisible = true;
            this.enterButton.IconZoom = 90D;
            this.enterButton.IsTab = false;
            this.enterButton.Location = new System.Drawing.Point(175, 114);
            this.enterButton.Name = "enterButton";
            this.enterButton.Normalcolor = System.Drawing.Color.SlateBlue;
            this.enterButton.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.enterButton.OnHoverTextColor = System.Drawing.Color.White;
            this.enterButton.selected = false;
            this.enterButton.Size = new System.Drawing.Size(162, 44);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Авторизоваться";
            this.enterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enterButton.Textcolor = System.Drawing.Color.White;
            this.enterButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click_1);
            // 
            // regButton
            // 
            this.regButton.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.regButton.BackColor = System.Drawing.Color.SlateBlue;
            this.regButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regButton.BorderRadius = 0;
            this.regButton.ButtonText = "Зарегистрироваться";
            this.regButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButton.DisabledColor = System.Drawing.Color.Gray;
            this.regButton.Iconcolor = System.Drawing.Color.Transparent;
            this.regButton.Iconimage = null;
            this.regButton.Iconimage_right = null;
            this.regButton.Iconimage_right_Selected = null;
            this.regButton.Iconimage_Selected = null;
            this.regButton.IconMarginLeft = 0;
            this.regButton.IconMarginRight = 0;
            this.regButton.IconRightVisible = true;
            this.regButton.IconRightZoom = 0D;
            this.regButton.IconVisible = true;
            this.regButton.IconZoom = 90D;
            this.regButton.IsTab = false;
            this.regButton.Location = new System.Drawing.Point(175, 169);
            this.regButton.Name = "regButton";
            this.regButton.Normalcolor = System.Drawing.Color.SlateBlue;
            this.regButton.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.regButton.OnHoverTextColor = System.Drawing.Color.White;
            this.regButton.selected = false;
            this.regButton.Size = new System.Drawing.Size(162, 44);
            this.regButton.TabIndex = 12;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regButton.Textcolor = System.Drawing.Color.White;
            this.regButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.Click += new System.EventHandler(this.regButton_Click_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(86, 33);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 21);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Логин";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(86, 66);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(68, 21);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Пароль";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(350, 225);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.bunifuFlatButton1);
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton regButton;
        private Bunifu.Framework.UI.BunifuFlatButton enterButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

