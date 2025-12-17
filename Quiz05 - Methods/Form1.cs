using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quiz05___Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void q1Button_Click(object sender, EventArgs e)
        {


            Random randgen = new Random();
            int number = randgen.Next(1, 10);
            outputLabel.Text = number.ToString();






            




        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            //int sum = (1 - 100); string outputLabel.Text ;
        }
    }
}
