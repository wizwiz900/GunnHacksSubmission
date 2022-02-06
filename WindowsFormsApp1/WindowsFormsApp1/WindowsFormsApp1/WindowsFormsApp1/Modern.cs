using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Modern : Form
    {
        PrivateFontCollection modFont = new PrivateFontCollection();
        string strName;
        string strContact;
        string strAddress;
        string strURL;
        string strComp;
        int color;
        int theme;
        Color bg;

        public Modern()
        {
            InitializeComponent();
            strName = Form1.strName;
            strContact = Form1.strContact;
            strAddress = Form1.strAddress;
            strURL = Form1.strURL;
            strComp = Form1.strComp;
            color = Form1.color;
            theme = Form1.theme;


            switch (color)
            {
                case 0:
                    bg = System.Drawing.ColorTranslator.FromHtml("#AFE6FF");
                    picBack.Image = Properties.Resources.ModB;
                    break;

                case 1:
                    bg = System.Drawing.ColorTranslator.FromHtml("#FAD26B");
                    picBack.Image = Properties.Resources.ModG;
                    break;

                case 2:
                    bg = System.Drawing.ColorTranslator.FromHtml("#FFCDCD");
                    picBack.Image = Properties.Resources.ModP;
                    break;
            }
        }

        private void Modern_Load(object sender, EventArgs e)
        {
            modFont.AddFontFile("Courgette-Regular.ttf");
            modFont.AddFontFile("Ubuntu-Regular.ttf");
            label1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            label1.Font = new Font(modFont.Families[0], 20);
            label1.Text = strComp;

            label2.BackColor = bg;
            label2.Font = new Font(modFont.Families[1], 20);
            label2.Text = "My Name Is: \n" + strName;

            label3.BackColor = bg;
            label3.Font = new Font(modFont.Families[1], 20);
            label3.Left = label2.Left;
            label3.Top = label2.Top + label2.Height + 20;
            label3.Text = "Please Contact Me At: \n" + strContact;

            label4.BackColor = bg;
            label4.Font = new Font(modFont.Families[1], 20);
            label4.Left = label3.Left;
            label4.Top = label3.Top + label3.Height + 20;
            label4.Text = "Or Find Me At: \n" + strAddress;
        }
    }
}
