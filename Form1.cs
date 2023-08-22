using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
       

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 225))
            {
                // Mostrar un mensaje de error indicando que solo se permiten números en el campo.
                MessageBox.Show("Por favor llene el campo con solo numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
             string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Por favor llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Program.mensaje2 = textBox1.Text;
                Form3 f3 = new Form3(); 

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }

        }

    }
}

