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
    public partial class selectItems : Form
    {
        public string[] returnList()
        {
            string[] str = new string[checkedListBox1.CheckedItems.Count];
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                str[i] = checkedListBox1.CheckedItems[i].ToString();
            }
            return str;
        }
        public selectItems()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = new string[returnList().Length];
            str = returnList();
            
            for (int i = 0; i < str.Count(); i++)
            {
                Console.WriteLine(str[i] + ", ");
            }
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
