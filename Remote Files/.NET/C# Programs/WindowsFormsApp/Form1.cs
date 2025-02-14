using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            MessageBox.Show("Addition = " + c);
        }

        private void LogMessage(string message)
        {
            listBox1.Items.Add(DateTime.Now.ToString() + " - "+ message);
        }

        //private async void button2_Click(object sender, EventArgs e)
        //{
        //    LogMessage("Task Started");
        //    string wetClothes = WashClothes();
        //    DryClothes(wetClothes);
        //    CookFood();
        //    CleanHouse();
        //    LogMessage("Task Ended");
        //}

        //private async void button2_Click(object sender, EventArgs e)
        //{
        //    LogMessage("Task Started");
        //    string wetClothes = await WashClothes();
        //    await DryClothes(wetClothes);
        //    await CookFood();
        //    await CleanHouse();
        //    LogMessage("Task Ended");
        //}

        //private async void button2_Click(object sender, EventArgs e)
        //{
        //    LogMessage("Task Started");
        //    string wetClothes = await WashClothes();
        //    DryClothes(wetClothes);
        //    CookFood();
        //    CleanHouse();
        //    LogMessage("Task Ended");
        //}

        //private async void button2_Click(object sender, EventArgs e)
        //{
        //    LogMessage("Task Started");
        //    string wetClothes = await WashClothes();
        //    Task t1 = DryClothes(wetClothes);
        //    Task t2 = CookFood();
        //    Task t3 = CleanHouse();
        //    await Task.WhenAll(t1, t2, t3); //parallel invoke in framework
        //    LogMessage("Task Ended");
        //}

        private async void button2_Click(object sender, EventArgs e)
        {
            LogMessage("Task Started");
            Task t1 = WashAndDry();
            Task t2 = CookFood();
            Task t3 = CleanHouse();
            await Task.WhenAll(t1, t2, t3);
            LogMessage("Task Ended");
        }
        private async Task<string> WashClothes()
        {
            LogMessage("Washing Clothes");
            await Task.Delay(1000);
            LogMessage("Completed washing clothes");
            return "Wet Clothes";
        }

        private async Task DryClothes(string clothes)
        {
            LogMessage("Drying Clothes");
            await Task.Delay(1000);
            LogMessage("Completed drying clothes");
        }

        private async Task CookFood()
        {
            LogMessage("Cooking Food");
            await Task.Delay(2000);
            LogMessage("Completed cooking food");
        }

        private async Task CleanHouse()
        {
            LogMessage("Cleaning House");
            await Task.Delay(2000);
            LogMessage("Completed cleaning house");
        }

        private async Task WashAndDry()
        {
            string wetClothes = await WashClothes();
            await DryClothes(wetClothes);
        }

    }
}
