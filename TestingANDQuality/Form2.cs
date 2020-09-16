using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingANDQuality
{
    public partial class Form2 : Form
    {
        private int sizeArray;
        private bool confirm = false;

        public int SizeArray { get {return  sizeArray; } }
        public bool Confirm { get { return confirm; } }
        public Form2()
        {
            InitializeComponent();
            for (int i = 1; i <= 250; i++)
            {
                comboBoxSizeArray.Items.Add(i);
            }
            comboBoxSizeArray.Text = "10";
            comboBoxSizeArray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            sizeArray = int.Parse(comboBoxSizeArray.Text);
            confirm = true;
            this.Close();
        }
    }
}
