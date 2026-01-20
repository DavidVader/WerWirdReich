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
            buttonExit = new Button();
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            SuspendLayout();
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(412, 420);
            buttonPlay.Margin = new Padding(4, 4, 4, 4);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(118, 36);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Play";
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
            // buttonExit
            // 
            buttonExit.Location = new Point(865, 11);
            buttonExit.Margin = new Padding(4, 4, 4, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(109, 42);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "button1";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            buttonA.Location = new Point(225, 220);
            buttonA.Margin = new Padding(4, 4, 4, 4);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(255, 61);
            buttonA.TabIndex = 6;
            buttonA.Text = "button1";
            buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(488, 220);
            buttonB.Margin = new Padding(4, 4, 4, 4);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(255, 61);
            buttonB.TabIndex = 7;
            buttonB.Text = "button2";
            buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(225, 289);
            buttonC.Margin = new Padding(4, 4, 4, 4);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(255, 61);
            buttonC.TabIndex = 8;
            buttonC.Text = "button3";
            buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(488, 289);
            buttonD.Margin = new Padding(4, 4, 4, 4);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(255, 61);
            buttonD.TabIndex = 9;
            buttonD.Text = "button4";
            buttonD.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(buttonExit);
            Controls.Add(labelCash);
            Controls.Add(labelLevel);
            Controls.Add(labelName);
            Controls.Add(labelQuestion);
            Controls.Add(buttonPlay);
            Margin = new Padding(4, 4, 4, 4);
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
        private Button buttonExit;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
    }
}