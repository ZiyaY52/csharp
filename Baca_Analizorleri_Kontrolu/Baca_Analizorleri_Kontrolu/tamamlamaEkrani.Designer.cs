namespace Baca_Analizorleri_Kontrolu
{
    partial class tamamlamaEkrani
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
            System.Windows.Forms.Label isimsoyisimLabel;
            System.Windows.Forms.Label sicilnoLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.dBElektrikDepartmaniDataSet = new Baca_Analizorleri_Kontrolu.DBElektrikDepartmaniDataSet();
            this.kisilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kisilerTableAdapter = new Baca_Analizorleri_Kontrolu.DBElektrikDepartmaniDataSetTableAdapters.KisilerTableAdapter();
            this.tableAdapterManager = new Baca_Analizorleri_Kontrolu.DBElektrikDepartmaniDataSetTableAdapters.TableAdapterManager();
            this.isimsoyisimComboBox = new System.Windows.Forms.ComboBox();
            this.kisilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSicilNo = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsAdi = new System.Windows.Forms.TextBox();
            isimsoyisimLabel = new System.Windows.Forms.Label();
            sicilnoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBElektrikDepartmaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // isimsoyisimLabel
            // 
            isimsoyisimLabel.AutoSize = true;
            isimsoyisimLabel.Location = new System.Drawing.Point(33, 112);
            isimsoyisimLabel.Name = "isimsoyisimLabel";
            isimsoyisimLabel.Size = new System.Drawing.Size(123, 16);
            isimsoyisimLabel.TabIndex = 4;
            isimsoyisimLabel.Text = "Bitirenin Adı Soyadı";
            // 
            // sicilnoLabel
            // 
            sicilnoLabel.AutoSize = true;
            sicilnoLabel.Location = new System.Drawing.Point(36, 173);
            sicilnoLabel.Name = "sicilnoLabel";
            sicilnoLabel.Size = new System.Drawing.Size(56, 16);
            sicilnoLabel.TabIndex = 5;
            sicilnoLabel.Text = "Sicil No:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dBElektrikDepartmaniDataSet
            // 
            this.dBElektrikDepartmaniDataSet.DataSetName = "DBElektrikDepartmaniDataSet";
            this.dBElektrikDepartmaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisilerBindingSource
            // 
            this.kisilerBindingSource.DataMember = "Kisiler";
            this.kisilerBindingSource.DataSource = this.dBElektrikDepartmaniDataSet;
            // 
            // kisilerTableAdapter
            // 
            this.kisilerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.isBittiMiTableAdapter = null;
            this.tableAdapterManager.KisilerTableAdapter = this.kisilerTableAdapter;
            this.tableAdapterManager.UpdateOrder = Baca_Analizorleri_Kontrolu.DBElektrikDepartmaniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // isimsoyisimComboBox
            // 
            this.isimsoyisimComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kisilerBindingSource, "isimsoyisim", true));
            this.isimsoyisimComboBox.DataSource = this.kisilerBindingSource1;
            this.isimsoyisimComboBox.DisplayMember = "isimsoyisim";
            this.isimsoyisimComboBox.FormattingEnabled = true;
            this.isimsoyisimComboBox.Location = new System.Drawing.Point(183, 104);
            this.isimsoyisimComboBox.Name = "isimsoyisimComboBox";
            this.isimsoyisimComboBox.Size = new System.Drawing.Size(121, 24);
            this.isimsoyisimComboBox.TabIndex = 5;
            this.isimsoyisimComboBox.ValueMember = "isimsoyisim";
            this.isimsoyisimComboBox.SelectedIndexChanged += new System.EventHandler(this.isimsoyisimComboBox_SelectedIndexChanged);
            // 
            // kisilerBindingSource1
            // 
            this.kisilerBindingSource1.DataMember = "Kisiler";
            this.kisilerBindingSource1.DataSource = this.dBElektrikDepartmaniDataSet;
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.Location = new System.Drawing.Point(183, 167);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.Size = new System.Drawing.Size(121, 22);
            this.txtSicilNo.TabIndex = 6;
            this.txtSicilNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(183, 228);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(205, 149);
            this.txtAciklama.TabIndex = 7;
            this.txtAciklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Açıklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "İş Adı:";
            // 
            // txtIsAdi
            // 
            this.txtIsAdi.Location = new System.Drawing.Point(183, 47);
            this.txtIsAdi.Name = "txtIsAdi";
            this.txtIsAdi.Size = new System.Drawing.Size(121, 22);
            this.txtIsAdi.TabIndex = 10;
            // 
            // tamamlamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 421);
            this.Controls.Add(this.txtIsAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtSicilNo);
            this.Controls.Add(sicilnoLabel);
            this.Controls.Add(isimsoyisimLabel);
            this.Controls.Add(this.isimsoyisimComboBox);
            this.Controls.Add(this.button1);
            this.Name = "tamamlamaEkrani";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.tamamlamaEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBElektrikDepartmaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private DBElektrikDepartmaniDataSet dBElektrikDepartmaniDataSet;
        private System.Windows.Forms.BindingSource kisilerBindingSource;
        private DBElektrikDepartmaniDataSetTableAdapters.KisilerTableAdapter kisilerTableAdapter;
        private DBElektrikDepartmaniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox isimsoyisimComboBox;
        private System.Windows.Forms.BindingSource kisilerBindingSource1;
        private System.Windows.Forms.TextBox txtSicilNo;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsAdi;
    }
}