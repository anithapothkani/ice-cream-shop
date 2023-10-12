using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ice_cream_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseClick += mouseClick;
            pictureBox2.MouseClick += mouseClick;
            pictureBox3.MouseClick += mouseClick;
            pictureBox4.MouseClick += mouseClick;
            pictureBox5.MouseClick += mouseClick;
            pictureBox6.MouseClick += mouseClick;
            pictureBox7.MouseClick += mouseClick;

                               

        }
        int price;
        string name;
        int qty;
        int total;



        private void mouseClick(object sender, MouseEventArgs e)
        {

            

            var clickpic = (PictureBox)sender;

            if(clickpic == pictureBox1)
            {
                name = "choclate";
                price = 20;
                qty = int.Parse(Interaction.InputBox("Enter the Qty ?", "Qty", ""));


            }

             else if (clickpic == pictureBox2)
            {
                name = "strawberry";
                price = 25;
                qty = int.Parse(Interaction.InputBox("Enter the Qty ?", "Qty", ""));


            }

             else  if (clickpic == pictureBox3)
            {
                name = "vanila";
                price = 30;
                qty = int.Parse(Interaction.InputBox("Enter the Qty ?", "Qty", ""));


            }
              else  if (clickpic == pictureBox4)
            {
                name = "butter scotch";
                price = 35;
                qty = int.Parse(Interaction.InputBox("Enter the Qty ?", "Qty", ""));


            }
                 else  if (clickpic == pictureBox5)
            {
                name = "orange juice";
                price = 25;
                qty = int.Parse(Interaction.InputBox("Enter the Qty ?", "Qty", ""));


            }
             else  if (clickpic == pictureBox6)
            {
                name = "mint juice";
                price = 30;
                qty = int.Parse(Interaction.InputBox("Enter the Qty ?", "Qty", ""));


            }
           else if (clickpic == pictureBox7)
            {
                name = "coca cola";
                price = 35;
                qty = int.Parse(Interaction.InputBox("Enter the Qty ?", "Qty", ""));


            }

            total = price * qty;
            this.dataGridView1.Rows.Add(name, price, qty, total.ToString());
            int sum = 0;
            for(int row =0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
                    
            }

            txtsum.Text = sum.ToString();






        }




        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
