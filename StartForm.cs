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
    public partial class StartForm : MetroFramework.Forms.MetroForm
    {
        public static bool Arbic=false;
        public StartForm()
        {
            InitializeComponent();
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserData().ShowDialog();
            this.Show();
            
        }

      
        private void rdbtnEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnEnglish.Checked == true)
                Arbic = false;
            else
               Arbic = true;

        }

        private void rdbtnArbic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnArbic.Checked == true)
                Arbic = true;
            else
                Arbic = false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
    
        }
    
        private void btnShowUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowUser().ShowDialog();
            this.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Show();
        }
    }
}
