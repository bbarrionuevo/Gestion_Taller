namespace UI
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            altaDeServicioToolStripMenuItem = new ToolStripMenuItem();
            iNFORMESToolStripMenuItem = new ToolStripMenuItem();
            vERINFORMESToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { serviciosToolStripMenuItem, iNFORMESToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1582, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaDeServicioToolStripMenuItem });
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new Size(93, 24);
            serviciosToolStripMenuItem.Text = "SERVICIOS";
            serviciosToolStripMenuItem.Click += serviciosToolStripMenuItem_Click;
            // 
            // altaDeServicioToolStripMenuItem
            // 
            altaDeServicioToolStripMenuItem.Name = "altaDeServicioToolStripMenuItem";
            altaDeServicioToolStripMenuItem.Size = new Size(196, 26);
            altaDeServicioToolStripMenuItem.Text = "Alta de Servicio";
            altaDeServicioToolStripMenuItem.Click += altaDeServicioToolStripMenuItem_Click;
            // 
            // iNFORMESToolStripMenuItem
            // 
            iNFORMESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vERINFORMESToolStripMenuItem });
            iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            iNFORMESToolStripMenuItem.Size = new Size(94, 24);
            iNFORMESToolStripMenuItem.Text = "INFORMES";
            iNFORMESToolStripMenuItem.Click += iNFORMESToolStripMenuItem_Click;
            // 
            // vERINFORMESToolStripMenuItem
            // 
            vERINFORMESToolStripMenuItem.Name = "vERINFORMESToolStripMenuItem";
            vERINFORMESToolStripMenuItem.Size = new Size(224, 26);
            vERINFORMESToolStripMenuItem.Text = "VER INFORMES";
            vERINFORMESToolStripMenuItem.Click += vERINFORMESToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 753);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem altaDeServicioToolStripMenuItem;
        private ToolStripMenuItem iNFORMESToolStripMenuItem;
        private ToolStripMenuItem vERINFORMESToolStripMenuItem;
    }
}