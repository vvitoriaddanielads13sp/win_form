using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace velhas_game
{
    public partial class Form1 : Form
    {
        int  jogadas=0;
        bool turno = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text=="")
            {
                if (turno)
                {
                    btn.Text = "X";
                    jogadas++;
                }
                else
                {
                    btn.Text = "O";
                    jogadas++;
                }turno = !turno;
            }
            //conferindo linhas
            if (btn1.Text== btn2.Text && btn1.Text== btn3.Text && btn1.Text!="")//l1C1-C3
            {
                MessageBox.Show(btn1.Text+" Venceu!");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turno =! turno;
            }
            if (btn4.Text == btn5.Text && btn4.Text == btn6.Text && btn4.Text != "")//l1C1-C3
            {
                MessageBox.Show(btn4.Text + " Venceu!");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turno = !turno;
            }
            if (btn7.Text == btn8.Text && btn7.Text == btn9.Text && btn7.Text != "")//l1C1-C3
            {
                MessageBox.Show(btn7.Text + " Venceu!");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turno = !turno;
            }

            //conferindo colunas
            if (btn1.Text == btn4.Text && btn1.Text == btn7.Text && btn1.Text != "")//l1C1
            {
                MessageBox.Show(btn1.Text + " Venceu!");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turno = !turno;
            }
            if (btn2.Text == btn5.Text && btn2.Text == btn8.Text && btn2.Text != "")//l2C2
            {
                MessageBox.Show(btn2.Text + " Venceu!");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turno = !turno;
            }
            if (btn3.Text == btn6.Text && btn3.Text == btn9.Text && btn3.Text != "")//l3C3
            {
                MessageBox.Show(btn3.Text + " Venceu!");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turno = !turno;
            }
            //conferindo diagonais
            if (btn1.Text == btn5.Text && btn1.Text == btn9.Text && btn1.Text != "")//l1C1-C3
            {
                MessageBox.Show(btn1.Text + " Venceu!");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turno = !turno;
            }
            if (btn3.Text == btn5.Text && btn3.Text == btn7.Text && btn3.Text != "")//l1C1-C3
            {
                MessageBox.Show(btn3.Text + " Venceu!");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                turno = !turno;
            }
        }
    }
}
