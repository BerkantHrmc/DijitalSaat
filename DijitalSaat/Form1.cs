namespace DijitalSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniyesayac = 0;
        int dakikasayac = 0;
        int saatsayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniyesayac++;
            if (saniyesayac <= 59)
            {
                if (saniyesayac <= 9)
                {
                    label1.Text = ":0" + saniyesayac.ToString();

                }
                else
                {
                    label1.Text = ":" + saniyesayac.ToString();

                }
            }

            else
            {
                saniyesayac = 0;
                label1.Text = ":0" + saniyesayac.ToString();
                dakikasayac++;
                if (dakikasayac <= 59)
                {
                    if (dakikasayac <= 9)
                    {
                        label2.Text = ":0" + dakikasayac.ToString();

                    }
                    else
                    {
                        label2.Text = ":" + dakikasayac.ToString();

                    }
                }

                else
                {
                    dakikasayac = 0;
                    label2.Text = ":0" + dakikasayac.ToString();
                    saatsayac++;
                    if (saatsayac <= 24)
                    {
                        if (saatsayac <= 9)
                        {
                            label3.Text = "0" + saatsayac.ToString();

                        }
                        else
                        {
                            label3.Text = saatsayac.ToString();

                        }
                    }

                    else
                    {
                        saatsayac = 0;
                        label3.Text = "0" + saatsayac.ToString();

                    }
                }
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saniyesayac = 0;
            label1.Text = ":00";
            label2.Text = ":00";
            label3.Text = "00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Add("Þu kadar zamanda "+ comboBox1.Text +" : " 
                + saatsayac +  " S " + dakikasayac + " D "+ saniyesayac + " SN ");
        }

    }
}
