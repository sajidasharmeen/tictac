using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string firstTurn = "X";
        int count = 0;

        public void check_draw()
        {
            bool s = WhosWins();

            if (count == 9 && s == false)
            {

                MessageBox.Show("Game Draw");
                Reset();
            }
        
        }

private bool WhosWins()
        {
            string one = button1.Text;
            string two = button2.Text;
            string three = button3.Text;
            string four = button4.Text;
            string five = button5.Text;
            string six = button6.Text;
            string seven = button7.Text;
            string eight = button8.Text;
            string nine = button9.Text;

            if (one == "X" && two == "X" && three == "X")
            {
                MessageBox.Show("Player 1 Wins");
                
                Reset();
                return true;
              
            }
            if (four == "X" && five == "X" && six == "X")
            {
                MessageBox.Show("Player 1 Wins");
                Reset();
                return true;
            }
            if (seven == "X" && eight == "X" && nine == "X")
            {
                MessageBox.Show("Player 1 Wins");
                Reset();
                return true;
            }
            if (one == "X" && four == "X" && seven == "X")
            {
                MessageBox.Show("Player 1 Wins");
                Reset();
                return true;
            }
            if (two == "X" && five == "X" && eight == "X")
            {
                MessageBox.Show("Player 1 Wins");
                Reset();
                return true;
            }
            if (three == "X" && six == "X" && nine == "X")
            {
                MessageBox.Show("Player 1 Wins");
                Reset();
                return true;
            }
            if (one == "X" && five == "X" && nine == "X")
            {
                MessageBox.Show("Player 1 Wins");
                Reset();
                return true;
            }
            if (three == "X" && five == "X" && seven == "X")
            {
                MessageBox.Show("Player 1 Wins");
                Reset();
                return true;
            }


            if (one == "O" && two == "O" && three == "O")
            {
                MessageBox.Show("Player 2 Wins");
                Reset();
                return true;
            }
            if (four == "O" && five == "O" && six == "O")
            {
                MessageBox.Show("Player2 Wins");
                Reset();
                return true;
            }
            if (seven == "O" && eight == "O" && nine == "O")
            {
                MessageBox.Show("Player 2 Wins");
                Reset();
                return true;
            }
            if (one == "O" && four == "O" && seven == "O")
            {
                MessageBox.Show("Player 2 Wins");
                Reset();
                return true;
            }
            if (two == "O" && five == "O" && eight == "O")
            {
                MessageBox.Show("Player 2 Wins");
                Reset(); 
                return true;
            }
            if (three == "O" && six == "O" && nine == "O")
            {
                MessageBox.Show("Player 2 Wins");
                Reset();
                return true;
            }
            if (one == "O" && five == "O" && nine == "O")
            {
                MessageBox.Show("Player 2 Wins");
                Reset();
                return true;
            }
            if (three == "O" && five == "O" && seven == "O")
            {
                MessageBox.Show("Player 2 Wins");
                Reset();
                return true;
            }
            return false;
        }

        private void WhosTurn()
        {
            if (firstTurn == "X")
            {
                firstTurn = "O";
            }
            else
            {
                firstTurn = "X";
            }
        }

        private void Reset()
        {
            count = 0;
            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            button3.Text = firstTurn;
          
            button3.Enabled = false;
            WhosTurn();
            count++;
            check_draw();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = firstTurn;
           
            button2.Enabled = false;
            WhosTurn();
            
            count++;
            check_draw();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = firstTurn;
           
            button6.Enabled = false;
            WhosTurn();
          
            count++;
            check_draw();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = firstTurn;

            button1.Enabled = false;
            WhosTurn();
            
            count++;
            check_draw();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = firstTurn;

            button4.Enabled = false;
            WhosTurn();
           
            count++;
            check_draw();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = firstTurn;
            
            button5.Enabled = false;
            WhosTurn();
           
            count++;
            check_draw();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = firstTurn;

            button7.Enabled = false;
            WhosTurn();
            
            count++;
            check_draw();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = firstTurn;
            
            button8.Enabled = false;
            WhosTurn();
         
            count++;
            check_draw();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = firstTurn;
            
            button9.Enabled = false;
            WhosTurn();
            
            count++;
            check_draw();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
