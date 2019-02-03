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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private Timer Clock;
        public MainForm()
        {
            InitializeComponent();
            iniClock();
            lblUserName.Text = Login.FullName;
            iniGride();
        }
        #region Timer
        protected void iniClock()
        {
            Clock = new Timer();
            Clock.Interval = 1000;
            Clock.Tick += Clock_Tick;
            Clock.Start();

        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTimeNow.Text = String.Format("{0:00}:{1:00}:{2:00}", dateTime.Hour, dateTime.Minute, dateTime.Second);
        }
 
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clock.Stop();
            Clock.Dispose();
        }
        #endregion

        #region GridView
        protected void iniGride()
        {
            try
            {
                DataTable dtUser = new clsUsers().GetUsers();
                gvUser.DataSource = dtUser;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,null,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        #endregion

     
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtUsers= new clsUsers().GetUsers();
            Reports.rptUser rptUser = new Reports.rptUser();
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (dtUsers.Rows.Count > 0 && saveFileDialog.ShowDialog()==DialogResult.OK)
            {

                rptUser.SetDataSource(dtUsers);
                rptUser.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, saveFileDialog.FileName);
                rptUser.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, saveFileDialog.FileName);

                MessageBox.Show(" File Download Successfully :) ","This msg",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            rptUser.Close();
            rptUser.Dispose();




        }
    }
}
