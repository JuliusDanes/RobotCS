using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RobotCS
{
    public partial class UseAs : Form
    {
        public UseAs()
        {
            InitializeComponent();
        }

        private void UseAs_Load(object sender, EventArgs e)
        {
            string[] list = { "Robot1", "Robot2", "Robot3" };
            cmbxUseAs.Items = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            setUseAs();
        }

        private void UseAs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                setUseAs();
        }

        void setUseAs()
        {
            if (cmbxUseAs.selectedIndex != -1)
            {
                string useAs = cmbxUseAs.selectedValue.ToString();
                new Thread(obj => Application.Run(new RobotCS(useAs))).Start();
                this.Close();
            }
            else
                MessageBox.Show("Please choose for Use As :>");
        }
    }
}
