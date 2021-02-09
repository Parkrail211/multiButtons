using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            int wayneNumber = 99;

            outputLabel.Text = $"Wayne Gretzky is number {wayneNumber}";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = (radius * radius) * pi;

            outputLabel.Text = $"The area of circle with a radius of 15cm is {area}cm^2 ";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            outputLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2 ";
            outputLabel.Text += $"\n\nThe cost to carpet this area at 19.95 per square metre is ${totalCost}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            int bill = 20;
            double shirt = 12.49;
            double hst = 0.13;
            double tax = shirt * hst;
            double fullPrice = shirt + tax;
            double change = bill - fullPrice;

            outputLabel.Text = $"Bill of Sale";

            outputLabel.Text += $"\n\nShirt: ${shirt}";

            outputLabel.Text += $"\n\nTax: ${tax}";
            outputLabel.Text += $"\nTotal: ${fullPrice}";

            outputLabel.Text += $"\n\nTendered: ${bill}";
            outputLabel.Text += $"\nChange: ${change}";
        }
    }
}
