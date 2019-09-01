using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddData AddData = new AddData();
            AddData.ShowDialog();
            // if you have clicked on the OK button …. Then
           // if (AddData.ShowDialog() == DialogResult.OK)
            //{//do something when they click OK once back on this form
                string data = string.Format(AddData.txtdata.Text);
                lbldata.Text = data;
                //Check with the form title that it worked
                this.Text = "OK";
            //}
        }
    }
}
