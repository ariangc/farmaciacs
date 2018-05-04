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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(newPasswordTextBox.Text == repeatPasswordTextbox.Text)
            {
                MessageBox.Show("Las contraseñas no deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("La contraseña fue actualizada corectamente", "Contraseña Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
