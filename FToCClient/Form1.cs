using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FToCClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (CheckDouble(degreeTextBox.Text))
            {
                double degree = Convert.ToDouble(degreeTextBox.Text.Replace('.', ','));
                ServiceReference1.ServiceClient serviceClient = new ServiceReference1.ServiceClient();
                switch ((sender as Control).Name)
                {
                    case "toCbtn":
                        degree = serviceClient.FahrenheitToCelsius(degree);
                        MessageBox.Show($"Celsius degrees: {degree}*");
                        break;
                    case "toFbtn":
                        degree = serviceClient.CelsiusToFahrenheit(degree);
                        MessageBox.Show($"Fahrenheit degrees: {degree}*");
                        break;
                }
            }
            else MessageBox.Show("Wrong input data!");
        }
        private static bool CheckDouble(string s)
        {
            return Regex.Match(s, @"[+-]?\d*\.?\d+", RegexOptions.IgnoreCase).Success;
        }
    }
}
