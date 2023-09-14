namespace VP_FirstEX
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label3.Text = "Eight of Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label3.Text = "Two of Clubs";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label3.Text = "King of Clubs";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label3.Text = "Ace of Spades";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label3.Text = "Ace of Hearts";
        }
    }
}