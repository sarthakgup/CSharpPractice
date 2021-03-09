using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetButton.Visible = false;
            ResetButton.Enabled = false;
        }

        
        // The range of possible values for an entry in the tic tac toe board
        private enum Player
        {
            playerNull,
            playerX,
            playerO
        };

        // The different buttons available
        private enum CellPick
        {
            topLeft, topMiddle, topRight, middleLeft, center, middleRight, bottomLeft, bottomMiddle, bottomRight
        };

        // The representation of the tic tac toe board. One value for each cell in the board
        private Player m_topLeft = Player.playerNull;
        private Player m_topMiddle = Player.playerNull;
        private Player m_topRight = Player.playerNull;
        private Player m_middleLeft = Player.playerNull;
        private Player m_middleMiddle = Player.playerNull;
        private Player m_middleRight = Player.playerNull;
        private Player m_bottomLeft = Player.playerNull;
        private Player m_bottomMiddle = Player.playerNull;
        private Player m_bottomRight = Player.playerNull;

        

        // which value the human choose, whether they want to be X or O
        private Player m_humanPlayer = Player.playerX;
        
        // determine if there is a winner in the current board setup
        // you need to write all of the code for this method
        // at that point you can treat it like any of the other method you have used like Read.
        // the code would look something like this
        // if (IsWinner() == Player.playerX)
        private Player IsWinner()
        {
            // determine if a player has won and if so set winner to the correct player
            Player winner = Player.playerNull;

            if (m_topLeft == m_topMiddle && m_topLeft == m_topRight && m_topLeft != Player.playerNull) {
                winner =  m_topLeft;
            } 
            else if (m_middleLeft == m_middleMiddle && m_middleLeft == m_middleRight && m_topLeft != Player.playerNull)
            {
                winner = m_middleLeft;
            }
            else if(m_bottomLeft == m_bottomMiddle && m_bottomLeft == m_bottomRight && m_topLeft != Player.playerNull)
            {
                winner = m_bottomLeft;
            }
            else if (m_topLeft == m_middleLeft && m_topLeft == m_bottomLeft && m_topLeft != Player.playerNull)
            {
                winner = m_topLeft;
            }
            else if (m_topMiddle == m_middleMiddle && m_topMiddle == m_bottomMiddle && m_topLeft != Player.playerNull)
            {
                winner = m_topMiddle;
            }
            else if (m_topRight == m_middleRight && m_topRight == m_bottomRight && m_topLeft != Player.playerNull)
            {
                winner = m_topRight;
            }
            else if (m_topLeft == m_middleMiddle && m_topLeft == m_bottomRight && m_topLeft != Player.playerNull)
            {
                winner = m_topLeft;
                // Diagonal left to right
            }
            else if (m_topRight == m_middleMiddle && m_topRight == m_bottomLeft && m_topLeft != Player.playerNull)
            {
                winner = m_topRight;
                // Diagonal right to left
            }
            
            // This will return the winner to the caller of this method. That value can be used to determine what to display to the user
            return winner;  
        }

        // Method that returns true if cell makes whichPlayer a winner
        // You need to write all of the code for this funtion
        private bool TestCell(CellPick cell, Player whichPlayer)
        {
            if(IsWinner() == whichPlayer)
            {
                return true;
            }
            
            return false;
        }

        // Method that sets whichCell to belong to whichPlayer
        // You need to write all of the code for this funtion
        private void SetCell(CellPick whichCell, Player whichPlayer)
        {
            switch(whichCell)
            {
                case CellPick.topLeft:
                    if (whichPlayer == Player.playerX)
                    {
                        TopLeftButton.Text = "X";
                        m_topLeft = Player.playerX;
                    }
                    else
                    {
                        TopLeftButton.Text = "O";
                        m_topLeft = Player.playerO;
                    }

                    TopLeftButton.Enabled = false;
                    break;

                case CellPick.topMiddle:
                    if (whichPlayer == Player.playerX)
                    {
                        MiddleTopButton.Text = "X";
                        m_topMiddle = Player.playerX;
                    }
                    else
                    {
                        MiddleTopButton.Text = "O";
                        m_topMiddle = Player.playerO;
                    }

                    MiddleTopButton.Enabled = false;
                    break;

                
                case CellPick.topRight:
                    if (whichPlayer == Player.playerX)
                    {
                        TopRightButton.Text = "X";
                        m_topRight = Player.playerX;
                    }
                    else
                    {
                        TopRightButton.Text = "O";
                        m_topRight = Player.playerO;
                    }

                    TopRightButton.Enabled = false;
                    break;

                case CellPick.middleLeft:
                    if (whichPlayer == Player.playerX)
                    {
                        MiddleLeftButton.Text = "X";
                        m_middleLeft = Player.playerX;
                    }
                    else
                    {
                        MiddleLeftButton.Text = "O";
                        m_middleLeft = Player.playerO;
                    }

                    MiddleLeftButton.Enabled = false;
                    break;

                case CellPick.center:
                    if (whichPlayer == Player.playerX)
                    {
                        MiddleMiddleButton.Text = "X";
                        m_middleMiddle = Player.playerX;
                    }
                    else
                    {
                        MiddleMiddleButton.Text = "O";
                        m_middleMiddle = Player.playerO;
                    }

                    MiddleMiddleButton.Enabled = false;
                    break;

                case CellPick.middleRight:
                    if (whichPlayer == Player.playerX)
                    {
                        MiddleRightButton.Text = "X";
                        m_middleRight = Player.playerX;
                    }
                    else
                    {
                        MiddleRightButton.Text = "O";
                        m_middleRight = Player.playerO;
                    }

                    MiddleRightButton.Enabled = false;
                    break;


                case CellPick.bottomLeft:
                    if (whichPlayer == Player.playerX)
                    {
                        BottomLeftButton.Text = "X";
                        m_bottomLeft = Player.playerX;
                    }
                    else
                    {
                        BottomLeftButton.Text = "O";
                        m_bottomLeft = Player.playerO;
                    }

                    BottomLeftButton.Enabled = false;
                    break;

                case CellPick.bottomMiddle:
                    if (whichPlayer == Player.playerX)
                    {
                        MiddleBottomButton.Text = "X";
                        m_bottomMiddle = Player.playerX;
                    }
                    else
                    {
                        MiddleBottomButton.Text = "O";
                        m_bottomMiddle = Player.playerO;
                    }

                    MiddleBottomButton.Enabled = false;
                    break;


                case CellPick.bottomRight:
                    if (whichPlayer == Player.playerX)
                    {
                        BottomRightButton.Text = "X";
                        m_bottomRight = Player.playerX;
                    }
                    else
                    {
                        BottomRightButton.Text = "O";
                        m_bottomRight = Player.playerO;
                    }

                    BottomRightButton.Enabled = false;
                    break;
            }
        }

        private bool IsCellSet(Player x)
        {
            if (x != Player.playerNull)
            {
                return true;
            }

            return false;
        }

        // Method that determines which cell the AI should pick and updates the board and buttons with that choice.
        // You need to write all of the code for this function
        private void AIPick()
        {
            /*
            a.	If the computer can win it must play to win.
            b.If the computer can block it must play to block.
            c.If the computer can play in the center it must play in the center.
            d.If the computer can play in a corner it must play in a corner.
            */
            if(m_topLeft == Player.playerNull)
            {
                m_topLeft = Player.playerO;
                if( TestCell(CellPick.topLeft, Player.playerO))
                {
                   SetCell(CellPick.topLeft, Player.playerO);
                   Announce("Player O wins!");
                    return;
                }
                else
                {
                    m_topLeft = Player.playerNull;
                }
             }
            if (m_middleLeft == Player.playerNull)
            {
                m_middleLeft = Player.playerO;
                if (TestCell(CellPick.middleLeft, Player.playerO))
                {
                    SetCell(CellPick.middleLeft, Player.playerO);
                    Announce("Player O wins!");
                    return;

                }
                else
                {
                    m_middleLeft = Player.playerNull;
                }
            }
            if (m_bottomLeft == Player.playerNull)
            {
                m_bottomLeft = Player.playerO;
                if (TestCell(CellPick.bottomLeft, Player.playerO))
                {
                    SetCell(CellPick.bottomLeft, Player.playerO);
                    Announce("Player O wins!");
                    return;

                }
                else
                {
                    m_bottomLeft = Player.playerNull;
                }
            }
            if (m_topMiddle == Player.playerNull)
            {
                m_topMiddle = Player.playerO;
                if (TestCell(CellPick.topMiddle, Player.playerO))
                {
                    SetCell(CellPick.topMiddle, Player.playerO);
                    Announce("Player O wins!");
                    return;
                }
                else
                {
                    m_topMiddle = Player.playerNull;
                }
            }
            if (m_middleMiddle == Player.playerNull)
            {
                m_middleMiddle = Player.playerO;
                if (TestCell(CellPick.center, Player.playerO))
                {
                    SetCell(CellPick.center, Player.playerO);
                    Announce("Player O wins!");
                    return;
                }
                else
                {
                    m_middleMiddle = Player.playerNull;
                }
            }
            if (m_bottomMiddle == Player.playerNull)
            {
                m_bottomMiddle = Player.playerO;
                if (TestCell(CellPick.bottomMiddle, Player.playerO))
                {
                    SetCell(CellPick.bottomMiddle, Player.playerO);
                    Announce("Player O wins!");
                    return;
                }
                else
                {
                    m_bottomMiddle = Player.playerNull;
                }
            }
            if (m_topRight == Player.playerNull)
            {
                m_topRight = Player.playerO;
                if (TestCell(CellPick.topRight, Player.playerO))
                {
                    SetCell(CellPick.topRight, Player.playerO);
                    Announce("Player O wins!");
                    return;
                }
                else
                {
                    m_topRight = Player.playerNull;
                }
            }
            if (m_middleRight == Player.playerNull)
            {
                m_middleRight = Player.playerO;
                if (TestCell(CellPick.middleRight, Player.playerO))
                {
                    SetCell(CellPick.middleRight, Player.playerO);
                    Announce("Player O wins!");
                    return;
                }
                else
                {
                    m_middleRight = Player.playerNull;
                }
            }
            if (m_bottomRight == Player.playerNull)
            {
                m_bottomRight = Player.playerO;
                if (TestCell(CellPick.bottomRight, Player.playerO))
                {
                    SetCell(CellPick.bottomRight, Player.playerO);
                    Announce("Player O wins!");
                    return;
                }
                else
                {
                    m_bottomRight = Player.playerNull;
                }
            }
            // START OF BLOCKING CODE BELOW ________________________________________________--
            // ---------------------------

            if (m_topLeft == Player.playerNull)
            {
                m_topLeft = Player.playerX;
                if (TestCell(CellPick.topLeft, Player.playerX))
                {
                    SetCell(CellPick.topLeft, Player.playerO);
                    return;
                }
                else
                {
                    m_topLeft = Player.playerNull;
                }
            }
            if (m_middleLeft == Player.playerNull)
            {
                m_middleLeft = Player.playerX;
                if (TestCell(CellPick.middleLeft, Player.playerX))
                {
                    SetCell(CellPick.middleLeft, Player.playerO);
                    
                    return;

                }
                else
                {
                    m_middleLeft = Player.playerNull;
                }
            }
            if (m_bottomLeft == Player.playerNull)
            {
                m_bottomLeft = Player.playerX;
                if (TestCell(CellPick.bottomLeft, Player.playerX))
                {
                    SetCell(CellPick.bottomLeft, Player.playerO);
                    return;

                }
                else
                {
                    m_bottomLeft = Player.playerNull;
                }
            }
            if (m_topMiddle == Player.playerNull)
            {
                m_topMiddle = Player.playerX;
                if (TestCell(CellPick.topMiddle, Player.playerX))
                {
                    SetCell(CellPick.topMiddle, Player.playerO);
                    return;
                }
                else
                {
                    m_topMiddle = Player.playerNull;
                }
            }
            if (m_middleMiddle == Player.playerNull)
            {
                m_middleMiddle = Player.playerX;
                if (TestCell(CellPick.center, Player.playerX))
                {
                    SetCell(CellPick.center, Player.playerO);
                    return;
                }
                else
                {
                    m_middleMiddle = Player.playerNull;
                }
            }
            if (m_bottomMiddle == Player.playerNull)
            {
                m_bottomMiddle = Player.playerX;
                if (TestCell(CellPick.bottomMiddle, Player.playerX))
                {
                    SetCell(CellPick.bottomMiddle, Player.playerO);
                    return;
                }
                else
                {
                    m_bottomMiddle = Player.playerNull;
                }
            }
            if (m_topRight == Player.playerNull)
            {
                m_topRight = Player.playerX;
                if (TestCell(CellPick.topRight, Player.playerX))
                {
                    SetCell(CellPick.topRight, Player.playerO);
                    return;
                }
                else
                {
                    m_topRight = Player.playerNull;
                }
            }
            if (m_middleRight == Player.playerNull)
            {
                m_middleRight = Player.playerX;
                if (TestCell(CellPick.middleRight, Player.playerX))
                {
                    SetCell(CellPick.middleRight, Player.playerO);
                    return;
                }
                else
                {
                    m_middleRight = Player.playerNull;
                }
            }
            if (m_bottomRight == Player.playerNull)
            {
                m_bottomRight = Player.playerX;
                if (TestCell(CellPick.bottomRight, Player.playerX))
                {
                    SetCell(CellPick.bottomRight, Player.playerO);
                    return;
                }
                else
                {
                    m_bottomRight = Player.playerNull;
                }
            }

            //CENTER -----------------------------------------------------------------
            if (m_middleMiddle == Player.playerNull)
            {
                SetCell(CellPick.center, Player.playerO);
            }
            //Corners ----------------------------------------------------------------
            else if(m_topLeft == Player.playerNull)
            {
                SetCell(CellPick.topLeft, Player.playerO);
            }
            else if(m_topRight == Player.playerNull)
            {
                SetCell(CellPick.topRight, Player.playerO);
            }
            else if(m_bottomLeft == Player.playerNull)
            {
                SetCell(CellPick.bottomLeft, Player.playerO);
            }
            else if(m_bottomRight == Player.playerNull)
            {
                SetCell(CellPick.bottomRight, Player.playerO);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void reset()
        {
            m_topLeft = Player.playerNull;
            m_topMiddle = Player.playerNull;
            m_topRight = Player.playerNull;
            m_middleLeft = Player.playerNull;
            m_middleMiddle = Player.playerNull;
            m_middleRight = Player.playerNull;
            m_bottomLeft = Player.playerNull;
            m_bottomMiddle = Player.playerNull;
            m_bottomRight = Player.playerNull;

            TopLeftButton.Text = "";
            MiddleLeftButton.Text = "";
            BottomLeftButton.Text = "";
            MiddleTopButton.Text = "";
            MiddleMiddleButton.Text = "";
            MiddleBottomButton.Text = "";
            TopRightButton.Text = "";
            MiddleRightButton.Text = "";
            BottomRightButton.Text = "";
            label4.Text = "";

            TopLeftButton.Enabled = true;
            MiddleLeftButton.Enabled = true;
            BottomLeftButton.Enabled = true;
            MiddleTopButton.Enabled = true;
            MiddleMiddleButton.Enabled = true;
            MiddleBottomButton.Enabled = true;
            TopRightButton.Enabled = true;
            MiddleRightButton.Enabled = true;
            BottomRightButton.Enabled = true;

            ResetButton.Visible = false;
            ResetButton.Enabled = false;
        }

        private void TopLeftButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.topLeft, Player.playerX);
            if (TestCell(CellPick.topLeft, Player.playerX))
            {
                Announce("YOU WIN!"); //Changed from "Player X wins!"
            }
            else
            {
                AIPick();
            }
        }

        private void MiddleLeftButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.middleLeft, Player.playerX);
            if (TestCell(CellPick.middleLeft, Player.playerX))
            {
                Announce("Player X wins!");
            }
            else
            {
                AIPick();
            }

        }

        private void BottomLeftButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.bottomLeft, Player.playerX);
            if (TestCell(CellPick.bottomLeft, Player.playerX))
            {
                Announce("Player X wins!");
            }
            else
            {
                AIPick();
            }

        }

        private void Announce(string s)
        {
            label4.Text = s;
            
            ResetButton.Enabled = true;
            ResetButton.Visible = true;
            TopLeftButton.Enabled = false;
            MiddleLeftButton.Enabled = false;
            BottomLeftButton.Enabled = false;
            MiddleTopButton.Enabled = false;
            MiddleMiddleButton.Enabled = false;
            MiddleBottomButton.Enabled = false;
            TopRightButton.Enabled = false;
            MiddleRightButton.Enabled = false;
            BottomRightButton.Enabled = false;
        }

        private void MiddleTopButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.topMiddle, Player.playerX);
            if (TestCell(CellPick.topMiddle, Player.playerX))
            {
                Announce("Player X wins!");
            }
            else
            {
                AIPick();
            }

        }

        private void MiddleMiddleButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.center, Player.playerX);
            if (TestCell(CellPick.center, Player.playerX))
            {
                Announce("Player X wins!");
            }
            else
            {
                AIPick();
            }

        }

        private void MiddleBottomButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.bottomMiddle, Player.playerX);
            if (TestCell(CellPick.bottomMiddle, Player.playerX))
            {
                Announce("Player X wins!");
            }
            else
            {
                AIPick();
            }

        }

        private void TopRightButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.topRight, Player.playerX);
            if (TestCell(CellPick.topRight, Player.playerX))
            {
                Announce("Player X wins!");
            }
            else
            {
                AIPick();
            }

        }

        private void MiddleRightButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.middleRight, Player.playerX);
            if (TestCell(CellPick.middleRight, Player.playerX))
            {
                Announce("Player X wins!");
            }
            else
            {
                AIPick();
            }

        }

        private void BottomRightButton_Click(object sender, EventArgs e)
        {
            SetCell(CellPick.bottomRight, Player.playerX);
            if (TestCell(CellPick.bottomRight, Player.playerX))
            {
                Announce("Player X wins!");
            }
            else
            {
                AIPick();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}