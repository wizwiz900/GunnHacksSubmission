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
    public partial class Classy : Form
    {
        PrivateFontCollection classFont = new PrivateFontCollection();
        string strName;
        string strContact;
        string strAddress;
        string strURL;
        string strComp;
        int color;
        int theme;
        Color bg;

        public Classy()
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
                    picBack.Image = Properties.Resources.clasbgB;
                    break;

                case 1:
                    bg = System.Drawing.ColorTranslator.FromHtml("#FAD26B");
                    picBack.Image = Properties.Resources.clasbgG;
                    break;

                case 2:
                    bg = System.Drawing.ColorTranslator.FromHtml("#FFCDCD");
                    picBack.Image = Properties.Resources.clasbgP;
                    break;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            classFont.AddFontFile("BodoniModa.ttf");
            classFont.AddFontFile("MontserratAlternates-LightItalic.ttf");
            label1.BackColor = bg;
            label1.Font = new Font(classFont.Families[0], 40);
            label1.Text = strComp;

            label2.BackColor = bg;
            label2.Font = new Font(classFont.Families[1], 32);
            label2.Text = strName;
            label2.Left = label1.Left;
            label2.Top = label1.Location.Y - label1.Height-150;

            label3.BackColor = bg;
            label3.Font = new Font(classFont.Families[1], 13);
            label3.Text = strURL;
            label3.Top = label1.Bottom ;
            label3.Left = label1.Left + 60;

            label4.BackColor = bg;
            label4.Font = new Font(classFont.Families[0], 14);
            label4.Text = "Contact: " + strContact;
            label4.Top = label2.Bottom - 5;
            label4.Left = label2.Left+30;

            label5.BackColor = bg;
            label5.Font = new Font(classFont.Families[0], 14);
            label5.Text = "Address: " + strAddress;
            label5.Top = label4.Bottom +10;
            label5.Left = label2.Left + 30;
        }
    }
}
