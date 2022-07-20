namespace Activity_5
{
    partial class Activity5
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.outputDataLabel = new System.Windows.Forms.Label();
            this.outputDataTextbox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Title = "Open Text File With Words";
            // 
            // outputDataLabel
            // 
            this.outputDataLabel.AutoSize = true;
            this.outputDataLabel.Location = new System.Drawing.Point(12, 10);
            this.outputDataLabel.Name = "outputDataLabel";
            this.outputDataLabel.Size = new System.Drawing.Size(75, 15);
            this.outputDataLabel.TabIndex = 1;
            this.outputDataLabel.Text = "Output Data:";
            // 
            // outputDataTextbox
            // 
            this.outputDataTextbox.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputDataTextbox.Location = new System.Drawing.Point(12, 28);
            this.outputDataTextbox.Multiline = true;
            this.outputDataTextbox.Name = "outputDataTextbox";
            this.outputDataTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputDataTextbox.Size = new System.Drawing.Size(440, 392);
            this.outputDataTextbox.TabIndex = 2;
            this.outputDataTextbox.WordWrap = false;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(141, 426);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(183, 23);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.Text = "Open Text File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // Activity5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 461);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.outputDataTextbox);
            this.Controls.Add(this.outputDataLabel);
            this.MaximumSize = new System.Drawing.Size(480, 500);
            this.MinimumSize = new System.Drawing.Size(480, 500);
            this.Name = "Activity5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Manipulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFile;
        private Label outputDataLabel;
        private TextBox outputDataTextbox;
        private Button openFileButton;
    }
}