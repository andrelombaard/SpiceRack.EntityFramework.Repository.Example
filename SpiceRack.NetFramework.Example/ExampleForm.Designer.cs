namespace SpiceRack.NetFramework.Example
{
    partial class ExampleForm
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
            this.DoItButton = new System.Windows.Forms.Button();
            this.FeedbackArea = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DoItButton
            // 
            this.DoItButton.Location = new System.Drawing.Point(13, 13);
            this.DoItButton.Name = "DoItButton";
            this.DoItButton.Size = new System.Drawing.Size(206, 41);
            this.DoItButton.TabIndex = 0;
            this.DoItButton.Text = "Do It";
            this.DoItButton.UseVisualStyleBackColor = true;
            this.DoItButton.Click += new System.EventHandler(this.DoItButton_Click);
            // 
            // FeedbackArea
            // 
            this.FeedbackArea.Location = new System.Drawing.Point(12, 77);
            this.FeedbackArea.Name = "FeedbackArea";
            this.FeedbackArea.Size = new System.Drawing.Size(686, 398);
            this.FeedbackArea.TabIndex = 1;
            this.FeedbackArea.Text = "";
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 505);
            this.Controls.Add(this.FeedbackArea);
            this.Controls.Add(this.DoItButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpiceRack.NetFramework.Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoItButton;
        private System.Windows.Forms.RichTextBox FeedbackArea;
    }
}

