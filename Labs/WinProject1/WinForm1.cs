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

    }

    static void Main()
    {
        MyForm myForm = new MyForm();

        //Display the form.
        Application.Run(myForm);
    }
}
