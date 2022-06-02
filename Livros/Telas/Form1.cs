using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;

namespace Livros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class GoogleSearch
        {
            //Chave API
            private static string API_KEY = "AIzaSyCyqAm432caVHD6ycUEWTbCNtg4rD_ao8Y";

            //Chave de identificação
            private static string cx = "015598178761323117960:sbbkk2__0lo";

            public static CustomsearchService Service = new CustomsearchService(
                new BaseClientService.Initializer
                {
                    ApplicationName = "ISBNBookCsutomSearch",
                    ApiKey = API_KEY,
                });

            public static IList<Result> Search(string query)
            {
                Console.WriteLine("Executando uma consulta sobre o livro, aguarde: {0} ...", query);

                CseResource.ListRequest listRequest = Service.Cse.List(query);
                listRequest.Cx = cx;

                Search search = listRequest.Execute();
                return search.Items;
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = txtNome.Text;
                var results = GoogleSearch.Search(query);
                foreach (Result result in results)
                {
                    ListViewItem lv = new ListViewItem(result.Title);
                    lv.SubItems.Add(result.Link);
                    lvTeste.Items.Add(lv);
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            try
            {
                string query = txtNome.Text;
                var results = GoogleSearch.Search(query);
                foreach (Result result in results)
                {
                    if (result.Link.Contains("wikipedia"))
                    {
                        System.Diagnostics.Process.Start("chrome", result.Link);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Necessario google chrome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = txtNome.Text;
                var results = GoogleSearch.Search(query);
                foreach (Result result in results)
                {
                    if (result.Link.Contains("amazon"))
                    {
                        System.Diagnostics.Process.Start("chrome", result.Link);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Necessario google chrome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = txtNome.Text;
                var results = GoogleSearch.Search(query);
                foreach (Result result in results)
                {
                    ListViewItem lv = new ListViewItem(result.Title);
                    lv.SubItems.Clear();
                    lvTeste.Items.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
