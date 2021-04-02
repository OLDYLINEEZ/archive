namespace WindowsFormsApp4
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button2 = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.SlateBlue;
            this.textBox1.HintForeColor = System.Drawing.Color.Empty;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.textBox1.LineMouseHoverColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox1.LineThickness = 3;
            this.textBox1.Location = new System.Drawing.Point(13, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 44);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Ваш путь";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.OnValueChanged += new System.EventHandler(this.textBox1_OnValueChanged);
            // 
            // Button1
            // 
            this.Button1.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.Button1.BackColor = System.Drawing.Color.SlateBlue;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.BorderRadius = 0;
            this.Button1.ButtonText = "Выбрать файл";
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.DisabledColor = System.Drawing.Color.Gray;
            this.Button1.Iconcolor = System.Drawing.Color.Transparent;
            this.Button1.Iconimage = null;
            this.Button1.Iconimage_right = null;
            this.Button1.Iconimage_right_Selected = null;
            this.Button1.Iconimage_Selected = null;
            this.Button1.IconMarginLeft = 0;
            this.Button1.IconMarginRight = 0;
            this.Button1.IconRightVisible = true;
            this.Button1.IconRightZoom = 0D;
            this.Button1.IconVisible = true;
            this.Button1.IconZoom = 90D;
            this.Button1.IsTab = false;
            this.Button1.Location = new System.Drawing.Point(107, 99);
            this.Button1.Name = "Button1";
            this.Button1.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Button1.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.Button1.OnHoverTextColor = System.Drawing.Color.White;
            this.Button1.selected = false;
            this.Button1.Size = new System.Drawing.Size(130, 48);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Выбрать файл";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Textcolor = System.Drawing.Color.White;
            this.Button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Button2
            // 
            this.Button2.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.Button2.BackColor = System.Drawing.Color.SlateBlue;
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.BorderRadius = 0;
            this.Button2.ButtonText = "Сохранить архив";
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.DisabledColor = System.Drawing.Color.Gray;
            this.Button2.Iconcolor = System.Drawing.Color.Transparent;
            this.Button2.Iconimage = null;
            this.Button2.Iconimage_right = null;
            this.Button2.Iconimage_right_Selected = null;
            this.Button2.Iconimage_Selected = null;
            this.Button2.IconMarginLeft = 0;
            this.Button2.IconMarginRight = 0;
            this.Button2.IconRightVisible = true;
            this.Button2.IconRightZoom = 0D;
            this.Button2.IconVisible = true;
            this.Button2.IconZoom = 90D;
            this.Button2.IsTab = false;
            this.Button2.Location = new System.Drawing.Point(107, 153);
            this.Button2.Name = "Button2";
            this.Button2.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Button2.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.Button2.OnHoverTextColor = System.Drawing.Color.White;
            this.Button2.selected = false;
            this.Button2.Size = new System.Drawing.Size(130, 48);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Сохранить архив";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Textcolor = System.Drawing.Color.White;
            this.Button2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 225);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Button2;
        private Bunifu.Framework.UI.BunifuFlatButton Button1;
    }
}