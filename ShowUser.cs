using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marwa_DeskTop
{
    public partial class ShowUser : Form
    {
        public ShowUser()
        {
            InitializeComponent();
            iniUser();
        }
        protected void iniUser()
        {

            DataTable dtUsers = new clsUsers().GetUsers();
            dataGridView1.DataSource = dtUsers;
        }
        private void ShowUser_Load(object sender, EventArgs e)
        {
  
          
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
