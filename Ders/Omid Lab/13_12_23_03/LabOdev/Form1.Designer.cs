namespace LabTask
{
    partial class Form1
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
            txtIdNum = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtOOPgrade = new TextBox();
            txtCalculusGrade = new TextBox();
            txtDataStructureGrade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnShow = new Button();
            rchTxtBox = new RichTextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtIdNum
            // 
            txtIdNum.Location = new Point(268, 22);
            txtIdNum.Margin = new Padding(3, 2, 3, 2);
            txtIdNum.Name = "txtIdNum";
            txtIdNum.Size = new Size(110, 23);
            txtIdNum.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(268, 55);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(268, 89);
            txtSurname.Margin = new Padding(3, 2, 3, 2);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(110, 23);
            txtSurname.TabIndex = 3;
            // 
            // txtOOPgrade
            // 
            txtOOPgrade.Location = new Point(268, 131);
            txtOOPgrade.Margin = new Padding(3, 2, 3, 2);
            txtOOPgrade.Name = "txtOOPgrade";
            txtOOPgrade.Size = new Size(110, 23);
            txtOOPgrade.TabIndex = 4;
            // 
            // txtCalculusGrade
            // 
            txtCalculusGrade.Location = new Point(268, 169);
            txtCalculusGrade.Margin = new Padding(3, 2, 3, 2);
            txtCalculusGrade.Name = "txtCalculusGrade";
            txtCalculusGrade.Size = new Size(110, 23);
            txtCalculusGrade.TabIndex = 5;
            // 
            // txtDataStructureGrade
            // 
            txtDataStructureGrade.Location = new Point(268, 214);
            txtDataStructureGrade.Margin = new Padding(3, 2, 3, 2);
            txtDataStructureGrade.Name = "txtDataStructureGrade";
            txtDataStructureGrade.Size = new Size(110, 23);
            txtDataStructureGrade.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 8;
            label1.Text = "Student ID Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 98);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 8;
            label2.Text = "Student Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 64);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 8;
            label3.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 140);
            label4.Name = "label4";
            label4.Size = new Size(195, 15);
            label4.TabIndex = 8;
            label4.Text = "Object Oriented Programmin Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 177);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 8;
            label5.Text = "Calculus Grade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 222);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 8;
            label6.Text = "Data Structure Grade:";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(21, 278);
            btnShow.Margin = new Padding(3, 2, 3, 2);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(74, 32);
            btnShow.TabIndex = 10;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // rchTxtBox
            // 
            rchTxtBox.Location = new Point(420, 22);
            rchTxtBox.Margin = new Padding(3, 2, 3, 2);
            rchTxtBox.Name = "rchTxtBox";
            rchTxtBox.Size = new Size(395, 468);
            rchTxtBox.TabIndex = 11;
            rchTxtBox.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(101, 278);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 32);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 501);
            Controls.Add(btnSave);
            Controls.Add(rchTxtBox);
            Controls.Add(btnShow);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtDataStructureGrade);
            Controls.Add(txtCalculusGrade);
            Controls.Add(txtOOPgrade);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtIdNum);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdNum;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtOOPgrade;
        private TextBox txtCalculusGrade;
        private TextBox txtDataStructureGrade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnShow;
        private RichTextBox rchTxtBox;
        private Button btnSave;
    }
}