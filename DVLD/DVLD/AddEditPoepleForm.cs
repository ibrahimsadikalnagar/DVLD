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
            userControlPoeple1.ComboBoxCountry.SelectedIndex = 123;
            if( _Mode == enMode.AddNewMode )
            {
                lblTitlePoeple.Text = "Add New Person "; 
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
