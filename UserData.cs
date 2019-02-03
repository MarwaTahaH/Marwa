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
    public partial class UserData : MetroFramework.Forms.MetroForm
    {
        public UserData()
        {
            InitializeComponent();
            iniPosition();
            SetLanaguage();
          
        }
        protected void iniPosition()
        {
            try
            {
                DataTable dtPosition = new clsPosition().GetPosition();
                DataRow dataRow = dtPosition.NewRow();
                dataRow["Id"]=0;
                dataRow["Name"] = "Select";

                dtPosition.Rows.InsertAt(dataRow,0);

                cmbPosition.DisplayMember = "Name";
                if (StartForm.Arbic == true)
                    cmbPosition.DisplayMember = "NameAr";
                cmbPosition.ValueMember = "Id";
                cmbPosition.DataSource = dtPosition;
            }

            catch(Exception)
            {
                throw;
            }
        }

        protected void SetLanaguage()
        {
            if(StartForm.Arbic==true)
            {
                btnSave.Text = "حفـــظ";
                lblFullName.Text = " اسم الموظف";
                lblEmail.Text = "الايميل";
                lblPassword.Text = "كلمة المرور";
                lblUserName.Text = "اسم المستخدم";
                lblPosition.Text = "المنصـــب";
                lblRetypePassword.Text= "اعادة ادخال كلمة المرور";
                    
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                epUser.Clear();
                if(String.IsNullOrEmpty(txtFullName.Text))
                {
                    epUser.SetError(lblFullName,"Please Enter Name ");

                }

                if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    epUser.SetError(lblPassword, "Please Enter Your Password ");

                }
                if (cmbPosition.SelectedIndex == 0)

                {
                    epUser.SetError(lblPosition, "Please Select Position");

                }
                if (txtPassword.Text == txtRetypePassword.Text)
                {

                    int addrow = new clsUsers().Adduser(txtFullName.Text, txtUserName.Text, txtEmail.Text, txtPassword.Text, Int32.Parse(cmbPosition.SelectedValue.ToString()));

                    if (addrow > 0)
                    {
                        txtFullName.Text = txtEmail.Text = txtPassword.Text = txtUserName.Text = txtRetypePassword.Text = "";
                        MessageBox.Show("Successfully Inserted");
                    }
                }
                else
                    MessageBox.Show("Retype Password Should Equal Password");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
