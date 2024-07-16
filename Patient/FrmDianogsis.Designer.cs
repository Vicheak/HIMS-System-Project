using System.Drawing;
using System.Windows.Forms;

namespace HIMS.Patient
{
    partial class FrmDianogsis
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
            label1 = new Label();
            txtPatientID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDescription = new TextBox();
            label6 = new Label();
            txtPhysicianNote = new TextBox();
            txtStatus = new TextBox();
            txtPhysicianID = new TextBox();
            dtpDiangnosisDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtSearchPatientID = new TextBox();
            label7 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(108, 36);
            label1.TabIndex = 0;
            label1.Text = "Patient ID ";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(207, 32);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(356, 44);
            txtPatientID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 38);
            label2.Name = "label2";
            label2.Size = new Size(131, 36);
            label2.TabIndex = 2;
            label2.Text = "Physician ID ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(633, 118);
            label3.Name = "label3";
            label3.Size = new Size(72, 36);
            label3.TabIndex = 6;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 115);
            label4.Name = "label4";
            label4.Size = new Size(148, 36);
            label4.TabIndex = 4;
            label4.Text = "Diagnosis Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(633, 200);
            label5.Name = "label5";
            label5.Size = new Size(148, 36);
            label5.TabIndex = 10;
            label5.Text = "Physician Note";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(207, 194);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(356, 201);
            txtDescription.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 197);
            label6.Name = "label6";
            label6.Size = new Size(114, 36);
            label6.TabIndex = 8;
            label6.Text = "Description";
            // 
            // txtPhysicianNote
            // 
            txtPhysicianNote.Location = new Point(797, 194);
            txtPhysicianNote.Multiline = true;
            txtPhysicianNote.Name = "txtPhysicianNote";
            txtPhysicianNote.Size = new Size(356, 201);
            txtPhysicianNote.TabIndex = 13;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(797, 112);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(356, 44);
            txtStatus.TabIndex = 12;
            // 
            // txtPhysicianID
            // 
            txtPhysicianID.Location = new Point(797, 32);
            txtPhysicianID.Name = "txtPhysicianID";
            txtPhysicianID.Size = new Size(356, 44);
            txtPhysicianID.TabIndex = 11;
            // 
            // dtpDiangnosisDate
            // 
            dtpDiangnosisDate.Location = new Point(207, 112);
            dtpDiangnosisDate.Name = "dtpDiangnosisDate";
            dtpDiangnosisDate.Size = new Size(356, 44);
            dtpDiangnosisDate.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSearchPatientID);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(38, 430);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1115, 283);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 120);
            label8.Name = "label8";
            label8.Size = new Size(88, 36);
            label8.TabIndex = 18;
            label8.Text = "Result : ";
            // 
            // txtSearchPatientID
            // 
            txtSearchPatientID.Location = new Point(230, 32);
            txtSearchPatientID.Name = "txtSearchPatientID";
            txtSearchPatientID.Size = new Size(295, 44);
            txtSearchPatientID.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 35);
            label7.Name = "label7";
            label7.Size = new Size(193, 36);
            label7.TabIndex = 16;
            label7.Text = "Search (Patient ID)";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.YellowGreen;
            btnInsert.ForeColor = SystemColors.WindowText;
            btnInsert.Location = new Point(609, 780);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(152, 48);
            btnInsert.TabIndex = 16;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Location = new Point(806, 780);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 48);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1001, 780);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 48);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 856);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Controls.Add(dtpDiangnosisDate);
            Controls.Add(txtPhysicianNote);
            Controls.Add(txtStatus);
            Controls.Add(txtPhysicianID);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtPatientID);
            Controls.Add(label1);
            Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient's Diagnosis";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPatientID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDescription;
        private Label label6;
        private TextBox txtPhysicianNote;
        private TextBox txtStatus;
        private TextBox txtPhysicianID;
        private DateTimePicker dtpDiangnosisDate;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtSearchPatientID;
        private Label label7;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;

    }
}