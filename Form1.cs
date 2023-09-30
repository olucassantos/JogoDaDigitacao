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

namespace JogoDaDigitacao
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private int dificuldade = 1000;
        Stopwatch cronometro = new Stopwatch();

        int corretos = 0;
        int errados = 0;
        int total = 0;
        float precisao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            timerJogo.Enabled = true;
            cronometro.Start();

            btnComecar.Text = "Começou";
        }

        private void timerJogo_Tick(object sender, EventArgs e)
        {
            // A cada 10 segundo a dificuldade do jogo aumenta
            if(cronometro.ElapsedMilliseconds / 1000 > dificuldade / 100)
            {
                timerJogo.Interval -= 100;
                this.dificuldade += 1000;
                prgDificuldade.Value = this.dificuldade;
            }

            // Caso tenha mais que 7 letras o jogo acaba
            if(lsbLetras.Items.Count > 5)
            {
                timerJogo.Enabled = false;
                cronometro.Stop();

                MessageBox.Show("Game Over!");

                return;
            }
            
            this.adicionarTexto();
        }

        private void adicionarTexto()
        {
            lsbLetras.Items.Add(
                (Keys) random.Next(65, 90)
            );

            total += 1;
        }

        private void verificaDigitacao(Keys key)
        {
            if (lsbLetras.Items.Count > 0)
            {
                if (key.ToString() == lsbLetras.Items[0].ToString())
                {
                    corretos += 1;
                    // Remove o primeiro elemento da lista
                    lsbLetras.Items.RemoveAt(0);
                }
                else
                {
                    errados += 1;
                }
            }
            else
            {
                errados += 1;
            }

            atualizaPlacar();
        }

        private void atualizaPlacar()
        {
            lblCorretos.Text = corretos.ToString();
            lblErrados.Text = errados.ToString();
            lblTotal.Text = total.ToString();
            
            if (total > 0)
            {
                precisao = ((float)corretos / (float)total) * 100;
            }

            lblPrecisao.Text = precisao.ToString();
        }

        private void tmrBotao_Tick(object sender, EventArgs e)
        {
            btnComecar.Text = cronometro.Elapsed.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            verificaDigitacao((Keys)e.KeyCode);
        }

        private void lsbLetras_KeyDown(object sender, KeyEventArgs e)
        {
            verificaDigitacao((Keys)e.KeyCode);
        }
    }
}
