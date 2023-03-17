using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace THA_W3_Calvin_T
{
    
    public partial class Form2 : Form
    {
        public Form1 mainform { get; set; }
        public static Form2 change;
        public Label label;
        public Form2()
        {
            InitializeComponent();
            change = this;
            label = label3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void cb_agreement_CheckedChanged(object sender, EventArgs e)
        {
            btn_magic.Enabled = cb_agreement.Checked && cb_choiceTrue.Checked;
        }
        private void cb_choiceTrue_CheckedChanged(object sender, EventArgs e)
        {
            btn_magic.Enabled = cb_agreement.Checked && cb_choiceTrue.Checked;
        }

        private void btn_magic_Click(object sender, EventArgs e)
        {
            if (rb_red.Checked)
            {
                mainform.BackColor = Color.IndianRed;
            }
            else if (rb_green.Checked)
            {
                mainform.BackColor = Color.GreenYellow;
            }
            else if (rb_blue.Checked)
            {
                mainform.BackColor = Color.AliceBlue;
            }
            else if (rb_pink.Checked)
            {
                mainform.BackColor = Color.Pink;
            }
            else if (rb_yellow.Checked)
            {
                mainform.BackColor = Color.LightYellow;
            }
            if (rb_navy.Checked)
            {
                mainform.ForeColor = Color.Navy;
            }
            else if (rb_purple.Checked)
            {
                mainform.ForeColor = Color.Purple;
            }
            else if (rb_grey.Checked)
            {
                mainform.ForeColor = Color.Gray;
            }
            if (!rb_blue.Checked && !rb_green.Checked && !rb_red.Checked && !rb_pink.Checked && !rb_yellow.Checked && !rb_navy.Checked && !rb_purple.Checked && !rb_grey.Checked)
            {
                MessageBox.Show("Choose background and text color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!rb_blue.Checked && !rb_green.Checked && !rb_red.Checked && !rb_pink.Checked && !rb_yellow.Checked)
            {
                MessageBox.Show("Choose background color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!rb_navy.Checked && !rb_purple.Checked && !rb_grey.Checked)
            {
                MessageBox.Show("Choose text color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
