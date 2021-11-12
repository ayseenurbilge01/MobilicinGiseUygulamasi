using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public string bicimlendir(string veri)
        {
            string sonveri = "";
            for(int i =3;i<veri.Length-3;i++)
            {
                sonveri += veri[i].ToString();
            }
            return sonveri;
        }
        public async void islemdekinumara()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/");
            HttpResponseMessage response = await client.GetAsync("/api/islemdekinigoster");
            string result = await response.Content.ReadAsStringAsync();
            if (result.ToString().Contains("null"))
                label2.Text = "boş";
            else
            label2.Text = bicimlendir(result).ToString();
           
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
        
        private async void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();
            Secim = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://127.0.0.1:5000/");
                HttpResponseMessage response = await client.GetAsync("api/gunsonu");
                string result = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Bugün" + bicimlendir(result) + " tane işlem yapılmıştır. Yarın için numaralar silindi.");
                islemdekinumara();
            }
           
        }
    }
}
