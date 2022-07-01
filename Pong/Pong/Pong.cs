namespace Pong
{
    public partial class Pong : Form
    {
        //Location Variables
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;

        //Score Variables
        int player1Score = 0;
        int player2Score = 0;

        //size variables
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        //Detection variables
        bool player1DetectedUp;
        bool player2DetectedUp;
        bool player1DetectedDown;
        bool player2DetectedDown;

        //Special key
        int spaceBarClicked = 0;

        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width/2;
            yMidpoint = ClientSize.Height/2;
        }


       //test


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pongtimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            //Adjust where ball is
            ball.Top -= ballYCoordinate; //subtract 5 from top
            ball.Left -= ballXCoordinate;

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

        }
    }
}