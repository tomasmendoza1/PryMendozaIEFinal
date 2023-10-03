namespace PryMendozaIE
{
    partial class FrmMainCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainCliente));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtUserBienvenido = new System.Windows.Forms.TextBox();
            this.PanelLine = new System.Windows.Forms.Panel();
            this.PtcLogo = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNombreDeUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tv = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtcLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.TxtUserBienvenido);
            this.panel2.Controls.Add(this.PanelLine);
            this.panel2.Controls.Add(this.PtcLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 337);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryMendozaIE.Properties.Resources.user_blue_25325;
            this.pictureBox1.Location = new System.Drawing.Point(52, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TxtUserBienvenido
            // 
            this.TxtUserBienvenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(170)))));
            this.TxtUserBienvenido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserBienvenido.Enabled = false;
            this.TxtUserBienvenido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserBienvenido.ForeColor = System.Drawing.Color.Black;
            this.TxtUserBienvenido.Location = new System.Drawing.Point(70, 18);
            this.TxtUserBienvenido.Name = "TxtUserBienvenido";
            this.TxtUserBienvenido.Size = new System.Drawing.Size(60, 20);
            this.TxtUserBienvenido.TabIndex = 2;
            this.TxtUserBienvenido.Text = "Usuario";
            this.TxtUserBienvenido.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            // 
            // PanelLine
            // 
            this.PanelLine.BackColor = System.Drawing.Color.White;
            this.PanelLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelLine.Location = new System.Drawing.Point(1, 100);
            this.PanelLine.Name = "PanelLine";
            this.PanelLine.Size = new System.Drawing.Size(199, 1);
            this.PanelLine.TabIndex = 2;
            // 
            // PtcLogo
            // 
            this.PtcLogo.Image = global::PryMendozaIE.Properties.Resources.logo_boston_1;
            this.PtcLogo.Location = new System.Drawing.Point(2, 195);
            this.PtcLogo.Name = "PtcLogo";
            this.PtcLogo.Size = new System.Drawing.Size(197, 83);
            this.PtcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtcLogo.TabIndex = 2;
            this.PtcLogo.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Location = new System.Drawing.Point(38, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(126, 21);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Menu principal";
            // 
            // LblNombreDeUsuario
            // 
            this.LblNombreDeUsuario.AutoSize = true;
            this.LblNombreDeUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreDeUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.LblNombreDeUsuario.Location = new System.Drawing.Point(397, 9);
            this.LblNombreDeUsuario.Name = "LblNombreDeUsuario";
            this.LblNombreDeUsuario.Size = new System.Drawing.Size(100, 21);
            this.LblNombreDeUsuario.TabIndex = 3;
            this.LblNombreDeUsuario.Text = "Bienvenido!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LblNombreDeUsuario);
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 37);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PryMendozaIE.Properties.Resources.minimize_icon_191837;
            this.pictureBox3.Location = new System.Drawing.Point(817, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PryMendozaIE.Properties.Resources.Cerrar4;
            this.pictureBox2.Location = new System.Drawing.Point(844, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.proveedoresToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem,
            this.verRegistrosToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.proveedoresToolStripMenuItem.Text = "Aseguradores";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoRegistroToolStripMenuItem.Text = "Nuevo registro";
            this.nuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem_Click);
            // 
            // verRegistrosToolStripMenuItem
            // 
            this.verRegistrosToolStripMenuItem.Name = "verRegistrosToolStripMenuItem";
            this.verRegistrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verRegistrosToolStripMenuItem.Text = "Ver registros";
            this.verRegistrosToolStripMenuItem.Click += new System.EventHandler(this.verRegistrosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRegistroToolStripMenuItem,
            this.nuevoRegistroToolStripMenuItem1});
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // verRegistroToolStripMenuItem
            // 
            this.verRegistroToolStripMenuItem.Name = "verRegistroToolStripMenuItem";
            this.verRegistroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verRegistroToolStripMenuItem.Text = "Ver registro";
            this.verRegistroToolStripMenuItem.Click += new System.EventHandler(this.verRegistroToolStripMenuItem_Click);
            // 
            // nuevoRegistroToolStripMenuItem1
            // 
            this.nuevoRegistroToolStripMenuItem1.Name = "nuevoRegistroToolStripMenuItem1";
            this.nuevoRegistroToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.nuevoRegistroToolStripMenuItem1.Text = "Nuevo registro";
            this.nuevoRegistroToolStripMenuItem1.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem1_Click);
            // 
            // tv
            // 
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.imageList1;
            this.tv.Location = new System.Drawing.Point(206, 64);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.Size = new System.Drawing.Size(267, 322);
            this.tv.TabIndex = 3;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "png-transparent-directory-computer-icons-folders-miscellaneous-angle-rectangle.pn" +
        "g");
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView.Location = new System.Drawing.Point(479, 65);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(383, 321);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // FrmMainCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 398);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainCliente";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainCliente";
            this.Load += new System.EventHandler(this.FrmMainCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtcLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PtcLogo;
        private System.Windows.Forms.Panel PanelLine;
        public System.Windows.Forms.TextBox TxtUserBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNombreDeUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verRegistroToolStripMenuItem;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem1;
    }
}