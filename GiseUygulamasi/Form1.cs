using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiseUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async void islemdekinumara()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            HttpResponseMessage response = await client.GetAsync("/api/islemdekinigoster");
            string result = await response.Content.ReadAsStringAsync();
            if (result.ToString() == "boş")
                label2.Text = result.ToString();
            else
            label2.Text = result[4] + result[5].ToString();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            HttpResponseMessage response = await client.GetAsync("api/islemal");
            string result = await response.Content.ReadAsStringAsync();
            MessageBox.Show(result);
            islemdekinumara();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            HttpResponseMessage response = await client.GetAsync("api/islemisonlandir");
            string result = await response.Content.ReadAsStringAsync();
            MessageBox.Show(result);
            islemdekinumara();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            islemdekinumara();
        }

    }
}
