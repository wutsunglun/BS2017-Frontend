using Fuel_consumption.Models;
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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var begin = dateTimePicker1.Value.Date;
            var end = dateTimePicker2.Value.Date.AddDays(1);
            var model = new MyModel();
            var list = model.MyTable.Where((x) => x.RefuelingDate >= begin && x.RefuelingDate < end).OrderBy((x) => x.RefuelingDate).ToList();
            dataGridView1.DataSource = list;
            DisplayComsuption(list);
        }

        private void DisplayComsuption(List<MyTable> list)
        {
            if (list.Count > 1)
            {
                double totalKM = list.Last().Kilometer - list.First().Kilometer;
                double totalConsumption = list.Sum((x) => x.Liter) - list.First().Liter;
                double result = totalKM / totalConsumption;
            }
        }
    }
}
