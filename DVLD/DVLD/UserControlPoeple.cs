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
                
        }
    }
}
