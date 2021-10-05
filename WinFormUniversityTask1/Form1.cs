using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUniversityTask1
{
    public partial class Form1 : Form
    {
        string[] stringArray = new string[] { "Kamal", "Akif", "Nebi", "Renat" };
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = stringArray;
        }
        private void btn_Reverse_Click(object sender, EventArgs e)
        {
            string[] tempArray = new string[] { };
            tempArray = stringArray;
            Array.Reverse(tempArray);
            listBox2.DataSource= tempArray;
        }
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            string[] tempArray = new string[4];
            for (int i = 0; i < stringArray.Count(); i++) tempArray[i] = stringArray[i];
            Array.Sort<string>(tempArray);
            listBox2.DataSource = tempArray;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (textBox.Text != string.Empty)
            {
                listBox3.Items.Add(textBox.Text);
                textBox.Text = string.Empty;
            }
            else MessageBox.Show("Text box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_Move_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                int index = listBox3.SelectedIndex;
                listBox4.Items.Add(listBox3.Items[index]);
                listBox3.Items.RemoveAt(index);
            }
            else if (listBox3.Items.Count == 0) MessageBox.Show("List box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Please select an item!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
