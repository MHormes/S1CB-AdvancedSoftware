using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14_MagazineApp
{
    public partial class EditForm : Form
    {
        Form1 mainForm;
        int givenID;

        public EditForm()
        {
            InitializeComponent();
        }
        
        public EditForm(Form1 parentForm, string title, string author, NewsType type, int idInQuestion)
        {
            InitializeComponent();
            mainForm = parentForm;
            tbTitle.Text = title;
            tbAuthor.Text = author;
            givenID = idInQuestion;
            cbNewstype.Items.Add(NewsType.CULTURE);
            cbNewstype.Items.Add(NewsType.GOSSIP);
            cbNewstype.Items.Add(NewsType.POLITICS);
            cbNewstype.Items.Add(NewsType.REGIONAL);
            cbNewstype.Items.Add(NewsType.SPORTS);
            cbNewstype.SelectedItem = type;
        }

        private void btnUpdateNewsItem_Click(object sender, EventArgs e)
        {
            NewsType givenType = (NewsType)cbNewstype.SelectedItem;
            mainForm.UpdateNewsItem(tbTitle.Text, tbAuthor.Text, givenType, richTextBoxContent.Text, givenID);
            this.Close();
        }
    }
}