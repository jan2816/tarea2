using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - button2.Width);
            int y = r.Next(0, this.Height - button2.Height);
            button2.Location = new Point(x, y);
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (button2.Location == button1.Location || button2.Location == label1.Location)
            {
                MoverBoton();
            }
        }
    }
}
