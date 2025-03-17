using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddEditPoepleForm : Form
    {
       
        enum enMode { AddNewMode = 0 , EditNewMode = 1 };
        private enMode _Mode;
         int _ContactID;
        clsPeopleB _Contact; 
        public AddEditPoepleForm(int ContactID)
        {
            InitializeComponent();
            _ContactID = ContactID;
            if (ContactID == -1)
            {
                _Mode = enMode.AddNewMode;
            }
            else
            { 

                _Mode = enMode.EditNewMode;
            }
        }
        private void _FillAllCountriesComboBox()
        {
            DataTable dtCountries = clsPeopleB.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                userControlPoeple1.ComboBoxCountry.Items.Add(row["CountryName"]);
                
            }

        }
        private void _LoadData()
        {
            _FillAllCountriesComboBox();
            
            if( _Mode == enMode.AddNewMode )
            {
                lblTitlePoeple.Text = "Add New Person "; 
                _Contact = new clsPeopleB();
                userControlPoeple1.ComboBoxCountry.SelectedIndex = 123;
                return; 
                
            }
            _Contact = clsPeopleB.Find(_ContactID);
            if (_Contact == null)
            {
                MessageBox.Show("This form will close because its emty");
                this.Close();
                return;
            }
            lblTitlePoeple.Text = "Edit People ID "; 
           LblID.Text = _ContactID.ToString();  
            userControlPoeple1.textBoxFirstName.Text = _Contact.FirstName;
            userControlPoeple1.textBoxSecondName.Text = _Contact.SecondName;
            userControlPoeple1.textBoxthirdName.Text = _Contact.ThirdName;
            userControlPoeple1.textBoxLastName.Text = _Contact.LastName;
            userControlPoeple1.textBoxNationalty.Text = _Contact.NationalId;
            userControlPoeple1.dateTimePickerDateBirthPeople.Value = _Contact.DateOfBith; 
            userControlPoeple1.textBoxPhone.Text = _Contact.Phone;
            userControlPoeple1.textBoxEmail.Text = _Contact.Email;
            userControlPoeple1.ComboBoxCountry.SelectedText = _Contact.CountryName;
          
            userControlPoeple1.listBoxAddress.Items.Add(_Contact.Address );
            if(_Contact.Gendor == 0)
            {
                userControlPoeple1.radioButtonMale.Checked = true;
                userControlPoeple1.radioButtonFemal.Checked = false; 
            }
            else
            {
                userControlPoeple1.radioButtonFemal.Checked= true;
                userControlPoeple1 .radioButtonMale.Checked = false;    
            }


        }

        private void userControlPoeple1_Load(object sender, EventArgs e)
        {

        }

        private void AddEditPoepleForm_Load(object sender, EventArgs e)
        {
           _LoadData();
        }
    }
}
