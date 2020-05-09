using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NPC_Lore_Generator
{


    public partial class Form1 : Form
    {
        public static Form1 kludge;
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
            InitializeComponent();
            kludge = this;
            Generator generator = new Generator();
        }


        // Window Form Dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]      public static extern bool ReleaseCapture();


        private void Form1_Load(object sender, EventArgs e)
        {
            Generator generator = new Generator();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool flip = false;
        private void button7_Click(object sender, EventArgs e)
        {
            if (flip == false)
            {
                this.WindowState = FormWindowState.Maximized;
                flip = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                flip = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /*protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            e.Graphics.FillRectangle(Brushes.Tan, Top);
            e.Graphics.FillRectangle(Brushes.Tan, Left);
            e.Graphics.FillRectangle(Brushes.Tan, Right);
            e.Graphics.FillRectangle(Brushes.Tan, Bottom);
        }*/

        // Window Dragging
        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;
        const int _ = 10; 
        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        // Sliding buttons function
        /*void slider()
        {
            if (isClosed == true)
            {
                sliderDropDown.Height += 10;
                if (sliderDropDown.Size == sliderDropDown.MaximumSize)
                {
                    timer1.Stop();
                    //isClosed = false; 
                }  
            }
            else
            {
                sliderDropDown.Height -= 10;
                if (sliderDropDown.Size == sliderDropDown.MinimumSize)
                {
                    timer1.Stop();
                    //isClosed = true;
                }  
            }
        }*/

        private Panel sliderDropDown;
        private bool isClosed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //slider();
            if (isClosed == true)
            {
                sliderDropDown.Height += 10;
                if (sliderDropDown.Size == sliderDropDown.MaximumSize)
                {
                    timer1.Stop();
                }
            }
            else
            {
                sliderDropDown.Height -= 10;
                if (sliderDropDown.Size == sliderDropDown.MinimumSize)
                {
                    timer1.Stop();
                }
            }
        }





        bool FlipFlop_Button2 = false;
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            FlipFlop_Button2 = !FlipFlop_Button2;
            this.isClosed = FlipFlop_Button2;
            sliderDropDown = this.panelDropDown_0;
            timer1.Start();

            /* // slider adjust
            sliderDropDown = this.flowLayoutPanel2;
            timer1.Start();*/

            // Change starting button text
            if (FlipFlop_Button2 == false)
            {
                button2.Text = "Open";


                /*flowLayoutPanel1.AutoScroll = false;
                flowLayoutPanel1.VerticalScroll.Enabled = false;
                flowLayoutPanel1.HorizontalScroll.Enabled = false;*/

                flowLayoutPanel1.AutoScroll = false;
                //richTextBox1.Visible = true;


            }
            else
            {
                button2.Text = "Close";
                flowLayoutPanel1.AutoScroll = true;

            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //sliderDropDown = this.panelDropDown_1;
            //timer1.Start();
        }

        bool FlipFlop_Button1 = false;
        private void button1_Click_2(object sender, EventArgs e)
        {
            FlipFlop_Button1 = !FlipFlop_Button1;
            this.isClosed = FlipFlop_Button1;
            //sliderDropDown = this.flowLayoutPanel2;
            sliderDropDown = this.panel2;
            timer1.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.VerticalScroll.Enabled = false;
           // flowLayoutPanel1.HorizontalScroll.Visible = false;
            //flowLayoutPanel1.HorizontalScroll.Enabled = false;
            //flowLayoutPanel1.AutoScroll = true;
        }

        private void panelDropDown_0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //this.trackBar1.Visible = false;  // You can disable visibility and draw over.
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Full Character Name";
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Character Race";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Age";
            }
        }

        bool FlipFlop_Button3 = false;
        private void button3_Click(object sender, EventArgs e)
        {
            FlipFlop_Button3 = !FlipFlop_Button3;
            this.isClosed = FlipFlop_Button3;
            this.sliderDropDown = panel5;
            timer1.Start();
        }

        bool FlipFlop_Button4 = false;
        private void button4_Click_3(object sender, EventArgs e)
        {
            FlipFlop_Button4 = !FlipFlop_Button4;
            this.isClosed = FlipFlop_Button4;
            this.sliderDropDown = panel6;
            timer1.Start();
        }

        bool FlipFlop_Button5 = false;
        private void button5_Click_2(object sender, EventArgs e)
        {
            FlipFlop_Button5 = !FlipFlop_Button5;
            this.isClosed = FlipFlop_Button5;
            this.sliderDropDown = panel7;
            timer1.Start();
        }

        bool FlipFlop_Button6 = false;
        private void button6_Click(object sender, EventArgs e)
        {
            FlipFlop_Button6 = !FlipFlop_Button6;
            this.isClosed = FlipFlop_Button6;
            this.sliderDropDown = panel8;
            timer1.Start();
        }

        bool FlipFlop_Button10 = false;
        private void button10_Click(object sender, EventArgs e)
        {
            FlipFlop_Button10 = !FlipFlop_Button10;
            this.isClosed = FlipFlop_Button10;
            this.sliderDropDown = panel9;
            timer1.Start();
        }

        private void customTrackBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void customTrackBarSmall1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void customTrackBarSmall1_MouseCaptureChanged(object sender, EventArgs e)
        {
            switch (customTrackBarSmall1.currentTickPosition)
            {
                case 0:
                    label20.Text = "1 Stage";
                    break;
                case 1:
                    label20.Text = "1-2 Stages";
                    break;
                case 2:
                    label20.Text = "1-3 Stages";
                    break;
                case 3:
                    label20.Text = "1-4 Stages";
                    break;
                case 4:
                    label20.Text = "1-5 Stages";
                    break;
            }
        }

        private void customTrackBar0_MouseCaptureChanged(object sender, EventArgs e)
        {
            switch (customTrackBar0.currentTickPosition)
            {
                case 0:
                    label8.Text = "Random";
                    break;
                case 1:
                    label8.Text = "Desert";
                    break;
                case 2:
                    label8.Text = "Coast";
                    break;
                case 3:
                    label8.Text = "Forests";
                    break;
                case 4:
                    label8.Text = "Steppe";
                    break;
                case 5:
                    label8.Text = "Grassland";
                    break;
                case 6:
                    label8.Text = "Rainforest";
                    break;
                case 7:
                    label8.Text = "Mountains";
                    break;
                case 8:
                    label8.Text = "Islands";
                    break;
                case 9:
                    label8.Text = "Tundra";
                    break;
            }
        }

        private void customTrackBar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (customTrackBar1.currentTickPosition == 0)
            {
                label21.Text = "Random";
            }
            else label21.Text = "     " + customTrackBar1.currentTickPosition.ToString();
        }

        private void customTrackBar2_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (customTrackBar2.currentTickPosition == 0)
            {
                label24.Text = "Random";
            }
            else label24.Text = "     " + customTrackBar2.currentTickPosition.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Clear();

            Generator.Receiver receiver = new Generator.Receiver(customTrackBar0.currentTickPosition);
            Generator.GenerateHandler phase1Handler = new Generator.Phase1Handler();

            phase1Handler.Handle(receiver);

        }



        /*public void TextUpdate(string message)
        {
            richTextBox2.Text += message;
        }*/






        // Window resizing
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
        protected override void WndProc(ref Message message)
        {

            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }






        /*
        // Generator
        public class Receiver
        {
            public int Condition { get; set; }
            public Receiver(int condition)
            {
                Condition = condition;
            }
        }

        // Responsibility Chain
        abstract class GenerateHandler
        {
            public GenerateHandler Successor { get; set; }
            public abstract void Handle(Receiver receiver);
        }

        // Phase 1 generate
        class Phase1Handler : GenerateHandler
        {
            public override void Handle(Receiver receiver)
            {
                if (receiver.Condition == 0)
                {
                    Form1._Form1.richTextBox2.Text = "YOU FAKIN SHIT NET FRAMEWORK KYS DEVS PLS";
                }
                else
                {
                    Form1._Form1.richTextBox2.Text = "KYS DEVS OF NETFRAMEWORK";
                }

                // throw new NotImplementedException();
                if (Successor != null)
                    Successor.Handle(receiver);
            }
        }*/



    }
}
