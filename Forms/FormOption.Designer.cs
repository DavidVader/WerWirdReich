namespace WerWirdReich
{
    partial class FormOption
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
            btnBack = new Button();
            btnMusicOn = new Button();
            btnMusicOff = new Button();
            trackBar1 = new TrackBar();
            labelVolume = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(690, 15);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "Zurück";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnMusicOn
            // 
            btnMusicOn.Location = new Point(301, 103);
            btnMusicOn.Margin = new Padding(4);
            btnMusicOn.Name = "btnMusicOn";
            btnMusicOn.Size = new Size(157, 36);
            btnMusicOn.TabIndex = 1;
            btnMusicOn.Text = "An";
            btnMusicOn.UseVisualStyleBackColor = true;
            btnMusicOn.Click += btnMusicOn_Click;
            // 
            // btnMusicOff
            // 
            btnMusicOff.Location = new Point(301, 147);
            btnMusicOff.Margin = new Padding(4);
            btnMusicOff.Name = "btnMusicOff";
            btnMusicOff.Size = new Size(157, 36);
            btnMusicOff.TabIndex = 2;
            btnMusicOff.Text = "Aus";
            btnMusicOff.UseVisualStyleBackColor = true;
            btnMusicOff.Click += btnMusicOff_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(301, 223);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(156, 69);
            trackBar1.TabIndex = 3;
            // 
            // labelVolume
            // 
            labelVolume.Location = new Point(301, 187);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(156, 33);
            labelVolume.TabIndex = 4;
            labelVolume.Text = "50";
            labelVolume.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormOption
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelVolume);
            Controls.Add(trackBar1);
            Controls.Add(btnMusicOff);
            Controls.Add(btnMusicOn);
            Controls.Add(btnBack);
            Margin = new Padding(2);
            Name = "FormOption";
            Text = "Einstellungen";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnMusicOn;
        private Button btnMusicOff;
        private TrackBar trackBar1;
        private Label labelVolume;
    }
}