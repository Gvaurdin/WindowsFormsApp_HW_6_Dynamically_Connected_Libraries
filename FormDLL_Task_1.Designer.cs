namespace WindowsFormsApp_HW_6_Dynamically_Connected_Libraries
{
    partial class FormDLL_Task_1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideTextBox = new System.Windows.Forms.TextBox();
            this.sideLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.squareResultLabel = new System.Windows.Forms.Label();
            this.rectangleResultLabel = new System.Windows.Forms.Label();
            this.triangleResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideTextBox
            // 
            this.sideTextBox.Location = new System.Drawing.Point(140, 28);
            this.sideTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sideTextBox.Name = "sideTextBox";
            this.sideTextBox.Size = new System.Drawing.Size(76, 20);
            this.sideTextBox.TabIndex = 0;
            // 
            // sideLabel
            // 
            this.sideLabel.AutoSize = true;
            this.sideLabel.Location = new System.Drawing.Point(20, 30);
            this.sideLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sideLabel.Name = "sideLabel";
            this.sideLabel.Size = new System.Drawing.Size(102, 13);
            this.sideLabel.TabIndex = 1;
            this.sideLabel.Text = "Сторона квадрата:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(5, 56);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(130, 13);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Длина прямоугольника:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(5, 82);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(136, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Ширина прямоугольника:";
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(5, 108);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(138, 13);
            this.baseLabel.TabIndex = 4;
            this.baseLabel.Text = "Основание треугольника:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(5, 134);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(120, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Высота треугольника:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(140, 54);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(76, 20);
            this.lengthTextBox.TabIndex = 6;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(140, 80);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(76, 20);
            this.widthTextBox.TabIndex = 7;
            // 
            // baseTextBox
            // 
            this.baseTextBox.Location = new System.Drawing.Point(140, 106);
            this.baseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(76, 20);
            this.baseTextBox.TabIndex = 8;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(140, 132);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(76, 20);
            this.heightTextBox.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(37, 166);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(158, 24);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Рассчитать площади";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // squareResultLabel
            // 
            this.squareResultLabel.AutoSize = true;
            this.squareResultLabel.Location = new System.Drawing.Point(34, 202);
            this.squareResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.squareResultLabel.Name = "squareResultLabel";
            this.squareResultLabel.Size = new System.Drawing.Size(0, 13);
            this.squareResultLabel.TabIndex = 11;
            // 
            // rectangleResultLabel
            // 
            this.rectangleResultLabel.AutoSize = true;
            this.rectangleResultLabel.Location = new System.Drawing.Point(34, 227);
            this.rectangleResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rectangleResultLabel.Name = "rectangleResultLabel";
            this.rectangleResultLabel.Size = new System.Drawing.Size(0, 13);
            this.rectangleResultLabel.TabIndex = 12;
            // 
            // triangleResultLabel
            // 
            this.triangleResultLabel.AutoSize = true;
            this.triangleResultLabel.Location = new System.Drawing.Point(34, 253);
            this.triangleResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.triangleResultLabel.Name = "triangleResultLabel";
            this.triangleResultLabel.Size = new System.Drawing.Size(0, 13);
            this.triangleResultLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 296);
            this.Controls.Add(this.triangleResultLabel);
            this.Controls.Add(this.rectangleResultLabel);
            this.Controls.Add(this.squareResultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.baseTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.sideLabel);
            this.Controls.Add(this.sideTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Geometry Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sideTextBox;
        private System.Windows.Forms.Label sideLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox baseTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label squareResultLabel;
        private System.Windows.Forms.Label rectangleResultLabel;
        private System.Windows.Forms.Label triangleResultLabel;
    }
}

