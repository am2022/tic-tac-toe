namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        int turn = 0;
        char[] game_board = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

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
            }
            else
            {
                btn1.BackColor = Color.Red;
                btn1.Text = "O";
                btn1.Enabled = false;
                this.game_board[0] = 'o';
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
            }
            else
            {
                btn2.BackColor = Color.Red;
                btn2.Text = "O";
                btn2.Enabled = false;
                this.game_board[1] = 'o';
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
            }
            else
            {
                btn3.BackColor = Color.Red;
                btn3.Text = "O";
                btn3.Enabled = false;
                this.game_board[2] = 'o';
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
            }
            else
            {
                btn4.BackColor = Color.Red;
                btn4.Text = "O";
                btn4.Enabled = false;
                this.game_board[3] = 'o';
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
            }
            else
            {
                btn5.BackColor = Color.Red;
                btn5.Text = "O";
                btn5.Enabled = false;
                this.game_board[4] = 'o';
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
            }
            else
            {
                btn6.BackColor = Color.Red;
                btn6.Text = "O";
                btn6.Enabled = false;
                this.game_board[5] = 'o';
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
            }
            else
            {
                btn7.BackColor = Color.Red;
                btn7.Text = "O";
                btn7.Enabled = false;
                this.game_board[6] = 'o';
            }

            this.turn++;
        }
    }
}