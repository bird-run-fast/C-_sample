using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormSample
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void gooButton_Click(object sender, EventArgs e)
        {
            string compHand = this.getComputerHand();
            this.judgemnetGame("グー", compHand);
        }

        private void chokiButton_Click(object sender, EventArgs e)
        {
            string compHand = this.getComputerHand();
            this.judgemnetGame("チョキ", compHand);
        }

        private void parButton_Click(object sender, EventArgs e)
        {
            string compHand = this.getComputerHand();
            this.judgemnetGame("パー", compHand);
        }

        private string getComputerHand()
        {

            Random rand = new Random();
            int result = rand.Next(3);
            string resultString = "";

            switch (result)
            {

                case 0:
                    label1.Text = "コンピューターの手はグー";
                    pictureBox1.ImageLocation = "Image/goo.png";
                    resultString = "グー";
                    break;

                case 1:
                    label1.Text = "コンピューターの手はチョキ";
                    pictureBox1.ImageLocation = "Image/choki.png";
                    resultString = "チョキ";
                    break;

                case 2:
                    label1.Text = "コンピューターの手はパー";
                    pictureBox1.ImageLocation = "Image/par.png";
                    resultString = "パー";
                    break;


            }
            return resultString;
        }

        private void judgemnetGame(string playerHand, string computerHand)
        {
            if (playerHand == computerHand)
            {
                label1.Text += " / 引き分けです";
            }
            else if (
                playerHand == "グー" && computerHand == "チョキ" ||
                playerHand == "チョキ" && computerHand == "パー" ||
                playerHand == "パー" && computerHand == "グー"
                )
            {
                label1.Text += " / あなたの勝ちです";
            }
            else
            {
                label1.Text += " / あなたの負けです";
            }

        }


    }
}
