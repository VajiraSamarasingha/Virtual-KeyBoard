using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualKeyBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

            
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void Alpabet(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(caps.Checked==true || leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send(btn.Text.ToUpper());
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send(btn.Text.ToLower());
            }
        }

        private void Num(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (numLock.Checked == true)
            {
                if (btn.Text.Equals("Enter"))
                {
                    SendKeys.Send("{ENTER}");
                }
                else
                {
                    SendKeys.Send(btn.Text);
                }
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if(leftShift.Checked==true || rightShift.Checked == true)
            {
                SendKeys.Send("{~}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{`}");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{!}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{@}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{#}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{3}");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{$}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{4}");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{%}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{5}");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{^}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{6}");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{&}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{7}");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{*}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{8}");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{(}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{9}");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{)}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{0}");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{_}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (leftShift.Checked == true || rightShift.Checked == true)
            {
                SendKeys.Send("{+}");
                leftShift.Checked = false;
                rightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{=}");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BKSP}");
        }

        private void button91_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void button90_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void button89_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void button88_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void button87_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void button86_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void button85_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void button84_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void button83_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void button82_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void button81_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void button79_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        Boolean blink = false;

        private void caps_CheckedChanged(object sender, EventArgs e)
        {

            timer1.Interval = 300;
            timer1.Start();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            SendKeys.Send("{CAPSLOCK}");

            
        }

        private void leftShift_CheckedChanged(object sender, EventArgs e)
        {
            timer4.Interval = 300;
            timer4.Start();
            timer1.Stop();
            timer3.Stop();
            timer5.Stop();

            SendKeys.Send("+");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send("%");
        }

        private void rightShift_CheckedChanged(object sender, EventArgs e)
        {
            timer5.Interval = 300;
            timer5.Start();
            timer1.Stop();
            timer3.Stop();
            timer4.Stop();

            SendKeys.Send("+");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer3.Interval = 300;
            timer3.Start();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (blink)
            {
                indicate2.BackColor = Color.Blue;
                indicate2.BackColor = Color.White;
            }
            else
            {
                indicate2.BackColor = Color.White;
                indicate2.BackColor = Color.Blue;
            }
            blink = !blink;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (blink)
            {
                indicate4.BackColor = Color.Red;
                indicate4.BackColor = Color.White;
            }
            else
            {
                indicate4.BackColor = Color.White;
                indicate4.BackColor = Color.Red;
            }
            blink = !blink;
        }

        private void indicate1_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (blink)
            {
                indicate1.BackColor = Color.Blue;
                indicate1.ForeColor = Color.Red;
                indicate1.BackColor = Color.White;
                indicate1.ForeColor = Color.Blue;
            }
            else
            {
                indicate1.BackColor = Color.White;
                indicate1.ForeColor = Color.Blue;
                indicate1.BackColor = Color.Blue;
                indicate1.ForeColor = Color.Red;
            }
            blink = !blink;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (blink)
            {
                indicate3.BackColor = Color.Blue;
                indicate3.ForeColor = Color.Red;
                indicate3.BackColor = Color.White;
                indicate3.ForeColor = Color.Blue;
            }
            else
            {
                indicate3.BackColor = Color.White;
                indicate3.ForeColor = Color.Blue;
                indicate3.BackColor = Color.Blue;
                indicate3.ForeColor = Color.Red;
            }
            blink = !blink;
        }
    }
}
