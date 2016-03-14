using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphingDices
{
    public partial class Form1 : Form
    {
        int count = 0, total = 0, avrage;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(avrage.ToString());
        }

        private void Roll_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Roll.ChartAreas[0].AxisY.Maximum = 12;
            Roll.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            List<int> AndrewOneSidedDiceRoll = new List<int> { 4, 2, 2, 5, 5, 2, 5, 6, 2,
             5, 4, 5, 3, 3, 5, 1, 5, 3, 2, 6 };
            //AndrewOneSidedDiceRoll.Sort();
            foreach(int i in AndrewOneSidedDiceRoll)
            {
                Roll.Series["Damage Roll"].Points.AddY(i);
                ++count;
                total += i;
            }
            avrage = total / count;
        }
    }
}
