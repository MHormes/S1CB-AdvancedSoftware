using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPCS2June2019
{
    public partial class Form1 : Form
    {
        private Magazine m;
        public Form1()
        {
            InitializeComponent();
            this.m = new Magazine("Fontys journal, edition June 2019");
            this.cbNewstype.SelectedIndex = 2;
        }

        private void btnFillMagazineWithSomeNewsitems_Click(object sender, EventArgs e)
        {
            this.m.AddNewsItem("Beyonce back in town", "Medhat Riad", NewsType.CULTURE);
            this.m.AddLineToNewsItem(101, "Beyonce announced she will come to the Netherlands.");
            this.m.AddLineToNewsItem(101, "She will perform in the Ziggo Dome.");
            this.m.AddLineToNewsItem(101, "Tomorrow ticket-sale starts!");

            this.m.AddNewsItem("BBQ by Proxy", "Mieke van Vucht", NewsType.GOSSIP);
            this.m.AddLineToNewsItem(102, "Next week a barbeque in the park.");

            this.m.AddNewsItem("Celebration Kings-day", "Mieke van Vucht", NewsType.CULTURE);
            this.m.AddLineToNewsItem(103, "Our king's name is Willem Alexander.");
            this.m.AddLineToNewsItem(103, "They have 3 children.");
            this.m.InsertLineToNewsItem(103, 1,"He is married with Maxima.");

            this.m.AddNewsItem("New Fontys-building build in 2019", "Medhat Riad",NewsType.REGIONAL);
            this.m.AddLineToNewsItem(104, "Working hard on the new building");
            this.m.AddLineToNewsItem(104, "Time to move in is september 2020.");
            this.m.AddLineToNewsItem(104, "You can follow the progress,");
            this.m.AddLineToNewsItem(104, "since some webcams are installed.");

            this.m.RemoveNewsItem(102); //the news-item about Proxy's bbq issues is removed
        }

        private void btnAddNewsitem_Click(object sender, EventArgs e)
        { //todo
 
         }

        private void btnRemoveNewsItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.tbIdNewsitem.Text);
            if (this.m.RemoveNewsItem(id))
            { MessageBox.Show("succesfully removed"); }
            else { MessageBox.Show("Not succesfully removed"); }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.tbIdNewsitem.Text);
            if (this.m.AddLineToNewsItem(id, this.tbLine.Text))
            { MessageBox.Show("succesfully added"); }
            else { MessageBox.Show("Not succesfully added"); }
        }

        private void btnInsertLine_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.tbIdNewsitem.Text);
            if (this.m.InsertLineToNewsItem(id, Convert.ToInt32(this.tbIndex.Text), this.tbLine.Text))
            { MessageBox.Show("succesfully inserted"); }
            else { MessageBox.Show("Not succesfully inserted"); }
        }

        private void btnShowGeneralInfoOfAllNewsitems_Click(object sender, EventArgs e)
        {//todo
            
        }
 
       private void btnShowInfoOfNewsitem_Click(object sender, EventArgs e)
        {//todo           
            
        }
 
        private void btnShowFromAuthor_Click(object sender, EventArgs e)
        {//todo

        }
    }
}
