using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace velhasgame
{
    public partial class Form1 : Form
    {
        int xplayer = 0, oplayer = 0, jogadas=0;
        //jogadas para calc vencedor
        bool turno = true; 

        // turno x = true 
        // turno o = false

        public Form1()
        {
            InitializeComponent();
        }

        private void Placar_Click(object sender, EventArgs e)
        {
            //verificar seq. dos btn
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn(object sender, EventArgs e)
        {
            Button btn = sender as Button; //atribuindo mesma função para todos os botões
            if (btn.Text=="")//verificando disponibilidade do btn
            {
                if (turno) // verificando qual jogador
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
                   

        }
    }
}
