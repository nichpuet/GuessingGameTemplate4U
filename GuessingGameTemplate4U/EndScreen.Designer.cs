namespace GuessingGameTemplate4U
{
    partial class EndScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OriginalLabel = new System.Windows.Forms.Label();
            this.SortedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // OriginalLabel
            // 
            this.OriginalLabel.BackColor = System.Drawing.SystemColors.Control;
            this.OriginalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OriginalLabel.Location = new System.Drawing.Point(13, 96);
            this.OriginalLabel.Name = "OriginalLabel";
            this.OriginalLabel.Size = new System.Drawing.Size(101, 191);
            this.OriginalLabel.TabIndex = 1;
            this.OriginalLabel.Text = "Unsorted Guesses: ";
            // 
            // SortedLabel
            // 
            this.SortedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SortedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SortedLabel.Location = new System.Drawing.Point(183, 96);
            this.SortedLabel.Name = "SortedLabel";
            this.SortedLabel.Size = new System.Drawing.Size(101, 191);
            this.SortedLabel.TabIndex = 2;
            this.SortedLabel.Text = "Sorted Guesses: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Good Guess!";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guessLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.guessLabel.Location = new System.Drawing.Point(10, 49);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(162, 20);
            this.guessLabel.TabIndex = 4;
            this.guessLabel.Text = "Number Of Guesses: ";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortedLabel);
            this.Controls.Add(this.OriginalLabel);
            this.Controls.Add(this.label1);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OriginalLabel;
        private System.Windows.Forms.Label SortedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label guessLabel;
    }
}
