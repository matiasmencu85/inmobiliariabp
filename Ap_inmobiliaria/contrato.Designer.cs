namespace Ap_inmobiliaria
{
    partial class contrato
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombrecon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSet6 = new Ap_inmobiliaria.inmobiliariaDataSet6();
            this.contratosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSet = new Ap_inmobiliaria.inmobiliariaDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSet5 = new Ap_inmobiliaria.inmobiliariaDataSet5();
            this.documentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.inmobiliariaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printgrid = new System.Windows.Forms.Button();
            this.documentosTableAdapter = new Ap_inmobiliaria.inmobiliariaDataSet5TableAdapters.documentosTableAdapter();
            this.contratosTableAdapter = new Ap_inmobiliaria.inmobiliariaDataSet6TableAdapters.contratosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrecon,
            this.dataGridViewTextBoxColumn3,
            this.fecha_ini,
            this.fecha_fin});
            this.dataGridView1.DataSource = this.contratosBindingSource2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(21, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(552, 303);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombrecon
            // 
            this.nombrecon.DataPropertyName = "nombre";
            this.nombrecon.HeaderText = "nombrecon";
            this.nombrecon.Name = "nombrecon";
            this.nombrecon.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // fecha_ini
            // 
            this.fecha_ini.DataPropertyName = "fecha_ini";
            this.fecha_ini.HeaderText = "fecha_ini";
            this.fecha_ini.Name = "fecha_ini";
            this.fecha_ini.ReadOnly = true;
            // 
            // fecha_fin
            // 
            this.fecha_fin.DataPropertyName = "fecha_fin";
            this.fecha_fin.HeaderText = "fecha_fin";
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.ReadOnly = true;
            // 
            // contratosBindingSource2
            // 
            this.contratosBindingSource2.DataMember = "contratos";
            this.contratosBindingSource2.DataSource = this.inmobiliariaDataSet6;
            // 
            // inmobiliariaDataSet6
            // 
            this.inmobiliariaDataSet6.DataSetName = "inmobiliariaDataSet6";
            this.inmobiliariaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratosBindingSource1
            // 
            this.contratosBindingSource1.DataMember = "contratos";
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "contratos";
            // 
            // inmobiliariaDataSetBindingSource
            // 
            this.inmobiliariaDataSetBindingSource.DataSource = this.inmobiliariaDataSet;
            this.inmobiliariaDataSetBindingSource.Position = 0;
            // 
            // inmobiliariaDataSet
            // 
            this.inmobiliariaDataSet.DataSetName = "inmobiliariaDataSet";
            this.inmobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.documentosBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(21, 376);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(472, 171);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "docId";
            this.dataGridViewTextBoxColumn1.HeaderText = "docId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // documentosBindingSource2
            // 
            this.documentosBindingSource2.DataMember = "documentos";
            this.documentosBindingSource2.DataSource = this.inmobiliariaDataSet5;
            // 
            // inmobiliariaDataSet5
            // 
            this.inmobiliariaDataSet5.DataSetName = "inmobiliariaDataSet5";
            this.inmobiliariaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentosBindingSource1
            // 
            this.documentosBindingSource1.DataMember = "documentos";
            // 
            // documentosBindingSource
            // 
            this.documentosBindingSource.DataMember = "documentos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "BUSCADOR POR FECHA FIN DE CONTRATO";
            // 
            // printgrid
            // 
            this.printgrid.Location = new System.Drawing.Point(211, 347);
            this.printgrid.Name = "printgrid";
            this.printgrid.Size = new System.Drawing.Size(75, 23);
            this.printgrid.TabIndex = 7;
            this.printgrid.Text = "IMPRIMIR";
            this.printgrid.UseVisualStyleBackColor = true;
            this.printgrid.Click += new System.EventHandler(this.printgrid_Click);
            // 
            // documentosTableAdapter
            // 
            this.documentosTableAdapter.ClearBeforeFill = true;
            // 
            // contratosTableAdapter
            // 
            this.contratosTableAdapter.ClearBeforeFill = true;
            // 
            // contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 559);
            this.Controls.Add(this.printgrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "contrato";
            this.Text = "contrato";
            this.Load += new System.EventHandler(this.contrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource inmobiliariaDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
   //     private ejemploDataSet ejemploDataSet;
        private System.Windows.Forms.BindingSource documentosBindingSource;
    //    private ejemploDataSetTableAdapters.documentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inmobiliariaDataSetBindingSource;
        private inmobiliariaDataSet inmobiliariaDataSet;
     //   private inmobiliariaDataSet10 inmobiliariaDataSet10;
        private System.Windows.Forms.BindingSource documentosBindingSource1;
      //  private inmobiliariaDataSet10TableAdapters.documentosTableAdapter documentosTableAdapter1;
     //   private inmobiliariaDataSet11 inmobiliariaDataSet11;
        private System.Windows.Forms.BindingSource contratosBindingSource;
     //   private inmobiliariaDataSet11TableAdapters.contratosTableAdapter contratosTableAdapter;
      //  private inmobiliariaDataSet16 inmobiliariaDataSet16;
        private System.Windows.Forms.BindingSource contratosBindingSource1;
       // private inmobiliariaDataSet16TableAdapters.contratosTableAdapter contratosTableAdapter1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaini;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button printgrid;
        private inmobiliariaDataSet5 inmobiliariaDataSet5;
        private System.Windows.Forms.BindingSource documentosBindingSource2;
        private inmobiliariaDataSet5TableAdapters.documentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private inmobiliariaDataSet6 inmobiliariaDataSet6;
        private System.Windows.Forms.BindingSource contratosBindingSource2;
        private inmobiliariaDataSet6TableAdapters.contratosTableAdapter contratosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ini;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin;
    }
}