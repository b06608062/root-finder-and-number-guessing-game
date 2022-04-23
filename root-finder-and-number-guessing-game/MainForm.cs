using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace root_finder_and_number_guessing_game
{
    public partial class MainForm : Form
    {
        RootFinder myRootFinder;
        NumberGuessingGame myGame;

        public MainForm()
        {
            InitializeComponent();
            myRootFinder = new RootFinder();
            myGame = new NumberGuessingGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myRootFinder.Set(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            richTextBox1.Text = myRootFinder.FindRoot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myGame.ResetDigits();
            label4.Text = myGame.GetAnswer();
            richTextBox2.Clear();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool is_repeat = false;
                if (textBox4.Text.Length == 4)
                {
                    for (int i = 0; i < 4 && !is_repeat; i++)
                    {
                        for (int j = i + 1; j < 4; j++)
                        {
                            if (textBox4.Text[i] == textBox4.Text[j]) {
                                is_repeat = true;
                                break;
                            }
                        }
                    }

                    if (!is_repeat)
                    {
                        richTextBox2.AppendText($"{myGame.Guessing(textBox4.Text)}");
                        richTextBox2.AppendText("\n");
                        return;
                    }
                }

                richTextBox2.AppendText("請輸入 0-9 四個數(不重複)\n");
            }
        }
    }
}
