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
    public partial class Form1 : Form
    {
        Networking networking = new Networking();

        public Form1()
        {
            InitializeComponent();

            networking.form = this;
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            string playerName = UserNameInput.Text;
            networking.CreateSession(playerName);
            SessionCodeInput.Text = networking.sessionName;
            var myForm = new GUI();
            myForm.Show();
        }

        private void JoinGameBtn_Click(object sender, EventArgs e)
        {
            
           /* string sessionName = SessionCodeInput.Text;
            string playerName = UserNameInput.Text;
            networking.JoinSession(sessionName, playerName);
           */
            var myForm = new GUI();
            myForm.Show();
        }

        private void GetStateBtn_Click(object sender, EventArgs e)
        {
            networking.LoadState();
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            networking.StartGame();
        }

        public void OnGameStart()
        {
            if (StartGameBtn.InvokeRequired)
                StartGameBtn.Invoke(new MethodInvoker(delegate {
                    StartGameBtn.Enabled = false;
                }));
            else
            {
                StartGameBtn.Enabled = false;
            }
        }
    }
}
