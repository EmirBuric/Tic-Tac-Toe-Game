using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmXO
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            GenerateMatrixOfButtons();
            btnPlyAgn.Enabled = false;
        }
        public int Counter { set; get; }
        public int CounterWinPlyr { get; private set; }
        public int CounterWinComp { get; private set; }
        Button[,] buttonMat = new Button[3, 3];
        char[,] board = {{ '_', '_', '_' },
                     { '_', '_', '_' },
                     { '_', '_', '_' }};
        class Move
        {
            public int row, col;
        };

        static char player = 'X', opponent = 'O';
        static Boolean isMovesLeft(char[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == '_')
                        return true;
            return false;
        }

        static int evaluate(char[,] b)
        {
            // Checking for Rows for X or O victory. 
            for (int row = 0; row < 3; row++)
            {
                if (b[row, 0] == b[row, 1] &&
                    b[row, 1] == b[row, 2])
                {
                    if (b[row, 0] == player)
                        return +10;
                    else if (b[row, 0] == opponent)
                        return -10;
                }
            }

            // Checking for Columns for X or O victory. 
            for (int col = 0; col < 3; col++)
            {
                if (b[0, col] == b[1, col] &&
                    b[1, col] == b[2, col])
                {
                    if (b[0, col] == player)
                        return +10;

                    else if (b[0, col] == opponent)
                        return -10;
                }
            }

            // Checking for Diagonals for X or O victory. 
            if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
            {
                if (b[0, 0] == player)
                    return +10;
                else if (b[0, 0] == opponent)
                    return -10;
            }

            if (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0])
            {
                if (b[0, 2] == player)
                    return +10;
                else if (b[0, 2] == opponent)
                    return -10;
            }

            // Else if none of them have won then return 0 
            return 0;
        }

        // This is the minimax function. It considers all 
        // the possible ways the game can go and returns 
        // the value of the board 
        static int minimax(char[,] board,
                           int depth, bool isMaximizing)
        {
            //int score = evaluate(board);
            //Console.WriteLine($"Depth: {depth}, Maximizing: {isMaximizing}, Score: {score}");
            /*if (score == -10 || score == 10 || score == 0)
            {
                if (score < 0)
                    score += depth;
                else if (score > 0)
                    score -= depth;

                return score;
            }*/
            int score = evaluate(board);
            if (score == 10) return score - depth; // Player X wins, subtract depth
            if (score == -10) return score + depth; // Player O wins, add depth
            if (!isMovesLeft(board)) return 0; // Draw

            if (isMaximizing)
            {
                int best = int.MinValue;

                // Traverse all cells 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty 
                        if (board[i, j] == '_')
                        {
                            // Make the move 
                            board[i, j] = player;

                            // Call minimax recursively and choose 
                            // the maximum value 
                            best = Math.Max(best, minimax(board, depth + 1, false));

                            // Undo the move 
                            board[i, j] = '_';
                        }
                    }
                }
                return best;
            }
            else
            {
                int best = int.MaxValue;

                // Traverse all cells 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty 
                        if (board[i, j] == '_')
                        {
                            // Make the move 
                            board[i, j] = opponent;

                            // Call minimax recursively and choose 
                            // the minimum value 
                            best = Math.Min(best, minimax(board, depth + 1, true));

                            // Undo the move 
                            board[i, j] = '_';
                        }
                    }
                }
                return best;
            }
        }

        // This will return the best possible 
        // move for the player 
        static Move FindBestMove(char[,] board)
        {
            int bestVal = int.MaxValue;
            Move bestMove = new Move();
            bestMove.row = -1;
            bestMove.col = -1;

            // Traverse all cells, evaluate minimax function  
            // for all empty cells. And return the cell  
            // with optimal value. 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Check if cell is empty 
                    if (board[i, j] == '_')
                    {
                        // Make the move 
                        board[i, j] = opponent;

                        // compute evaluation function for this 
                        // move. 
                        int moveVal = minimax(board, 0, true);

                        // Undo the move 
                        board[i, j] = '_';

                        // If the value of the current move is 
                        // more than the best value, then update 
                        // best/ 
                        if (moveVal < bestVal)
                        {
                            bestMove.row = i;
                            bestMove.col = j;
                            bestVal = moveVal;
                        }
                    }
                }
            }

            Console.WriteLine($"Best move: ({bestMove.row}, {bestMove.col}) with value: {bestVal}");
            return bestMove;
        }
        private void GenerateMatrixOfButtons()
        {
            int CelNbr = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttonMat[i, j] = CreateButton(i, j);
                    PnlTable.Controls.Add(buttonMat[i, j]);
                    buttonMat[i, j].Tag = CelNbr++;
                    buttonMat[i, j].Click += Btn_Click;
                }
            }
        }
        private Button CreateButton(int i, int j)
        {
            return new Button
            {

                BackColor = Color.Teal,
                Font = new Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = SystemColors.ControlLightLight,
                Width = 75,
                Height = 75,
                Location = new Point(i * 50 + 10,
                                     j * 50 + 10),
            };
        }
        private (int, int) GetButtonPosition(Button button)
        {
            // Traverse the buttonMat array to find the position of the button
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (buttonMat[i, j] == button)
                    {
                        // Return the position (row, col) of the button
                        return (i, j);
                    }
                }
            }

            // Return (-1, -1) if the button is not found (which should not happen if used correctly)
            return (-1, -1);
        }
        #region btn_click
        private void Btn_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }
        private void btnPlyAgn_Click(object sender, EventArgs e)
        {
            Counter = 0;
            btnPlyAgn.Enabled = false;  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttonMat[i, j].Text = "";
                    buttonMat[i, j].Enabled = true;
                    buttonMat[i, j].BackColor = default;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        void PlayerMove(object sender)
        {
            Button btn = sender as Button;
            Move playMove= new Move();
            int row, col;
            (row, col) = GetButtonPosition(btn);
            if (btn.Text == "" && board[row,col]=='_')
            {
                if (Counter % 2 == 0)
                {
                    btn.Text = "X";
                    board[row, col] = 'X';
                    Counter++;
                    
                    if (!EndGame())
                    {
                        playMove = FindBestMove(board);
                        if (playMove.row != -1 && playMove.col != -1)
                        {
                            buttonMat[playMove.row, playMove.col].Text = "O";
                            board[playMove.row, playMove.col] = 'O';
                            Counter++;
                        }
                    }
                }  
                /*else
                {
                   
                }*/
                
            }
            /*for (int i = 0;i < 3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(board[i,j]);
                }
                //Console.WriteLine("\n");
            }*/
            
            Console.WriteLine(playMove.row.ToString(),playMove.col.ToString());
            if (EndGame())
            {
                EndGameTasks();
            }
        }

        
        #region end_game
        public bool EndGame()
        {
            return CheckRow() || CheckColumn() || CheckDiagonal() || CheckTie();
        }

        private bool CheckTie()
        {
            if (Counter == 9) return true;
            return false;
        }

        private bool CheckDiagonal()
        {
            return (Compare(buttonMat[0,0], buttonMat[1,1], buttonMat[2,2])) ||
            (Compare(buttonMat[0,2], buttonMat[1,1], buttonMat[2,0]));
        }

        private bool CheckRow()
        {
            return Compare(buttonMat[0,0], buttonMat[1,0], buttonMat[2,0]) ||
           Compare(buttonMat[0,1], buttonMat[1,1], buttonMat[2,1]) ||
           Compare(buttonMat[0,2], buttonMat[1,2], buttonMat[2,2]);
        }

        private bool CheckColumn()
        {
            return Compare(buttonMat[0, 0], buttonMat[0, 1], buttonMat[0, 2]) ||
            Compare(buttonMat[1, 0], buttonMat[1, 1], buttonMat[1, 2]) ||
            Compare(buttonMat[2, 0], buttonMat[2, 1], buttonMat[2, 2]);
        }

        private bool Compare(Button button1, Button button2, Button button3)
        {
            if (!string.IsNullOrEmpty(button1.Text) && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                if (Counter % 2 == 1)
                    CounterWinPlyr++;
                else
                    CounterWinComp++;
                button1.BackColor = button2.BackColor = button3.BackColor = Color.FromArgb(77);
                return true;
            }
            return false;
        }
        private void EndGameTasks()
        {
            btnPlyAgn.Enabled = true;
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttonMat[i, j].Enabled = false;
                }
            }
            lblPlyrWin.Text = CounterWinPlyr.ToString();
            lblCompWin.Text = CounterWinComp.ToString();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '_';
                }
            }
        }
        #endregion
       
    }
}
