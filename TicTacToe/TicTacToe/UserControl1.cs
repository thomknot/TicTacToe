using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class UserControl1 : UserControl
    {
       
        bool turn = true;// true = X, false = y turn
        int turn_count = 0;
        
        
        string win = "";

        public UserControl1()
        {
            InitializeComponent();
            Free_play.Checked = true;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
               b.Text = "O";
            turn = !turn;
            turn_count++;
           
            b.Enabled = false;
            b.BackColor = Color.Aquamarine;
            p1.Enabled = false;
            p2.Enabled = false;
            winnercheck();
            
        } // end button_click

        private void winnercheck()
            // to check winner
    {
       bool winner = false;

            // horizontal checks
       if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
       {
           A1.BackColor = Color.Coral;
           A2.BackColor = Color.Coral;
           A3.BackColor = Color.Coral;
           winner = true;
                  }
       else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
       {
           B1.BackColor = Color.Coral;
           B2.BackColor = Color.Coral;
           B3.BackColor = Color.Coral;
           winner = true;
       }
       else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
       {
           C1.BackColor = Color.Coral;
           C2.BackColor = Color.Coral;
           C3.BackColor = Color.Coral;
           winner = true;
       }
            // VERTICAL CHECKS
           if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
           {
               A1.BackColor = Color.Coral;
               B1.BackColor = Color.Coral;
               C1.BackColor = Color.Coral;
                winner = true;
             }
       else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
           {
               A2.BackColor = Color.Coral;
               B2.BackColor = Color.Coral;
               C2.BackColor = Color.Coral;
               winner = true;
           }

       else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
           {
               A3.BackColor = Color.Coral;
               B3.BackColor = Color.Coral;
               C3.BackColor = Color.Coral;
               winner = true;
           }

        // DIAGONAL CHECK
           if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
           {
               A1.BackColor = Color.Coral;
               B2.BackColor = Color.Coral;
               C3.BackColor = Color.Coral;
               winner = true;
           }
           else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && (!C1.Enabled))
           {
               C1.BackColor = Color.Coral;
               B2.BackColor = Color.Coral;
               A3.BackColor = Color.Coral;
               winner = true;
           }

           
        if (winner)    // in increment the winner's score
        { 
            
            if (turn)
            {
                win = p2.Text ;
                o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
            }

            else
            {
                win = p1.Text;
                x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
            }

            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;

            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
           
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
             MessageBox.Show(win + " wins" , " Congrats !!  ");
            
             five();
             ten();
             count();

        }
        else
        {
            if (turn_count == 9)
            {
                count();
                five();
                ten();
               
                MessageBox.Show("DRAW");
                draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
            }
        }// end if
        // end winnercheck

    }
        private void count()
        {
            gcount.Text = (Int32.Parse(gcount.Text) + 1).ToString();
            
           
            }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void boardset()   // to set the board
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.Bisque;
                }// end try
                catch { }
            } // end foreach
            playagain.BackColor = Color.White;
            playagain.Text = "Play Again";
        }

        private void five()    // for a five game mode
        {


            if ((gcount.Text == lbl5.Text) && (fivegames.Checked == true))
            {
                MessageBox.Show(" Game Ends");
                if (x_win_count.Text == o_win_count.Text)
                    MessageBox.Show(" Game Draw");
                else
                {
                    MessageBox.Show(win + " wins;  " + p1.Text + " won  " + x_win_count.Text + " times &  " + p2.Text + " won " + o_win_count.Text + " times", " Congrats !!  ");
                }
                    Free_play.Enabled = true;
                    ten_games.Enabled = true;
                    timetrail.Enabled = true;
            }
        }
        
        private void ten()    // for a ten mode game
        {
            if  ((gcount.Text == lblten.Text) && (ten_games.Checked == true))
            {
                MessageBox.Show(" Game Ends");
                if (x_win_count.Text == o_win_count.Text)
                    MessageBox.Show("Game Draw");
                else
                {
                    MessageBox.Show(win + " wins;  " + p1.Text + " won  " + x_win_count.Text + " times &  " + p2.Text + " won " + o_win_count.Text + " times", " Congrats !!  ");

                    Free_play.Enabled = true;
                    ten_games.Enabled = true;
                    timetrail.Enabled = true;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
            // for selecting a new game
        {
            boardset();
            p1.Enabled = true;
            p2.Enabled = true;
            fixednumber.Enabled = true;
            Free_play.Enabled = true;
            timetrail.Enabled = true;
            fivegames.Enabled = true;
            ten_games.Enabled = true;
            timelabel.Visible = false;
            one_min.Visible = false;
            two_mins.Visible = false;
            fivegames.Visible = false;
            ten_games.Visible = false;
            timer1.Stop();

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
            // to reset the scores
        {
            if (MessageBox.Show("Game in progress. Do you want to start a new game?", "Tic Tac Toe", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                boardset();
                p1.Enabled = true;
                p2.Enabled = true;
                x_win_count.Text = "0";
                o_win_count.Text = "0";
                draw_count.Text = "0";
               
            }
            else
            {
                x_win_count.Text = "0";
                o_win_count.Text = "0";
                draw_count.Text = "0";
                p1.Enabled = true;
                p2.Enabled = true;
            }

            

        }

        private void button_enter(object sender, EventArgs e)
            // to show whose turn
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, MouseEventArgs e)
        {
        }

        private void button_leave(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void x_win_count_Click(object sender, EventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show (" Assisgnment 1 ");
        }

        private void againclick(object sender, EventArgs e)
            // to play again
        {
            boardset();
        }

        
        private void fixednumber_CheckedChanged(object sender, EventArgs e)
            // selecting a fixed game mode
        {
            one_min.Visible = false;
            two_mins.Visible = false;
            fivegames.Visible = true;
            ten_games.Visible = true;
            fivegames.Checked = true;
            timelabel.Visible = false;
        }

        private void time(object sender, EventArgs e)
            //selecting a time mode game
        {
            timelabel.Text = "0";
            timelabel.Visible = true;
            one_min.Visible = true;
            two_mins.Visible = true;
            fivegames.Visible = false ;
            ten_games.Visible = false ;
            one_min.Checked = true;
            one_min.Enabled = true;
            two_mins.Enabled = true;
        }

        private void freeplay(object sender, EventArgs e)
            // normal mode game
        {
            one_min.Visible = false;
            two_mins.Visible = false;
            fivegames.Visible = false;
            ten_games.Visible = false;
            timelabel.Visible = false;

        }

        private void five(object sender, EventArgs e)
            // selcting a five games mode
        {
            gcount.Text = "0";
            Free_play.Enabled = false;
            ten_games.Enabled = false;
            timetrail.Enabled = false;
            fixednumber.Enabled = false;
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void tenclick(object sender, EventArgs e)
            //selecting a ten games mode
        {

            gcount.Text = "0";
            Free_play.Enabled = false;
            fivegames.Enabled = false;
            timetrail.Enabled = false;
            fixednumber.Enabled = false;
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void oneminclick(object sender, EventArgs e)
            //selecting a 1min game
        {
            
            timer1.Start();
            Free_play.Enabled = false;
            fivegames.Enabled = false;
            timetrail.Enabled = false;
            two_mins.Enabled = false;
            fixednumber.Enabled = false;
            one_min.Enabled = false;
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
                
        }

        private void timertick(object sender, EventArgs e)
            // instructions while the timer ticks
        {
            timelabel.Text = (Int32.Parse(timelabel.Text) + 1).ToString();
            if (one_min.Checked == true && timelabel.Text == sixtylbl.Text )
            {
                timer1.Stop();
                MessageBox.Show(" Game Ends ");
                if (x_win_count.Text == o_win_count.Text)
                    MessageBox.Show("Draw");
                else 
                MessageBox.Show(win + " wins;  " + p1.Text + " won  " + x_win_count.Text + " times &  " + p2.Text + " won " + o_win_count.Text + " times", " Congrats !!  ");
            }
            else if (two_mins.Checked == true && timelabel.Text == twomin.Text)
                {
                  timer1.Stop();
                  MessageBox.Show(" Game Ends ");
                if (x_win_count.Text == o_win_count.Text)
                    MessageBox.Show("Draw");
                else
                  MessageBox.Show(win + " wins;  " + p1.Text + " won  " + x_win_count.Text + " times &  " + p2.Text + " won " + o_win_count.Text + "times", " Congrats !!  ");
                }



        }

        private void twominclick(object sender, EventArgs e)
            //selecting a 2 min game mode
        {
            timer1.Start();
            Free_play.Enabled = false;
            fivegames.Enabled = false;
            timetrail.Enabled = false;
             two_mins.Enabled = false;
            one_min.Enabled = false;
            fixednumber.Enabled = false;
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void o_win_count_Click(object sender, EventArgs e)
        {

        }

       
   }
}