namespace Livros.Telas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "LOGIN";
            this.bunifuTileButton1.Location = new System.Drawing.Point(89, 15);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(159, 147);
            this.bunifuTileButton1.TabIndex = 22;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnEntrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.BorderRadius = 0;
            this.btnEntrar.ButtonText = "ENTRAR";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEntrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEntrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Iconimage")));
            this.btnEntrar.Iconimage_right = null;
            this.btnEntrar.Iconimage_right_Selected = null;
            this.btnEntrar.Iconimage_Selected = null;
            this.btnEntrar.IconMarginLeft = 0;
            this.btnEntrar.IconMarginRight = 0;
            this.btnEntrar.IconRightVisible = true;
            this.btnEntrar.IconRightZoom = 0D;
            this.btnEntrar.IconVisible = true;
            this.btnEntrar.IconZoom = 90D;
            this.btnEntrar.IsTab = false;
            this.btnEntrar.Location = new System.Drawing.Point(99, 260);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnEntrar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnEntrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEntrar.selected = false;
            this.btnEntrar.Size = new System.Drawing.Size(123, 48);
            this.btnEntrar.TabIndex = 21;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Textcolor = System.Drawing.Color.White;
            this.btnEntrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtSenha.BorderColorIdle = System.Drawing.SystemColors.MenuHighlight;
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtSenha.BorderThickness = 3;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSenha.isPassword = true;
            this.txtSenha.Location = new System.Drawing.Point(99, 210);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(123, 33);
            this.txtSenha.TabIndex = 20;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtUsuario.BorderColorIdle = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsuario.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtUsuario.BorderThickness = 3;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsuario.isPassword = false;
            this.txtUsuario.Location = new System.Drawing.Point(99, 172);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(192, 33);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 384);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEntrar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}