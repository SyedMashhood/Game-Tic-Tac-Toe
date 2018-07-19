using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTicTocToye
{
    public partial class Form1 : Form
    {
        private bool isplayerOne;
        private int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableButton(false);
            this.BackColor = Color.LightPink;
            this.groupBox2.Text = "Player Nmae";
            this.groupBox3.Text = "X For Player";
            this.groupBox4.Text = "Start Player";
            this.label1.Text = "Player one";
            this.label2.Text = "Player two";

            this.radioButton1.Text = "Player one";
            this.radioButton2.Text = "Player two";
            this.radioButton3.Text = "Player one";
            this.radioButton4.Text = "Player two";

            startGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
        }


        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            EnableButton(false);
            startGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
            enablePlayer(true);
            buttontext();
            
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttontext();
            enablePlayer(false);
            EnableButton(true);
            startGameToolStripMenuItem.Enabled = false;
            resetGameToolStripMenuItem.Enabled = true;
            count = 0;
            isplayerOne = true;
        }
        private void EnableButton(bool enable)
        {
            button1.Enabled = enable;
            button2.Enabled = enable;
            button3.Enabled = enable;
            button4.Enabled = enable;
            button5.Enabled = enable;
            button6.Enabled = enable;
            button7.Enabled = enable;
            button8.Enabled = enable;
            button1.Enabled = enable;
        }
        private void enablePlayer(bool enable)
        {

            groupBox2.Enabled = enable;
            groupBox3.Enabled = enable;
            groupBox4.Enabled = enable;
        }

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are a good gammer solve yuor problem own");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isplayerOne == true)
            {
                b.Text = "X";
                isplayerOne = false;
                b.Enabled = false;
            }
            else
            {
                b.Text = "O";
                isplayerOne = true;
                b.Enabled = false;
            }
            count++;
            winner();
            
        }

        private void winner()
        { bool winer = false;
            if (count == 9)
            {
                MessageBox.Show("Game over , Please restart","Game Is Drawn");

                reset();
            }
            else 
            {
                if ((button1.Text == button2.Text) && (button2.Text == button3.Text) &&(!button1.Enabled))
                    winer = true;
                if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                    winer = true;
                if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button6.Enabled))
                    winer = true;
                if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                    winer = true;
                if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                    winer = true;
                if ((button3.Text == button6.Text) && (button9.Text == button3.Text) && (!button3.Enabled))
                    winer = true;
                if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                    winer = true;
                if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                    winer = true;






                if (winer == true)
                {
                    if (isplayerOne == false)
                        MessageBox.Show("Player one is wiiner!!!","Game Over",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Player two is wiiner!!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
        }
        private void buttontext()
    {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button8.Text = "";
    }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (isplayerOne == true)
            {
                this.radioButton1.Checked = true;
                this.radioButton3.Checked = true;
            }
            else
            {
                this.radioButton2.Checked = true;
                this.radioButton4.Checked = true;
            }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton4.Checked = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton2.Checked = true;
            
        }

    }
}
