using System.Media;
namespace Timer_1._0
{
    public partial class Form1 : Form
    {
        int m, s;
        SoundPlayer player;
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s == 0)
            {
                if (m > 0)
                {
                    m--;
                    s = 59;
                    label2.Text = m.ToString();
                    label3.Text = s.ToString();
                }
            }
            else
            {
                s--;
                label3.Text = s.ToString();
            }
            if ((s == 0) && (m == 0))
            {
                timer1.Stop();
                SoundPlayer player=new SoundPlayer("chime_up.wav");
                player.Play();
                MessageBox.Show("time is up!!!!!", "time up", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox2.Visible = true;
            textBox3.Visible = true;
            label3.Visible = false;
            label2.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                label2.Text = "00";
            }
            else
                m = Convert.ToInt32(textBox2.Text);
            if (textBox3.Text.Length == 0)
            {

                label3.Text = "00";
            }
            else
                s = Convert.ToInt32(textBox3.Text);
            textBox2.Visible = false;
            textBox3.Visible = false;
            label3.Visible = true;
            label2.Visible = true;
            label2.Text = m.ToString();
            label3.Text = s.ToString();
            timer1.Start();
        }
    }
}