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
            buttonPlay = new Button();
            labelQuestion = new Label();
            labelName = new Label();
            labelLevel = new Label();
            labelCash = new Label();
            btnOption = new Button();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            SuspendLayout();
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(412, 420);
            buttonPlay.Margin = new Padding(4);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(118, 36);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Spielen";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(412, 11);
            labelQuestion.Margin = new Padding(4, 0, 4, 0);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(66, 25);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "Fragen";
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
            labelLevel.Location = new Point(196, 11);
            labelLevel.Margin = new Padding(4, 0, 4, 0);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(59, 25);
            labelLevel.TabIndex = 3;
            labelLevel.Text = "label1";
            // 
            // labelCash
            // 
            labelCash.AutoSize = true;
            labelCash.Location = new Point(635, 18);
            labelCash.Margin = new Padding(4, 0, 4, 0);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(59, 25);
            labelCash.TabIndex = 4;
            labelCash.Text = "label1";
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
            btnA.Location = new Point(225, 220);
            btnA.Margin = new Padding(4);
            btnA.Name = "btnA";
            btnA.Size = new Size(255, 61);
            btnA.TabIndex = 6;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(488, 220);
            btnB.Margin = new Padding(4);
            btnB.Name = "btnB";
            btnB.Size = new Size(255, 61);
            btnB.TabIndex = 7;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(225, 289);
            btnC.Margin = new Padding(4);
            btnC.Name = "btnC";
            btnC.Size = new Size(255, 61);
            btnC.TabIndex = 8;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(488, 289);
            btnD.Margin = new Padding(4);
            btnD.Name = "btnD";
            btnD.Size = new Size(255, 61);
            btnD.TabIndex = 9;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(btnOption);
            Controls.Add(labelCash);
            Controls.Add(labelLevel);
            Controls.Add(labelName);
            Controls.Add(labelQuestion);
            Controls.Add(buttonPlay);
            Margin = new Padding(4);
            Name = "FormGame";
            Text = "WER WIRD REICH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlay;
        private Label labelQuestion;
        private Label labelName;
        private Label labelLevel;
        private Label labelCash;
        private Button btnOption;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
    }
}