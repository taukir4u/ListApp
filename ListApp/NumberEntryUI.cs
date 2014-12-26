using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListApp
{
    public partial class NumberEntryUI : Form
    {

        List<double> numbers = new List<double>();
        public NumberEntryUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(numberTextBox.Text);
            numbers.Add(number);
            countTextBox.Text = numbers.Count.ToString();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            double sum = 0;
            numberListBox.Items.Clear();
            foreach (double aNumber in numbers)
            {
                
                numberListBox.Items.Add(aNumber);
                sum += aNumber;
                
            }
            sumTextBox.Text = sum.ToString();
        }
    }
}
