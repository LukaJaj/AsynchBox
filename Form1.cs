using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Button> clickedButtonsList = new List<Button>();    
        Button button = new Button();
        Button currentButton = new Button();
      
         public Form1()
        {
            InitializeComponent();
        }

      
        private  void Stop_Click(object sender, EventArgs e)
        { 

            button = Stop;
            Start.Enabled = true;
        }

        private async  void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
          
                button = Start;

                while (button == Start)
                {
                    foreach (var item in clickedButtonsList)
                    {
                        if (button != Stop)
                        {
                            currentButton = item;
                            Task task = new Task(() => item.BackColor = Color.Red);
                            task.Start();
                            await Task.Delay(1000);
                            item.BackColor = Color.LightGray;

                        }
                    }
                }
            
        }     
        private void button25_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button30);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button24);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button18);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button12);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickedButtonsList.Add(button1);

        }
    }
}
