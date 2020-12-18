using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App
{
    public partial class BorrowForm : Form
    {
        Form1 mainForm;

        public BorrowForm()
        {
            InitializeComponent();
        }

        public BorrowForm(Form1 Testing, string bookInfo)
        {
            InitializeComponent();
            mainForm = Testing;
            lblBookInfo.Text = bookInfo;
        }

        private void btnBorrowToBorrower_Click(object sender, EventArgs e)
        {
            mainForm.SetBorrowInfo(tbBorrowerInfo.Text);
            this.Close();
        }
    }
}
