using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
    
namespace sest_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(884, 127);
        }

        private void put_btn_Click(object sender, EventArgs e)
        {

        }

        private void post_btn_Click(object sender, EventArgs e)
        {

        }

        private void get_btn_Click(object sender, EventArgs e)
        {
            if (url_txt.Text.Length > 0)
            {
                try
                {
                    HttpClient httpClient = new HttpClient();
                    var result = httpClient.GetAsync(url_txt.Text).Result;
                    this.Size = new Size(884,604);
                    field_txt.Enabled = false;
                    value_txt.Enabled = false;
                    results_txt.Text = result.ToString();
                }
                catch (HttpRequestException ef)
                {
                   MessageBox.Show("Exception Caught!");
                   MessageBox.Show("Message :{0} ", ef.Message);
                }
                catch(InvalidOperationException efg)
                {
                    MessageBox.Show("Must be a complete url (http/s) included");
                }

               
            }
            else
            {
                MessageBox.Show("Please type in an url");
            }
        }
    }
}
