using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetInformation
{
    public partial class Form1 : Form
    {
        Pet newPet;
        List<Pet> Pets = new List<Pet>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            newPet = new Pet();
            newPet.SetPet(tbxName.Text, tbxBYear.Text, tbxType.Text);
            Pets.Add(newPet);
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            int currentYear = 2020;
            int birthYear = newPet.GetAge();
            int age = currentYear - birthYear;
            MessageBox.Show($"{age}");
        }
    }
}
