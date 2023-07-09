using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); 
            Application.Exit();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterial frmMaterial = new frmMaterial();
            frmMaterial.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.ShowDialog();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill frmBill = new frmBill();
            frmBill.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchBill frmSearchBill= new frmSearchBill();
            frmSearchBill.ShowDialog();
        }
    }
}
