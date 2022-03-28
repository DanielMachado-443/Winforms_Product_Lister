namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Price1 = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.PName1 = new System.Windows.Forms.Label();
            this.PPrice1 = new System.Windows.Forms.Label();
            this.thatQuantity = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.OpenForm = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(367, 348);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(377, 20);
            this.UserName.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(367, 421);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(377, 20);
            this.Password.TabIndex = 1;
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.ForeColor = System.Drawing.Color.White;
            this.Text2.Location = new System.Drawing.Point(367, 376);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(377, 42);
            this.Text2.TabIndex = 3;
            this.Text2.Text = "Password";
            this.Text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.ForeColor = System.Drawing.Color.White;
            this.Text1.Location = new System.Drawing.Point(367, 303);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(377, 42);
            this.Text1.TabIndex = 4;
            this.Text1.Text = "Loggin";
            this.Text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 93);
            this.button1.TabIndex = 5;
            this.button1.Text = "Loggin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(112, 72);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(327, 20);
            this.Name.TabIndex = 6;
            // 
            // Price1
            // 
            this.Price1.Location = new System.Drawing.Point(112, 103);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(327, 20);
            this.Price1.TabIndex = 7;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(112, 137);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(327, 20);
            this.Quantity.TabIndex = 8;            
            this.Quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Quantity_KeyDown);
            // 
            // PName1
            // 
            this.PName1.AutoSize = true;
            this.PName1.BackColor = System.Drawing.Color.Transparent;
            this.PName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName1.ForeColor = System.Drawing.Color.White;
            this.PName1.Location = new System.Drawing.Point(31, 72);
            this.PName1.Name = "PName1";
            this.PName1.Size = new System.Drawing.Size(45, 17);
            this.PName1.TabIndex = 9;
            this.PName1.Text = "Name";
            // 
            // PPrice1
            // 
            this.PPrice1.AutoSize = true;
            this.PPrice1.BackColor = System.Drawing.Color.Transparent;
            this.PPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPrice1.ForeColor = System.Drawing.Color.White;
            this.PPrice1.Location = new System.Drawing.Point(31, 103);
            this.PPrice1.Name = "PPrice1";
            this.PPrice1.Size = new System.Drawing.Size(40, 17);
            this.PPrice1.TabIndex = 11;
            this.PPrice1.Text = "Price";
            // 
            // thatQuantity
            // 
            this.thatQuantity.AutoSize = true;
            this.thatQuantity.BackColor = System.Drawing.Color.Transparent;
            this.thatQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thatQuantity.ForeColor = System.Drawing.Color.White;
            this.thatQuantity.Location = new System.Drawing.Point(31, 137);
            this.thatQuantity.Name = "thatQuantity";
            this.thatQuantity.Size = new System.Drawing.Size(61, 17);
            this.thatQuantity.TabIndex = 15;
            this.thatQuantity.Text = "Quantity";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(150, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 63);
            this.button2.TabIndex = 16;
            this.button2.Text = "Product";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(466, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 151);
            this.label2.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(346, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 54);
            this.button3.TabIndex = 18;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OpenForm
            // 
            this.OpenForm.BackColor = System.Drawing.Color.DimGray;
            this.OpenForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenForm.ForeColor = System.Drawing.Color.White;
            this.OpenForm.Location = new System.Drawing.Point(25, 256);
            this.OpenForm.Name = "OpenForm";
            this.OpenForm.Size = new System.Drawing.Size(249, 93);
            this.OpenForm.TabIndex = 19;
            this.OpenForm.Text = "Open View";
            this.OpenForm.UseVisualStyleBackColor = false;
            this.OpenForm.Click += new System.EventHandler(this.OpenForm_Click);
            // 
            // Play
            // 
            this.Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Play.BackColor = System.Drawing.Color.DimGray;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Location = new System.Drawing.Point(558, 94);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(90, 60);
            this.Play.TabIndex = 21;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.DimGray;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(654, 94);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(90, 60);
            this.Stop.TabIndex = 22;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.OpenForm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.thatQuantity);
            this.Controls.Add(this.PPrice1);
            this.Controls.Add(this.PName1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);            
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Price1;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label PName1;
        private System.Windows.Forms.Label PQuantity;
        private System.Windows.Forms.Label PPrice1;
        private System.Windows.Forms.Label thatQuantity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OpenForm;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
    }
}

