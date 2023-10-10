namespace SimpleCalculator_Home
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
            txtDisplayer = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnminus = new Button();
            btnplus = new Button();
            btndivide = new Button();
            btncarp = new Button();
            btnclear = new Button();
            btnequal = new Button();
            SuspendLayout();
            // 
            // txtDisplayer
            // 
            txtDisplayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplayer.Location = new Point(12, 12);
            txtDisplayer.Multiline = true;
            txtDisplayer.Name = "txtDisplayer";
            txtDisplayer.Size = new Size(480, 60);
            txtDisplayer.TabIndex = 0;
            txtDisplayer.TextChanged += txtDisplayer_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 78);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 68);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(93, 78);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 68);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(174, 78);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 68);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 152);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 68);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 226);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 68);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(93, 152);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 68);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(174, 152);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 68);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(93, 226);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 68);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(174, 226);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 68);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(93, 300);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 68);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(417, 78);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(75, 68);
            btnminus.TabIndex = 11;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnminus_Click;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(336, 78);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(75, 68);
            btnplus.TabIndex = 12;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btndivide
            // 
            btndivide.Location = new Point(417, 152);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(75, 68);
            btndivide.TabIndex = 13;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += btndivide_Click;
            // 
            // btncarp
            // 
            btncarp.Location = new Point(336, 152);
            btncarp.Name = "btncarp";
            btncarp.Size = new Size(75, 68);
            btncarp.TabIndex = 14;
            btncarp.Text = "*";
            btncarp.UseVisualStyleBackColor = true;
            btncarp.Click += btncarp_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(417, 226);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 68);
            btnclear.TabIndex = 15;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnequal
            // 
            btnequal.Location = new Point(336, 226);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(75, 68);
            btnequal.TabIndex = 16;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            btnequal.Click += btnequal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
            Controls.Add(btnequal);
            Controls.Add(btnclear);
            Controls.Add(btncarp);
            Controls.Add(btndivide);
            Controls.Add(btnplus);
            Controls.Add(btnminus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplayer);
            Name = "Form1";
            Text = "Calculator_0001";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplayer;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn7;
        private Button btn5;
        private Button btn6;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnminus;
        private Button btnplus;
        private Button btndivide;
        private Button btncarp;
        private Button btnclear;
        private Button btnequal;
    }
}