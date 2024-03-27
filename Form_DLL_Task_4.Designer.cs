namespace WindowsFormsApp_HW_6_Dynamically_Connected_Libraries
{
    partial class Form_DLL_Task_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DLL_Task_4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFiles = new System.Windows.Forms.Button();
            this.buttonDirectories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFiles
            // 
            this.buttonFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiles.Location = new System.Drawing.Point(48, 376);
            this.buttonFiles.Name = "buttonFiles";
            this.buttonFiles.Size = new System.Drawing.Size(167, 51);
            this.buttonFiles.TabIndex = 1;
            this.buttonFiles.Text = "Files";
            this.buttonFiles.UseVisualStyleBackColor = false;
            this.buttonFiles.Click += new System.EventHandler(this.buttonFiles_Click);
            // 
            // buttonDirectories
            // 
            this.buttonDirectories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDirectories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDirectories.Location = new System.Drawing.Point(350, 376);
            this.buttonDirectories.Name = "buttonDirectories";
            this.buttonDirectories.Size = new System.Drawing.Size(175, 51);
            this.buttonDirectories.TabIndex = 2;
            this.buttonDirectories.Text = "Directories";
            this.buttonDirectories.UseVisualStyleBackColor = false;
            this.buttonDirectories.Click += new System.EventHandler(this.buttonDirectories_Click);
            // 
            // Form_DLL_Task_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.buttonDirectories);
            this.Controls.Add(this.buttonFiles);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_DLL_Task_4";
            this.Text = "Form_DLL_Task_4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFiles;
        private System.Windows.Forms.Button buttonDirectories;
    }
}