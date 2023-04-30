using System.DirectoryServices.ActiveDirectory;

namespace Forms
{
    public partial class Form1 : Form
    {
        entryPoint enPoint = new();
        private string filePath;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { filePath = openFileDialog1.FileName; }
            textBox_path.Text = filePath;
            enPoint.path = filePath;
            textBox_amTree.Text = Convert.ToString(enPoint.getNumber());
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            try
            {
                enPoint.n = int.Parse(textBox_n.Text);
            }
            catch (Exception) { }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            List<int> emptyRow = new List<int>();
            if (textBox_n.Text != string.Empty && textBox_amTree.Text != "0")
            {
                enPoint.main();
                emptyRow = enPoint.getEmpty(enPoint.row);
                foreach (var item in emptyRow)
                {
                    comboBox_empty.Items.Add(item);
                }
                textBox_row.Text = enPoint.ansRow.ToString();
                textBox_Column.Text = enPoint.ansColumn.ToString();
            }
            else { textBox_row.Text = "Err"; }

        }
    }
}