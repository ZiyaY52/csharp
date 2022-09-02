namespace Baca_Analizorleri_Kontrolu
{
    partial class log
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dBElektrikDepartmaniDataSet = new Baca_Analizorleri_Kontrolu.DBElektrikDepartmaniDataSet();
            this.isBittiMiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isBittiMiTableAdapter = new Baca_Analizorleri_Kontrolu.DBElektrikDepartmaniDataSetTableAdapters.isBittiMiTableAdapter();
            this.tableAdapterManager = new Baca_Analizorleri_Kontrolu.DBElektrikDepartmaniDataSetTableAdapters.TableAdapterManager();
            this.isBittiMiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBElektrikDepartmaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isBittiMiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isBittiMiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBElektrikDepartmaniDataSet
            // 
            this.dBElektrikDepartmaniDataSet.DataSetName = "DBElektrikDepartmaniDataSet";
            this.dBElektrikDepartmaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isBittiMiBindingSource
            // 
            this.isBittiMiBindingSource.DataMember = "isBittiMi";
            this.isBittiMiBindingSource.DataSource = this.dBElektrikDepartmaniDataSet;
            // 
            // isBittiMiTableAdapter
            // 
            this.isBittiMiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.isBittiMiTableAdapter = this.isBittiMiTableAdapter;
            this.tableAdapterManager.KisilerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Baca_Analizorleri_Kontrolu.DBElektrikDepartmaniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // isBittiMiDataGridView
            // 
            this.isBittiMiDataGridView.AllowUserToAddRows = false;
            this.isBittiMiDataGridView.AllowUserToDeleteRows = false;
            this.isBittiMiDataGridView.AutoGenerateColumns = false;
            this.isBittiMiDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.isBittiMiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.isBittiMiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isBittiMiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.isBittiMiDataGridView.DataSource = this.isBittiMiBindingSource;
            this.isBittiMiDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.isBittiMiDataGridView.Location = new System.Drawing.Point(-1, -2);
            this.isBittiMiDataGridView.Name = "isBittiMiDataGridView";
            this.isBittiMiDataGridView.RowHeadersWidth = 51;
            this.isBittiMiDataGridView.RowTemplate.Height = 24;
            this.isBittiMiDataGridView.Size = new System.Drawing.Size(1144, 462);
            this.isBittiMiDataGridView.TabIndex = 0;
            this.isBittiMiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.isBittiMiDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "isadi";
            this.dataGridViewTextBoxColumn1.HeaderText = "isadi";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "isimsoyisim";
            this.dataGridViewTextBoxColumn2.HeaderText = "isimsoyisim";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tarih";
            this.dataGridViewTextBoxColumn3.HeaderText = "tarih";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sicilno";
            this.dataGridViewTextBoxColumn4.HeaderText = "sicilno";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bitti";
            this.dataGridViewTextBoxColumn5.HeaderText = "bitti";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "aciklama";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "aciklama";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 472);
            this.Controls.Add(this.isBittiMiDataGridView);
            this.Name = "log";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBElektrikDepartmaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isBittiMiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isBittiMiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DBElektrikDepartmaniDataSet dBElektrikDepartmaniDataSet;
        private System.Windows.Forms.BindingSource isBittiMiBindingSource;
        private DBElektrikDepartmaniDataSetTableAdapters.isBittiMiTableAdapter isBittiMiTableAdapter;
        private DBElektrikDepartmaniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView isBittiMiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}