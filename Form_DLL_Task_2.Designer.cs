namespace WindowsFormsApp_HW_6_Dynamically_Connected_Libraries
{
    partial class Form_DLL_Task_2
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.palindromeLabel = new System.Windows.Forms.Label();
            this.sentencesLabel = new System.Windows.Forms.Label();
            this.reversedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(9, 10);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(226, 82);
            this.inputTextBox.TabIndex = 0;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(9, 96);
            this.processButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(225, 24);
            this.processButton.TabIndex = 1;
            this.processButton.Text = "Process Text";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // palindromeLabel
            // 
            this.palindromeLabel.AutoSize = true;
            this.palindromeLabel.Location = new System.Drawing.Point(9, 131);
            this.palindromeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.palindromeLabel.Name = "palindromeLabel";
            this.palindromeLabel.Size = new System.Drawing.Size(0, 13);
            this.palindromeLabel.TabIndex = 2;
            // 
            // sentencesLabel
            // 
            this.sentencesLabel.AutoSize = true;
            this.sentencesLabel.Location = new System.Drawing.Point(9, 153);
            this.sentencesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sentencesLabel.Name = "sentencesLabel";
            this.sentencesLabel.Size = new System.Drawing.Size(0, 13);
            this.sentencesLabel.TabIndex = 3;
            // 
            // reversedLabel
            // 
            this.reversedLabel.AutoSize = true;
            this.reversedLabel.Location = new System.Drawing.Point(9, 175);
            this.reversedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reversedLabel.Name = "reversedLabel";
            this.reversedLabel.Size = new System.Drawing.Size(0, 13);
            this.reversedLabel.TabIndex = 4;
            // 
            // Form_DLL_Task_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 202);
            this.Controls.Add(this.reversedLabel);
            this.Controls.Add(this.sentencesLabel);
            this.Controls.Add(this.palindromeLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_DLL_Task_2";
            this.Text = "Text Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label palindromeLabel;
        private System.Windows.Forms.Label sentencesLabel;
        private System.Windows.Forms.Label reversedLabel;
    }
}