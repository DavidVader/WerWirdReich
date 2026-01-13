namespace WerWirdReich
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnGame = new Button();
            pictureBox1 = new PictureBox();
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
            btnGame.Location = new Point(47, 146);
            btnGame.Margin = new Padding(2);
            btnGame.Name = "btnGame";
            btnGame.Size = new Size(211, 74);
            btnGame.TabIndex = 0;
            btnGame.UseVisualStyleBackColor = true;
            btnGame.Click += btnGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 570);
            Controls.Add(pictureBox1);
            Controls.Add(btnGame);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Menu";
            Text = "WER WIRD REICH";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGame;
        private PictureBox pictureBox1;
    }
}
