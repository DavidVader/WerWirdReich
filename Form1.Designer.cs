namespace WerWirdReich
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNewGame = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Cursor = Cursors.Hand;
            btnNewGame.FlatAppearance.BorderSize = 4;
            btnNewGame.FlatStyle = FlatStyle.Flat;
            btnNewGame.Font = new Font("Sans Serif Collection", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(43, 279);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(340, 90);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "NEW GAME";
            btnNewGame.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1130, 712);
            Controls.Add(pictureBox1);
            Controls.Add(btnNewGame);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "WER WIRD REICH";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewGame;
        private PictureBox pictureBox1;
    }
}
