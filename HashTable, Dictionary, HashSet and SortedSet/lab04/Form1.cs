using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    //Hamed tara - n01540404
    public partial class Form1 : Form
    {

        Hashtable hastable1;
        Dictionary<string, int> dictionary1;
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            hastable1 = new Hashtable();
            dictionary1 = new Dictionary<string, int>();
            this.form2 = new Form2(this);

        }
        //Add functionality 
        //Only works when key-value input textboxes have valid values
        //Throws error is the key is duplicate/already present
        private void btn_add_hashTable_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_ket_hashTable.Text) && !string.IsNullOrWhiteSpace(txt_value_hashTable.Text))
            {
                if (hastable1.ContainsKey(txt_ket_hashTable.Text))
                {
                    lbl_error_hastable.Text = "HashTable Should be unique";
                }



                else
                {

                    hastable1.Add(txt_ket_hashTable.Text, txt_value_hashTable.Text);
                }
            }
            else
            {
                lbl_error_hastable.Text = "Please enter a valid key and valid value";
            }
            txt_ket_hashTable.Text = " ";
            txt_value_hashTable.Text = " ";
        }


        /*
         *Remove functionality
        Only works when key input has valid value
        Throws error if key not found
         */

        private void btn_remove_hashTable_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_ket_hashTable.Text) && !string.IsNullOrEmpty(txt_value_hashTable.Text))
            {

                if (hastable1.ContainsKey(txt_ket_hashTable.Text))
                {
                    hastable1.Remove(txt_ket_hashTable.Text);
                }
                else
                {

                    lbl_error_hastable.Text = "Key not found in hashtable";
                }
            }
            else
            {

                lbl_error_hastable.Text = "Please Enter valid key and valid value";
            }

            txt_ket_hashTable.Text = " ";
            txt_value_hashTable.Text = " ";

        }

        private void btn_display_hashTable_Click(object sender, EventArgs e)
        {
            lbx_hashTable.Items.Clear();
            foreach (DictionaryEntry de in hastable1)
            {
                lbx_hashTable.Items.Add(de.Key + " - " + de.Value);


            }

        }
        //•	Clear functionality (0.5 point)
        // Add a new button clear
        //Clears the hashtable
        //Throws error when hashtable is already empty

        private void btn_clear_hashTable_Click(object sender, EventArgs e)
        {
            if (hastable1.Count > 0)
            {
                hastable1.Clear();
                lbx_hashTable.Items.Clear();
            }
            else
            {
                lbl_error_hastable.Text = "hashtable is empty";
            }
        }

        //•	Add new button called “Values” (0.5 point)
        //Display only the values that are present in the hash table in the list box

        private void btn_Values_hashtable_Click(object sender, EventArgs e)
        {
            lbx_hashTable.Items.Clear();
            foreach (var value in hastable1.Values)
            {
                lbx_hashTable.Items.Add(value);
            }
        }

        private void btn_add_dictionarry_Click(object sender, EventArgs e)

        {
            //Add functionality (0.5 point)
            //Only works when key - value input textboxes have valid values
            //Throws error is the key is duplicate / already present

            if (!string.IsNullOrWhiteSpace(txt_keyDictionary.Text) && !string.IsNullOrWhiteSpace(txt_valu_dictionary.Text))
            {
                if (dictionary1.ContainsKey(txt_keyDictionary.Text))
                {
                    lbl_dictionar_errorlist.Text = "The key  should be uniqe ";
                }
                else
                {
                    dictionary1.Add(txt_keyDictionary.Text, Int32.Parse(txt_valu_dictionary.Text));
                }
            }
            else
            {
                lbl_dictionar_errorlist.Text = "please enter a valid key and a valid value";
            }
            txt_keyDictionary.Text = " ";
            txt_valu_dictionary.Text = " ";
        
        }

        //Remove functionality (0.5 point)
        //Only works when key input has valid value
        //Throws error if key not found


        private void btn_remove_dictionarry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_keyDictionary.Text) && !string.IsNullOrWhiteSpace(txt_valu_dictionary.Text))
            {
                if (dictionary1.ContainsKey(txt_keyDictionary.Text))
                {
                    dictionary1.Remove(txt_keyDictionary.Text);

                }
                else
                {
                    lbl_dictionar_errorlist.Text = "The key not found";
                }
            }
            else
            {
                lbl_dictionar_errorlist.Text = "please enter a valid key and a valid value";
            }
            txt_keyDictionary.Text = " ";
            txt_valu_dictionary.Text = " ";

        }

        private void btn_display_dictionarry_Click(object sender, EventArgs e)
        {
            lbx_dictionary.Items.Clear();
            foreach (KeyValuePair<string, int> ke in dictionary1)
            {
                lbx_dictionary.Items.Add(ke.Key + " _ " + ke.Value);
            }
        }

        private void btn_clear_dictionarry_Click(object sender, EventArgs e)

        {
            if (dictionary1.Count > 0)
            {
                dictionary1.Clear();
                lbx_dictionary.Items.Clear();
            }
            else
            {
                lbl_dictionar_errorlist.Text = "dictioary is empty";
            }


        }

        private void btn_form2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void btn_checkvalues_dictionary_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_valu_dictionary.Text))
            {
                int check_value;


                if (int.TryParse(txt_valu_dictionary.Text, out check_value))
                {

                    //bool found = false;
               /*     string key = "";
                    foreach (KeyValuePair<string, int> d in dictionary1)
                    {
                        if (d.Value == valueToFind)
                        {
                            found = true;
                            key = d.Key;
                            break;
                        }
                    }*/


                    // Check if the value is present in the dictionary
                    bool isValuePresent = dictionary1.ContainsValue(check_value);
                    if (isValuePresent)
                    {
                        //The method uses a LINQ expression to find the first key-value pair
                        //in the dictionary that has the check_value as its value.
                        //The FirstOrDefault method is used to find this key-value pair.
                        //If a key-value pair is found, the corresponding key is stored in the key variable.
                        var key = dictionary1.FirstOrDefault(x => x.Value == check_value).Key;

                        lbl_dictionar_errorlist.Text = $"Key: {key} - Value: {check_value}";
                    }
                    else

                    {

                        lbl_dictionar_errorlist.Text = "Value is not present in the dictionary";
                    }
                }

                else


                {

                    lbl_dictionar_errorlist.Text = "Please enter a valid integer value";
                }
            }

            else

            {
                lbl_dictionar_errorlist.Text = "Please enter a valid value to check";
            }
        }

        private void lbl_dictionar_errorlist_Click(object sender, EventArgs e)
        {

        }
    }
}
