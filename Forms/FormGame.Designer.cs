namespace WerWirdReich
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            labelQuestion = new Label();
            labelName = new Label();
            btnOption = new Button();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnJoker1 = new Button();
            btnJoker2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            labelJ = new Label();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.BackColor = Color.FromArgb(100, 100, 255);
            labelQuestion.Font = new Font("Franklin Gothic Medium Cond", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQuestion.Location = new Point(230, 14);
            labelQuestion.Margin = new Padding(4, 0, 4, 0);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(728, 160);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "Fragen";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Franklin Gothic Medium Cond", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(12, 14);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(165, 37);
            labelName.TabIndex = 2;
            labelName.Text = "Spielername";
            // 
            // btnOption
            // 
            btnOption.FlatStyle = FlatStyle.Flat;
            btnOption.Font = new Font("Franklin Gothic Medium Cond", 11F);
            btnOption.Location = new Point(1019, 14);
            btnOption.Margin = new Padding(5);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(168, 48);
            btnOption.TabIndex = 5;
            btnOption.Text = "Einstellungen";
            btnOption.UseVisualStyleBackColor = true;
            btnOption.Click += btnOption_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(192, 192, 255);
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Font = new Font("Franklin Gothic Medium Cond", 11F);
            btnA.Location = new Point(231, 277);
            btnA.Margin = new Padding(5);
            btnA.Name = "btnA";
            btnA.Size = new Size(360, 120);
            btnA.TabIndex = 6;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnClickController;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(192, 192, 255);
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Font = new Font("Franklin Gothic Medium Cond", 11F);
            btnB.Location = new Point(598, 277);
            btnB.Margin = new Padding(5);
            btnB.Name = "btnB";
            btnB.Size = new Size(360, 120);
            btnB.TabIndex = 7;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnClickController;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(192, 192, 255);
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Franklin Gothic Medium Cond", 11F);
            btnC.Location = new Point(228, 407);
            btnC.Margin = new Padding(5);
            btnC.Name = "btnC";
            btnC.Size = new Size(360, 120);
            btnC.TabIndex = 8;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnClickController;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(192, 192, 255);
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Franklin Gothic Medium Cond", 11F);
            btnD.Location = new Point(598, 407);
            btnD.Margin = new Padding(5);
            btnD.Name = "btnD";
            btnD.Size = new Size(360, 120);
            btnD.TabIndex = 9;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnClickController;
            // 
            // btnJoker1
            // 
            btnJoker1.FlatStyle = FlatStyle.Flat;
            btnJoker1.Font = new Font("Franklin Gothic Medium Cond", 11F);
            btnJoker1.Location = new Point(14, 277);
            btnJoker1.Margin = new Padding(5);
            btnJoker1.Name = "btnJoker1";
            btnJoker1.Size = new Size(200, 54);
            btnJoker1.TabIndex = 10;
            btnJoker1.Text = "50 / 50";
            btnJoker1.UseVisualStyleBackColor = true;
            btnJoker1.Click += btnJoker1_Click;
            // 
            // btnJoker2
            // 
            btnJoker2.FlatStyle = FlatStyle.Flat;
            btnJoker2.Font = new Font("Franklin Gothic Medium Cond", 11F);
            btnJoker2.Location = new Point(14, 341);
            btnJoker2.Margin = new Padding(5);
            btnJoker2.Name = "btnJoker2";
            btnJoker2.Size = new Size(200, 54);
            btnJoker2.TabIndex = 11;
            btnJoker2.Text = "25 / 75";
            btnJoker2.UseVisualStyleBackColor = true;
            btnJoker2.Click += btnJoker2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label1.Location = new Point(1019, 513);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 13;
            label1.Text = "1 | 50 MK";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label2.Location = new Point(1019, 477);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 14;
            label2.Text = "2 | 100 MK";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label3.Location = new Point(1019, 441);
            label3.Margin = new Padding(4);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 15;
            label3.Text = "3 | 500 MK";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label4.Location = new Point(1019, 405);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 16;
            label4.Text = "4 | 1.000 MK";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(255, 255, 192);
            label5.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label5.Location = new Point(1019, 368);
            label5.Margin = new Padding(4);
            label5.Name = "label5";
            label5.Size = new Size(171, 28);
            label5.TabIndex = 17;
            label5.Text = "5 | 5.000 MK";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(255, 192, 192);
            label6.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label6.Location = new Point(1019, 333);
            label6.Margin = new Padding(4);
            label6.Name = "label6";
            label6.Size = new Size(171, 28);
            label6.TabIndex = 18;
            label6.Text = "6 | 10.000 MK";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(255, 192, 192);
            label7.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label7.Location = new Point(1019, 297);
            label7.Margin = new Padding(4);
            label7.Name = "label7";
            label7.Size = new Size(171, 28);
            label7.TabIndex = 19;
            label7.Text = "7 | 50.000 MK";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(255, 192, 192);
            label8.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label8.Location = new Point(1019, 261);
            label8.Margin = new Padding(4);
            label8.Name = "label8";
            label8.Size = new Size(171, 28);
            label8.TabIndex = 20;
            label8.Text = "8 | 100.000 MK";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(255, 192, 192);
            label9.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label9.Location = new Point(1019, 225);
            label9.Margin = new Padding(4);
            label9.Name = "label9";
            label9.Size = new Size(171, 28);
            label9.TabIndex = 21;
            label9.Text = "9 | 500.000 MK";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 192, 192);
            label10.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label10.Location = new Point(1019, 189);
            label10.Margin = new Padding(4);
            label10.Name = "label10";
            label10.Size = new Size(171, 28);
            label10.TabIndex = 22;
            label10.Text = "10 | 1.000.000 MK";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelJ
            // 
            labelJ.BackColor = Color.Transparent;
            labelJ.Font = new Font("Franklin Gothic Medium Cond", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelJ.ForeColor = Color.White;
            labelJ.Location = new Point(12, 222);
            labelJ.Margin = new Padding(4, 0, 4, 0);
            labelJ.Name = "labelJ";
            labelJ.Size = new Size(201, 50);
            labelJ.TabIndex = 23;
            labelJ.Text = "Jokers";
            labelJ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1201, 702);
            Controls.Add(labelJ);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnJoker2);
            Controls.Add(btnJoker1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(btnOption);
            Controls.Add(labelName);
            Controls.Add(labelQuestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FormGame";
            Text = "WER WIRD REICH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelQuestion;
        private Label labelName;
        private Button btnOption;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnJoker1;
        private Button btnJoker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelJ;
    }
}