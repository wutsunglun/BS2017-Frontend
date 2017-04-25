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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new MyTable();
            data.RefuelingDate = Convert.ToDateTime(dateTimePicker1.Value);
            data.Liter = Convert.ToDouble(numericUpDown1.Value);
            data.Kilometer = Convert.ToDouble(numericUpDown2.Value);
            var model = new MyModel();

            if (BeforeData(data, model) && AfterData(data, model))
            {               
                model.MyTable.Add(data);
                model.SaveChanges();
                MessageBox.Show("存檔完成");
            }
            else
            {
                MessageBox.Show("日期與里程數不合理");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            MessageBox.Show("已清除資料，請繼續動作");
        }

        private static bool BeforeData(MyTable data, MyModel model)
        {
            if (model.MyTable.Where((x) => x.RefuelingDate <= data.RefuelingDate).Any((x) => x.Kilometer > data.Kilometer))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool AfterData(MyTable data, MyModel model)
        {
            if (model.MyTable.Where((x) => x.RefuelingDate >= data.RefuelingDate).Any((x) => x.Kilometer < data.Kilometer))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
