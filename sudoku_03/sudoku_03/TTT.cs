using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace sudoku_03
{
    public partial class TTT : Form
    {
        public TTT()
        {
            InitializeComponent();
        }

        int moves = 1;
        string player_one ="X";//X is player 1 , Blue
        string player_two="O";//O is player 2 , Green
        string changetox()
        { 
            return player_one;

        }
        string changetoo()
        {
            return player_two;
        }/*
        bool isthereawinner()//atempt one
        {
              if(
              ( btn1.Text.Equals(btn2.Text) && (btn2.Text.Equals(btn3.Text)))||//
              ( btn4.Text.Equals(btn5.Text) && (btn5.Text.Equals(btn6.Text)))||//Horizontal winns
              ( btn7.Text.Equals(btn8.Text) && (btn8.Text.Equals(btn9.Text)))||//
               
              ( btn1.Text.Equals(btn4.Text) && (btn4.Text.Equals(btn7.Text)))||//
              ( btn2.Text.Equals(btn5.Text) && (btn5.Text.Equals(btn8.Text)))||//Vertical winns
              ( btn3.Text.Equals(btn6.Text) && (btn6.Text.Equals(btn9.Text)))||//

              ( btn1.Text.Equals(btn5.Text) && (btn5.Text.Equals(btn9.Text)))||//Diagonal winns
              ( btn3.Text.Equals(btn5.Text) && (btn5.Text.Equals(btn7.Text))) )//
                return true;
              else
            return false;
        }*/
        
        bool isthereawinner()//mod
        {
            if((btn1.Text.Equals(btn2.Text) && (btn2.Text.Equals(btn3.Text)) && (btn1.Text.Equals(btn3.Text)))) 
                          return true ;
            if((btn4.Text.Equals(btn5.Text) && (btn5.Text.Equals(btn6.Text)) && (btn4.Text.Equals(btn6.Text))))
                          return true;//Horizontal winns
            if ((btn7.Text.Equals(btn8.Text) && (btn8.Text.Equals(btn9.Text)) && (btn7.Text.Equals(btn9.Text)))) //error is in here
                          return true;
            if((btn1.Text.Equals(btn4.Text) && (btn4.Text.Equals(btn7.Text)) && (btn1.Text.Equals(btn7.Text))))
                          return true;
            if((btn2.Text.Equals(btn5.Text) && (btn5.Text.Equals(btn8.Text)) && (btn2.Text.Equals(btn8.Text))))
                          return true;//Vertical winns
            if((btn3.Text.Equals(btn6.Text) && (btn6.Text.Equals(btn9.Text)) && (btn3.Text.Equals(btn9.Text)))) //
                          return true;
            if((btn1.Text.Equals(btn5.Text) && (btn5.Text.Equals(btn9.Text)) && (btn1.Text.Equals(btn9.Text))))
                          return true;//Diagonal winns
            if((btn3.Text.Equals(btn5.Text) && (btn5.Text.Equals(btn7.Text)) && (btn3.Text.Equals(btn7.Text))))//
                return true;
           
            return false;
        }
        void resetgame()
        {

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            moves = 1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
                int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                    btn1.ForeColor = Color.Blue;
               
                btn1.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                   btn1.ForeColor = Color.Green;
                btn1.Text = changetoo();
            }
                //MessageBox.Show($"TOUCHED MOVES  are :-  {count}");
            if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn1.Text}  WON");
                resetgame();
            }
            //if (count>=5 && !isthereawinner())
              //  MessageBox.Show("The Game ended in a DRAW");
              //  btn1.Enabled=false;
                
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                btn2.ForeColor = Color.Blue;

                btn2.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                btn2.ForeColor = Color.Green;
                btn2.Text = changetoo();
            }
           // MessageBox.Show($"TOUCHED MOVES  are :-  {count}");

           if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn2.Text}  WON");
                resetgame();
            }
            //btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                btn3.ForeColor = Color.Blue;

                btn3.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                btn3.ForeColor = Color.Green;
                btn3.Text = changetoo();
            }
            //MessageBox.Show($"TOUCHED MOVES  are :-  {count}");
            if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn3.Text}  WON");
                resetgame();
            }
            //btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                btn4.ForeColor = Color.Blue;

                btn4.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                btn4.ForeColor = Color.Green;
                btn4.Text = changetoo();
            }
            //MessageBox.Show($"TOUCHED MOVES  are :-  {count}");
            if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn4.Text}  WON");
                resetgame();
            }
            //btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                btn5.ForeColor = Color.Blue;

                btn5.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                btn5.ForeColor = Color.Green;
                btn5.Text = changetoo();
            }
            // MessageBox.Show($"TOUCHED MOVES  are :-  {count}");
            if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn5.Text}  WON");
                resetgame();
            }
            //btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                btn6.ForeColor = Color.Blue;

                btn6.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                btn6.ForeColor = Color.Green;
                btn6.Text = changetoo();
            }
           // MessageBox.Show($"TOUCHED MOVES  are :-  {count}");
            if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn6.Text}  WON");
                resetgame();
            }
            //btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                btn7.ForeColor = Color.Blue;

                btn7.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                btn7.ForeColor = Color.Green;
                btn7.Text = changetoo();
            }
            //MessageBox.Show($"TOUCHED MOVES  are :-  {count}");
            if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn7.Text}  WON");
                resetgame();
            }
            //btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                btn8.ForeColor = Color.Blue;

                btn8.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                btn8.ForeColor = Color.Green;
                btn8.Text = changetoo();
            }
           // MessageBox.Show($"TOUCHED MOVES  are :-  {count}");
            if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn8.Text}  WON");
                resetgame();
            }
            //btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int count = moves++;
            if (count % 2 == 1)
            {
                string temp = changetox();
                btn9.ForeColor = Color.Blue;

                btn9.Text = changetox();
            }
            else
            {
                string temp = changetoo();
                btn9.ForeColor = Color.Green;
                btn9.Text = changetoo();
            }
            //MessageBox.Show($"TOUCHED MOVES  are :-  {count}");
            if (count >= 5 && isthereawinner())
            {
                MessageBox.Show($"PLAYER   {btn9.Text}  WON");
                resetgame();
            }
            //btn9.Enabled = false;
        }
    }
}