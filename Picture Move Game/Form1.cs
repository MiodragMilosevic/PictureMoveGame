using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Move_Game
{
    public partial class Form1 : Form
    {
        private List<Bitmap> listImage = new List<Bitmap>();
        private int iNullImage, iMovesMade = 0;
        private Random random = new Random();
        private Stopwatch time = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            listImage.AddRange(new List<Bitmap> {Properties.Resources._1, Properties.Resources._2,
            Properties.Resources._3, Properties.Resources._4, Properties.Resources._5,
            Properties.Resources._6, Properties.Resources._7, Properties.Resources._8,
            Properties.Resources._9, Properties.Resources._null});
            btnPause.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 8; i++)
            {
                if (listImage[i] != ((PictureBox)puzzleBox.Controls[i]).Image)
                {
                    return false;
                }
            }
            return true;
        }

        private void resetGame()
        {
            time.Reset();
            iMovesMade = 0;
            lblMovesMade.Text = iMovesMade.ToString();
            stopwatchText.Text = "00:00:00";
            Shuffle();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (stopwatchText.Text == "00:00:00") Shuffle();
            else
            {
                DialogResult areYouSure = MessageBox.Show("Are you sure?", "Picture Move Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (areYouSure == DialogResult.Yes)
                {
                    resetGame();
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult yesNo = MessageBox.Show("Are you sure?", "Picture Move Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesNo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MovePicture(object sender, EventArgs e)
        {
            PictureBox pB = (PictureBox)sender;
            int IndexOfPic = 0;

            for (int i = 0; i < 9; i++)
            {
                if (pB == ((PictureBox)puzzleBox.Controls[i]))
                {
                    IndexOfPic = i;
                    break;
                }
            }
            if (IndexOfPic == iNullImage) return;

            List<int> listOfBrothers = new List<int>();

            if (iNullImage % 3 != 0) listOfBrothers.Add(iNullImage - 1);
            if (iNullImage % 3 != 2) listOfBrothers.Add(iNullImage + 1);
            if (iNullImage >= 3) listOfBrothers.Add(iNullImage - 3);
            if (iNullImage < 6) listOfBrothers.Add(iNullImage + 3);

            if (!listOfBrothers.Contains(IndexOfPic)) return;

            iMovesMade++;
            lblMovesMade.Text = iMovesMade.ToString();
            if (stopwatchText.Text == "00:00:00")
                time.Start();

            Image temp = ((PictureBox)puzzleBox.Controls[iNullImage]).Image;
            ((PictureBox)puzzleBox.Controls[iNullImage]).Image = ((PictureBox)puzzleBox.Controls[IndexOfPic]).Image;
            ((PictureBox)puzzleBox.Controls[IndexOfPic]).Image = temp;
            iNullImage = IndexOfPic;

            if (CheckWin())
            {
                time.Stop();
                ((PictureBox)puzzleBox.Controls[8]).Image = listImage[8];
                DialogResult win = MessageBox.Show("Congratulations!\nYour time is " + time.Elapsed.ToString().Remove(8) + "\nYou made: " + lblMovesMade.Text + " moves\nDo you want new game?", "Picture Move Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (win == DialogResult.Yes)
                {
                    resetGame();
                }
                else
                {
                    Application.Exit();
                }
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                time.Stop();
                puzzleBox.Visible = false;
                btnPause.Text = "Resume";
            }
            else
            {
                time.Start();
                puzzleBox.Visible = true;
                btnPause.Text = "Pause";
            }
        }

        private void stopwatch_Tick(object sender, EventArgs e)
        {
            if (time.Elapsed.ToString() != "00:00:00")
            {
                stopwatchText.Text = time.Elapsed.ToString().Remove(8);
            }
            if (stopwatchText.Text == "00:00:00") btnPause.Enabled = false;
            else btnPause.Enabled = true;
            if (time.Elapsed.Minutes.ToString() == "1")
            {
                time.Reset();
                stopwatchText.Text = "00:00:00";
                DialogResult tryAgain = MessageBox.Show( "Time is up\nDo you want new game", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tryAgain == DialogResult.Yes)
                {
                    resetGame();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void Shuffle()
        {
            do
            {
                int j;
                List<int> Index = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 9 };

                for (int i = 0; i < 9; i++)
                {
                    j = Index[random.Next(0, Index.Count)];
                    Index.Remove(j);
                    ((PictureBox)(puzzleBox.Controls[i])).Image = listImage[j];
                    if (j == 9) iNullImage = i;
                }
            }
            while (CheckWin());
        }

    }
}
