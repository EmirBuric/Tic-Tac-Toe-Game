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
    public partial class frmTable : Form
    {
        string _playerOne;
        string _playerTwo;
        public int Counter { set; get; }
        int CounterWinPlyr1 = 0;
        int CounterWinPlyr2 = 0;
        public int GameCounter = 1;
        public bool EndGame() {
            return CheckRow() || CheckColumn() || CheckDiagonal() || CheckTie();
        }

        private bool CheckTie()
        {
            if (Counter == 9) return true;
            return false;
        }

        private bool CheckDiagonal()
        {
            return (Compare(button1, button5, button9)) ||
            (Compare(button3, button5, button7));
        }

        private bool CheckColumn()
        {
            return (Compare(button1, button4, button7)) ||
           (Compare(button2, button5, button8)) ||
           (Compare(button3, button6, button9));
        }

        private bool CheckRow()
        {
            return (Compare(button1, button2, button3)) ||
            (Compare(button4, button5, button6)) ||
            (Compare(button7, button8, button9));
        }

        private bool Compare(Button button1, Button button2, Button button3)
        {
            if (!string.IsNullOrEmpty(button1.Text) && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                if (GameCounter % 2 == 1) {

                    if (Counter % 2 == 1)
                        CounterWinPlyr1++;
                    else
                        CounterWinPlyr2++;
                    button1.BackColor = button2.BackColor = button3.BackColor = Color.FromArgb(77);
                    return true;

                }
                else
                {
                    if (Counter % 2 == 1)
                        CounterWinPlyr2++;
                    else
                        CounterWinPlyr1++;
                    button1.BackColor = button2.BackColor = button3.BackColor = Color.FromArgb(77);
                    return true;
                }

                
            } 
            return false;
        }

        public frmTable()
        {
            InitializeComponent();
            btnPlyAgn.Enabled = false;
        }
        public frmTable(string playerOne, string playerTwo) : this()
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
            lblPlyr1Tbl.Text =(string.IsNullOrEmpty(playerOne))? lblPlyr1Tbl.Text:playerOne;
            lblPlyr2Tbl.Text = (string.IsNullOrEmpty(playerTwo)) ? lblPlyr2Tbl.Text : playerTwo;
        }
       
        void PlayerMove(object sender)
        {
            Button btn = sender as Button;
            if(btn.Text=="")
            {
                if (Counter % 2 == 0)
                    btn.Text = "X";
                else
                    btn.Text = "O";

                Counter++;
            }
            if (EndGame())
            {
                EndGameTasks();
            }
        }

        private void EndGameTasks()
        {
            foreach (var item in Controls)
            {
                if (item is Button)
                {
                    if ((item as Button).Name == btnExit.Name || (item as Button).Name == btnPlyAgn.Name)
                        (item as Button).Enabled = true;
                    else
                        (item as Button).Enabled = false;
                }
            }
            GameCounter++;
            if(GameCounter%2==0)
            {
                lblSign1.Text = "O";
                lblSign2.Text = "X";
            }
            else
            {
                lblSign1.Text = "X";
                lblSign2.Text = "O";
            }
            lblWinPlyr1.Text = CounterWinPlyr1.ToString();
            lblWinPlyr2.Text = CounterWinPlyr2.ToString();
        }
        #region btnClick
        private void button1_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Result());
            this.Close();
        }
        private string Result()
        {
            string Mssg="";
            if (CounterWinPlyr1 > CounterWinPlyr2)
                Mssg = $"{_playerOne} beat {_playerTwo} with a score of {CounterWinPlyr1}:{CounterWinPlyr2}";
            else if(CounterWinPlyr1<CounterWinPlyr2)
            {
                Mssg = $"{_playerTwo} beat {_playerOne} with a score of {CounterWinPlyr2}:{CounterWinPlyr1}";
            }
            else if(CounterWinPlyr1==CounterWinPlyr2){
                Mssg = $"{_playerOne} and {_playerTwo} tied with a score of {CounterWinPlyr1}:{CounterWinPlyr2}";
            }
            return Mssg;
        }
       
        private void btnPlyAgn_Click(object sender, EventArgs e)
        {
            Counter = 0;
            foreach (var item in Controls)
            {
                if (item is Button)
                {
                    if ((item as Button).Enabled == false) {
                        (item as Button).Text = "";
                        (item as Button).Enabled = true;
                        (item as Button).BackColor = default(Color);
                    }
                               
                }
            }
            btnPlyAgn.Enabled = false;
        }

        
    }
}
