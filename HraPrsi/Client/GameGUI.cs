using System;
using System.Drawing;
using System.Windows.Forms;
using Client.DataStructures;
using Client.Properties;
using Client.PrsiService;

namespace Client
{
    public partial class GameGUI : Form
    {
        Networking networking;

        bool cardSaved = false;
        PictureBox previouslySelectedCard = null;
        ClientCard selectedCard = null;

        public GameGUI(Networking networking)
        {
            InitializeComponent();
            this.networking = networking;
            networking.gameGUI = this;
            networking.OnGameWindowReady();
        }

        public void UpdatePlayerList (Player[] players, int playerTurn, Player me)
        {
            PlayerBox.Controls.Clear();

            int y = 24;
            int i = 0;
            foreach (Player player in players)
            {
                Label playerLabel = new Label();
                playerLabel.Text = player.name;
                playerLabel.Location = new Point(24, y);

                if (i == playerTurn)
                    playerLabel.Location = new Point(48, y);

                if (player.isCreator)
                    playerLabel.ForeColor = Color.Red;

                if (me.id == player.id)
                    playerLabel.ForeColor = Color.Green;

                PlayerBox.Controls.Add(playerLabel);

                y += 24;
                i++;
            }
        }

        public void UpdatePlayedCard (Card card)
        {
            // clear box
            if (CardOnTheTableBox.InvokeRequired) this.Invoke(new MethodInvoker(delegate { CardOnTheTableBox.Controls.Clear(); }));
            else CardOnTheTableBox.Controls.Clear();

            ClientCard cardPicture = new ClientCard();
            cardPicture.card = card;
            cardPicture.Image = CardToImage(card);
            cardPicture.Location = new Point(20, 20);
            cardPicture.Anchor = AnchorStyles.Bottom;
            cardPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            cardPicture.Size = new Size(154, 194);

            if (this.InvokeRequired) this.Invoke(new MethodInvoker(delegate { CardOnTheTableBox.Controls.Add(cardPicture); }));
            else CardOnTheTableBox.Controls.Add(cardPicture);
        }

        public void UpdatePlayerCards (Card[] cards)
        {
            // clear box
            if (CardBox.InvokeRequired) this.Invoke(new MethodInvoker(delegate { CardBox.Controls.Clear(); }));
            else CardBox.Controls.Clear();
            

            int x = 50;
            foreach (Card card in cards)
            {
                ClientCard cardPicture = new ClientCard();
                cardPicture.card = card;
                cardPicture.Image = CardToImage(card);
                cardPicture.Location = new Point(x, 50);
                cardPicture.Anchor = AnchorStyles.Bottom;
                cardPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                cardPicture.Size = new Size(154, 194);

                cardPicture.Click += Card_Click;

                if (CardBox.InvokeRequired) this.Invoke(new MethodInvoker(delegate {CardBox.Controls.Add(cardPicture);}));
                else CardBox.Controls.Add(cardPicture);

                x += 59;
            }
        }

        public void EnableStartGameBtn ()
        {
            if (StartGameBtn.InvokeRequired) this.Invoke(new MethodInvoker(delegate { StartGameBtn.Enabled = true; }));
            else StartGameBtn.Enabled = true;
        }

        public void ShowGameActionBtns ()
        {
            if (SkipTurnBtn.InvokeRequired) this.Invoke(new MethodInvoker(delegate { SkipTurnBtn.Visible = true; }));
            else SkipTurnBtn.Visible = true;

            if (PlayCardBtn.InvokeRequired) this.Invoke(new MethodInvoker(delegate { PlayCardBtn.Visible = true; }));
            else PlayCardBtn.Visible = true;
        }

