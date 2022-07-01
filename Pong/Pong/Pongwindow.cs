namespace Pong
{
    public partial class Pongwindow : Form
    {
        //Location Variables
        int ballXCoordinate = 10;
        int ballYCoordinate = 10;

        //Score Variables
        int player1Score = 0;
        int player2Score = 0;

        //size variables
        int bottomBoundary;
        int xMidpoint;
        int yMidpoint;

        int tickcounter; 

        //Detection variables
        bool player1DetectedUp;
        bool player2DetectedUp;
        bool player1DetectedDown;
        bool player2DetectedDown;

        //Special key
        int spaceBarClicked = 0;

        public Pongwindow()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width/2;
            yMidpoint = ClientSize.Height/2;
        }


       //test


        private void Form1_Load(object sender, EventArgs e)
        {
            //damn
        }

        private void pongtimer_Tick(object sender, EventArgs e)
        {
            tickcounter++;
            
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            //Adjust where ball is
            ball.Top -= ballYCoordinate; //subtract 5 from top
            ball.Left -= ballXCoordinate;
            
            if(player2Score > 5 || player1Score > 5)
            {
                label1.Text = "Oh shit es wird spannend";
                if (tickcounter % 10 == 0) //Why did I DO this??
                {
                    this.BackColor = Color.DarkRed;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }

            if(ball.Left < 0)
            {
                ball.Left = xMidpoint;
                ball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                player2Score++;
                score2.Text = player2Score.ToString();

            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = xMidpoint;
                ball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                player1Score++;
                score1.Text = player1Score.ToString();

            }

            //ensure ball is in screen
            if(ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate; //just go to the oother direction LMAO
            }
            //check if ball hits player 
            if (ball.Bounds.IntersectsWith(player1.Bounds)|| ball.Bounds.IntersectsWith(Player2.Bounds))
            {
                ballXCoordinate = -ballXCoordinate;
            }

            //move player up
            if(player1DetectedUp == true && player1.Top > 0)
            {
                player1.Top -= 30; //move 10px
            }
            if (player1DetectedDown == true && player1.Top < bottomBoundary)
            {
                player1.Top += 30; //move 10px
            }
            //------------player2---------------
            //move player up
            if (player2DetectedUp == true && Player2.Top > 0)
            {
                Player2.Top -= 29; //move 10px
            }
            if (player2DetectedDown == true && Player2.Top < bottomBoundary)
            {
                Player2.Top += 29; //move 10px
            }
            if (player1Score >= 10 || player2Score>= 10)
            {
                pongtimer.Stop();
            }


        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            //if player presses up move up
            if (e.KeyCode == Keys.Up) { player2DetectedUp = false; }
            if (e.KeyCode == Keys.W) { player1DetectedUp = false; }
            //if player presses down move down
            if (e.KeyCode == Keys.Down) { player2DetectedDown = false; }
            if (e.KeyCode == Keys.S) { player1DetectedDown = false; }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            //if player presses up move up
            if (e.KeyCode == Keys.Up) { player2DetectedUp = true; }
            if (e.KeyCode == Keys.W) { player1DetectedUp = true; }
            //if player presses down move down
            if (e.KeyCode == Keys.Down) { player2DetectedDown = true; }
            if (e.KeyCode == Keys.S) { player1DetectedDown = true; }

            //pause game
            if (e.KeyCode == Keys.Space) { 
            if(spaceBarClicked % 2 == 0)
                {
                    pongtimer.Stop();
                }
                else
                {
                    pongtimer.Start();
                }
            }
           
        }
    }
}