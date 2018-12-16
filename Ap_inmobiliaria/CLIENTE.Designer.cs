namespace Ap_inmobiliaria
{
    partial class CLIENTE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROPIEDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aLQToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROPIEDADESToolStripMenuItem,
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
            this.vENTAToolStripMenuItem1,
            this.aLQToolStripMenuItem1});
            this.pROPIEDADESToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROPIEDADESToolStripMenuItem.Image = global::Ap_inmobiliaria.Properties.Resources.casa;
            this.pROPIEDADESToolStripMenuItem.Name = "pROPIEDADESToolStripMenuItem";
            this.pROPIEDADESToolStripMenuItem.Size = new System.Drawing.Size(193, 31);
            this.pROPIEDADESToolStripMenuItem.Text = "PROPIEDADES";
            // 
            // vENTAToolStripMenuItem1
            // 
            this.vENTAToolStripMenuItem1.Name = "vENTAToolStripMenuItem1";
            this.vENTAToolStripMenuItem1.Size = new System.Drawing.Size(190, 32);
            this.vENTAToolStripMenuItem1.Text = "VENTA";
            this.vENTAToolStripMenuItem1.Click += new System.EventHandler(this.vENTAToolStripMenuItem_Click);
            // 
            // aLQToolStripMenuItem1
            // 
            this.aLQToolStripMenuItem1.Name = "aLQToolStripMenuItem1";
            this.aLQToolStripMenuItem1.Size = new System.Drawing.Size(190, 32);
            this.aLQToolStripMenuItem1.Text = "ALQUILER";
            this.aLQToolStripMenuItem1.Click += new System.EventHandler(this.aLQToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem2});
            this.cLIENTESToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTESToolStripMenuItem.Image = global::Ap_inmobiliaria.Properties.Resources.clientes;
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(139, 31);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // cLIENTESToolStripMenuItem2
            // 
            this.cLIENTESToolStripMenuItem2.Name = "cLIENTESToolStripMenuItem2";
            this.cLIENTESToolStripMenuItem2.Size = new System.Drawing.Size(183, 32);
            this.cLIENTESToolStripMenuItem2.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem2.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem1_Click);
            // 
            // CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 328);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CLIENTE";
            this.Text = "CLIENTE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROPIEDADESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aLQToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem2;
    }
}