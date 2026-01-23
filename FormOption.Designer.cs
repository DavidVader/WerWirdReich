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
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(552, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(76, 32);
            btnBack.TabIndex = 0;
            btnBack.Text = "Zurück";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormOption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnBack);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormOption";
            Text = "Einstellungen";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
    }
}