using System;

namespace GUIwithSQL
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
            System.Windows.Forms.ComboBox comboBox1;
            System.Windows.Forms.Label workerNameLabel;
            System.Windows.Forms.Label workerSurnameLabel;
            System.Windows.Forms.Label addressofWorkerLabel;
            System.Windows.Forms.Label phoneNumLabel;
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label workerIDLabel1;
            this.workerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDBDataSet = new GUIwithSQL.TestDBDataSet();
            this.workerInfoTableAdapter = new GUIwithSQL.TestDBDataSetTableAdapters.WorkerInfoTableAdapter();
            this.tableAdapterManager = new GUIwithSQL.TestDBDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.workerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.addressofWorkerTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.sSNTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.workerIDTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.subMenu = new System.Windows.Forms.Panel();
            comboBox1 = new System.Windows.Forms.ComboBox();
            workerNameLabel = new System.Windows.Forms.Label();
            workerSurnameLabel = new System.Windows.Forms.Label();
            addressofWorkerLabel = new System.Windows.Forms.Label();
            phoneNumLabel = new System.Windows.Forms.Label();
            sSNLabel = new System.Windows.Forms.Label();
            workerIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.subMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            comboBox1.DataSource = this.workerInfoBindingSource;
            comboBox1.DisplayMember = "WorkerName";
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(318, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(202, 24);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // workerInfoBindingSource
            // 
            this.workerInfoBindingSource.DataMember = "WorkerInfo";
            this.workerInfoBindingSource.DataSource = this.testDBDataSet;
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "TestDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerNameLabel
            // 
            workerNameLabel.AutoSize = true;
            workerNameLabel.Location = new System.Drawing.Point(155, 237);
            workerNameLabel.Name = "workerNameLabel";
            workerNameLabel.Size = new System.Drawing.Size(94, 16);
            workerNameLabel.TabIndex = 19;
            workerNameLabel.Text = "Worker Name:";
            // 
            // workerSurnameLabel
            // 
            workerSurnameLabel.AutoSize = true;
            workerSurnameLabel.Location = new System.Drawing.Point(155, 290);
            workerSurnameLabel.Name = "workerSurnameLabel";
            workerSurnameLabel.Size = new System.Drawing.Size(107, 16);
            workerSurnameLabel.TabIndex = 20;
            workerSurnameLabel.Text = "worker Surname:";
            // 
            // addressofWorkerLabel
            // 
            addressofWorkerLabel.AutoSize = true;
            addressofWorkerLabel.Location = new System.Drawing.Point(143, 341);
            addressofWorkerLabel.Name = "addressofWorkerLabel";
            addressofWorkerLabel.Size = new System.Drawing.Size(119, 16);
            addressofWorkerLabel.TabIndex = 21;
            addressofWorkerLabel.Text = "Addressof Worker:";
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new System.Drawing.Point(143, 395);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new System.Drawing.Size(80, 16);
            phoneNumLabel.TabIndex = 22;
            phoneNumLabel.Text = "Phone Num:";
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.Location = new System.Drawing.Point(143, 447);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(38, 16);
            sSNLabel.TabIndex = 23;
            sSNLabel.Text = "SSN:";
            // 
            // workerIDLabel1
            // 
            workerIDLabel1.AutoSize = true;
            workerIDLabel1.Location = new System.Drawing.Point(155, 191);
            workerIDLabel1.Name = "workerIDLabel1";
            workerIDLabel1.Size = new System.Drawing.Size(70, 16);
            workerIDLabel1.TabIndex = 29;
            workerIDLabel1.Text = "Worker ID:";
            // 
            // workerInfoTableAdapter
            // 
            this.workerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GUIwithSQL.TestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerInfoTableAdapter = this.workerInfoTableAdapter;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(100, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 80);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insert Worker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerInfoBindingSource, "WorkerName", true));
            this.workerNameTextBox.Location = new System.Drawing.Point(283, 231);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.workerNameTextBox.TabIndex = 20;
            this.workerNameTextBox.TextChanged += new System.EventHandler(this.workerNameTextBox_TextChanged_1);
            // 
            // workerSurnameTextBox
            // 
            this.workerSurnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerInfoBindingSource, "workerSurname", true));
            this.workerSurnameTextBox.Location = new System.Drawing.Point(283, 284);
            this.workerSurnameTextBox.Name = "workerSurnameTextBox";
            this.workerSurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.workerSurnameTextBox.TabIndex = 21;
            this.workerSurnameTextBox.TextChanged += new System.EventHandler(this.workerSurnameTextBox_TextChanged_1);
            // 
            // addressofWorkerTextBox
            // 
            this.addressofWorkerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerInfoBindingSource, "AddressofWorker", true));
            this.addressofWorkerTextBox.Location = new System.Drawing.Point(283, 335);
            this.addressofWorkerTextBox.Name = "addressofWorkerTextBox";
            this.addressofWorkerTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressofWorkerTextBox.TabIndex = 22;
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerInfoBindingSource, "PhoneNum", true));
            this.phoneNumTextBox.Location = new System.Drawing.Point(283, 395);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneNumTextBox.TabIndex = 23;
            // 
            // sSNTextBox
            // 
            this.sSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerInfoBindingSource, "SSN", true));
            this.sSNTextBox.Location = new System.Drawing.Point(283, 441);
            this.sSNTextBox.Name = "sSNTextBox";
            this.sSNTextBox.Size = new System.Drawing.Size(100, 22);
            this.sSNTextBox.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(100, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 64);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete Worker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(100, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 73);
            this.button3.TabIndex = 27;
            this.button3.Text = "Update Worker";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select the Person to see info";
            // 
            // workerIDTextBox
            // 
            this.workerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerInfoBindingSource, "WorkerID", true));
            this.workerIDTextBox.Location = new System.Drawing.Point(283, 179);
            this.workerIDTextBox.Name = "workerIDTextBox";
            this.workerIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.workerIDTextBox.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(731, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 74);
            this.button4.TabIndex = 31;
            this.button4.Text = "Upload file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(827, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 74);
            this.button5.TabIndex = 32;
            this.button5.Text = "Send mail";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 80);
            this.button6.TabIndex = 33;
            this.button6.Text = "Insert Tool";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(547, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 71);
            this.button7.TabIndex = 34;
            this.button7.Text = "Support Case";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(547, 286);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 63);
            this.button8.TabIndex = 35;
            this.button8.Text = "Solution to the Case";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(547, 388);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 56);
            this.button9.TabIndex = 36;
            this.button9.Text = "Log";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Location = new System.Drawing.Point(0, 76);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 64);
            this.button10.TabIndex = 37;
            this.button10.Text = "Delete Tool";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button11.Location = new System.Drawing.Point(0, 140);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 73);
            this.button11.TabIndex = 38;
            this.button11.Text = "Update Tool";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.button12);
            this.panelSettings.Controls.Add(this.subMenu);
            this.panelSettings.Location = new System.Drawing.Point(706, 12);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(208, 294);
            this.panelSettings.TabIndex = 41;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(60, 20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(83, 39);
            this.button12.TabIndex = 42;
            this.button12.Text = "Settings";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // subMenu
            // 
            this.subMenu.Controls.Add(this.button11);
            this.subMenu.Controls.Add(this.button1);
            this.subMenu.Controls.Add(this.button3);
            this.subMenu.Controls.Add(this.button6);
            this.subMenu.Controls.Add(this.button2);
            this.subMenu.Controls.Add(this.button10);
            this.subMenu.Location = new System.Drawing.Point(3, 65);
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(201, 218);
            this.subMenu.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 515);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(workerIDLabel1);
            this.Controls.Add(this.workerIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(sSNLabel);
            this.Controls.Add(this.sSNTextBox);
            this.Controls.Add(phoneNumLabel);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(addressofWorkerLabel);
            this.Controls.Add(this.addressofWorkerTextBox);
            this.Controls.Add(workerSurnameLabel);
            this.Controls.Add(this.workerSurnameTextBox);
            this.Controls.Add(workerNameLabel);
            this.Controls.Add(this.workerNameTextBox);
            this.Controls.Add(comboBox1);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.subMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestDBDataSet testDBDataSet;
        private System.Windows.Forms.BindingSource workerInfoBindingSource;
        private TestDBDataSetTableAdapters.WorkerInfoTableAdapter workerInfoTableAdapter;
        private TestDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private EventHandler workerSurnameTextBox_TextChanged;
        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.TextBox workerSurnameTextBox;
        private System.Windows.Forms.TextBox addressofWorkerTextBox;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.TextBox sSNTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox workerIDTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel subMenu;
        private System.Windows.Forms.Button button12;
    }
}

