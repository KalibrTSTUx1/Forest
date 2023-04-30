namespace Forms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Column = new System.Windows.Forms.TextBox();
            this.textBox_row = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_choicePath = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_amTree = new System.Windows.Forms.TextBox();
            this.comboBox_empty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Сажаем деревья\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(206, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Row:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(188, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Column:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Путь к файлу:";
            // 
            // textBox_Column
            // 
            this.textBox_Column.Location = new System.Drawing.Point(253, 135);
            this.textBox_Column.Name = "textBox_Column";
            this.textBox_Column.ReadOnly = true;
            this.textBox_Column.Size = new System.Drawing.Size(40, 23);
            this.textBox_Column.TabIndex = 5;
            this.textBox_Column.Tag = "path";
            // 
            // textBox_row
            // 
            this.textBox_row.Location = new System.Drawing.Point(253, 106);
            this.textBox_row.Name = "textBox_row";
            this.textBox_row.ReadOnly = true;
            this.textBox_row.Size = new System.Drawing.Size(40, 23);
            this.textBox_row.TabIndex = 6;
            this.textBox_row.Tag = "path";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(148, 106);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(23, 23);
            this.textBox_n.TabIndex = 7;
            this.textBox_n.Tag = "n";
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(148, 77);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(344, 23);
            this.textBox_path.TabIndex = 8;
            this.textBox_path.Tag = "path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Tag = "openPath";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button_choicePath
            // 
            this.button_choicePath.Location = new System.Drawing.Point(498, 77);
            this.button_choicePath.Name = "button_choicePath";
            this.button_choicePath.Size = new System.Drawing.Size(109, 23);
            this.button_choicePath.TabIndex = 9;
            this.button_choicePath.Tag = "buttonPath";
            this.button_choicePath.Text = "Выбрать файл";
            this.button_choicePath.UseVisualStyleBackColor = true;
            this.button_choicePath.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(148, 164);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(145, 49);
            this.button_start.TabIndex = 10;
            this.button_start.Text = "Запустить";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Кол-во деревьев:";
            // 
            // textBox_amTree
            // 
            this.textBox_amTree.Location = new System.Drawing.Point(148, 135);
            this.textBox_amTree.Name = "textBox_amTree";
            this.textBox_amTree.ReadOnly = true;
            this.textBox_amTree.Size = new System.Drawing.Size(23, 23);
            this.textBox_amTree.TabIndex = 12;
            // 
            // comboBox_empty
            // 
            this.comboBox_empty.FormattingEnabled = true;
            this.comboBox_empty.Location = new System.Drawing.Point(371, 106);
            this.comboBox_empty.Name = "comboBox_empty";
            this.comboBox_empty.Size = new System.Drawing.Size(121, 23);
            this.comboBox_empty.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 225);
            this.Controls.Add(this.comboBox_empty);
            this.Controls.Add(this.textBox_amTree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_choicePath);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_row);
            this.Controls.Add(this.textBox_Column);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_Column;
        private TextBox textBox_row;
        private TextBox textBox_n;
        private TextBox textBox_path;
        private OpenFileDialog openFileDialog1;
        private Button button_choicePath;
        private Button button_start;
        private Label label6;
        private TextBox textBox_amTree;
        private ComboBox comboBox_empty;
    }
}