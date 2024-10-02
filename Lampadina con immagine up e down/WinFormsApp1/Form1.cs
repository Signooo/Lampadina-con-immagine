namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int y = 125;
        private void button3_Click(object sender, EventArgs e)
        {
            y = y - 10;
            pictureBox2.Location = new Point(281, y);
            pictureBox1.Location = new Point(281, y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y = y + 10;
            pictureBox2.Location = new Point(281, y);
            pictureBox1.Location = new Point(281, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}
