namespace ArrayswithLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] cities = { "Ankara", "Eskisehir", "Bursa", "Balýkesir", "Adana", "Antalya" };
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    listBox1.Items.Add(cities[i]);
            //}

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    listBox1.Items.Add(numbers[i]);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 20, 30, 40 };
            for (int i = 0;i < num.Length;i++)
            {
                if ((num[i] %2) == 0 || num[i]>=10) {
                    listBox2.Items.Add(num[i]); 
               }
            }
        }
    }
}
