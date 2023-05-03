using System.Collections;

namespace Lab_01_V2
{

    /*Hamed Tara  - n01540404 */
    public partial class Form1 : Form
    {
        ArrayList alist1 = new ArrayList();
        List<string> scoreList = new List<string>();
        Boolean flagErrorArray = false;
        Boolean flagErrorlist = false;
        public Form1()
        {
            InitializeComponent();
        }

        /* add button for Array */

        private void btn_AddAL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ArrayList.Text))
            {
                lbl_Array_errorLabel.Text = "Text box is empty." +
                    " Please enter a valid value.";
                flagErrorArray = true;
            }
            else
            {
                string value = txt_ArrayList.Text;
                bool isDuplicate = false;
                foreach (string element in alist1)
                {
                    if (value == element)
                    {
                        lbl_Array_errorLabel.Text = "Duplicated Value." +
                        " Please enter a valid value.";
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    lbl_Array_errorLabel.Text =
                    txt_ArrayList.Text + " Is Added To Course Araay";
                    alist1.Add(txt_ArrayList.Text);
                }
            }
            txt_ArrayList.Text = "";
        }

        /* remove button for Array */

        private void btn_RemoveAL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ArrayList.Text))
            {
                lbl_Array_errorLabel.Text = "Text box is empty." +
                    " Please enter a valid value.";
            }
            else
            {
                string value = txt_ArrayList.Text;
                bool isMatching = false;
                foreach (string element in alist1)
                {
                    if (value == element)
                    {
                        isMatching = true;
                        break;
                    }
                }
                if (isMatching)
                {
                    alist1.Remove(value);
                    lbl_Array_errorLabel.Text =
                    txt_ArrayList.Text + " Is Removed From Araay";

                }
                else
                {
                    lbl_Array_errorLabel.Text = "Course not found to remove";
                }
            }
            txt_ArrayList.Text = "";
        }

        private void btn_DisplayAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbx_ArrayList.Text))
            {
                lbl_Array_errorLabel.Text = "Array List Is Empty, Please Add Some Values.";

            }
            lbx_ArrayList.Items.Clear();
            alist1.Sort();
            foreach (string element in alist1)
            {
                lbx_ArrayList.Items.Add(element);
                lbl_Array_errorLabel.Text = "You Can See Array List In Text Box";
            }
        }

        /*List */
        //----------------------------------------------------------------
        private void btn_AddL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_List.Text))
            {
                lbl_list_erroerLabel.Text = "Text box is empty." +
                    " Please enter a valid value.";
                flagErrorlist = false;
            }
            else
            {
                string value = txt_List.Text;
                bool isDuplicate = false;
                foreach (string element in scoreList)
                {
                    if (value == element)
                    {
                        lbl_list_erroerLabel.Text = "Duplicated Value." +
                        " Please enter a valid value.";
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    lbl_list_erroerLabel.Text =
                    txt_List.Text + " Is Added To Scoure List";
                    scoreList.Add(txt_List.Text);
                }
            }
            txt_List.Text = "";


        }

        /* remove button from list */

        private void btn_removeL_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_List.Text))
            {
                lbl_list_erroerLabel.Text = "Text box is empty." +
                    " Please enter a valid value.";
                flagErrorlist = false;
            }
            else
            {
                string value = txt_List.Text;
                bool isMatching = false;
                foreach (string element in scoreList)
                {
                    if (value == element)
                    {
                        isMatching = true;
                        break;
                    }
                }
                if (isMatching)
                {
                    scoreList.Remove(txt_List.Text);
                    lbl_list_erroerLabel.Text =
                    txt_List.Text + " Is Removed From List";

                }
                else
                {
                    lbl_list_erroerLabel.Text = "Score not found to remove";
                }
            }
            txt_List.Text = "";

        }
        /* display button list */
        private void btn_DisplatL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbx_List.Text))
            {
                lbl_list_erroerLabel.Text = "Scoure List Is Empty, Please Add Some Values.";

            }
            lbx_List.Items.Clear();

            scoreList.Sort();
            foreach (string element in scoreList)
            {
                lbx_List.Items.Add(element);
                lbl_list_erroerLabel.Text = "You Can See Score List In Text Box";
            }

        }

        private void txt_ArrayList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


