namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Text = "Open File";
            label1.Visible = false;
            label2.Visible = true;
            textBox1.Visible = true;
            button4.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
        }
        public void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
            string FileName = $"C:\\Program Files\\KNotepad GUI\\files\\{textBox1.Text}.txt";
            using (StreamReader InputFile = new(File.Open(FileName, FileMode.Open)))
            {
                textBox2.Text = InputFile.ReadToEnd();
            }
            textBox2.Visible = true;
            button5.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText($"C:\\Program Files\\KNotepad GUI\\files\\{textBox1.Text}.txt", textBox2.Text);
            textBox2.Visible = false;
            button5.Visible = false;
            label3.Visible = true;
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            textBox1.Visible = true;
            button6.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label2.Visible = false;
            button6.Visible = false;
            string FileName = $"C:\\Program Files\\KNotepad GUI\\files\\{textBox1.Text}.txt";
            using (StreamReader InputFile = new(File.Open(FileName, FileMode.Create)))
            {
                textBox2.Text = InputFile.ReadToEnd();
            }
            textBox2.Visible = true;
            button5.Visible = true;
        }
        bool CreditsOpen = false;
        private void button3_Click(object sender, EventArgs e)
        {
            CreditsOpen = !CreditsOpen;
            if (CreditsOpen == true)
            {
                button1.Visible = false;
                button2.Visible = false;
                label4.Visible = true;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
                label4.Visible = false;
            }
        }
    }
}