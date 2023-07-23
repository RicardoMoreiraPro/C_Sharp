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
    public partial class F_ToolStripContainer : Form
    {
        public F_ToolStripContainer()
        {
            InitializeComponent();
        }

        private void F_ToolStripContainer_Load(object sender, EventArgs e)
        {
            List<ToolStrip> br = new List<ToolStrip>();
            int num = toolStripContainer1.TopToolStripPanel.Controls.Count;
            for(int i = 0; i < num; i++)
            {
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[i].Name);
                checkedListBox1.SetItemChecked(i, true);
                
            }
            
        }
    }
}
