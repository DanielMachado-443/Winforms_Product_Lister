using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using WindowsFormsApp3.Entities;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private SoundPlayer bigSoundPlayer; // CRIO UMA PROPRIEDADE QUE É UM OBJETO DA CLASSE SoundPlayer     

        public Form1() // class entry point
        {
            InitializeComponent();
            bigSoundPlayer = new SoundPlayer("BillyIdol.wav"); // INSTANCIO UM OBJETO DA CLASSE DA PROPRIEDADE           
            this.ActiveControl = Name;                       // It need to be instanced in the constructor, dont know why AFTER MONTHS NOW I KNOW
            Name.Focus();            
        }

        public string LabelText  // creating a PROPERTY form1 label to be called easily in other forms
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        List<Product> LProduct = new List<Product>();        
        string PName = "";
        double PPrice = 0.0;
        int PQuantity1 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            bigSoundPlayer.Play();            
        }

        private void button1_Click(object sender, EventArgs e) // i get this object kkkkkk Everything is a subset of object
        {
            if (UserName.Text == "Daniel" && Password.Text == "3126")
            {
                new Form2().Show();
                this.Hide();
            }
        }                                   
                
        private void button3_Click(object sender, EventArgs e)
        {        
            PName = Name.Text;            
            PPrice = double.Parse(Price1.Text);
            PQuantity1 = int.Parse(Quantity.Text);

            Name.Clear();  // interesting
            Price1.Clear();
            Quantity.Clear();

            LProduct.Add(new Product(PName, PPrice, PQuantity1));

            int PrdtCount = LProduct.Count - 1;            

            for (int i = 0; i < PrdtCount + 1; i++)
            {                                             
                if (i == PrdtCount)
                {
                    label2.Text += LProduct[i].ToString();
                }                                  
            }                                                  
        }       

        private void OpenForm_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);
            frm.Show();
            this.Hide();            
        }                             

        private void Play_Click(object sender, EventArgs e)
        {
            bigSoundPlayer.Play();            
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            bigSoundPlayer.Stop();           
        }                

        private void Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {                
                PName = Name.Text;
                PPrice = double.Parse(Price1.Text);
                PQuantity1 = int.Parse(Quantity.Text);

                Name.Clear();  // interesting
                Price1.Clear();
                Quantity.Clear();
                Name.Focus();

                LProduct.Add(new Product(PName, PPrice, PQuantity1));

                int PrdtCount = LProduct.Count - 1;                               

                for (int i = 0; i < PrdtCount + 1; i++)
                {
                    if (i == PrdtCount)
                    {
                        label2.Text += LProduct[i].ToString();
                    }
                }                
            }
        }
    }
}
