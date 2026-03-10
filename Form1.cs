using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        bool isPhoto1 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = MyBusinessCard.Properties.Resources.photo1;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 40, 40, 180, 90);
            path.AddArc(panel1.Width - 40, 0, 40, 40, 270, 90);
            path.AddArc(panel1.Width - 40, panel1.Height - 40, 40, 40, 0, 90);
            path.AddArc(0, panel1.Height - 40, 40, 40, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new Region(path);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddArc(0, 0, 40, 40, 180, 90);
            path2.AddArc(pictureBox1.Width - 40, 0, 40, 40, 270, 90);
            path2.AddArc(pictureBox1.Width - 40, pictureBox1.Height - 40, 40, 40, 0, 90);
            path2.AddArc(0, pictureBox1.Height - 40, 40, 40, 90, 90);
            path2.CloseAllFigures();

            pictureBox1.Region = new Region(path2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(200));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isPhoto1)
                pictureBox1.Image = MyBusinessCard.Properties.Resources.photo2;
            else
                pictureBox1.Image = MyBusinessCard.Properties.Resources.photo1;

            isPhoto1 = !isPhoto1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/jaeyong1346",
                UseShellExecute = true
            });
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
