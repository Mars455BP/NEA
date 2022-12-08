using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleForms
{
    
    public partial class PickList : Form
    {
        public int CountOfBoxes;
        public PickList()
        {
            InitializeComponent();
            CountOfBoxes = this.checkedListBox1.Items.Count;
            this.CenterToParent();
            for (int i = 0; i <= UserInterface.x; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
