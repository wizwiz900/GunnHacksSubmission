using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string strName;
        public static string strContact;
        public static string strAddress;
        public static string strURL;
        public static string strComp;
        public static int color;
        public static int theme;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {


                strName = txtName.Text;
                strContact = txtContact.Text;
                strAddress = txtAddy.Text;
                strURL = txtUrl.Text;
                strComp = txtComp.Text;

 



                    if (radGunn.Checked == false)
                    {
                        if (radBlue.Checked)
                        {
                            color = 0;
                        }
                        else if (radGold.Checked)
                        {
                            color = 1;
                        }
                        else
                        {
                            color = 2;
                        }

                        if (radClassy.Checked)
                        {
                            theme = 0;
                        }
                        else if (radSimple.Checked)
                        {
                            theme = 1;
                        }
                        else
                        {
                            theme = 2;
                        }

                    }
                    else
                    {
                        theme = 3;
                        color = -1;
                    }


                    switch (theme)
                    {
                        case 0:
                            var Classy = new Classy();
                            Classy.Show();
                            break;

                        case 1:
                            var Simple = new Simple();
                            Simple.Show();
                            break;

                        case 2:
                            var Modern = new Modern();
                            Modern.Show();
                            break;

                        case 3:
                        var Gunn = new Gunn();
                            Gunn.Show();
                            break;
                    }

            }
            catch
            {
                MessageBox.Show("An Error Occured! Make Sure your Information is Correctly Placed!");
            }


        }

        private void radGunn_CheckedChanged(object sender, EventArgs e)
        {
            if(radGunn.Checked)
            {
                gbxColor.Enabled = false;
            }
            else
            {
                gbxColor.Enabled = true;
            }
        }
    }
}
