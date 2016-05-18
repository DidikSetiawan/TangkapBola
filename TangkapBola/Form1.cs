using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TangkapBola
{
    public partial class Form1 : Form
    {
        int speed = 5;
        int moveX ;
        int moveY ;
        objectgame bola;
        objectgame palang;

        List<objecttarget> bata;
        List<Button> listbutton; 

        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            InitBata();
            bola = new objectgame(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
            palang = new objectgame(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
            moveX = moveY = speed; 
            timer.Enabled = false;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
        }

        private void InitBata()
        {
            listbutton = new List<Button>(); 

            listbutton.Add(button2);
            listbutton.Add(button3);
            listbutton.Add(button4);
            listbutton.Add(button5); 
            listbutton.Add(button6);
            listbutton.Add(button7);
            listbutton.Add(button8);
            listbutton.Add(button9);
            listbutton.Add(button10);
            listbutton.Add(button11);
            listbutton.Add(button12);
            listbutton.Add(button13);
            listbutton.Add(button14);
            listbutton.Add(button15);
            listbutton.Add(button16);
            listbutton.Add(button17);
            listbutton.Add(button18);
            listbutton.Add(button19);

            bata = new List<objecttarget>(); 
            foreach (Button itembutton in listbutton)
            {
                bata.Add(new objecttarget(itembutton.Location.X, itembutton.Location.Y, itembutton.Size.Width, itembutton.Size.Height));
            }
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 109)
            {
                moveX = (moveX - (moveX / Math.Abs(moveX)));
                moveY = (moveY - (moveY / Math.Abs(moveY)));
            }
            if (e.KeyValue == 107)
            {
                moveX = moveX + (moveX / Math.Abs(moveX));
                moveY = moveY + (moveY / Math.Abs(moveY));
            }
            if (e.KeyCode == Keys.D) 
            {
                if (palang.X + palang.P <= this.Width - 25) palang.X += 20; 
            }
            if (e.KeyCode == Keys.A)
            {
                if (palang.X >= 21) palang.X -= 20;
            }
            this.button1.Location = new Point(palang.X, palang.Y);
            if (e.KeyCode == Keys.Space)
            {
                timer.Enabled = !timer.Enabled;                
            }
            if (e.KeyCode == Keys.R)
            {
                moveX = moveY = speed;
                timer.Enabled = false;
                timer.Interval = 200;
            }
        }

        private void timer_Tick(Object sender, EventArgs e)
        {
            GerakinBola();
        }

        private void GerakinBola()
        {
            if (timer.Enabled == false) return; 

            //nyentuh ujung kiri 
            if (bola.X <= 1 || bola.X + bola.P +5 >= this.Width )
            {
                moveX = -1 * moveX;
            }

            for(int i=0; i<=bata.Count-1 ;i++) 
            {
                if (bola.Y <= bata[i].Y2 && bola.X >= bata[i].X && bola.X2 <= bata[i].X2 && bata[i].kena == false)
                {
                    moveY = -1 * moveY;
                    bata[i].kena = true;
                    listbutton[i].Visible = false;
                    
                }
            }
            
            if (bola.Y2 + 15 >= this.Height || bola.Y <= 1 || (bola.Y2 + 5 >= palang.Y && bola.X >= palang.X && bola.X2 <= palang.X2))
            {
                moveY = -1 * moveY;
            }

            bola.X = bola.X + moveX;
            bola.Y = bola.Y + moveY;
            pictureBox1.Location = new Point(bola.X, bola.Y); 
        }
    }
}