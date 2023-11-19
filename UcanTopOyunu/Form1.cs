namespace UcanTopOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5, yerY = 5, can = 3;

        private void CarpmaOlayi()
        {
            //label2 carpma
            if (ball.Top <= label2.Bottom)
                yerY = yerY * -1;
            //kontrolere carpma olayi 
            if (ball.Bottom >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)
                yerY = yerY * -1;

            //sag kenara carpma olayi
            else if (ball.Right >= label4.Left)
                yerX = yerX * -1;

            //sol kenara carpa olayi
            else if (ball.Left <= label1.Right)
                yerX = yerX * -1;
        }

        private void YanmaOlayi(object sender, EventArgs e)
        {
            if (ball.Top >= label4.Bottom)
            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandiniz kalan can = " + can.ToString());
                    Form1_Load(sender, e);
                }
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun bitdi", "", MessageBoxButtons.OK);

                }
            }
            label3.Text = can.ToString();
        }
        private void TopBasa()
        {
            ball.Location = new Point(162, 122);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopBasa();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarpmaOlayi();
            YanmaOlayi(sender, e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }
    }
}