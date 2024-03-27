namespace WindowsFormsApp_HW_6_Dynamically_Connected_Libraries
{
    partial class Form_DLL_Task_3
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
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.validateButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameHintLabel = new System.Windows.Forms.Label();
            this.ageHintLabel = new System.Windows.Forms.Label();
            this.phoneHintLabel = new System.Windows.Forms.Label();
            this.emailHintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(9, 10);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(9, 41);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(196, 20);
            this.ageTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(9, 72);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(196, 20);
            this.phoneTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(9, 102);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(196, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(9, 133);
            this.validateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(195, 24);
            this.validateButton.TabIndex = 4;
            this.validateButton.Text = "Validate";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click_1);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(9, 170);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fullNameLabel.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(9, 192);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 13);
            this.ageLabel.TabIndex = 6;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(9, 214);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(0, 13);
            this.phoneLabel.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(9, 236);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 13);
            this.emailLabel.TabIndex = 8;
            // 
            // fullNameHintLabel
            // 
            this.fullNameHintLabel.AutoSize = true;
            this.fullNameHintLabel.Location = new System.Drawing.Point(208, 12);
            this.fullNameHintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameHintLabel.Name = "fullNameHintLabel";
            this.fullNameHintLabel.Size = new System.Drawing.Size(54, 13);
            this.fullNameHintLabel.TabIndex = 9;
            this.fullNameHintLabel.Text = "Full Name";
            // 
            // ageHintLabel
            // 
            this.ageHintLabel.AutoSize = true;
            this.ageHintLabel.Location = new System.Drawing.Point(208, 43);
            this.ageHintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageHintLabel.Name = "ageHintLabel";
            this.ageHintLabel.Size = new System.Drawing.Size(26, 13);
            this.ageHintLabel.TabIndex = 10;
            this.ageHintLabel.Text = "Age";
            // 
            // phoneHintLabel
            // 
            this.phoneHintLabel.AutoSize = true;
            this.phoneHintLabel.Location = new System.Drawing.Point(208, 74);
            this.phoneHintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneHintLabel.Name = "phoneHintLabel";
            this.phoneHintLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneHintLabel.TabIndex = 11;
            this.phoneHintLabel.Text = "Phone";
            // 
            // emailHintLabel
            // 
            this.emailHintLabel.AutoSize = true;
            this.emailHintLabel.Location = new System.Drawing.Point(208, 105);
            this.emailHintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailHintLabel.Name = "emailHintLabel";
            this.emailHintLabel.Size = new System.Drawing.Size(32, 13);
            this.emailHintLabel.TabIndex = 12;
            this.emailHintLabel.Text = "Email";
            // 
            // Form_DLL_Task_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 271);
            this.Controls.Add(this.emailHintLabel);
            this.Controls.Add(this.phoneHintLabel);
            this.Controls.Add(this.ageHintLabel);
            this.Controls.Add(this.fullNameHintLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_DLL_Task_3";
            this.Text = "Contact Data Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fullNameHintLabel;
        private System.Windows.Forms.Label ageHintLabel;
        private System.Windows.Forms.Label phoneHintLabel;
        private System.Windows.Forms.Label emailHintLabel;
    }
}