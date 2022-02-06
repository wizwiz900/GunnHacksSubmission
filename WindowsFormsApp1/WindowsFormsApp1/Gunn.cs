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
    public partial class Gunn : Form
    {
        string strName;
        string strContact;
        string strAddress;
        string strURL;
        string strComp;
        int color;
        int theme;

        public Gunn()
        {
            InitializeComponent();
            strName = Form1.strName;
            strContact = Form1.strContact;
            strAddress = Form1.strAddress;
            strURL = Form1.strURL;
            strComp = Form1.strComp;
            color = Form1.color;
            theme = Form1.theme;
        }
        private void Gunn_Load(object sender, EventArgs e)
        {

        }
    }
}
