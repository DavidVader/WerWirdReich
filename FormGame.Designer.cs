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
            labelQuestion = new Label();
            labelName = new Label();
            labelLevel = new Label();
            labelCash = new Label();
            btnOption = new Button();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnJoker1 = new Button();
            btnJoker2 = new Button();
            btnJoker3 = new Button();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(330, 9);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(54, 20);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "Fragen";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(50, 20);
            labelName.TabIndex = 2;
            labelName.Text = "label1";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(157, 9);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(50, 20);
            labelLevel.TabIndex = 3;
            labelLevel.Text = "label1";
            // 
            // labelCash
            // 
            labelCash.AutoSize = true;
            labelCash.Location = new Point(508, 14);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(50, 20);
            labelCash.TabIndex = 4;
            labelCash.Text = "label1";
            // 
            // btnOption
            // 
            btnOption.Location = new Point(692, 9);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(87, 34);
            btnOption.TabIndex = 5;
            btnOption.Text = "Einstellungen";
            btnOption.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            btnA.Location = new Point(180, 176);
            btnA.Name = "btnA";
            btnA.Size = new Size(204, 49);
            btnA.TabIndex = 6;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(390, 176);
            btnB.Name = "btnB";
            btnB.Size = new Size(204, 49);
            btnB.TabIndex = 7;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(180, 231);
            btnC.Name = "btnC";
            btnC.Size = new Size(204, 49);
            btnC.TabIndex = 8;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(390, 231);
            btnD.Name = "btnD";
            btnD.Size = new Size(204, 49);
            btnD.TabIndex = 9;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnJoker1
            // 
            btnJoker1.Location = new Point(12, 111);
            btnJoker1.Name = "btnJoker1";
            btnJoker1.Size = new Size(94, 29);
            btnJoker1.TabIndex = 10;
            btnJoker1.Text = "button1";
            btnJoker1.UseVisualStyleBackColor = true;
            // 
            // btnJoker2
            // 
            btnJoker2.Location = new Point(12, 161);
            btnJoker2.Name = "btnJoker2";
            btnJoker2.Size = new Size(94, 29);
            btnJoker2.TabIndex = 11;
            btnJoker2.Text = "button2";
            btnJoker2.UseVisualStyleBackColor = true;
            // 
            // btnJoker3
            // 
            btnJoker3.Location = new Point(12, 213);
            btnJoker3.Name = "btnJoker3";
            btnJoker3.Size = new Size(94, 29);
            btnJoker3.TabIndex = 12;
            btnJoker3.Text = "button3";
            btnJoker3.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJoker3);
            Controls.Add(btnJoker2);
            Controls.Add(btnJoker1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(btnOption);
            Controls.Add(labelCash);
            Controls.Add(labelLevel);
            Controls.Add(labelName);
            Controls.Add(labelQuestion);
            Name = "FormGame";
            Text = "WER WIRD REICH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelQuestion;
        private Label labelName;
        private Label labelLevel;
        private Label labelCash;
        private Button btnOption;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnJoker1;
        private Button btnJoker2;
        private Button btnJoker3;
    }
}