        private Image CardToImage (Card card)
        {
            if (card.type == CardType.Diamond && card.value == CardValue.CA) return Resources.KaryA;
            if (card.type == CardType.Diamond && card.value == CardValue.C2) return Resources.Kary2;
            if (card.type == CardType.Diamond && card.value == CardValue.C3) return Resources.Kary3;
            if (card.type == CardType.Diamond && card.value == CardValue.C4) return Resources.Kary4;
            if (card.type == CardType.Diamond && card.value == CardValue.C5) return Resources.Kary5;
            if (card.type == CardType.Diamond && card.value == CardValue.C6) return Resources.Kary6;
            if (card.type == CardType.Diamond && card.value == CardValue.C7) return Resources.Kary7;
            if (card.type == CardType.Diamond && card.value == CardValue.C8) return Resources.Kary8;
            if (card.type == CardType.Diamond && card.value == CardValue.C9) return Resources.Kary9;
            if (card.type == CardType.Diamond && card.value == CardValue.C10) return Resources.Kary10;
            if (card.type == CardType.Diamond && card.value == CardValue.CJ) return Resources.KaryJ;
            if (card.type == CardType.Diamond && card.value == CardValue.CQ) return Resources.KaryQ;
            if (card.type == CardType.Diamond && card.value == CardValue.CK) return Resources.KaryK;

            if (card.type == CardType.Heart && card.value == CardValue.CA) return Resources.SrdceA;
            if (card.type == CardType.Heart && card.value == CardValue.C2) return Resources.Srdce2;
            if (card.type == CardType.Heart && card.value == CardValue.C3) return Resources.Srdce3;
            if (card.type == CardType.Heart && card.value == CardValue.C4) return Resources.Srdce4;
            if (card.type == CardType.Heart && card.value == CardValue.C5) return Resources.Srdce5;
            if (card.type == CardType.Heart && card.value == CardValue.C6) return Resources.Srdce6;
            if (card.type == CardType.Heart && card.value == CardValue.C7) return Resources.Srdce7;
            if (card.type == CardType.Heart && card.value == CardValue.C8) return Resources.Srdce8;
            if (card.type == CardType.Heart && card.value == CardValue.C9) return Resources.Srdce9;
            if (card.type == CardType.Heart && card.value == CardValue.C10) return Resources.Srdce10;
            if (card.type == CardType.Heart && card.value == CardValue.CJ) return Resources.SrdceJ;
            if (card.type == CardType.Heart && card.value == CardValue.CQ) return Resources.SrdceQ;
            if (card.type == CardType.Heart && card.value == CardValue.CK) return Resources.SrdceK;

            if (card.type == CardType.Leaf && card.value == CardValue.CA) return Resources.PikiA;
            if (card.type == CardType.Leaf && card.value == CardValue.C2) return Resources.Piki2;
            if (card.type == CardType.Leaf && card.value == CardValue.C3) return Resources.Piki3;
            if (card.type == CardType.Leaf && card.value == CardValue.C4) return Resources.Piki4;
            if (card.type == CardType.Leaf && card.value == CardValue.C5) return Resources.Piki5;
            if (card.type == CardType.Leaf && card.value == CardValue.C6) return Resources.Piki6;
            if (card.type == CardType.Leaf && card.value == CardValue.C7) return Resources.Piki7;
            if (card.type == CardType.Leaf && card.value == CardValue.C8) return Resources.Piki8;
            if (card.type == CardType.Leaf && card.value == CardValue.C9) return Resources.Piki9;
            if (card.type == CardType.Leaf && card.value == CardValue.C10) return Resources.Piki10;
            if (card.type == CardType.Leaf && card.value == CardValue.CJ) return Resources.PikiJ;
            if (card.type == CardType.Leaf && card.value == CardValue.CQ) return Resources.PikiQ;
            if (card.type == CardType.Leaf && card.value == CardValue.CK) return Resources.PikiK;

            if (card.type == CardType.Acorn && card.value == CardValue.CA) return Resources.KrizA;
            if (card.type == CardType.Acorn && card.value == CardValue.C2) return Resources.Kriz2;
            if (card.type == CardType.Acorn && card.value == CardValue.C3) return Resources.Kriz3;
            if (card.type == CardType.Acorn && card.value == CardValue.C4) return Resources.Kriz4;
            if (card.type == CardType.Acorn && card.value == CardValue.C5) return Resources.Kriz5;
            if (card.type == CardType.Acorn && card.value == CardValue.C6) return Resources.Kriz6;
            if (card.type == CardType.Acorn && card.value == CardValue.C7) return Resources.Kriz7;
            if (card.type == CardType.Acorn && card.value == CardValue.C8) return Resources.Kriz8;
            if (card.type == CardType.Acorn && card.value == CardValue.C9) return Resources.Kriz9;
            if (card.type == CardType.Acorn && card.value == CardValue.C10) return Resources.Kriz10;
            if (card.type == CardType.Acorn && card.value == CardValue.CJ) return Resources.KrizJ;
            if (card.type == CardType.Acorn && card.value == CardValue.CQ) return Resources.KrizQ;
            if (card.type == CardType.Acorn && card.value == CardValue.CK) return Resources.KrizK;

            return Resources.PrazdnaKarta;
        }

        public void OnGameStart()
        {
            if (StartGameBtn.InvokeRequired)
                StartGameBtn.Invoke(new MethodInvoker(delegate {
                    LeaveRoomBtn.Enabled = false;
                    LeaveRoomBtn.Visible = false;
                    StartGameBtn.Enabled = false;
                    StartGameBtn.Visible = false;
                }));
            else
            {
                LeaveRoomBtn.Enabled = false;
                LeaveRoomBtn.Visible = false;
                StartGameBtn.Enabled = false;
                StartGameBtn.Visible = false;
            }
        }

        public void UpdatePlayerListInvoke (Player[] players, int playerTurn, Player me)
        {
            if (PlayerBox.InvokeRequired)
                PlayerBox.Invoke(new MethodInvoker(delegate {
                    UpdatePlayerList(players, playerTurn, me);
                }));
            else
                UpdatePlayerList(players, playerTurn, me);
        }

        private void PlayCardBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Right now am playin' card: {selectedCard.card.type}, {selectedCard.card.color}, {selectedCard.card.value}");
            networking.PlayCard(selectedCard.card);
        }


        private void SkipTurnBtn_Click(object sender, EventArgs e)
        {
            networking.SkipTurn();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (cardSaved)
            {
                previouslySelectedCard.Location = new Point(previouslySelectedCard.Location.X, previouslySelectedCard.Location.Y + 50);
            }
            previouslySelectedCard = (PictureBox)sender;
            cardSaved = true;
            selectedCard = ((ClientCard)sender);
            selectedCard.Location = new Point(selectedCard.Location.X, selectedCard.Location.Y - 50);

        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            networking.StartGame();
        }

        private void LeaveRoomBtn_Click(object sender, EventArgs e)
        {
            networking.LeaveRoom();
            this.Close();
        }
    }
}
