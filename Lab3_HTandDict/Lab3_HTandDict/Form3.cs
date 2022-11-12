using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_HTandDict
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        SortedSet<string> sset1;
        SortedSet<string> sset2;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
            sset1 = new SortedSet<string>();
            sset2 = new SortedSet<string>();
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a value in the textbox");
            }
            else 
            { 
                sset1.Add(textBox1.Text);
                 textBox1.Clear();
            }
        }

        private void BrnRem1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a value in the textbox");
            }
            else
            {
                sset1.Remove(textBox1.Text);
                textBox1.Clear();
            }

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a value in the textbox");
            }
            else
            {
                sset2.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void btnRem2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a value in the textbox");
            }
            else
            {
                sset2.Remove(textBox1.Text);
                textBox1.Clear();
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
          
                ss1.Items.Clear();
                ss2.Items.Clear();

                foreach (String item in sset1)
                {
                    ss1.Items.Add(item);
                }

                
                foreach (String item in sset2)
                {
                    ss2.Items.Add(item);
                }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sset1.Clear();
            sset2.Clear();
           
        }

        private void btnIntersec_Click(object sender, EventArgs e)
        {
           
                sset1.IntersectWith(sset2);
            
        }

        private void BtnUnion_Click(object sender, EventArgs e)
        {
           

                sset1.UnionWith(sset2);
            
            
        }

        private void btnSubset_Click(object sender, EventArgs e)
        {
          
                lblresult.Text = sset1.IsSubsetOf(sset2).ToString();
            
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {
           
            
                lblresult.Text = sset1.IsSupersetOf(sset2).ToString();
            
        }
    }
}
