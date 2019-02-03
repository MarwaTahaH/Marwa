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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public static int UserId = 0;
        public static string FullName=" ";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
                {
                UserId = new clsUsers().CheckUser(txtUserName.Text, txtPassword.Text);
                if(UserId>0)
                {
                    txtPassword.Text = "";
                    DataTable dtuser = new clsUsers().GetUsers(UserId);
                    FullName = dtuser.Rows[0]["FullName"].ToString();

                    this.Hide();
                    new MainForm().ShowDialog();
                    this.Show();
                }



                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
