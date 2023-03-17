using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_Calvin_T
{
    public partial class Form1 : Form
    {
        public bool benar = false;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbox_FavArtist.Text) && string.IsNullOrEmpty(tbox_Name.Text))
            {
                MessageBox.Show("Please input Name and Favorite Artist","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(string.IsNullOrEmpty(tbox_FavArtist.Text))
            {
                MessageBox.Show("Please input Favorite Artist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(string.IsNullOrEmpty(tbox_Name.Text))
            {
                MessageBox.Show("Please input Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                Form2.change.label.Text = "Hi, my name is " + tbox_Name.Text + " and my favorite artist is " + tbox_FavArtist.Text;
            }
        }
        public void BisaSubmit()
        {
            if (benar == true && cb_agree.Checked)
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }
        private void cb_agree_CheckedChanged(object sender, EventArgs e)
        {
            BisaSubmit();
        }
        private void btn_NextForm_Click(object sender, EventArgs e)
        {
            benar = true;
            Form2 form2 = new Form2();
            form2.mainform = this;
            form2.Show();
            BisaSubmit();
        }
    }
}
