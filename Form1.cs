using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        int KEY0 = 96;
        int KEY1 = 97;
        int KEY2 = 98;
        int KEY3 = 99;
        int KEY4 = 100;
        int KEY5 = 101;
        int KEY6 = 102;
        int KEY7 = 103;
        int KEY8 = 104;
        int KEY9 = 105;
        


        

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread TH = new Thread(Keybind);
           
            TH.Start();

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;

            button12.Visible = false;
        pictureBox1.Visible = false;


        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }




        private void Keybind()
        {

            while (true)
            {
      
                  Thread.Sleep(25);
                int Keystate0 = GetAsyncKeyState(KEY0);
                int Keystate1 = GetAsyncKeyState(KEY1);
                int Keystate2 = GetAsyncKeyState(KEY2);
                int Keystate3 = GetAsyncKeyState(KEY3);
                int Keystate4 = GetAsyncKeyState(KEY4);
                int Keystate5 = GetAsyncKeyState(KEY5);
                int Keystate6 = GetAsyncKeyState(KEY6);
                int Keystate7 = GetAsyncKeyState(KEY7);
                int Keystate8 = GetAsyncKeyState(KEY8);
                int Keystate9 = GetAsyncKeyState(KEY9);

                if (Keystate0 == 32769)
                {

                    if(Properties.Settings.Default.emot10 != "") {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e "+Properties.Settings.Default.emot10+"{ENTER}{F8}");
                    }
                 
                    
                }

                if (Keystate1 == 32769)
                {
                    if (Properties.Settings.Default.emot1 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot1 + "{ENTER}{F8}");
                    }
                }

                if (Keystate2 == 32769)
                {
                    if (Properties.Settings.Default.emot2 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot2 + "{ENTER}{F8}");
                    }
                }

                if (Keystate3 == 32769)
                {
                    if (Properties.Settings.Default.emot3 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot3 + "{ENTER}{F8}");
                    }

                }

                if (Keystate4 == 32769)
                {

                    if (Properties.Settings.Default.emot4 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot4 + "{ENTER}{F8}");
                    }
                }

                if (Keystate5 == 32769)
                {

                    if (Properties.Settings.Default.emot5 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot5 + "{ENTER}{F8}");
                    }
                }
                
                if (Keystate6 == 32769)
                {
                    if (Properties.Settings.Default.emot6 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot6 + "{ENTER}{F8}");
                    }

                }

                if (Keystate7 == 32769)
                {
                    if (Properties.Settings.Default.emot7 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot7 + "{ENTER}{F8}");
                    }

                }

                if (Keystate8 == 32769)
                {
                    if (Properties.Settings.Default.emot8 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot8 + "{ENTER}{F8}");
                    }

                }

                if (Keystate9 == 32769)
                {

                    if (Properties.Settings.Default.emot9 != "")
                    {
                        SendKeys.SendWait("{F8}");
                        Thread.Sleep(25);
                        SendKeys.SendWait("e " + Properties.Settings.Default.emot9 + "{ENTER}{F8}");
                    }
                }



            }
        }





        private void button1_Click(object sender, EventArgs e)
        {


         
            if (Properties.Settings.Default.emot1 != "") {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot1].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            

            button1.BackColor = Color.Green;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            comboBox1.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            comboBox1.Text = Properties.Settings.Default.emot1;



            button10.BackColor = Color.Black;

        }

     
      
        private void button4_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.emot4 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot4].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }

            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;

            comboBox4.Text = Properties.Settings.Default.emot4;
            comboBox4.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox1.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            
        }


        private void button10_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.emot10 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot10].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            comboBox10.Text = Properties.Settings.Default.emot10;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            comboBox10.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox1.Visible = false;

            button10.BackColor = Color.Green;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.emot2 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot2].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            comboBox2.Text = Properties.Settings.Default.emot2;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
            comboBox2.Visible = true;
            comboBox1.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.emot3 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot3].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            comboBox3.Text = Properties.Settings.Default.emot3;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
            comboBox3.Visible = true;
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.emot5 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot5].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }


            comboBox5.Text = Properties.Settings.Default.emot5;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;

            comboBox5.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox1.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.emot6 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot6].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            comboBox6.Text = Properties.Settings.Default.emot6;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
            comboBox6.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox1.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.emot7 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot7].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            comboBox7.Text = Properties.Settings.Default.emot7;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
            comboBox7.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox1.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.emot8 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot8].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            comboBox8.Text = Properties.Settings.Default.emot8;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
            comboBox8.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox1.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.emot9 != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: Properties.Settings.Default.emot9].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            comboBox9.Text = Properties.Settings.Default.emot9;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Green;
            button10.BackColor = Color.Black;
            comboBox9.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox1.Visible = false;
            comboBox10.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        button12.Visible = true;


            if (comboBox1.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox1.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }


        }

        

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {


            if(button1.BackColor == Color.Green){
                button12.Visible = false;
               
                Properties.Settings.Default.emot1 = comboBox1.Text;
                Properties.Settings.Default.Save();

                if (comboBox1.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox1.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }

            }
            if (button2.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot2 = comboBox2.Text;
                Properties.Settings.Default.Save();

                if (comboBox2.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox2.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            if (button3.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot3 = comboBox3.Text;
                Properties.Settings.Default.Save();
                if (comboBox3.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox3.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            if (button4.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot4 = comboBox4.Text;
                Properties.Settings.Default.Save();
                if (comboBox4.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox4.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            if (button5.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot5 = comboBox5.Text;
                Properties.Settings.Default.Save();
                if (comboBox5.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox5.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            if (button6.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot6 = comboBox6.Text;
                Properties.Settings.Default.Save();
                if (comboBox6.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox6.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            if (button7.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot7 = comboBox7.Text;
                Properties.Settings.Default.Save();
                if (comboBox7.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox7.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            if (button8.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot8 = comboBox8.Text;
                Properties.Settings.Default.Save();
                if (comboBox8.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox8.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            if (button9.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot9 = comboBox9.Text;
                Properties.Settings.Default.Save();
                if (comboBox9.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox9.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            if (button10.BackColor == Color.Green)
            {
                button12.Visible = false;

                Properties.Settings.Default.emot10 = comboBox10.Text;
                Properties.Settings.Default.Save();
                if (comboBox10.Text != "")
                {

                    pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox10.Text].ToString().Trim());
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }


        }

      

       


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;


            if (comboBox3.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox3.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }


        }


        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
            if (comboBox10.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox10.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
            if (comboBox2.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox2.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
            if (comboBox5.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox5.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
            if (comboBox4.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox4.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
            if (comboBox7.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox7.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
            if (comboBox9.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox9.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
            if (comboBox8.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox8.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
            if (comboBox6.Text != "")
            {

                pictureBox1.Load(Properties.Settings.Default[propertyName: comboBox6.Text].ToString().Trim());
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
      
       
       

        private void button14_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
            Environment.Exit(0);
            
        }
    }
}





