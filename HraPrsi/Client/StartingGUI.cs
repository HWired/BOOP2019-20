using System;
using System.Windows.Forms;


namespace Client
{
    public partial class StartingGUI : Form
    {
        Networking networking = new Networking();

        public StartingGUI()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;

            networking.startingGUI = this;
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            string playerName = UserNameInput.Text;

            if (!IsPlayerNameValid(playerName))
            {
                UserNameInput.Text = "Enter your name";
                return;
            }
            
            networking.CreateSession(playerName);
            SessionCodeInput.Text = networking.sessionName;

            RunGame();
        }

        private void JoinGameBtn_Click(object sender, EventArgs e)
        {
            string playerName = UserNameInput.Text;
            if (!IsPlayerNameValid(playerName))
            {
                UserNameInput.Text = "Enter your name";
                return;
            }

            string sessionName = SessionCodeInput.Text;
            if (!IsSessionNameValid(sessionName))
            {
                SessionCodeInput.Text = "Enter the session code";
                return;
            }
            
            networking.JoinSession(sessionName, playerName);
            RunGame();
        }

        private bool IsSessionNameValid (string sessionName)
        {
            if (sessionName != "" && sessionName != "Enter the session code")
                return true;

            return false;
        }

        private bool IsPlayerNameValid(string playerName)
        {
            if (playerName != "" && playerName != "Enter your name")
                return true;

            return false;
        }

        private void RunGame ()
        {
            var gameGUI = new GameGUI(networking);
            networking.gameGUI = gameGUI;
            gameGUI.Show();
        }

        public void ClearSessionCodeInput ()
        {
            SessionCodeInput.Text = "";
        }
    }
}
