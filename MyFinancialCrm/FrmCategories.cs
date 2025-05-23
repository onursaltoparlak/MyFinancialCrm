using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var categories = db.Categories.OrderBy(c => c.CategoryId).ToList();
            var labels = new List<Label> { label1, label2, label3, label4, label5, label6 };

            for (int i = 0; i < labels.Count && i < categories.Count; i++)
            {
                labels[i].Text = categories[i].CategoryName;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }
    }
}
