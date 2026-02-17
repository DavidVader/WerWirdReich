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
            label1 = new Label();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.Location = new Point(180, 43);
            labelQuestion.Margin = new Padding(4, 0, 4, 0);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(608, 132);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "Fragen";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(15, 11);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 2;
            labelName.Text = "label1";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(469, 9);
            labelLevel.Margin = new Padding(4, 0, 4, 0);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(22, 25);
            labelLevel.TabIndex = 3;
            labelLevel.Text = "1";
            // 
            // labelCash
            // 
            labelCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCash.AutoSize = true;
            labelCash.BackColor = Color.White;
            labelCash.ImageAlign = ContentAlignment.MiddleRight;
            labelCash.Location = new Point(712, 11);
            labelCash.Margin = new Padding(4, 0, 4, 0);
            labelCash.Name = "labelCash";
            labelCash.RightToLeft = RightToLeft.No;
            labelCash.Size = new Size(76, 25);
            labelCash.TabIndex = 4;
            labelCash.Text = "0 MARK";
            labelCash.TextAlign = ContentAlignment.TopRight;
            // 
            // btnOption
            // 
            btnOption.Location = new Point(865, 11);
            btnOption.Margin = new Padding(4);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(109, 42);
            btnOption.TabIndex = 5;
            btnOption.Text = "Einstellungen";
            btnOption.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(192, 192, 255);
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Location = new Point(180, 181);
            btnA.Margin = new Padding(4);
            btnA.Name = "btnA";
            btnA.Size = new Size(300, 100);
            btnA.TabIndex = 6;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnClickController;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(192, 192, 255);
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Location = new Point(488, 181);
            btnB.Margin = new Padding(4);
            btnB.Name = "btnB";
            btnB.Size = new Size(300, 100);
            btnB.TabIndex = 7;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnClickController;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(192, 192, 255);
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Location = new Point(180, 289);
            btnC.Margin = new Padding(4);
            btnC.Name = "btnC";
            btnC.Size = new Size(300, 100);
            btnC.TabIndex = 8;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnClickController;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(192, 192, 255);
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Location = new Point(488, 289);
            btnD.Margin = new Padding(4);
            btnD.Name = "btnD";
            btnD.Size = new Size(300, 100);
            btnD.TabIndex = 9;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnClickController;
            // 
            // btnJoker1
            // 
            btnJoker1.Location = new Point(15, 139);
            btnJoker1.Margin = new Padding(4);
            btnJoker1.Name = "btnJoker1";
            btnJoker1.Size = new Size(118, 36);
            btnJoker1.TabIndex = 10;
            btnJoker1.Text = "button1";
            btnJoker1.UseVisualStyleBackColor = true;
            // 
            // btnJoker2
            // 
            btnJoker2.Location = new Point(15, 201);
            btnJoker2.Margin = new Padding(4);
            btnJoker2.Name = "btnJoker2";
            btnJoker2.Size = new Size(118, 36);
            btnJoker2.TabIndex = 11;
            btnJoker2.Text = "button2";
            btnJoker2.UseVisualStyleBackColor = true;
            // 
            // btnJoker3
            // 
            btnJoker3.Location = new Point(15, 266);
            btnJoker3.Margin = new Padding(4);
            btnJoker3.Name = "btnJoker3";
            btnJoker3.Size = new Size(118, 36);
            btnJoker3.TabIndex = 12;
            btnJoker3.Text = "button3";
            btnJoker3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(904, 470);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 13;
            label1.Text = "1. 100 MK";
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 562);
            Controls.Add(label1);
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
            Margin = new Padding(4);
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
        private Label label1;
    }
}