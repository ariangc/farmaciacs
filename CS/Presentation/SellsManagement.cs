﻿using System;
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
    public partial class SellsManagement : Form
    {
        static int cliente = 0;
        static int productos = 0;
        public SellsManagement()
        {
            cliente = productos = 0;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (cliente == 0) {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                cliente++;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e) {
            if (cliente == 0) {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            if (productos == 0) {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                productos++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            MessageBox.Show("La venta ha sido registrada", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e) {

        }
    }
}
