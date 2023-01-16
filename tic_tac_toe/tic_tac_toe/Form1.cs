namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        int turn = 0;
        char[] game_board = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
        Check_win cw = new Check_win();
        char get_win;
        string dump;
        int dumpi;

        private void make()
        {
            for (int i = 0; i < game_board.Length; i++)
            {
                game_board[i] = ' ';

                btn1.BackColor = Color.White;
                btn2.BackColor = Color.White;
                btn3.BackColor = Color.White;
                btn4.BackColor = Color.White;
                btn5.BackColor = Color.White;
                btn6.BackColor = Color.White;
                btn7.BackColor = Color.White;
                btn8.BackColor = Color.White;
                btn9.BackColor = Color.White;

                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;

                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(this.turn % 2 == 0)
            {
                btn1.BackColor = Color.Green;
                btn1.Text = "X";
                btn1.Enabled = false;
                this.game_board[0] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");

                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn1.BackColor = Color.Red;
                btn1.Text = "O";
                btn1.Enabled = false;
                this.game_board[0] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn2.BackColor = Color.Green;
                btn2.Text = "X";
                btn2.Enabled = false;
                this.game_board[1] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn2.BackColor = Color.Red;
                btn2.Text = "O";
                btn2.Enabled = false;
                this.game_board[1] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn3.BackColor = Color.Green;
                btn3.Text = "X";
                btn3.Enabled = false;
                this.game_board[2] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn3.BackColor = Color.Red;
                btn3.Text = "O";
                btn3.Enabled = false;
                this.game_board[2] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn4.BackColor = Color.Green;
                btn4.Text = "X";
                btn4.Enabled = false;
                this.game_board[3] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn4.BackColor = Color.Red;
                btn4.Text = "O";
                btn4.Enabled = false;
                this.game_board[3] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn5.BackColor = Color.Green;
                btn5.Text = "X";
                btn5.Enabled = false;
                this.game_board[4] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn5.BackColor = Color.Red;
                btn5.Text = "O";
                btn5.Enabled = false;
                this.game_board[4] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn6.BackColor = Color.Green;
                btn6.Text = "X";
                btn6.Enabled = false;
                this.game_board[5] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn6.BackColor = Color.Red;
                btn6.Text = "O";
                btn6.Enabled = false;
                this.game_board[5] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn7.BackColor = Color.Green;
                btn7.Text = "X";
                btn7.Enabled = false;
                this.game_board[6] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn7.BackColor = Color.Red;
                btn7.Text = "O";
                btn7.Enabled = false;
                this.game_board[6] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn8.BackColor = Color.Green;
                btn8.Text = "X";
                btn8.Enabled = false;
                this.game_board[7] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn8.BackColor = Color.Red;
                btn8.Text = "O";
                btn8.Enabled = false;
                this.game_board[7] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn9.BackColor = Color.Green;
                btn9.Text = "X";
                btn9.Enabled = false;
                this.game_board[8] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn9.BackColor = Color.Red;
                btn9.Text = "O";
                btn9.Enabled = false;
                this.game_board[8] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.make();
        }
    }
}