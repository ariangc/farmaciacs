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
    public partial class RegisterClient : Form
    {
        static int dni = 0;
        static int nombres = 0;
        static int apellidos = 0;
        static int distrito = 0;
        static int telefono = 0;
        static int email = 0;

        public RegisterClient()
        {
			dni = nombres = apellidos = distrito = telefono = email = 0;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void RegisterClient_Load(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (distrito == 0)
            {
                districtTextBox.Text = "";
                districtTextBox.ForeColor = Color.Black;
                distrito++;
            }
        }
        
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente ha sido registrado", "Registro de cliente nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (distrito == 0)
            {
                districtTextBox.Text = "";
            }
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dni == 0)
            {
                dniTextBox.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dni == 0)
            {
                dniTextBox.Text = "";
                dniTextBox.ForeColor = Color.Black;
                dni++;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (nombres == 0)
            {
                nameTextBox.Text = "";
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (apellidos == 0)
            {
                lastnameTextBox.Text = "";
            }
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (telefono == 0)
            {
                phoneTextBox.Text = "";
            }
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if(email == 0)
            {
                emailTextBox.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (nombres == 0)
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
                nombres++;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (apellidos == 0)
            {
                lastnameTextBox.Text = "";
                lastnameTextBox.ForeColor = Color.Black;
                apellidos++;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (telefono == 0)
            {
                phoneTextBox.Text = "";
                phoneTextBox.ForeColor = Color.Black;
                telefono++;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (email == 0)
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
                email++;
            }
        }
    }
}
