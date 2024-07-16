using System.Drawing;
using System.Windows.Forms;

namespace HIMS.Medicine
{
    partial class FrmMedicine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineDescriptoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uniprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unistock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrModify = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ស្វែងរកឈ្មោះថ្នាំ ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 49);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(995, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "ស្វែងរក";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.MedicineType,
            this.MedicineDescriptoin,
            this.Uniprice,
            this.Unistock,
            this.ImportedDate,
            this.ExpirationDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 395);
            this.dataGridView1.TabIndex = 3;
            // 
            // MedicineID
            // 
            this.MedicineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineID.HeaderText = "លេខសម្គាល់ថ្នាំ";
            this.MedicineID.MinimumWidth = 6;
            this.MedicineID.Name = "MedicineID";
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.HeaderText = "ឈ្មោះថ្នាំ";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            // 
            // MedicineType
            // 
            this.MedicineType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineType.HeaderText = "ប្រភេទថ្នាំ";
            this.MedicineType.MinimumWidth = 6;
            this.MedicineType.Name = "MedicineType";
            // 
            // MedicineDescriptoin
            // 
            this.MedicineDescriptoin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineDescriptoin.HeaderText = "អំពីថ្នាំ";
            this.MedicineDescriptoin.MinimumWidth = 6;
            this.MedicineDescriptoin.Name = "MedicineDescriptoin";
            // 
            // Uniprice
            // 
            this.Uniprice.HeaderText = "តម្លៃឯកតា";
            this.Uniprice.MinimumWidth = 6;
            this.Uniprice.Name = "Uniprice";
            this.Uniprice.Width = 125;
            // 
            // Unistock
            // 
            this.Unistock.HeaderText = "ចំនួនក្នុងស្តុក";
            this.Unistock.MinimumWidth = 6;
            this.Unistock.Name = "Unistock";
            this.Unistock.Width = 125;
            // 
            // ImportedDate
            // 
            this.ImportedDate.HeaderText = "ថ្ងៃខែនាំចូល";
            this.ImportedDate.MinimumWidth = 6;
            this.ImportedDate.Name = "ImportedDate";
            this.ImportedDate.Width = 125;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpirationDate.HeaderText = "ថ្ងៃខែផុតកំណត់";
            this.ExpirationDate.MinimumWidth = 6;
            this.ExpirationDate.Name = "ExpirationDate";
            // 
            // btnAddOrModify
            // 
            this.btnAddOrModify.Location = new System.Drawing.Point(12, 495);
            this.btnAddOrModify.Name = "btnAddOrModify";
            this.btnAddOrModify.Size = new System.Drawing.Size(241, 48);
            this.btnAddOrModify.TabIndex = 4;
            this.btnAddOrModify.Text = "កែប្រែ ឬ បន្ថែមទិន្នន័យ";
            this.btnAddOrModify.UseVisualStyleBackColor = true;
            this.btnAddOrModify.Click += new System.EventHandler(this.btnAddOrModify_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(995, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "លុបទិន្នន័យ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1152, 555);
            this.Controls.Add(this.btnAddOrModify);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmMedicine";
            this.Text = "ព័ត៌មាននៃថ្នាំ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnAddOrModify;
        private Button button3;
        private DataGridViewTextBoxColumn MedicineID;
        private DataGridViewTextBoxColumn MedicineName;
        private DataGridViewTextBoxColumn MedicineType;
        private DataGridViewTextBoxColumn MedicineDescriptoin;
        private DataGridViewTextBoxColumn Uniprice;
        private DataGridViewTextBoxColumn Unistock;
        private DataGridViewTextBoxColumn ImportedDate;
        private DataGridViewTextBoxColumn ExpirationDate;

    }
}