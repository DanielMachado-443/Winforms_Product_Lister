using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {        
        public Form3()
        {            
            InitializeComponent();
        }               

        private Form1 mainForm = null;        
                
        public Form3(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();            
        }                                

        private void Form3_Load(object sender, EventArgs e)
        {                                             
            textBox1.Text = mainForm.LabelText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
