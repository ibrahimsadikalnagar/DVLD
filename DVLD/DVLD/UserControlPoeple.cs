using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UserControlPoeple : UserControl
    {
        public UserControlPoeple()
        {
            InitializeComponent();
        }
        public  ComboBox ComboBoxCountry
        {
            get { return comboBoxCountry; }
        }
        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
              clsPeopleB people1 = new clsPeopleB();
            people1.FirstName = textBoxFirstName.Text; 
            people1.SecondName = textBoxSecondName.Text;
            people1.ThirdName = textBoxthirdName.Text;
            people1.LastName = textBoxLastName.Text;    
            people1.NationalId = textBoxNationalty.Text;
            people1.Address = richTextBoxAddress.Text;
            people1.Email = textBoxEmail.Text;
            people1.Phone = textBoxPhone.Text;
            people1.DateOfBirth = dateTimePickerDateBirthPeople.Value ;
            people1.Gendor = 0; 
            people1.CountryName = comboBoxCountry.Text;
            people1.ImagePath = "dfd";
          
            
            if( people1.AddAllPeopleAndGetIDLastNewRecord())
            {
                AddEditPoepleForm EditFrm = new AddEditPoepleForm(people1.PeopleId); 
                EditFrm.ShowDialog();
            }
        }
    }
}
