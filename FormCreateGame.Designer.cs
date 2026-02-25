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
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // cBoxPlayers
            // 
            cBoxPlayers.FormattingEnabled = true;
            cBoxPlayers.Location = new Point(289, 111);
            cBoxPlayers.Margin = new Padding(2);
            cBoxPlayers.Name = "cBoxPlayers";
            cBoxPlayers.Size = new Size(196, 33);
            cBoxPlayers.TabIndex = 0;
            // 
            // tBoxPlayer
            // 
            tBoxPlayer.Location = new Point(270, 218);
            tBoxPlayer.Margin = new Padding(2);
            tBoxPlayer.Name = "tBoxPlayer";
            tBoxPlayer.Size = new Size(225, 31);
            tBoxPlayer.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(289, 308);
            btnStart.Margin = new Padding(2);
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
            label1.Location = new Point(289, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 5;
            label1.Text = "Wähle einen Spieler aus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 188);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 6;
            label2.Text = "Erstelle einen neuen Spieler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 152);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 7;
            label3.Text = "oder";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(704, 15);
            btnBack.Margin = new Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 34);
            btnBack.TabIndex = 8;
            btnBack.Text = "Zurück";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormCreateGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(tBoxPlayer);
            Controls.Add(cBoxPlayers);
            Margin = new Padding(2);
            Name = "FormCreateGame";
            Text = "Spiel Einstellungen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBoxPlayers;
        private TextBox tBoxPlayer;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBack;
    }
}