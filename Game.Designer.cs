namespace WerWirdReich
{
    partial class Game
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
            buttonPlay.Location = new Point(330, 336);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(94, 29);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
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
            // buttonExit
            // 
            buttonExit.Location = new Point(692, 9);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(87, 34);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "button1";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            buttonA.Location = new Point(180, 176);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(204, 49);
            buttonA.TabIndex = 6;
            buttonA.Text = "button1";
            buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(390, 176);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(204, 49);
            buttonB.TabIndex = 7;
            buttonB.Text = "button2";
            buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(180, 231);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(204, 49);
            buttonC.TabIndex = 8;
            buttonC.Text = "button3";
            buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(390, 231);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(204, 49);
            buttonD.TabIndex = 9;
            buttonD.Text = "button4";
            buttonD.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Game";
            Text = "NeuesSpiel";
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