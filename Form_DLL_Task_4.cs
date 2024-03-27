using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSystemUtility;
using WindowsFormsApp_HW_6_Dynamically_Connected_Libraries.Properties;

namespace WindowsFormsApp_HW_6_Dynamically_Connected_Libraries
{
    public partial class Form_DLL_Task_4 : Form
    {
        public Form_DLL_Task_4()
        {
            InitializeComponent();
        }

        private void buttonFiles_Click(object sender, EventArgs e)
        {
            FormFiles formFiles = new FormFiles();
            formFiles.ShowDialog();
        }

        private void buttonDirectories_Click(object sender, EventArgs e)
        {
            FormDirectoryCopy formDirectoryCopy = new FormDirectoryCopy();
            formDirectoryCopy.ShowDialog();
        }
    }

    public partial class FormFiles : Form
    {
        public FormFiles()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(600, 400);

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DLL_Task_4));
            PictureBox picture = new PictureBox();
            picture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            picture.Location = new System.Drawing.Point(5, 5);
            picture.Size = new System.Drawing.Size(590, 250);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture);

            Button buttonCopyTransferFile = new Button();
            buttonCopyTransferFile.Text = "Copy or transfer file";
            buttonCopyTransferFile.BackColor = System.Drawing.Color.LightCyan;
            buttonCopyTransferFile.Location = new System.Drawing.Point(100, 300);
            buttonCopyTransferFile.Size = new System.Drawing.Size(80, 40);
            this.Controls.Add(buttonCopyTransferFile);


            Button buttonDeleteFile = new Button();
            buttonDeleteFile.Text = "Delete file";
            buttonDeleteFile.BackColor = System.Drawing.Color.LightCyan;
            buttonDeleteFile.Location = new System.Drawing.Point(200, 300);
            buttonDeleteFile.Size = new System.Drawing.Size(80, 40);
            this.Controls.Add(buttonDeleteFile);


            Button buttonFindWordInFile_or_Folder = new Button();
            buttonFindWordInFile_or_Folder.Text = "Search word in file or folder";
            buttonFindWordInFile_or_Folder.BackColor = System.Drawing.Color.LightCyan;
            buttonFindWordInFile_or_Folder.Location = new System.Drawing.Point(300, 300);
            buttonFindWordInFile_or_Folder.Size = new System.Drawing.Size(100, 40);
            this.Controls.Add(buttonFindWordInFile_or_Folder);



            buttonCopyTransferFile.Click += ButtonCopyTransferFile_Click;
            buttonDeleteFile.Click += ButtonDeleteFile_Click;
            buttonFindWordInFile_or_Folder.Click += ButtonFindWordInFile_or_Folder_Click;
        }

        private void ButtonFindWordInFile_or_Folder_Click(object sender, EventArgs e)
        {
            FormSearchWord formSearchWord = new FormSearchWord();
            this.Hide();
            formSearchWord.ShowDialog();
        }

        private void ButtonCopyTransferFile_Click(object sender, EventArgs e)
        {
            FormCopyTransfer formCopyTransfer = new FormCopyTransfer();
            this.Hide();
            formCopyTransfer.ShowDialog();
        }

        private void ButtonDeleteFile_Click(object sender, EventArgs e)
        {
            FormDelete formDelete = new FormDelete();
            this.Hide();
            formDelete.ShowDialog();
        }

    }

    public partial class FormCopyTransfer : Form
    {
        private Label labelSourceDirectory;
        private Label labelTargetDirectory;
        public FormCopyTransfer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(600, 400);

            Button buttonSource = new Button();
            buttonSource.Text = "Source file";
            buttonSource.BackColor = System.Drawing.Color.LightCyan;
            buttonSource.Location = new System.Drawing.Point(10, 100);
            buttonSource.Size = new System.Drawing.Size(80, 40);
            this.Controls.Add(buttonSource);

            labelSourceDirectory = new Label();
            labelSourceDirectory.Location = new Point(100, 100);
            labelSourceDirectory.Size = new Size(300, 40);
            this.Controls.Add(labelSourceDirectory);


            Button buttonTarget = new Button();
            buttonTarget.Text = "Target directory";
            buttonTarget.BackColor = System.Drawing.Color.LightCyan;
            buttonTarget.Location = new System.Drawing.Point(10, 200);
            buttonTarget.Size = new System.Drawing.Size(80, 40);
            this.Controls.Add(buttonTarget);

            labelTargetDirectory = new Label();
            labelTargetDirectory.Location = new Point(100, 200);
            labelTargetDirectory.Size = new Size(300, 40);
            this.Controls.Add(labelTargetDirectory);

            Button buttonCopy = new Button();
            buttonCopy.Text = "Copy";
            buttonCopy.BackColor = System.Drawing.Color.LightCyan;
            buttonCopy.Location = new Point(200, 300);
            buttonCopy.Size = new Size(80, 40);
            this.Controls.Add(buttonCopy);

            Button buttonTransfer = new Button();
            buttonTransfer.Text = "Transfer";
            buttonTransfer.BackColor = System.Drawing.Color.LightCyan;
            buttonTransfer.Location = new Point(300, 300);
            buttonTransfer.Size = new Size(80, 40);
            this.Controls.Add(buttonTransfer);

            buttonCopy.Click += ButtonCopy_Click;
            buttonTransfer.Click += ButtonTransfer_Click;
            buttonSource.Click += ButtonSource_Click;
            buttonTarget.Click += ButtonTarget_Click;

        }

        private void ButtonTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // настраиваем свойства диалогового окна
            folderBrowserDialog.Description = "Select Directory"; // описание окна
            folderBrowserDialog.ShowNewFolderButton = false; // отключаем кнопку создания новой папки

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                string selectedDirectoryPath = folderBrowserDialog.SelectedPath;


                labelTargetDirectory.Text = selectedDirectoryPath;
            }
        }

        private void ButtonSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // настраиваем свойства диалогового окна
            openFileDialog.Title = "Select File"; // заголовок окна
            openFileDialog.Filter = "All Files (*.*)|*.*"; // фильтр файлов (в данном случае все файлы)
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Начальная директория для открытия

            // показываем диалоговое окно
            DialogResult result = openFileDialog.ShowDialog();

            // проверяем результат диалогового окна
            if (result == DialogResult.OK)
            {
                // получаем путь к выбранному файлу
                string selectedFilePath = openFileDialog.FileName;

                labelSourceDirectory.Text = selectedFilePath;

            }
        }

        private void ButtonTransfer_Click(object sender, EventArgs e)
        {
            // проверяем, что оба пути не пустые
            if (!string.IsNullOrEmpty(labelSourceDirectory.Text) && !string.IsNullOrEmpty(labelTargetDirectory.Text))
            {
                // создаем полный путь к целевому файлу вместе с именем файла
                string targetFilePath = Path.Combine(labelTargetDirectory.Text, Path.GetFileName(labelSourceDirectory.Text));

                try
                {
                    // вызываем метод MoveFile для перемещения файла
                    FileManager.MoveFile(labelSourceDirectory.Text, targetFilePath);
                    MessageBox.Show("Sucefful move");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both source and target directories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelSourceDirectory.Text) && !string.IsNullOrEmpty(labelTargetDirectory.Text))
            {
                string targetFilePath = Path.Combine(labelTargetDirectory.Text, Path.GetFileName(labelSourceDirectory.Text));

                try
                {
                    // вызываем метод MoveFile для перемещения файла
                    FileManager.CopyFile(labelSourceDirectory.Text, targetFilePath);
                    MessageBox.Show("Sucefful copy");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both source and target directories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public partial class FormDelete : Form
    {
        private TextBox textBoxFileName;
        private Label labelTargetDirectory;
        public FormDelete()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(600, 400);

            textBoxFileName = new TextBox();
            textBoxFileName.Location = new Point(180,100);
            textBoxFileName.Size = new Size(300, 40);
            this.Controls.Add(textBoxFileName);

            Label labelInfo = new Label();
            labelInfo.Location = new Point(10,100);
            labelInfo.Size = new Size(150, 40);
            labelInfo.Text = "Name or names or mask of file(s)  : ";
            this.Controls.Add(labelInfo);

            Button buttonDelete = new Button();
            buttonDelete.Text = "Delete";
            buttonDelete.BackColor = System.Drawing.Color.LightCyan;
            buttonDelete.Location = new System.Drawing.Point(250, 300);
            buttonDelete.Size = new System.Drawing.Size(80, 40);
            this.Controls.Add(buttonDelete);

            Button buttonTarget = new Button();
            buttonTarget.Text = "Target directory";
            buttonTarget.BackColor = System.Drawing.Color.LightCyan;
            buttonTarget.Location = new System.Drawing.Point(10, 200);
            buttonTarget.Size = new System.Drawing.Size(80, 40);
            this.Controls.Add(buttonTarget);

            labelTargetDirectory = new Label();
            labelTargetDirectory.Location = new Point(100, 200);
            labelTargetDirectory.Size = new Size(300, 40);
            this.Controls.Add(labelTargetDirectory);

            buttonDelete.Click += ButtonDelete_Click;
            buttonTarget.Click += ButtonTarget_Click;

        }

        private void ButtonTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // настраиваем свойства диалогового окна
            folderBrowserDialog.Description = "Select Directory"; // описание окна
            folderBrowserDialog.ShowNewFolderButton = false; // отключаем кнопку создания новой папки

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                string selectedDirectoryPath = folderBrowserDialog.SelectedPath;


                labelTargetDirectory.Text = selectedDirectoryPath;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // получаем введенное пользователем значение из текстовых полей
            string directoryPath = labelTargetDirectory.Text.Trim();
            string input = textBoxFileName.Text.Trim();

            // проверяем, введено ли что-то в оба текстовых поля
            if (string.IsNullOrEmpty(directoryPath) || string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter both directory and file(s)/mask.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // проверяем, существует ли указанная директория
            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("Directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // проверяем, является ли введенное значение маской файлов
            if (input.Contains("*") || input.Contains("?"))
            {
                // введена маска файлов, вызываем метод удаления файлов по маске
                try
                {
                    FileManager.DeleteFilesByMask(directoryPath, input);
                    MessageBox.Show("Files deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // введено имя файла или имена файлов, вызываем метод удаления файла(-ов)
                try
                {
                    string[] filesToDelete = input.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    FileManager.DeleteFiles(directoryPath, filesToDelete);
                    MessageBox.Show("File(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public partial class FormDirectoryCopy : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private Label labelSource;
        private TextBox textBoxSource;
        private Button buttonSource;
        private Label labelTarget;
        private TextBox textBoxTarget;
        private Button buttonTarget;
        private Button buttonCopy;
        public FormDirectoryCopy()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(600, 400);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelSource = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.buttonSource = new System.Windows.Forms.Button();
            this.labelTarget = new System.Windows.Forms.Label();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.buttonTarget = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();

            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.buttonSource);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.buttonTarget);
            this.Controls.Add(this.buttonCopy);

            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(12, 21);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source";

            this.textBoxSource.Location = new System.Drawing.Point(65, 18);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ReadOnly = true;
            this.textBoxSource.Size = new System.Drawing.Size(250, 20);
            this.textBoxSource.TabIndex = 1;

            this.buttonSource.Location = new System.Drawing.Point(321, 16);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(75, 23);
            this.buttonSource.TabIndex = 2;
            this.buttonSource.Text = "Browse";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);

            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(12, 57);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(38, 13);
            this.labelTarget.TabIndex = 3;
            this.labelTarget.Text = "Target";

            this.textBoxTarget.Location = new System.Drawing.Point(65, 54);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.Size = new System.Drawing.Size(250, 20);
            this.textBoxTarget.TabIndex = 4;

            this.buttonTarget.Location = new System.Drawing.Point(321, 52);
            this.buttonTarget.Name = "buttonTarget";
            this.buttonTarget.Size = new System.Drawing.Size(75, 23);
            this.buttonTarget.TabIndex = 5;
            this.buttonTarget.Text = "Browse";
            this.buttonTarget.UseVisualStyleBackColor = true;
            this.buttonTarget.Click += new System.EventHandler(this.buttonTarget_Click);

            this.buttonCopy.Location = new System.Drawing.Point(15, 90);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy Directory";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSource.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxTarget.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string sourceDir = textBoxSource.Text;
            string destinationDir = textBoxTarget.Text;

            try
            {
                FileManager.CopyDirectory(sourceDir, destinationDir);

                MessageBox.Show("Directory copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    public partial class FormSearchWord : Form
    {
        private Label labelFolderPath;
        private Label labelFilePath;
        private Label labelReportFilePath;
        private TextBox textBoxSearchWord;
        private Button buttonFilePath;
        private Button buttonFolderPath;
        private Button buttonReportFilepath;
        private Button buttonSearchWordInFile;
        private Button buttonSearchWordInFolder;

        public FormSearchWord()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(600, 600);

            labelFilePath = new Label()
            {
                Location = new Point(100, 100),
                Size = new Size(200,40),
            };
            this.Controls.Add(labelFilePath);

            labelFolderPath = new Label()
            {
                Location = new Point(100, 200),
                Size = new Size(200, 40),
            };
            this.Controls.Add(labelFolderPath);

            labelReportFilePath = new Label()
            {
                Location = new Point(120, 300),
                Size = new Size(200, 40),
            };
            this.Controls.Add(labelReportFilePath);

            buttonFilePath = new Button()
            {
                Text = "File path",
                Location = new Point(10, 100),
                Size = new Size(80, 40),
                BackColor = System.Drawing.Color.LightCyan
            };
            this.Controls.Add(buttonFilePath);

            buttonFolderPath = new Button()
            {
                Text = "Folder path",
                Location = new Point(10, 200),
                Size = new Size(80, 40),
                BackColor = System.Drawing.Color.LightCyan
            };
            this.Controls.Add(buttonFolderPath);

            buttonReportFilepath = new Button()
            {
                Text = "File report path",
                Location = new Point(10, 300),
                Size = new Size(100, 40),
                BackColor = System.Drawing.Color.LightCyan
            };
            this.Controls.Add(buttonReportFilepath);

            textBoxSearchWord = new TextBox()
            {
                Text = "Word for search",
                Location = new Point(250,400),
                Size = new Size(200,40)
            };
            this.Controls.Add(textBoxSearchWord);

            buttonSearchWordInFile = new Button()
            {
                Text = "Search word in file",
                Location = new Point(150, 500),
                Size = new Size(80, 40),
                BackColor = System.Drawing.Color.LightCyan
            };
            this.Controls.Add(buttonSearchWordInFile);

            buttonSearchWordInFolder = new Button()
            {
                Text = "Search word in folder",
                Location = new Point(300, 500),
                Size = new Size(80, 40),
                BackColor = System.Drawing.Color.LightCyan
            };
            this.Controls.Add(buttonSearchWordInFolder);

            buttonFilePath.Click += ButtonFilePath_Click;
            buttonFolderPath.Click += ButtonFolderPath_Click;
            buttonReportFilepath.Click += ButtonReportFilepath_Click;
            buttonSearchWordInFile.Click += ButtonSearchWordInFile_Click;
            buttonSearchWordInFolder.Click += ButtonSearchWordInFolder_Click;
        }

        private void ButtonSearchWordInFolder_Click(object sender, EventArgs e)
        {
            string folderPath = labelFolderPath.Text;
            string searchWord = textBoxSearchWord.Text;
            string fileReportDirectory = labelReportFilePath.Text;

            if(!Directory.Exists(folderPath))
            {
                MessageBox.Show("The specified directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Directory.Exists(fileReportDirectory))
            {
                MessageBox.Show("The specified directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileManager.SearchWordInFolder(folderPath, searchWord, fileReportDirectory);
                MessageBox.Show("Report in created", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ButtonSearchWordInFile_Click(object sender, EventArgs e)
        {
            string filePath = labelFilePath.Text;
            string searchWord = textBoxSearchWord.Text;
            string fileReportDirectory = labelReportFilePath.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The specified file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!Directory.Exists(fileReportDirectory))
            {
                MessageBox.Show("The specified directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileManager.SearchWordInFile(filePath, searchWord, fileReportDirectory);
                MessageBox.Show("Report in created", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonReportFilepath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "Select Directory";
            folderBrowserDialog.ShowNewFolderButton = false;

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                string selectedDirectoryPath = folderBrowserDialog.SelectedPath;


                labelReportFilePath.Text = selectedDirectoryPath;
            }
        }

        private void ButtonFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "Select Directory";
            folderBrowserDialog.ShowNewFolderButton = false;

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                string selectedDirectoryPath = folderBrowserDialog.SelectedPath;


                labelFolderPath.Text = selectedDirectoryPath;
            }
        }

        private void ButtonFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "TXT Files (*.txt)|*.txt";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                labelFilePath.Text = selectedFilePath;

            }
        }

    }
}
