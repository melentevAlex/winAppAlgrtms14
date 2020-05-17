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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        delegate int[] SortMethod(int[] arr);


        private void button1_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            ProductiveSortes productive = new ProductiveSortes();
            List<double> prefomance = new List<double>();


            foreach (var item in sort.Ga.ListArrays)
            {
                productive.arr = item;
                prefomance.Add(productive.Perfomance(sort.Buble));
                prefomance.Add(productive.Perfomance(sort.ShakeSort));
                prefomance.Add(productive.Perfomance(sort.SwitchSort));
                prefomance.Add(productive.Perfomance(sort.CountSort));
                prefomance.Add(productive.Perfomance(sort.ExtractSort));
            }

            foreach (var item in prefomance)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
