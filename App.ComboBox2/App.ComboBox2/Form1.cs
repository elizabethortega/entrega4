using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.ComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int cont = 1; cont <= 10; cont++)
            {
                cbmOpcion.Items.Add(cont.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la opcion es: " + cbmOpcion.Text);
        }


    }
}
