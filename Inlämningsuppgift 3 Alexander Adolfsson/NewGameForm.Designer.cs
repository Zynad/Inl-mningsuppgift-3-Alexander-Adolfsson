namespace Inlämningsuppgift_3_Alexander_Adolfsson
{
    partial class New_Game
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
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(26, 140);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(155, 58);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "Logga in";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Location = new System.Drawing.Point(234, 140);
            this.ExitGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(155, 58);
            this.ExitGameButton.TabIndex = 1;
            this.ExitGameButton.Text = "Avsluta";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(129, 81);
            this.NameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(180, 23);
            this.NameText.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(164, 64);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 15);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Skriv in ditt namn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Välkommen till Zynads adventure";
            // 
            // New_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.NewGameButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "New_Game";
            this.Text = "New_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NewGameButton;
        private Button ExitGameButton;
        private TextBox NameText;
        private Label NameLabel;
        private Label label1;
    }
}