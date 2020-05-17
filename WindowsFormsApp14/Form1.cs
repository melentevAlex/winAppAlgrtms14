using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {


       //private int am;

       //public int Am { get => am; set => am = value; }


       public Form1()
       {
           InitializeComponent();
       }
        
       private void Form1_Load(object sender, EventArgs e)
       {

       }
       Sort st = new Sort();

       GenerateArray r = new GenerateArray();

































       private void originalBbutton_Click(object sender, EventArgs e)
       {

           Stopwatch orstp = new Stopwatch();
           orstp.Start();
           GenerateArray f = new GenerateArray();
           foreach (var item in f.Arr)
           {
               listBox1.Items.Add(item);
           }
       }

       private void ClearButton_Click(object sender, EventArgs e)
       {
           Stopwatch clst = new Stopwatch();
           clst.Start();
           listBox1.Items.Clear();
           listBox2.Items.Clear();
           clst.Stop();
       }

       private void button1_Click(object sender, EventArgs e)
       {
           this.Hide();
           MyChart ch = new MyChart();
           ch.Show();
       }

       private void bubbleButton_Click_1(object sender, EventArgs e)
       {

           listBox2.Items.Add("метод Пузыря");
           // Здесь вызывается метод Пузыря
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.Buble(st.Ga.ListArrays[i]);
           }

           Stopwatch BuSt = new Stopwatch();

           BuSt.Start();
           foreach (var item in st.Ga.A100)
           {
               listBox2.Items.Add(item);

           }
           BuSt.Stop();
           label15.Text = BuSt.ElapsedMilliseconds.ToString();


           BuSt.Start();
           foreach (var item in st.Ga.A500)
           {
               listBox2.Items.Add(item);

           }
           BuSt.Stop();
           label24.Text = BuSt.ElapsedMilliseconds.ToString();

           BuSt.Start();
           foreach (var item in st.Ga.A1000)
           {
               listBox2.Items.Add(item);

           }
           BuSt.Stop();
           label29.Text = BuSt.ElapsedMilliseconds.ToString();

           BuSt.Start();
           foreach (var item in st.Ga.A2500)
           {
               listBox2.Items.Add(item);

           }
           BuSt.Stop();
           label34.Text = BuSt.ElapsedMilliseconds.ToString();

           BuSt.Start();
           foreach (var item in st.Ga.A5000)
           {
               listBox2.Items.Add(item);

           }
           BuSt.Stop();
           label39.Text = BuSt.ElapsedMilliseconds.ToString();


           BuSt.Start();
           foreach (var item in st.Ga.Arr)
           {
               listBox2.Items.Add(item);

           }
           BuSt.Stop();
           label44.Text = BuSt.ElapsedMilliseconds.ToString();


           Stopwatch BuStw = new Stopwatch();
           BuStw.Start();




           // Здесь вызывается метод Шейкер
           listBox2.Items.Add("метод Шейкер");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.ShakeSort(st.Ga.ListArrays[i]);

           }

           Stopwatch SHSt = new Stopwatch();

           SHSt.Start();
           foreach (var item in st.Ga.A100)
           {
               listBox2.Items.Add(item);

           }
           SHSt.Stop();
           label16.Text = SHSt.ElapsedMilliseconds.ToString();

           SHSt.Start();
           foreach (var item in st.Ga.A500)
           {
               listBox2.Items.Add(item);

           }
           SHSt.Stop();
           label23.Text = SHSt.ElapsedMilliseconds.ToString();

           SHSt.Start();
           foreach (var item in st.Ga.A1000)
           {
               listBox2.Items.Add(item);

           }
           SHSt.Stop();
           label28.Text = SHSt.ElapsedMilliseconds.ToString();

           SHSt.Start();
           foreach (var item in st.Ga.A2500)
           {
               listBox2.Items.Add(item);

           }
           SHSt.Stop();
           label33.Text = SHSt.ElapsedMilliseconds.ToString();

           SHSt.Start();
           foreach (var item in st.Ga.A5000)
           {
               listBox2.Items.Add(item);

           }
           SHSt.Stop();
           label38.Text = SHSt.ElapsedMilliseconds.ToString();


           SHSt.Start();
           foreach (var item in st.Ga.Arr)
           {
               listBox2.Items.Add(item);

           }
           SHSt.Stop();
           label43.Text = SHSt.ElapsedMilliseconds.ToString();











           // Здесь вызывается метод Включением
           listBox2.Items.Add("метод Включением");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.SwitchSort(st.Ga.ListArrays[i]);

           }

           Stopwatch SWSt = new Stopwatch();

           SWSt.Start();
           foreach (var item in st.Ga.A100)
           {
               listBox2.Items.Add(item);

           }
           SWSt.Stop();
           label17.Text = SWSt.ElapsedMilliseconds.ToString();

           SWSt.Start();
           foreach (var item in st.Ga.A500)
           {
               listBox2.Items.Add(item);

           }
           SWSt.Stop();
           label22.Text = SWSt.ElapsedMilliseconds.ToString();

           SWSt.Start();
           foreach (var item in st.Ga.A1000)
           {
               listBox2.Items.Add(item);

           }
           SWSt.Stop();
           label27.Text = SWSt.ElapsedMilliseconds.ToString();

           SWSt.Start();
           foreach (var item in st.Ga.A2500)
           {
               listBox2.Items.Add(item);

           }
           SWSt.Stop();
           label32.Text = SWSt.ElapsedMilliseconds.ToString();

           SWSt.Start();
           foreach (var item in st.Ga.A5000)
           {
               listBox2.Items.Add(item);

           }
           SWSt.Stop();
           label37.Text = SWSt.ElapsedMilliseconds.ToString();


           SWSt.Start();
           foreach (var item in st.Ga.Arr)
           {
               listBox2.Items.Add(item);

           }
           SWSt.Stop();
           label42.Text = SWSt.ElapsedMilliseconds.ToString();











           // Здесь вызывается метод Подсчётом
           listBox2.Items.Add("метод Подсчётом");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.CountSort(st.Ga.ListArrays[i]);

           }

           Stopwatch CouSt = new Stopwatch();

           CouSt.Start();
           foreach (var item in st.Ga.A100)
           {
               listBox2.Items.Add(item);

           }
           CouSt.Stop();
           label18.Text = CouSt.ElapsedMilliseconds.ToString();

           CouSt.Start();
           foreach (var item in st.Ga.A500)
           {
               listBox2.Items.Add(item);

           }
           CouSt.Stop();
           label21.Text = CouSt.ElapsedMilliseconds.ToString();

           CouSt.Start();
           foreach (var item in st.Ga.A1000)
           {
               listBox2.Items.Add(item);

           }
           CouSt.Stop();
           label26.Text = CouSt.ElapsedMilliseconds.ToString();

           CouSt.Start();
           foreach (var item in st.Ga.A2500)
           {
               listBox2.Items.Add(item);

           }
           CouSt.Stop();
           label31.Text = CouSt.ElapsedMilliseconds.ToString();

           CouSt.Start();
           foreach (var item in st.Ga.A5000)
           {
               listBox2.Items.Add(item);

           }
           CouSt.Stop();
           label36.Text = CouSt.ElapsedMilliseconds.ToString();


           CouSt.Start();
           foreach (var item in st.Ga.Arr)
           {
               listBox2.Items.Add(item);

           }
           CouSt.Stop();
           label41.Text = CouSt.ElapsedMilliseconds.ToString();









           // Здесь вызывается метод Извлечением
           listBox2.Items.Add("метод Извлечением");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.ExtractSort(st.Ga.ListArrays[i]);

           }

           Stopwatch ExtSt = new Stopwatch();

           ExtSt.Start();
           foreach (var item in st.Ga.A100)
           {
               listBox2.Items.Add(item);

           }
           ExtSt.Stop();
           label19.Text = ExtSt.ElapsedMilliseconds.ToString();

           ExtSt.Start();
           foreach (var item in st.Ga.A500)
           {
               listBox2.Items.Add(item);

           }
           ExtSt.Stop();
           label20.Text = ExtSt.ElapsedMilliseconds.ToString();

           ExtSt.Start();
           foreach (var item in st.Ga.A1000)
           {
               listBox2.Items.Add(item);

           }
           ExtSt.Stop();
           label25.Text = ExtSt.ElapsedMilliseconds.ToString();

           ExtSt.Start();
           foreach (var item in st.Ga.A2500)
           {
               listBox2.Items.Add(item);

           }
           ExtSt.Stop();
           label30.Text = ExtSt.ElapsedMilliseconds.ToString();

           ExtSt.Start();
           foreach (var item in st.Ga.A5000)
           {
               listBox2.Items.Add(item);

           }
           ExtSt.Stop();
           label35.Text = ExtSt.ElapsedMilliseconds.ToString();


           ExtSt.Start();
           foreach (var item in st.Ga.Arr)
           {
               listBox2.Items.Add(item);

           }
           ExtSt.Stop();
           label40.Text = ExtSt.ElapsedMilliseconds.ToString();



























           // Здесь вызывается метод Пузыря
           listBox2.Items.Add("метод Пузыря");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.Buble(st.Ga.ListArrays[i]);

               foreach (var item in st.Ga.ListArrays[i])
               {
                   listBox2.Items.Add(item);

               }
               listBox2.Items.Add(" ");
           }
           /*
           // Здесь вызывается метод Шейкер
           listBox2.Items.Add("метод Шейкер");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.ShakeSort(st.Ga.ListArrays[i]);

               foreach (var item in st.Ga.ListArrays[i])
               {
                   listBox2.Items.Add(item);

               }
               listBox2.Items.Add(" ");
           }

           // Здесь вызывается метод Включением
           listBox2.Items.Add("метод Включением");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.SwitchSort(st.Ga.ListArrays[i]);

               foreach (var item in st.Ga.ListArrays[i])
               {
                   listBox2.Items.Add(item);

               }
               listBox2.Items.Add(" ");
           }

           // Здесь вызывается метод Подсчётом
           listBox2.Items.Add("метод Подсчётом");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.CountSort(st.Ga.ListArrays[i]);

               foreach (var item in st.Ga.ListArrays[i])
               {
                   listBox2.Items.Add(item);

               }
               listBox2.Items.Add(" ");
           }

           // Здесь вызывается метод Извлечением
           listBox2.Items.Add("метод Извлечением");
           for (int i = 0; i < st.Ga.ListArrays.Count; i++)
           {
               st.ExtractSort(st.Ga.ListArrays[i]);

               foreach (var item in st.Ga.ListArrays[i])
               {
                   listBox2.Items.Add(item);

               }
               listBox2.Items.Add(" ");
           }

           */











    }
























    //Stopwatch stw = new Stopwatch();

    /*
    private void shakerButton_Click(object sender, EventArgs e)
    {

        Stopwatch shst = new Stopwatch();
        shst.Start();
        st.ShakeSort(st.Ga.Arr);
        foreach (var item in st.Ga.Arr)
        {
            listBox4.Items.Add(item);
        }
        shst.Stop();
        timeOfShaker.Text = shst.Elapsed.ToString();

    }

    private void switchButton_Click(object sender, EventArgs e)
    {
        Stopwatch swst = new Stopwatch();
        swst.Start();
        st.SwitchSort(st.Ga.Arr);
        foreach (var item in st.Ga.Arr)
        {
            listBox3.Items.Add(item);
        }
        swst.Stop();
        sw.Text = swst.Elapsed.ToString();

    }

    private void countButton_Click(object sender, EventArgs e)
    {
        Stopwatch couSt = new Stopwatch();
        couSt.Start();
        st.CountSort(st.Ga.Arr);
        foreach (var item in st.CountArr1)
        {
            listBox5.Items.Add(item);
        }
        couSt.Stop();
        countLabel.Text = couSt.Elapsed.ToString();
    }

    private void extractButton3_Click(object sender, EventArgs e)
    {
        Stopwatch exst = new Stopwatch();
        exst.Start();
        st.Extract3(st.Ga.Arr);
        foreach (var item in st.Ga.Arr)
        {
            listBox7.Items.Add(item);
        }
        exst.Stop();
        ExLable.Text = exst.Elapsed.ToString();
    }
    */

}
}