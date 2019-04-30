using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            networking.CreateSession(playerName);
            SessionCodeInput.Text = networking.sessionName;

            RunGame();
        }

        private void JoinGameBtn_Click(object sender, EventArgs e)
        {
            
            string sessionName = SessionCodeInput.Text;
            string playerName = UserNameInput.Text;
            networking.JoinSession(sessionName, playerName);

            RunGame();
        }

        private void RunGame ()
        {
            var gameGUI = new GameGUI(networking);
            networking.gameGUI = gameGUI;
            gameGUI.Show();
        }
    }
}
