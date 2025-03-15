using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace DVLD
{
    public partial class PeopleForm : Form
    {
        public PeopleForm()
        {
            InitializeComponent();
        }
        private void _RefreshPersonList()
        {
            dgvAllPeople.DataSource = clsPeopleB.GetAllContact(); 
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            _RefreshPersonList();
        }
    }
}
