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

    public partial class Simple : Form
    {
        PrivateFontCollection simpFont = new PrivateFontCollection();
        string strName;
        string strContact;
        string strAddress;
        string strURL;
        string strComp;
        int color;
        Color bg;
        
        public Simple()
        {
            InitializeComponent();
            strName = Form1.strName;
            strContact = Form1.strContact;
            strAddress = Form1.strAddress;
            strURL = Form1.strURL;
            strComp = Form1.strComp;
            color = Form1.color;
  
            switch(color)
            {
                case 0:
                    bg = System.Drawing.ColorTranslator.FromHtml("#afe6ff");
                    break;

                case 1:
                    bg = System.Drawing.ColorTranslator.FromHtml("#FAD26B");
                    break;

                case 2:
                    bg = System.Drawing.ColorTranslator.FromHtml("#FFCDCD");
                    break;
            }

            BackColor = bg;
        }
        private void Simple_Load(object sender, EventArgs e)
        {
            simpFont.AddFontFile("Shrikhand-Regular.ttf");
            simpFont.AddFontFile("Spartan-VariableFont.ttf");
            label1.Font = new Font(simpFont.Families[0], 60);
            label1.Text = strComp;

            label2.Font = new Font(simpFont.Families[1], 20);
            label2.Left = label1.Location.X + 15;
            label2.Top = label1.Location.Y + label1.Height-10;
            label2.Text = "Hello! Im: " + strName;

            line.Top = label2.Location.Y + label2.Height + 15;

            label3.Font = new Font(simpFont.Families[1], 16);
            label3.Left = label1.Location.X + 25;
            label3.Top = line.Location.Y + line.Height + 20;
            label3.Text = "Contact Me Through: " + strContact;

            label4.Font = new Font(simpFont.Families[1], 16);
            label4.Left = label3.Location.X;
            label4.Top = label3.Location.Y + label3.Height + 10;
            label4.Text = "Located In: " + strAddress;

            label5.Font = new Font(simpFont.Families[1], 16);
            label5.Left = label4.Location.X;
            label5.Top = label4.Location.Y + label4.Height + 10;
            label5.Text = "Our Website: " + strURL;

            picPeople.Left = line.Location.X + line.Width - picPeople.Width;
            picPeople.Top = label3.Location.Y;
            
        }
    }
}
