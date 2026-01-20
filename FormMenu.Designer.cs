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
            btnGame.Location = new Point(59, 182);
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
            btnOption.Location = new Point(59, 291);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(264, 95);
            btnOption.TabIndex = 2;
            btnOption.Text = "Einstellungen";
            btnOption.UseVisualStyleBackColor = true;
            btnOption.Click += btnOption_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(59, 413);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(264, 95);
            btnQuit.TabIndex = 3;
            btnQuit.Text = "Beenden";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1130, 712);
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
    }
}
