namespace WerWirdReich
{
    partial class FormCreateGame
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
            cBoxPlayers = new ComboBox();
            tBoxPlayer = new TextBox();
            checkBoxTimer = new CheckBox();
            checkBoxJoker = new CheckBox();
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cBoxPlayers
            // 
            cBoxPlayers.FormattingEnabled = true;
            cBoxPlayers.Location = new Point(119, 71);
            cBoxPlayers.Name = "cBoxPlayers";
            cBoxPlayers.Size = new Size(197, 33);
            cBoxPlayers.TabIndex = 0;
            // 
            // tBoxPlayer
            // 
            tBoxPlayer.Location = new Point(450, 73);
            tBoxPlayer.Name = "tBoxPlayer";
            tBoxPlayer.Size = new Size(225, 31);
            tBoxPlayer.TabIndex = 1;
            // 
            // checkBoxTimer
            // 
            checkBoxTimer.AutoSize = true;
            checkBoxTimer.Location = new Point(299, 160);
            checkBoxTimer.Name = "checkBoxTimer";
            checkBoxTimer.Size = new Size(165, 29);
            checkBoxTimer.TabIndex = 2;
            checkBoxTimer.Text = "Spiele mit Timer";
            checkBoxTimer.UseVisualStyleBackColor = true;
            // 
            // checkBoxJoker
            // 
            checkBoxJoker.AutoSize = true;
            checkBoxJoker.Location = new Point(299, 213);
            checkBoxJoker.Name = "checkBoxJoker";
            checkBoxJoker.Size = new Size(170, 29);
            checkBoxJoker.TabIndex = 3;
            checkBoxJoker.Text = "Spiele mit Jokers";
            checkBoxJoker.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(289, 307);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(175, 89);
            btnStart.TabIndex = 4;
            btnStart.Text = "Spiel starten";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 43);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 5;
            label1.Text = "Wähle einen Spieler aus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 43);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 6;
            label2.Text = "Erstelle einen neuen Spieler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 74);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 7;
            label3.Text = "oder";
            // 
            // FormCreateGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(checkBoxJoker);
            Controls.Add(checkBoxTimer);
            Controls.Add(tBoxPlayer);
            Controls.Add(cBoxPlayers);
            Name = "FormCreateGame";
            Text = "Spiel Einstellungen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBoxPlayers;
        private TextBox tBoxPlayer;
        private CheckBox checkBoxTimer;
        private CheckBox checkBoxJoker;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}