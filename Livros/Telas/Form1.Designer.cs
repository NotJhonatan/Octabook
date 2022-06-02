namespace Livros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvTeste = new System.Windows.Forms.ListView();
            this.Título = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnComprar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSobre = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFechar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lvTeste
            // 
            this.lvTeste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Título,
            this.Link});
            this.lvTeste.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTeste.GridLines = true;
            this.lvTeste.Location = new System.Drawing.Point(47, 126);
            this.lvTeste.Name = "lvTeste";
            this.lvTeste.Size = new System.Drawing.Size(740, 214);
            this.lvTeste.TabIndex = 13;
            this.lvTeste.UseCompatibleStateImageBehavior = false;
            this.lvTeste.View = System.Windows.Forms.View.Details;
            // 
            // Título
            // 
            this.Título.Text = "Título";
            this.Título.Width = 370;
            // 
            // Link
            // 
            this.Link.Text = "Link";
            this.Link.Width = 366;
            // 
            // txtNome
            // 
            this.txtNome.BorderColorFocused = System.Drawing.Color.Black;
            this.txtNome.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txtNome.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtNome.BorderThickness = 2;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.isPassword = false;
            this.txtNome.Location = new System.Drawing.Point(97, 93);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(627, 23);
            this.txtNome.TabIndex = 19;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(45, 95);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(48, 19);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Livro:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.BorderRadius = 0;
            this.btnConsultar.ButtonText = "";
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultar.Iconimage = global::Livros.Properties.Resources._64673;
            this.btnConsultar.Iconimage_right = null;
            this.btnConsultar.Iconimage_right_Selected = null;
            this.btnConsultar.Iconimage_Selected = null;
            this.btnConsultar.IconMarginLeft = 0;
            this.btnConsultar.IconMarginRight = 0;
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconRightZoom = 0D;
            this.btnConsultar.IconVisible = true;
            this.btnConsultar.IconZoom = 90D;
            this.btnConsultar.IsTab = false;
            this.btnConsultar.Location = new System.Drawing.Point(731, 62);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultar.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(56, 54);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Textcolor = System.Drawing.Color.White;
            this.btnConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnComprar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprar.BorderRadius = 0;
            this.btnComprar.ButtonText = "Comprar";
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.DisabledColor = System.Drawing.Color.Gray;
            this.btnComprar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnComprar.Iconimage = global::Livros.Properties.Resources.download;
            this.btnComprar.Iconimage_right = null;
            this.btnComprar.Iconimage_right_Selected = null;
            this.btnComprar.Iconimage_Selected = null;
            this.btnComprar.IconMarginLeft = 0;
            this.btnComprar.IconMarginRight = 0;
            this.btnComprar.IconRightVisible = true;
            this.btnComprar.IconRightZoom = 0D;
            this.btnComprar.IconVisible = true;
            this.btnComprar.IconZoom = 90D;
            this.btnComprar.IsTab = false;
            this.btnComprar.Location = new System.Drawing.Point(47, 352);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnComprar.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnComprar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnComprar.selected = false;
            this.btnComprar.Size = new System.Drawing.Size(108, 23);
            this.btnComprar.TabIndex = 22;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Textcolor = System.Drawing.Color.Black;
            this.btnComprar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnSobre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSobre.BorderRadius = 0;
            this.btnSobre.ButtonText = "Sobre";
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.DisabledColor = System.Drawing.Color.Gray;
            this.btnSobre.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSobre.Iconimage = null;
            this.btnSobre.Iconimage_right = null;
            this.btnSobre.Iconimage_right_Selected = null;
            this.btnSobre.Iconimage_Selected = null;
            this.btnSobre.IconMarginLeft = 0;
            this.btnSobre.IconMarginRight = 0;
            this.btnSobre.IconRightVisible = true;
            this.btnSobre.IconRightZoom = 0D;
            this.btnSobre.IconVisible = true;
            this.btnSobre.IconZoom = 90D;
            this.btnSobre.IsTab = false;
            this.btnSobre.Location = new System.Drawing.Point(161, 352);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnSobre.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnSobre.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSobre.selected = false;
            this.btnSobre.Size = new System.Drawing.Size(108, 23);
            this.btnSobre.TabIndex = 23;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSobre.Textcolor = System.Drawing.Color.Black;
            this.btnSobre.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.BorderRadius = 0;
            this.btnLimpar.ButtonText = "Limpar campos";
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.DisabledColor = System.Drawing.Color.Gray;
            this.btnLimpar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimpar.Iconimage = global::Livros.Properties.Resources.download__1_;
            this.btnLimpar.Iconimage_right = null;
            this.btnLimpar.Iconimage_right_Selected = null;
            this.btnLimpar.Iconimage_Selected = null;
            this.btnLimpar.IconMarginLeft = 0;
            this.btnLimpar.IconMarginRight = 0;
            this.btnLimpar.IconRightVisible = true;
            this.btnLimpar.IconRightZoom = 0D;
            this.btnLimpar.IconVisible = true;
            this.btnLimpar.IconZoom = 90D;
            this.btnLimpar.IsTab = false;
            this.btnLimpar.Location = new System.Drawing.Point(632, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnLimpar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLimpar.selected = false;
            this.btnLimpar.Size = new System.Drawing.Size(155, 23);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Textcolor = System.Drawing.Color.Black;
            this.btnLimpar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(765, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 23);
            this.btnFechar.TabIndex = 25;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Livros.Properties.Resources.Imagem_2;
            this.ClientSize = new System.Drawing.Size(842, 424);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lvTeste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvTeste;
        private System.Windows.Forms.ColumnHeader Título;
        private System.Windows.Forms.ColumnHeader Link;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNome;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
        private Bunifu.Framework.UI.BunifuFlatButton btnComprar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSobre;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpar;
        private Bunifu.Framework.UI.BunifuCustomLabel btnFechar;
    }
}

