using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55_Componentes_textbox
{
    public partial class F_MonthCalendar : Form
    {
        private void data()
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();
        }
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_pegarData_Click(object sender, EventArgs e)
        {
            data();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            data();
        }
    }
}
