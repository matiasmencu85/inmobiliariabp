namespace Ap_inmobiliaria
{
    partial class ADMINISTRADOR
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROPIEDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTRATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fECHASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTRATOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hora = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROPIEDADESToolStripMenuItem,
            this.cONTRATOSToolStripMenuItem,
            this.cLIENTESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROPIEDADESToolStripMenuItem
            // 
            this.pROPIEDADESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTAToolStripMenuItem,
            this.aLQToolStripMenuItem});
            this.pROPIEDADESToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROPIEDADESToolStripMenuItem.Image = global::Ap_inmobiliaria.Properties.Resources.casa;
            this.pROPIEDADESToolStripMenuItem.Name = "pROPIEDADESToolStripMenuItem";
            this.pROPIEDADESToolStripMenuItem.Size = new System.Drawing.Size(193, 31);
            this.pROPIEDADESToolStripMenuItem.Text = "PROPIEDADES";
            // 
            // vENTAToolStripMenuItem
            // 
            this.vENTAToolStripMenuItem.Name = "vENTAToolStripMenuItem";
            this.vENTAToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.vENTAToolStripMenuItem.Text = "VENTA";
            this.vENTAToolStripMenuItem.Click += new System.EventHandler(this.vENTAToolStripMenuItem_Click);
            // 
            // aLQToolStripMenuItem
            // 
            this.aLQToolStripMenuItem.Name = "aLQToolStripMenuItem";
            this.aLQToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.aLQToolStripMenuItem.Text = "ALQUILER";
            this.aLQToolStripMenuItem.Click += new System.EventHandler(this.aLQToolStripMenuItem_Click);
            // 
            // cONTRATOSToolStripMenuItem
            // 
            this.cONTRATOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fECHASToolStripMenuItem,
            this.cONTRATOSToolStripMenuItem1});
            this.cONTRATOSToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cONTRATOSToolStripMenuItem.Image = global::Ap_inmobiliaria.Properties.Resources.contrato;
            this.cONTRATOSToolStripMenuItem.Name = "cONTRATOSToolStripMenuItem";
            this.cONTRATOSToolStripMenuItem.Size = new System.Drawing.Size(168, 31);
            this.cONTRATOSToolStripMenuItem.Text = "CONTRATOS";
            // 
            // fECHASToolStripMenuItem
            // 
            this.fECHASToolStripMenuItem.Name = "fECHASToolStripMenuItem";
            this.fECHASToolStripMenuItem.Size = new System.Drawing.Size(212, 32);
            this.fECHASToolStripMenuItem.Text = "FECHAS";
            this.fECHASToolStripMenuItem.Click += new System.EventHandler(this.fECHASToolStripMenuItem_Click);
            // 
            // cONTRATOSToolStripMenuItem1
            // 
            this.cONTRATOSToolStripMenuItem1.Name = "cONTRATOSToolStripMenuItem1";
            this.cONTRATOSToolStripMenuItem1.Size = new System.Drawing.Size(212, 32);
            this.cONTRATOSToolStripMenuItem1.Text = "CONTRATOS";
            this.cONTRATOSToolStripMenuItem1.Click += new System.EventHandler(this.cONTRATOSToolStripMenuItem1_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem1});
            this.cLIENTESToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTESToolStripMenuItem.Image = global::Ap_inmobiliaria.Properties.Resources.clientes;
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(139, 31);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // cLIENTESToolStripMenuItem1
            // 
            this.cLIENTESToolStripMenuItem1.Name = "cLIENTESToolStripMenuItem1";
            this.cLIENTESToolStripMenuItem1.Size = new System.Drawing.Size(183, 32);
            this.cLIENTESToolStripMenuItem1.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem1.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(593, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(556, 11);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(28, 13);
            this.hora.TabIndex = 4;
            this.hora.Text = "hora";
            // 
            // ADMINISTRADOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 328);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ADMINISTRADOR";
            this.Text = "ADMINISTRADOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROPIEDADESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTAToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aLQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTRATOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fECHASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTRATOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hora;
    }
}