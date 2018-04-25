using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ClientManagement : Form
    {
        public ClientManagement()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterClient rc = new RegisterClient();
            this.Hide();
            rc.ShowDialog();
            this.Show();
        }

        private void ClientManagement_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            UpdateClient uc = new UpdateClient();
            this.Hide();
            uc.ShowDialog();
            this.Show();
        }
    }
}
