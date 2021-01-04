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
    public partial class Form1 : Form
    {
        Magazine magazine;

        public Form1()
        {
            InitializeComponent();
            cbNewstype.Items.Add(NewsType.CULTURE);
            cbNewstype.Items.Add(NewsType.GOSSIP);
            cbNewstype.Items.Add(NewsType.POLITICS);
            cbNewstype.Items.Add(NewsType.REGIONAL);
            cbNewstype.Items.Add(NewsType.SPORTS);

            magazine = new Magazine("MyMagazine");
        }

        private void btnFillMagazineWithSomeNewsItems_Click(object sender, EventArgs e)
        {
            magazine.AddNewsItem("Elton John back in town", "Georgiana Manolache", NewsType.CULTURE); 
            magazine.AddNewsItem("Drinks by Proxy", "Kalina Petrova", NewsType.GOSSIP);   
            magazine.AddNewsItem("More ES stduents, please!", "Gerald Hilderink", NewsType.GOSSIP);           
            magazine.AddNewsItem("New Fontys-building build in 2019? Make it 2020", "Bert van Gestel", NewsType.REGIONAL);
            btnFillMagazineWithSomeNewsItems.Enabled = false;
        }


        private void btnAddNewsitem_Click(object sender, EventArgs e)
        {
            NewsType givenType = (NewsType)cbNewstype.SelectedItem;
            magazine.AddNewsItem(tbTitle.Text, tbAuthor.Text, givenType);

        }

        private void btnRemoveNewsItem_Click(object sender, EventArgs e)
        {
            if (magazine.RemoveNewsItem(Convert.ToInt32(tbIdNewsItem.Text)))
            {
                return;
            }
            MessageBox.Show("Item with specified id was not found");
        }

        private void btnEditNewsItem_Click(object sender, EventArgs e)
        {
            int idInQuestion = Convert.ToInt32(tbIdNewsItem.Text);
            string title = "";
            string author = "";
            NewsType type = 0;

            if (magazine.EditNewsItem(idInQuestion))
            {
                foreach(NewsItem nI in magazine.GetNewsItems())
                {
                    if(nI.Id == idInQuestion)
                    {
                        title = nI.Title;
                        author = nI.Author;
                        type = nI.Type;
                    }
                }
                EditForm newForm = new EditForm(this, title, author, type, idInQuestion);
                newForm.ShowDialog();
                return;
            }
            MessageBox.Show("Item with specified id was not found");

        }

        private void btnShowGeneralInfoOfAllNewsItems_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            foreach (NewsItem nI in magazine.GetNewsItems())
            {
                lbInfo.Items.Add(nI.GetGeneralInfo());
            }

        }

        private void btnShowRandomNewsItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show(magazine.GetRandomNewsItem());         
        }

        public void UpdateNewsItem(string title, string author, NewsType type, string content, int givenID)
        {
            foreach(NewsItem nI in magazine.GetNewsItems())
            {
                if(nI.Id == givenID)
                {
                    nI.Title = title;
                    nI.Author = author;
                    nI.Type = type;
                    nI.Content = content;
                    return;
                }
            }
        }
    }
}
