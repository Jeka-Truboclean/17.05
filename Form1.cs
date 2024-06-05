namespace _17._05
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            this.random = new Random();
            this.MouseClick += new MouseEventHandler(this.Form1_MouseClick);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int diameter = random.Next(10, 100);
            int radius = diameter / 2;

            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            Brush brush = new SolidBrush(color);

            Graphics graphics = this.CreateGraphics();
            graphics.FillEllipse(brush, e.X - radius, e.Y - radius, diameter, diameter);

            brush.Dispose();
            graphics.Dispose();
        }
    }
}
