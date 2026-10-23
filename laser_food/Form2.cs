using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laser_food
{
    public partial class Form2 : Form
    {
        int etapa = 0; //menu atual da tela

        decimal subtotal = 0;
        decimal desconto = 0;
        decimal total = 0;

        bool som = true; //começa com a música ativada

        System.Media.SoundPlayer musica = new System.Media.SoundPlayer("musica.wav"); //adiciona a música de fundo

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; //inícia com a mesa 1 selecionada

            AtualizarPedido(); //atualiza o pedido na tela

            musica.PlayLooping(); //toca a música repetindo
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (etapa == 1)
            {
                //=== TÍTULO ===
                label1.Text = "ESCOLHA A MESA";
                label2.Text = "ETAPA 1 DE 4";

                //=== LEGENDA SELECIONAR ===
                label8.Text = "SELECIONE A MESA DESEJADA, APÓS CLIQUE EM CONTINUAR";

                //=== BOTÃO VOLTAR ===
                button2.Visible = false;

                //=== MENU MESA ===
                label3.BackColor = Color.Yellow;
                label3.ForeColor = Color.Black;

                //=== MENU PRATO ===
                label4.BackColor = Color.FromArgb(64, 64, 64);
                label4.ForeColor = Color.Silver;

                //=== OPÇÕES MESA ===
                comboBox1.Visible = true;
                label9.Visible = true;

                //=== PRATO 1 ===
                radioButton1.Visible = false;
                button4.Visible = false;
                pictureBox2.Visible = false;

                //=== PRATO 2 ===
                radioButton2.Visible = false;
                button5.Visible = false;
                pictureBox5.Visible = false;

                //=== PRATO 3 ===
                radioButton3.Visible = false;
                button6.Visible = false;
                pictureBox4.Visible = false;

                //=== PRATO 4 ===
                radioButton4.Visible = false;
                button7.Visible = false;
                pictureBox3.Visible = false;

                //=== PEDIDO ATUAL ===
                label7.Visible = false;
                label8.Visible = false;
                panel2.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                button16.Visible = false;
                button17.Visible = false;

                //=== QUANTIDADES PRATO ===
                numericUpDown1.Visible = false;
                numericUpDown2.Visible = false;
                numericUpDown3.Visible = false;
                numericUpDown4.Visible = false;

                etapa--; //volta para o menu anterior
            }
            else if (etapa == 2)
            {
                //=== TÍTULO ===
                label1.Text = "ESCOLHA O PRATO";
                label2.Text = "ETAPA 2 DE 4";

                //=== MENU PRATO ===
                label4.BackColor = Color.Yellow;
                label4.ForeColor = Color.Black;

                //=== MENU ACOMPANHAMENTO ===
                label5.BackColor = Color.FromArgb(64, 64, 64);
                label5.ForeColor = Color.Silver;

                //=== PRATO 1 ===
                button4.Visible = true;
                radioButton1.Visible = true;
                pictureBox2.Visible = true;

                //=== PRATO 2 ===
                button5.Visible = true;
                radioButton2.Visible = true;
                pictureBox5.Visible = true;

                //=== PRATO 3 ===
                button6.Visible = true;
                radioButton3.Visible = true;
                pictureBox4.Visible = true;

                //=== PRATO 4 ===
                button7.Visible = true;
                radioButton4.Visible = true;
                pictureBox3.Visible = true;

                //=== ACOMPANHAMENTO 2 ===
                button8.Visible = false;
                radioButton5.Visible = false;
                pictureBox6.Visible = false;

                //=== ACOMPANHAMENTO 1 ===
                button9.Visible = false;
                radioButton6.Visible = false;
                pictureBox7.Visible = false;

                //=== ACOMPANHAMENTO 3 ===
                button10.Visible = false;
                radioButton7.Visible = false;
                pictureBox8.Visible = false;

                //=== ACOMPANHAMENTO 4 ===
                button11.Visible = false;
                radioButton8.Visible = false;
                pictureBox9.Visible = false;

                //=== QUANTIDADES PRATO ===
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
                numericUpDown3.Visible = true;
                numericUpDown4.Visible = true;

                //=== QUANTIDADES ACOMPANHAMENTO ===
                numericUpDown5.Visible = false;
                numericUpDown6.Visible = false;
                numericUpDown7.Visible = false;
                numericUpDown8.Visible = false;

                etapa--; //volta para o menu anterior
            }
            else if (etapa == 3)
            {
                //=== TÍTULO ===
                label1.Text = "ESCOLHA O ACOMPANHAMENTO";
                label2.Text = "ETAPA 3 DE 4";

                //=== MENU ACOMPANHAMENTO ===
                label5.BackColor = Color.Yellow;
                label5.ForeColor = Color.Black;

                //=== MENU BEBIDA ===
                label6.BackColor = Color.FromArgb(64, 64, 64);
                label6.ForeColor = Color.Silver;

                //=== ACOMPANHAMENTO 2 ===
                button8.Visible = true;
                radioButton5.Visible = true;
                pictureBox6.Visible = true;

                //=== ACOMPANHAMENTO 1 ===
                button9.Visible = true;
                radioButton6.Visible = true;
                pictureBox7.Visible = true;

                //=== ACOMPANHAMENTO 3 ===
                button10.Visible = true;
                radioButton7.Visible = true;
                pictureBox8.Visible = true;

                //=== ACOMPANHAMENTO 4 ===
                button11.Visible = true;
                radioButton8.Visible = true;
                pictureBox9.Visible = true;

                //=== BEBIDA 1 ===
                button12.Visible = false;
                radioButton9.Visible = false;
                button12.SendToBack();
                pictureBox11.Visible = false;

                //=== BEBIDA 2 ===
                button13.Visible = false;
                radioButton10.Visible = false;
                button13.SendToBack();
                pictureBox12.Visible = false;

                //=== BEBIDA 3 ===
                button14.Visible = false;
                radioButton11.Visible = false;
                button14.SendToBack();
                pictureBox13.Visible = false;

                //=== BEBIDA 4 ===
                button15.Visible = false;
                radioButton12.Visible = false;
                button15.SendToBack();
                pictureBox14.Visible = false;

                //=== BOTÃO CONTINUAR ===
                button1.Visible = true;

                //=== QUANTIDADES BEBIDA ===
                numericUpDown9.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
                numericUpDown12.Visible = false;

                //=== QUANTIDADES ACOMPANHAMENTO ===
                numericUpDown5.Visible = true;
                numericUpDown6.Visible = true;
                numericUpDown7.Visible = true;
                numericUpDown8.Visible = true;

                etapa--; //volta para o menu anterior
            }
            else
            {
                MessageBox.Show("NÃO É POSSÍVEL VOLTAR", "TOMOU LASER!"); //não deixa voltar do menu da mesa
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (etapa == 0)
            {
                //=== TÍTULO ===
                label1.Text = "ESCOLHA O PRATO";
                label2.Text = "ETAPA 2 DE 4";

                //=== LEGENDA SELECIONAR ===
                label8.Visible = true;
                label8.Text = "SELECIONE O PRATO DESEJADO, APÓS CLIQUE EM CONTINUAR";

                //=== BOTÃO VOLTAR ===
                button2.Visible = true;

                //=== MENU MESA ===
                label3.BackColor = Color.Red;
                label3.ForeColor = Color.White;

                //=== MENU PRATO ===
                label4.BackColor = Color.Yellow;
                label4.ForeColor = Color.Black;

                //=== OPÇÕES MESA ===
                comboBox1.Visible = false;
                label9.Visible = false;

                //=== PRATO 1 ===
                button4.Visible = true;
                radioButton1.Visible = true;
                pictureBox2.Visible = true;

                //=== PRATO 2 ===
                button5.Visible = true;
                radioButton2.Visible = true;
                button5.SendToBack();
                pictureBox5.Visible = true;

                //=== PRATO 3 ===
                button6.Visible = true;
                radioButton3.Visible = true;
                button6.SendToBack();
                pictureBox4.Visible = true;

                //=== PRATO 4 ===
                button7.Visible = true;
                radioButton4.Visible = true;
                button7.SendToBack();
                pictureBox3.Visible = true;

                //=== PEDIDO ATUAL ===
                label7.Visible = true;
                label10.Visible = true;
                panel2.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                button16.Visible = true;
                button17.Visible = true;

                //=== QUANTIDADES PRATO ===
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
                numericUpDown3.Visible = true;
                numericUpDown4.Visible = true;


                etapa++; //vai para o próximo menu
            }

            else if (etapa == 1)
            {
                //=== TÍTULO ===
                label1.Text = "ESCOLHA O ACOMPANHAMENTO";
                label2.Text = "ETAPA 3 DE 4";

                //=== LEGENDA SELECIONAR ===
                label8.Visible = true;
                label8.Text = "SELECIONE O ACOMPANHAMENTO DESEJADO, APÓS CLIQUE EM CONTINUAR";

                //=== MENU PRATO ===
                label4.BackColor = Color.Red;
                label4.ForeColor = Color.White;

                //=== MENU ACOMPANHAMENTO ===
                label5.BackColor = Color.Yellow;
                label5.ForeColor = Color.Black;

                //=== PRATO 1 ===
                button4.Visible = false;
                radioButton1.Visible = false;
                pictureBox2.Visible = false;

                //=== PRATO 2 ===
                button5.Visible = false;
                radioButton2.Visible = false;
                pictureBox5.Visible = false;

                //=== PRATO 3 ===
                button6.Visible = false;
                radioButton3.Visible = false;
                pictureBox4.Visible = false;

                //=== PRATO 4 ===
                button7.Visible = false;
                radioButton4.Visible = false;
                pictureBox3.Visible = false;

                //=== ACOMPANHAMENTO 2 ===
                button8.Visible = true;
                radioButton5.Visible = true;
                button8.SendToBack();
                pictureBox6.Visible = true;

                //=== ACOMPANHAMENTO 1 ===
                button9.Visible = true;
                radioButton6.Visible = true;
                button9.SendToBack();
                pictureBox7.Visible = true;

                //=== ACOMPANHAMENTO 3 ===
                button10.Visible = true;
                radioButton7.Visible = true;
                button10.SendToBack();
                pictureBox8.Visible = true;

                //=== ACOMPANHAMENTO 4 ===
                button11.Visible = true;
                radioButton8.Visible = true;
                button11.SendToBack();
                pictureBox9.Visible = true;

                //=== QUANTIDADES PRATO ===
                numericUpDown1.Visible = false;
                numericUpDown2.Visible = false;
                numericUpDown3.Visible = false;
                numericUpDown4.Visible = false;

                //=== QUANTIDADES ACOMPANHAMENTO ===
                numericUpDown5.Visible = true;
                numericUpDown6.Visible = true;
                numericUpDown7.Visible = true;
                numericUpDown8.Visible = true;

                etapa++; //vai para o próximo menu
            }
            else if (etapa == 2)
            {
                //=== TÍTULO ===
                label1.Text = "ESCOLHA A BEBIDA";
                label2.Text = "ETAPA 4 DE 4";

                //=== LEGENDA SELECIONAR ===
                label8.Visible = true;
                label8.Text = "SELECIONE A BEBIDA DESEJADA, APÓS CLIQUE EM FINALIZAR";

                //=== MENU ACOMPANHAMENTO ===
                label5.BackColor = Color.Red;
                label5.ForeColor = Color.White;

                //=== MENU BEBIDA ===
                label6.BackColor = Color.Yellow;
                label6.ForeColor = Color.Black;

                //=== ACOMPANHAMENTO 2 ===
                button8.Visible = false;
                radioButton5.Visible = false;
                button8.SendToBack();
                pictureBox6.Visible = false;

                //=== ACOMPANHAMENTO 1 ===
                button9.Visible = false;
                radioButton6.Visible = false;
                button9.SendToBack();
                pictureBox7.Visible = false;

                //=== ACOMPANHAMENTO 3 ===
                button10.Visible = false;
                radioButton7.Visible = false;
                button10.SendToBack();
                pictureBox8.Visible = false;

                //=== ACOMPANHAMENTO 4 ===
                button11.Visible = false;
                radioButton8.Visible = false;
                button11.SendToBack();
                pictureBox9.Visible = false;

                //=== BEBIDA 1 ===
                button12.Visible = true;
                radioButton9.Visible = true;
                button12.SendToBack();
                pictureBox11.Visible = true;

                //=== BEBIDA 2 ===
                button13.Visible = true;
                radioButton10.Visible = true;
                button13.SendToBack();
                pictureBox12.Visible = true;

                //=== BEBIDA 3 ===
                button14.Visible = true;
                radioButton11.Visible = true;
                button14.SendToBack();
                pictureBox13.Visible = true;

                //=== BEBIDA 4 ===
                button15.Visible = true;
                radioButton12.Visible = true;
                button15.SendToBack();
                pictureBox14.Visible = true;

                //=== BOTÃO CONTINUAR ===
                button1.Visible = false;

                //=== QUANTIDADES ACOMPANHAMENTO ===
                numericUpDown5.Visible = false;
                numericUpDown6.Visible = false;
                numericUpDown7.Visible = false;
                numericUpDown8.Visible = false;

                //=== QUANTIDADES BEBIDA ===
                numericUpDown9.Visible = true;
                numericUpDown10.Visible = true;
                numericUpDown11.Visible = true;
                numericUpDown12.Visible = true;
                numericUpDown9.BringToFront();
                numericUpDown10.BringToFront();
                numericUpDown11.BringToFront();
                numericUpDown12.BringToFront();

                etapa++; //vai para o próximo menu
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("REALMENTE DESEJA SAIR?", "VAI SE QUEIMAR!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //=== PRATO 1 ===
                radioButton1.BackColor = Color.Yellow;
                radioButton1.ForeColor = Color.Black;
                button4.BackColor = Color.Yellow;
                pictureBox2.BackColor = Color.Yellow;
            }
            else if (radioButton1.Checked == false)
            {
                //=== PRATO 1 ===
                radioButton1.BackColor = Color.Black;
                radioButton1.ForeColor = Color.White;
                button4.BackColor = Color.Black;
                pictureBox2.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton1.Checked == true && numericUpDown1.Value == 0)
            {
                numericUpDown1.Value = 1;
            }
            else if (radioButton1.Checked == false)
            {
                numericUpDown1.Value = 0;
            }
            AtualizarPedido();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton1.Tag != null && (bool)radioButton1.Tag == true)
            {
                radioButton1.Checked = false;
                radioButton1.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton1.Checked = true;
                radioButton1.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                //=== PRATO 2 ===
                radioButton2.BackColor = Color.Yellow;
                radioButton2.ForeColor = Color.Black;
                button5.BackColor = Color.Yellow;
                pictureBox5.BackColor = Color.Yellow;
            }
            else if (radioButton2.Checked == false)
            {
                //=== PRATO 2 ===
                radioButton2.BackColor = Color.Black;
                radioButton2.ForeColor = Color.White;
                button5.BackColor = Color.Black;
                pictureBox5.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton2.Checked == true && numericUpDown2.Value == 0)
            {
                numericUpDown2.Value = 1;
            }
            else if (radioButton2.Checked == false)
            {
                numericUpDown2.Value = 0;
            }
            AtualizarPedido();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                //=== PRATO 3 ===
                radioButton3.BackColor = Color.Yellow;
                radioButton3.ForeColor = Color.Black;
                button6.BackColor = Color.Yellow;
                pictureBox4.BackColor = Color.Yellow;
            }
            else if (radioButton3.Checked == false)
            {
                //=== PRATO 3 ===
                radioButton3.BackColor = Color.Black;
                radioButton3.ForeColor = Color.White;
                button6.BackColor = Color.Black;
                pictureBox4.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton3.Checked == true && numericUpDown4.Value == 0)
            {
                numericUpDown4.Value = 1;
            }
            else if (radioButton3.Checked == false)
            {
                numericUpDown4.Value = 0;
            }
            AtualizarPedido();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                //=== PRATO 4 ===
                radioButton4.BackColor = Color.Yellow;
                radioButton4.ForeColor = Color.Black;
                button7.BackColor = Color.Yellow;
                pictureBox3.BackColor = Color.Yellow;
            }
            else if (radioButton4.Checked == false)
            {
                //=== PRATO 4 ===
                radioButton4.BackColor = Color.Black;
                radioButton4.ForeColor = Color.White;
                button7.BackColor = Color.Black;
                pictureBox3.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton4.Checked == true && numericUpDown3.Value == 0)
            {
                numericUpDown3.Value = 1;
            }
            else if (radioButton4.Checked == false)
            {
                numericUpDown3.Value = 0;
            }
            AtualizarPedido();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton2.Tag != null && (bool)radioButton2.Tag == true)
            {
                radioButton2.Checked = false;
                radioButton2.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton2.Checked = true;
                radioButton2.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton4.Tag != null && (bool)radioButton4.Tag == true)
            {
                radioButton4.Checked = false;
                radioButton4.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton4.Checked = true;
                radioButton4.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton3.Tag != null && (bool)radioButton3.Tag == true)
            {
                radioButton3.Checked = false;
                radioButton3.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton3.Checked = true;
                radioButton3.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                //=== ACOMPANHAMENTO 1 ===
                radioButton6.BackColor = Color.Yellow;
                radioButton6.ForeColor = Color.Black;
                button9.BackColor = Color.Yellow;
                pictureBox7.BackColor = Color.Yellow;
            }
            else if (radioButton6.Checked == false)
            {
                //=== ACOMPANHAMENTO 1 ===
                radioButton6.BackColor = Color.Black;
                radioButton6.ForeColor = Color.White;
                button9.BackColor = Color.Black;
                pictureBox7.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton6.Checked == true && numericUpDown5.Value == 0)
            {
                numericUpDown5.Value = 1;
            }
            else if (radioButton6.Checked == false)
            {
                numericUpDown5.Value = 0;
            }
            AtualizarPedido();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                //=== ACOMPANHAMENTO 2 ===
                radioButton5.BackColor = Color.Yellow;
                radioButton5.ForeColor = Color.Black;
                button8.BackColor = Color.Yellow;
                pictureBox6.BackColor = Color.Yellow;
            }
            else if (radioButton5.Checked == false)
            {
                //=== ACOMPANHAMENTO 2 ===
                radioButton5.BackColor = Color.Black;
                radioButton5.ForeColor = Color.White;
                button8.BackColor = Color.Black;
                pictureBox6.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton5.Checked == true && numericUpDown6.Value == 0)
            {
                numericUpDown6.Value = 1;
            }
            else if (radioButton5.Checked == false)
            {
                numericUpDown6.Value = 0;
            }
            AtualizarPedido();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                //=== ACOMPANHAMENTO 3 ===
                radioButton7.BackColor = Color.Yellow;
                radioButton7.ForeColor = Color.Black;
                button10.BackColor = Color.Yellow;
                pictureBox8.BackColor = Color.Yellow;
            }
            else if (radioButton7.Checked == false)
            {
                //=== ACOMPANHAMENTO 3 ===
                radioButton7.BackColor = Color.Black;
                radioButton7.ForeColor = Color.White;
                button10.BackColor = Color.Black;
                pictureBox8.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton7.Checked == true && numericUpDown7.Value == 0)
            {
                numericUpDown7.Value = 1;
            }
            else if (radioButton7.Checked == false)
            {
                numericUpDown7.Value = 0;
            }
            AtualizarPedido();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                //=== ACOMPANHAMENTO 4 ===
                radioButton8.BackColor = Color.Yellow;
                radioButton8.ForeColor = Color.Black;
                button11.BackColor = Color.Yellow;
                pictureBox9.BackColor = Color.Yellow;
            }
            else if (radioButton8.Checked == false)
            {
                //=== ACOMPANHAMENTO 4 ===
                radioButton8.BackColor = Color.Black;
                radioButton8.ForeColor = Color.White;
                button11.BackColor = Color.Black;
                pictureBox9.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton8.Checked == true && numericUpDown8.Value == 0)
            {
                numericUpDown8.Value = 1;
            }
            else if (radioButton8.Checked == false)
            {
                numericUpDown8.Value = 0;
            }
            AtualizarPedido();
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton6.Tag != null && (bool)radioButton6.Tag == true)
            {
                radioButton6.Checked = false;
                radioButton6.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton6.Checked = true;
                radioButton6.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton5.Tag != null && (bool)radioButton5.Tag == true)
            {
                radioButton5.Checked = false;
                radioButton5.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton5.Checked = true;
                radioButton5.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton8.Tag != null && (bool)radioButton8.Tag == true)
            {
                radioButton8.Checked = false;
                radioButton8.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton8.Checked = true;
                radioButton8.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton7.Tag != null && (bool)radioButton7.Tag == true)
            {
                radioButton7.Checked = false;
                radioButton7.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton7.Checked = true;
                radioButton7.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (som == true)
            {
                musica.Stop(); //música para

                pictureBox10.Image = Properties.Resources.som_mutado1;

                som = false;
            }
            else if (som == false)
            {
                musica.PlayLooping(); //música volta a tocar

                pictureBox10.Image = Properties.Resources.som_ligado;

                som = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                //=== BEBIDA 1 ===
                radioButton9.BackColor = Color.Yellow;
                radioButton9.ForeColor = Color.Black;
                button12.BackColor = Color.Yellow;
                pictureBox11.BackColor = Color.Yellow;
            }
            else if (radioButton9.Checked == false)
            {
                //=== BEBIDA 1 ===
                radioButton9.BackColor = Color.Black;
                radioButton9.ForeColor = Color.White;
                button12.BackColor = Color.Black;
                pictureBox11.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton9.Checked == true && numericUpDown9.Value == 0)
            {
                numericUpDown9.Value = 1;
            }
            else if (radioButton9.Checked == false)
            {
                numericUpDown9.Value = 0;
            }
            AtualizarPedido();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                //=== BEBIDA 3 ===
                radioButton11.BackColor = Color.Yellow;
                radioButton11.ForeColor = Color.Black;
                button14.BackColor = Color.Yellow;
                pictureBox13.BackColor = Color.Yellow;
            }
            else if (radioButton11.Checked == false)
            {
                //=== BEBIDA 3 ===
                radioButton11.BackColor = Color.Black;
                radioButton11.ForeColor = Color.White;
                button14.BackColor = Color.Black;
                pictureBox13.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton11.Checked == true && numericUpDown11.Value == 0)
            {
                numericUpDown11.Value = 1;
            }
            else if (radioButton11.Checked == false)
            {
                numericUpDown11.Value = 0;
            }
            AtualizarPedido();
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton9.Tag != null && (bool)radioButton9.Tag == true)
            {
                radioButton9.Checked = false;
                radioButton9.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton9.Checked = true;
                radioButton9.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton10.Tag != null && (bool)radioButton10.Tag == true)
            {
                radioButton10.Checked = false;
                radioButton10.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton10.Checked = true;
                radioButton10.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton11.Tag != null && (bool)radioButton11.Tag == true)
            {
                radioButton11.Checked = false;
                radioButton11.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton11.Checked = true;
                radioButton11.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                //=== BEBIDA 4 ===
                radioButton12.BackColor = Color.Yellow;
                radioButton12.ForeColor = Color.Black;
                button15.BackColor = Color.Yellow;
                pictureBox14.BackColor = Color.Yellow;
            }
            else if (radioButton12.Checked == false)
            {
                //=== BEBIDA 4 ===
                radioButton12.BackColor = Color.Black;
                radioButton12.ForeColor = Color.White;
                button15.BackColor = Color.Black;
                pictureBox14.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton12.Checked == true && numericUpDown12.Value == 0)
            {
                numericUpDown12.Value = 1;
            }
            else if (radioButton12.Checked == false)
            {
                numericUpDown12.Value = 0;
            }
            AtualizarPedido();
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            // Verifica se ele já estava marcado antes de receber este clique
            if (radioButton12.Tag != null && (bool)radioButton12.Tag == true)
            {
                radioButton12.Checked = false;
                radioButton12.Tag = false; // Atualiza o estado na Tag
            }
            else
            {
                radioButton12.Checked = true;
                radioButton12.Tag = true; // Atualiza o estado na Tag
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                //=== BEBIDA 2 ===
                radioButton10.BackColor = Color.Yellow;
                radioButton10.ForeColor = Color.Black;
                button13.BackColor = Color.Yellow;
                pictureBox12.BackColor = Color.Yellow;
            }
            else if (radioButton10.Checked == false)
            {
                //=== BEBIDA 2 ===
                radioButton10.BackColor = Color.Black;
                radioButton10.ForeColor = Color.White;
                button13.BackColor = Color.Black;
                pictureBox12.BackColor = Color.Black;
            }

            //atualiza a quantidade do produto
            if (radioButton10.Checked == true && numericUpDown10.Value == 0)
            {
                numericUpDown10.Value = 1;
            }
            else if (radioButton10.Checked == false)
            {
                numericUpDown10.Value = 0;
            }
            AtualizarPedido();
        }


        private void Quantidade_ValueChanged(object sender, EventArgs e)
        {
            //atualiza o pedido quando a quantidade muda
            if (numericUpDown1.Value > 0) radioButton1.Checked = true;
            else radioButton1.Checked = false;
            radioButton1.Tag = radioButton1.Checked;
            if (numericUpDown2.Value > 0) radioButton2.Checked = true;
            else radioButton2.Checked = false;
            radioButton2.Tag = radioButton2.Checked;
            if (numericUpDown3.Value > 0) radioButton4.Checked = true;
            else radioButton4.Checked = false;
            radioButton4.Tag = radioButton4.Checked;
            if (numericUpDown4.Value > 0) radioButton3.Checked = true;
            else radioButton3.Checked = false;
            radioButton3.Tag = radioButton3.Checked;
            if (numericUpDown5.Value > 0) radioButton6.Checked = true;
            else radioButton6.Checked = false;
            radioButton6.Tag = radioButton6.Checked;
            if (numericUpDown6.Value > 0) radioButton5.Checked = true;
            else radioButton5.Checked = false;
            radioButton5.Tag = radioButton5.Checked;
            if (numericUpDown7.Value > 0) radioButton7.Checked = true;
            else radioButton7.Checked = false;
            radioButton7.Tag = radioButton7.Checked;
            if (numericUpDown8.Value > 0) radioButton8.Checked = true;
            else radioButton8.Checked = false;
            radioButton8.Tag = radioButton8.Checked;
            if (numericUpDown9.Value > 0) radioButton9.Checked = true;
            else radioButton9.Checked = false;
            radioButton9.Tag = radioButton9.Checked;
            if (numericUpDown10.Value > 0) radioButton10.Checked = true;
            else radioButton10.Checked = false;
            radioButton10.Tag = radioButton10.Checked;
            if (numericUpDown11.Value > 0) radioButton11.Checked = true;
            else radioButton11.Checked = false;
            radioButton11.Tag = radioButton11.Checked;
            if (numericUpDown12.Value > 0) radioButton12.Checked = true;
            else radioButton12.Checked = false;
            radioButton12.Tag = radioButton12.Checked;
            AtualizarPedido();
        }

        private void Mesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarPedido();
        }

        private void AtualizarPedido()
        {
            //=== PEDIDO ATUAL ===
            listBox1.Items.Clear();
            subtotal = 0;
            label10.Text = comboBox1.Text;

            //=== PRODUTOS ===
            for (int i = 1; i <= 12; i++)
            {
                string produto = "";
                decimal preco = 0;
                decimal quantidade = 0;

                if (i == 1 && radioButton1.Checked)
                {
                    produto = "Pizza de Banana";
                    preco = 59.99m;
                    quantidade = numericUpDown1.Value;
                }
                else if (i == 2 && radioButton2.Checked)
                {
                    produto = "Lasanha de Berinjela";
                    preco = 39.99m;
                    quantidade = numericUpDown2.Value;
                }
                else if (i == 3 && radioButton3.Checked)
                {
                    produto = "Macarrão com Sardinha";
                    preco = 24.99m;
                    quantidade = numericUpDown4.Value;
                }
                else if (i == 4 && radioButton4.Checked)
                {
                    produto = "Tapioca de Manteiga";
                    preco = 11.99m;
                    quantidade = numericUpDown3.Value;
                }
                else if (i == 5 && radioButton5.Checked)
                {
                    produto = "Bacia de Batata Doce";
                    preco = 14.99m;
                    quantidade = numericUpDown6.Value;
                }
                else if (i == 6 && radioButton6.Checked)
                {
                    produto = "Porção de Torresmo";
                    preco = 20.99m;
                    quantidade = numericUpDown5.Value;
                }
                else if (i == 7 && radioButton7.Checked)
                {
                    produto = "Queijo Mineiro";
                    preco = 59.99m;
                    quantidade = numericUpDown7.Value;
                }
                else if (i == 8 && radioButton8.Checked)
                {
                    produto = "Saco de Licuri Assado";
                    preco = 9.99m;
                    quantidade = numericUpDown8.Value;
                }
                else if (i == 9 && radioButton9.Checked)
                {
                    produto = "Jarra de Suco de Açaí";
                    preco = 16.99m;
                    quantidade = numericUpDown9.Value;
                }
                else if (i == 10 && radioButton10.Checked)
                {
                    produto = "Jarra de Suco de Cajá";
                    preco = 16.99m;
                    quantidade = numericUpDown10.Value;
                }
                else if (i == 11 && radioButton11.Checked)
                {
                    produto = "Guaraná Jesus";
                    preco = 0.99m;
                    quantidade = numericUpDown11.Value;
                }
                else if (i == 12 && radioButton12.Checked)
                {
                    produto = "Refresco de Tamarindo";
                    preco = 9.99m;
                    quantidade = numericUpDown12.Value;
                }

                if (quantidade > 0)
                {
                    decimal valor = preco * quantidade;
                    listBox1.Items.Add(quantidade + "x " + produto + " - R$ " + valor.ToString("N2"));
                    subtotal += valor;
                }
            }

            //=== DESCONTO ===
            if (subtotal > 100)
            {
                desconto = subtotal * 0.10m;
            }
            else
            {
                desconto = 0;
            }

            //=== VALORES DO PEDIDO ===
            total = subtotal - desconto;
            label16.Text = "R$ " + subtotal.ToString("N2");
            label15.Text = "-R$ " + desconto.ToString("N2");
            label12.Text = "R$ " + total.ToString("N2");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //=== FINALIZAR PEDIDO ===
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("SELECIONE PELO MENOS UM PRODUTO!", "LASER FOOD!");
            }
            else
            {
                MessageBox.Show("PEDIDO REALIZADO COM SUCESSO!", "LASER FOOD!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //=== LIMPAR PEDIDO ===
            DialogResult resposta = MessageBox.Show("REALMENTE DESEJA LIMPAR O PEDIDO?", "LASER FOOD!", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                radioButton1.Checked = false;
                radioButton1.Tag = false;
                radioButton2.Checked = false;
                radioButton2.Tag = false;
                radioButton3.Checked = false;
                radioButton3.Tag = false;
                radioButton4.Checked = false;
                radioButton4.Tag = false;
                radioButton5.Checked = false;
                radioButton5.Tag = false;
                radioButton6.Checked = false;
                radioButton6.Tag = false;
                radioButton7.Checked = false;
                radioButton7.Tag = false;
                radioButton8.Checked = false;
                radioButton8.Tag = false;
                radioButton9.Checked = false;
                radioButton9.Tag = false;
                radioButton10.Checked = false;
                radioButton10.Tag = false;
                radioButton11.Checked = false;
                radioButton11.Tag = false;
                radioButton12.Checked = false;
                radioButton12.Tag = false;

                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
                numericUpDown5.Value = 0;
                numericUpDown6.Value = 0;
                numericUpDown7.Value = 0;
                numericUpDown8.Value = 0;
                numericUpDown9.Value = 0;
                numericUpDown10.Value = 0;
                numericUpDown11.Value = 0;
                numericUpDown12.Value = 0;

                comboBox1.SelectedIndex = 0;

                while (etapa > 0)
                {
                    button2.PerformClick();
                }

                AtualizarPedido();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Define a cor da borda (ex: Vermelho ou Amarelo)
            Color corBorda = Color.FromArgb(255, 0, 0); // Vermelho
            int espessuraBorda = 2; // Espessura em pixéis

            // Desenha o retângulo da borda nas dimensões exatas do painel
            using (Pen pen = new Pen(corBorda, espessuraBorda))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panel2.Width - 1, panel2.Height - 1);
            }
        }
    }
}