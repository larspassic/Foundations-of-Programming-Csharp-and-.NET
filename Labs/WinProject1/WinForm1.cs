using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    public MyForm()
    {
        //Change the caption of the application.
        Text = "Hello World";
        BackColor = System.Drawing.Color.Red;
        MinimizeBox = false;
        //TransparencyKey = System.Drawing.Color.Red;
        Opacity = .25;
        //WindowState = FormWindowState.Maximized;
        WindowState = FormWindowState.Normal;
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(1280, 720);
    }

    static void Main()
    {
        MyForm myForm = new MyForm();

        //Display the form.
        Application.Run(myForm);
    }
}
