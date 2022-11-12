using Microsoft.VisualBasic.Devices;
using System.Collections;

namespace Lab3_HTandDict
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Hashtable hashtable;
        private Dictionary<int, string> dict;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            hashtable = new Hashtable();
            dict = new Dictionary<int, string>();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btnHtAdd_Click(object sender, EventArgs e)
            
        {
            if (txtKey.Text != "" && txtValue.Text != "")
            {
                if (hashtable.ContainsKey(txtKey.Text))
                {
                    MessageBox.Show("Key Already exists");
                }
                else
                {
                    hashtable.Add(txtKey.Text, txtValue.Text);
                    txtKey.Clear();
                    txtValue.Clear();
                    lblErr.Text = "";
                    txtValue.Text = "";
                    txtKey.Text = "";

                }
               
            }
            else
            {
               
                    lblErr.Text = "Please Enter key and value";
               
            }
        }

        private void btnHtRemove_Click(object sender, EventArgs e)
        {


            if ((!hashtable.ContainsKey(txtKey.Text)))
            {
                MessageBox.Show("Key does not exists");

            }

            else
            {
                hashtable.Remove(txtKey.Text);
                txtValue.Text = "";
                txtKey.Text = "";
            }
            
           
        }

        private void btnHtDisplay_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            if (hashtable.Count == 0)
            {

                MessageBox.Show("HashTable is Empty");

            }
            else
            {
                
                foreach (DictionaryEntry de in hashtable)
                {
                    lbxDisplay.Items.Add(de.Key + " - " + de.Value);
                }
            }
            
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            hashtable.Clear();
                
            
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
           
                lbxDisplay.Items.Clear();
               
                foreach (String v  in hashtable.Values)
                {
                    lbxDisplay.Items.Add(v);
               }
            
        }

        private void btnDictAdd_Click(object sender, EventArgs e)
        {
            if (txtKey.Text != "" && txtValue.Text != "")
            {
                if (dict.ContainsKey(Int32.Parse(txtKey.Text)))
                {
                    MessageBox.Show("Key Already exists");
                }
                else
                {
                    dict.Add(Int32.Parse(txtKey.Text), txtValue.Text);
                    txtKey.Clear();
                    txtValue.Clear();
                    lblErr.Text = "";
                    txtValue.Text = "";
                    txtKey.Text = "";
                }
            }

            else
            {
               
                    lblErr.Text = "Please Enter  key and value";
                
            }

        }

        private void btnDictRemove_Click(object sender, EventArgs e)
        {

            if ((!hashtable.ContainsKey(txtKey.Text)))
            {
                MessageBox.Show("Key does not exists");

            }

            else
            {
                hashtable.Remove(txtKey.Text);
                txtValue.Text = "";
                txtKey.Text = "";
            }




        }

        private void btnDictDisplay_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            foreach(KeyValuePair<int, string> kvp in dict)
            {
                lbxDisplay.Items.Add(kvp.Key + " - " + kvp.Value);
            }
        }

        private void btnDClr_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();

            dict.Clear();
            
        }

        private void btnCkval_Click(object sender, EventArgs e)

        {
            

            
                foreach (KeyValuePair<int, string> kv in dict)


                    if (kv.Value == (txtValue.Text))

                     {

                    lblKva.Text = kv.Key + "--" + kv.Value;


                     }
             
               else
                 {
                     lblKva.Text = " Not Found ";
                 }


            
        }
    }
}