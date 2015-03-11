using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string contents;
        public string lastSign;
        int swapper;
        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NumberThree_Click(object sender, EventArgs e)
        {

        }

        private void NumberTwo_Click(object sender, EventArgs e)
        {

        }

        private void NumberOne_Click(object sender, EventArgs e)
        {
            if (contents == null)
            {
                try
                {
                    int switchCase = 1;
                    if (lastSign != null)
                    {
                        if (lastSign == "+")
                        {
                            switchCase = 1;
                        }else if(lastSign == "-")
                        {
                            switchCase = 2;
                        }
                        else if (lastSign == "*")
                        {
                            switchCase = 3;
                        }else if (lastSign == "/")
                        {
                            switchCase = 4;
                        }
                        else { MessageBox.Show("Error with NumberOne sign switch case. Please report to creator!"); }
                        
                        switch (switchCase)
                        {
                                
                            case 1:
                                swapper = 0;
                                swapper = swapper + 1;
                                contents = swapper.ToString();
                                lastSign = null;
                                break;

                            case 2:
                                swapper = 0;
                                swapper = swapper - 1;
                                contents = swapper.ToString();
                                lastSign = null;
                                break;

                            case 3:
                                swapper = 0;
                                swapper = swapper * 1; // I realize that this gives me 0, but who cares. Might as well.
                                contents = swapper.ToString();
                                lastSign = null;
                                break;
                            case 4:
                                MessageBox.Show("You cannot divide by zero. Sorry!");
                                lastSign = null;
                                break;
                        }

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (lastSign == null)
                {

                }
            }
int oneMod = Int32.Parse(contents);
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {

        }

        private void NumberFour_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {

        }

        private void ClearSign_Click(object sender, EventArgs e)
        {

        }
        
        private void text_TextChanged(object sender, EventArgs e)
        {
            text.Text = contents;
        }
    }
}
