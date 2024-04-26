namespace UsingTimer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hours = 0 ,minutes=0,seconds=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label3.Text=seconds.ToString();
            if (seconds == 60) {
                minutes++;
                label2.Text=minutes.ToString();
                seconds = 0;

                if (minutes == 3) {
                hours++;
                    label1.Text=hours.ToString();
                    minutes = 0;
                    label2.Text = minutes.ToString();
                    
                    if(hours == 2) {
                        hours = 0;
                            }

                }
               
            }

        }
    }
}
