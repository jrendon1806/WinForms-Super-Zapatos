using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinShoeStore.Controllers;
using WinShoeStore.Models;

namespace WinShoeStore.Views
{
    public partial class frmArticles : Form
    {
        private ArticlesController ArticlesController;
        //private Articles articles;
        public frmArticles()
        {
            InitializeComponent();
            ArticlesController = new ArticlesController();
            //articles = new Articles();
        }

        private async void GetArticles()
        {
            var articlesList = await ArticlesController.GetArticlesAsync();


            if (articlesList != null && articlesList.Any())
            {
                foreach(var article in articlesList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvArticles);

                    row.Cells[0].Value = article.Description;
                    row.Cells[1].Value = article.Price;
                    row.Cells[2].Value = article.Total1;
                    row.Cells[3].Value = article.Total2;
                    row.Cells[4].Value = article.StoreId;

                    dgvArticles.Rows.Add(row);
                }
            }
            else {
                MessageBox.Show("No se encontraron artículos");
            }

        }

        private void btnLoadStock_Click(object sender, EventArgs e)
        {
            GetArticles();

        }
    }
}
