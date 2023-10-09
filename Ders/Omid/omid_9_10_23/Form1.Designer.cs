namespace omid_9_10_23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkBox1 = new CheckBox();
            button1 = new Button();
            bomb = new TextBox();
            pictureBox1 = new PictureBox();
            liste = new ListBox();
            ShowList = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(705, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Kontrol";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Nuke Serbs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bomb
            // 
            bomb.Location = new Point(93, 10);
            bomb.Name = "bomb";
            bomb.Size = new Size(261, 23);
            bomb.TabIndex = 3;
            bomb.Text = "I suggesting to bomb Belgrade - Darth Brandon";
            bomb.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(452, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 397);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // liste
            // 
            liste.FormattingEnabled = true;
            liste.ItemHeight = 15;
            liste.Location = new Point(93, 41);
            liste.Name = "liste";
            liste.Size = new Size(261, 394);
            liste.TabIndex = 5;
            liste.Visible = false;
            liste.SelectedIndexChanged += liste_SelectedIndexChanged;
            // 
            // ShowList
            // 
            ShowList.Location = new Point(12, 41);
            ShowList.Name = "ShowList";
            ShowList.Size = new Size(75, 23);
            ShowList.TabIndex = 6;
            ShowList.Text = "button2";
            ShowList.UseVisualStyleBackColor = true;
            ShowList.Click += ShowList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 563);
            Controls.Add(ShowList);
            Controls.Add(liste);
            Controls.Add(pictureBox1);
            Controls.Add(bomb);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
        private TextBox bomb;
        private PictureBox pictureBox1;
        private ListBox liste;
        private Button ShowList;
    }
}