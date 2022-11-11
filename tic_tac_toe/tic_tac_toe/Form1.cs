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
        }
    }
}