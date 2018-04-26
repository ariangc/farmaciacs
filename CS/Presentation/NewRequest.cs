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
    public partial class NewRequest : Form
    {
        public NewRequest()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (requestTextBox.Text != "")
            {
                MessageBox.Show("Solicitud enviada", "Estado de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Debe ingresar su solicitud", "Estado de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
