using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form2 : Form
    {
        private Form1 theForm;
        private Button button;

        public Form2()
        {
            InitializeComponent();
        }

        public void setEveryThing(Form1 myForm, Button theButton)
        {
            this.theForm = myForm;
            this.button = theButton;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            try
            {
                number = int.Parse(textBox1.Text);
                this.button.Text = (number + int.Parse(this.button.Text)).ToString();
            }
            catch (Exception ex) { }
        }
    }
}
