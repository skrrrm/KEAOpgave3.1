using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variables
        double n;
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToDouble(textBoxNumber.Text); // Converts text to number
            }
            catch 
            {
                labelInfo.Text = "Only numbers allowed"; // if convertion fails, error
            }

            if (n > 0) // if n is bigger than zero
                labelRes.Text = "Number is positive!"; 
            else if (n < 0) // if n is smaller than zero
                labelRes.Text = "Number is negative!";
        }
    }
}
