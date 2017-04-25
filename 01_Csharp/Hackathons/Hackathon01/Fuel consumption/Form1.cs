using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_consumption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewForm form = new ViewForm();
            form.Show();
        }
    }
}
