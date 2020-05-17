using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class MyChart : Form
    {
        public MyChart()
        {
            InitializeComponent();
        }

        private void MyChart_Load(object sender, EventArgs e)
        {
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 10, h = 0.1, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;


            while (x<=b)
            {
                y = Math.Pow(x, 2);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }

            // как в форме 2 забить методы в лист и вызвать с foreach
            // добавить take
            // 100 000
        }
    }
}
