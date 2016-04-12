namespace OutdoorParadiseViewer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outdoorParadiseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outdoorParadiseDataSet = new OutdoorParadiseViewer.OutdoorParadiseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBQuery = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnHRM = new System.Windows.Forms.Button();
            this.btnPChin = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorParadiseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorParadiseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(869, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // outdoorParadiseDataSetBindingSource
            // 
            this.outdoorParadiseDataSetBindingSource.DataSource = this.outdoorParadiseDataSet;
            this.outdoorParadiseDataSetBindingSource.Position = 0;
            // 
            // outdoorParadiseDataSet
            // 
            this.outdoorParadiseDataSet.DataSetName = "OutdoorParadiseDataSet";
            this.outdoorParadiseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Basic commands";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Query";
            // 
            // tBQuery
            // 
            this.tBQuery.Location = new System.Drawing.Point(472, 510);
            this.tBQuery.Name = "tBQuery";
            this.tBQuery.Size = new System.Drawing.Size(346, 20);
            this.tBQuery.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 510);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(558, 476);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(81, 19);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status: ";
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Location = new System.Drawing.Point(84, 498);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(61, 44);
            this.btnManager.TabIndex = 10;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnHRM
            // 
            this.btnHRM.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRM.Location = new System.Drawing.Point(151, 498);
            this.btnHRM.Name = "btnHRM";
            this.btnHRM.Size = new System.Drawing.Size(61, 44);
            this.btnHRM.TabIndex = 11;
            this.btnHRM.Text = "HRM";
            this.btnHRM.UseVisualStyleBackColor = true;
            this.btnHRM.Click += new System.EventHandler(this.btnHRM_Click);
            // 
            // btnPChin
            // 
            this.btnPChin.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPChin.Location = new System.Drawing.Point(17, 498);
            this.btnPChin.Name = "btnPChin";
            this.btnPChin.Size = new System.Drawing.Size(61, 44);
            this.btnPChin.TabIndex = 12;
            this.btnPChin.Text = "P. Chin";
            this.btnPChin.UseVisualStyleBackColor = true;
            this.btnPChin.Click += new System.EventHandler(this.btnPChin_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(826, 508);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(57, 23);
            this.btnExecute.TabIndex = 13;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(218, 498);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(61, 44);
            this.btnAdmin.TabIndex = 14;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 545);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnPChin);
            this.Controls.Add(this.btnHRM);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tBQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorParadiseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorParadiseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource outdoorParadiseDataSetBindingSource;
        private OutdoorParadiseDataSet outdoorParadiseDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBQuery;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnHRM;
        private System.Windows.Forms.Button btnPChin;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnAdmin;
    }
}

