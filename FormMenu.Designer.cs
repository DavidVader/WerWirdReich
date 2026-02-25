namespace WerWirdReich
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            btnGame = new Button();
            pictureBox1 = new PictureBox();
            btnOption = new Button();
            btnQuit = new Button();
            listBoxScoreBoard = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGame
            // 
            btnGame.BackgroundImage = (Image)resources.GetObject("btnGame.BackgroundImage");
            btnGame.BackgroundImageLayout = ImageLayout.Stretch;
            btnGame.Cursor = Cursors.Hand;
            btnGame.FlatAppearance.BorderSize = 0;
            btnGame.FlatStyle = FlatStyle.Flat;
            btnGame.Font = new Font("Sans Serif Collection", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGame.Location = new Point(244, 216);
            btnGame.Margin = new Padding(2);
            btnGame.Name = "btnGame";
            btnGame.Size = new Size(264, 92);
            btnGame.TabIndex = 0;
            btnGame.UseVisualStyleBackColor = true;
            btnGame.Click += btnGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 9);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnOption
            // 
            btnOption.BackColor = Color.Transparent;
            btnOption.BackgroundImage = (Image)resources.GetObject("btnOption.BackgroundImage");
            btnOption.BackgroundImageLayout = ImageLayout.Stretch;
            btnOption.Cursor = Cursors.Hand;
            btnOption.FlatAppearance.BorderSize = 0;
            btnOption.FlatStyle = FlatStyle.Flat;
            btnOption.Location = new Point(244, 330);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(264, 95);
            btnOption.TabIndex = 2;
            btnOption.UseVisualStyleBackColor = false;
            btnOption.Click += btnOption_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackgroundImage = (Image)resources.GetObject("btnQuit.BackgroundImage");
            btnQuit.BackgroundImageLayout = ImageLayout.Stretch;
            btnQuit.FlatAppearance.BorderSize = 0;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Location = new Point(244, 447);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(264, 95);
            btnQuit.TabIndex = 3;
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // listBoxScoreBoard
            // 
            listBoxScoreBoard.BackColor = Color.FromArgb(56, 68, 176);
            listBoxScoreBoard.BorderStyle = BorderStyle.None;
            listBoxScoreBoard.Font = new Font("Franklin Gothic Medium Cond", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxScoreBoard.FormattingEnabled = true;
            listBoxScoreBoard.ItemHeight = 37;
            listBoxScoreBoard.Location = new Point(607, 216);
            listBoxScoreBoard.Name = "listBoxScoreBoard";
            listBoxScoreBoard.Size = new Size(373, 296);
            listBoxScoreBoard.TabIndex = 4;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1130, 712);
            Controls.Add(listBoxScoreBoard);
            Controls.Add(btnQuit);
            Controls.Add(btnOption);
            Controls.Add(pictureBox1);
            Controls.Add(btnGame);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormMenu";
            Text = "WER WIRD REICH";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGame;
        private PictureBox pictureBox1;
        private Button btnOption;
        private Button btnQuit;
        private ListBox listBoxScoreBoard;
    }
}
