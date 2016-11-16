using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Redesign
{
    public partial class ManagementWindow : Form
    {
        LoginWindow original = new LoginWindow();

        public ManagementWindow()
        {
            InitializeComponent();
        }

        public void setParentForm(LoginWindow x)
        {
            original = x; 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            original.Close();
        }
    }
}
