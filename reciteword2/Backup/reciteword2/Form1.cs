using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace reciteword2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox3.Items.AddRange(new object[] { "闭着眼睛飘单词iii1_05_new.mp3", "闭着眼睛飘单词iii1_06_new.mp3", "蔡依林-听说爱情回来过.mp3" });
            this.skinEngine1.SkinFile = "Diamondgreen.ssk";
            listBox3.SelectedIndex = 0;
            string x = (Directory.GetCurrentDirectory()).ToString();
            label9.Text = x;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (; groupBox3.Left  >= 0;groupBox3 .Left -- )
                groupBox3.Left -= 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (radioButton1.Checked == true)
            {
                label1.Text = "单词";
                
            }
           
          else  if (radioButton2.Checked == true)
            {
                label1.Text = "word";
               
            }
            for (a = 11; a >= 0; a--)
            {
                c = x.rd.Next(0, a);
                d += 1;
                x.cmiddle[d] = x.chinese[c];
                x.emiddle[d] = x.english[c];
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (; groupBox3.Left  <=437; groupBox3 .Left ++)
                groupBox3 .Left += 2;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = false;
            button1.Enabled = false;
        }
        
        
        
       //背单词 
        public static int a, b, c, d =-1, t = 15, f = 0, g=0,m=-1;
        private void timer3_Tick(object sender, EventArgs e)
        { 
            t -= 1;
            label2.Text = t.ToString();

            if (t == 0 && radioButton1.Checked == true)
            {
                m += 1;
                x.unknowcword[m] = x.cmiddle[f];
                x.unknoweword[m] = x.emiddle[f];
                
                
                listBox2.Items.Add(x.cmiddle [f]+"        "+x.emiddle [f]);
                listBox1.Items.Add(x.emiddle [f]);
                f += 1;
                label1.Text = x.cmiddle[f];
                if (f == 9)
                    timer3.Enabled = false;
                t = 15;

            }

            if (t == 0 && radioButton2.Checked == true)
            {
                m += 1;
                x.unknowcword[m] = x.cmiddle[f];
                x.unknoweword[m] = x.emiddle[f];


                listBox2.Items.Add(x.emiddle[f] + "        " + x.cmiddle[f]);
                listBox1.Items.Add(x.cmiddle[f]);
                f += 1;
                label1.Text = x.emiddle[f];
                if (f == 9)
                    timer3.Enabled = false;
                t = 15;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = x.cmiddle[0];
               // label5.Text = x.emiddle[0];
            }
            if (radioButton2.Checked == true)
                label1.Text = x.emiddle[0];
            timer3.Enabled = true;
            
        }
        //int n = -1;
       // int  m = -1;
        private void button5_Click(object sender, EventArgs e)
        {

           
            
            if (radioButton1.Checked == true&&f<=9)
                {
                    

                    if (textBox1.Text == x.emiddle[f])
                    {
                        g += 10;
                        label5.Text = "得分" + g.ToString() + "/100";
                        textBox1.Clear();
                       
                    }
                    else if (textBox1.Text != x.emiddle[f])
                    {
                        listBox1.Items.Add(x.emiddle[f]);
                        listBox2.Items.Add(x.cmiddle[f] + "        " + x.emiddle[f]);
                        m += 1;
                        x.unknowcword[m] = x.cmiddle[f];
                        x.unknoweword[m] = x.emiddle[f];
                        textBox1.Clear();
                    }
                    
                    label1.Text = x.cmiddle[ f+1];
                    f += 1;
                }
                
            
            
            else if (radioButton2.Checked == true && f <= 9)
                {
                    
                    
                    if (textBox1.Text == x.cmiddle[f])
                    {
                        g += 10;
                        label5.Text = "得分" + g.ToString() + "/100";
                        textBox1.Clear();

                    }
                    else if (textBox1.Text != x.cmiddle[f])
                    {
                        listBox1.Items.Add(x.cmiddle[f]);
                        listBox2.Items.Add(x.emiddle[f] + "        " + x.cmiddle[f]);
                        m += 1;
                        x.unknowcword2[m] = x.cmiddle[f];
                        x.unknoweword2[m] = x.emiddle[f];
                        textBox1.Clear();
                    }
                    label1.Text = x.emiddle[ f+1];
                    f += 1;
                }
            t = 15;
             if(f==10)
            {
                label1.Text = "测试完毕";
                label2.Text = "15";
                button5.Enabled = false;
                timer3.Enabled = false;
            }
            
            }


        //生词本
        int q = 20, h =0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            q-= 1;
            label4 .Text =q.ToString();
            if (label3.Text == x.unknowcword[h] && q == 0)
            {
                listBox2.Items.Add(x.unknoweword[h]);
                h += 1;
                if (h ==m)
                    timer4.Enabled = false;
                label3.Text = x.unknowcword[h];
                q = 20;

            }
            if (label3.Text == x.unknoweword2[h] && q == 0)
            {
                listBox2.Items.Add(x.unknowcword2 [h]);
                h += 1;
                if (h == m)
                    timer4.Enabled = false;
                label3.Text = x.unknoweword2[h];
                q = 20;

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            if (radioButton1.Checked == true)
                label3.Text = x.unknowcword[0];
            if (radioButton2.Checked == true)
                label3.Text = x.unknoweword2[0];
            listBox2.Items.Clear();
            
        }
        int s = 0;
        private void button6_Click(object sender, EventArgs e)
        {


            if (label3 .Text ==x.unknowcword [h] &&h <= m)
            {


                if (textBox2.Text == x.unknoweword [h])
                {
                    s+= 10;
                    label6.Text = "得分" + s.ToString() + "/"+((m+1)*10).ToString ();
                    textBox2.Clear();

                }
                else if (textBox2.Text != x.unknoweword[h])
                {
                    listBox2.Items.Add(x.unknoweword [h]);
                    textBox2.Clear();
                }
                label3.Text = x.unknowcword[ h+1];

                h += 1;
                
            }



            else if (label3 .Text ==x.unknoweword2 [h] && h<=m)
            {



                if (textBox2.Text == x.unknowcword2[h])
                {
                    g += 10;
                    label6.Text = "得分" + g.ToString() + "/" + ((m+1) * 10).ToString();
                    textBox2.Clear();

                }
                else if (textBox2.Text != x.unknowcword2[h])
                {
                    listBox2.Items.Add(x.unknowcword2[h]);
                    textBox2.Clear();
                }
                label3.Text = x.unknoweword2[h + 1];
                h += 1;
            }
            q = 20;
            if (h == m)
            {
                label3.Text = "测试完毕";
                label4.Text = "20";
                button6.Enabled = false;
                timer4.Enabled = false;
            }

        }
        

          //英语单词听力      
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            x.filename = System.IO.Path.GetFileName(openFileDialog1 .FileName );
            x.openfilename = openFileDialog1.FileName;
            listBox3.Items.Add(x.filename );
         }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItem );
        }
       
        private void listen(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex<= 2)
            {
                string str = Directory.GetCurrentDirectory();
                str = str + "\\songs";
                string address = listBox3.SelectedItem.ToString();
                axWindowsMediaPlayer1.URL = str + "\\" + address;
            }
            if(listBox3 .SelectedIndex >2)
            axWindowsMediaPlayer1.URL = x.openfilename;
           
                           
        }





        //更改皮肤
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string skin = comboBox1.SelectedItem.ToString ();
            this.skinEngine1.SkinFile = skin + ".ssk";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        
                                   
        
        
    }
}
