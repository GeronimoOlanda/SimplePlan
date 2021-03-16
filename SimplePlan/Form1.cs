using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePlan
{
    public partial class Form1 : Form
    {
        private bool flagPintar = false; // para controlar quando devemos pintar
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color colorBorracha;
        private bool flagApagar = false; //controlar quando se deve apagar com a borracha
        private Image imagemASalvar;
        private Graphics graphicsImagemASalvar;
        public Form1()
        {
            
            InitializeComponent();
            // as propriedades abaixo só funciona quando colocamos os botoes em modo flat
            //setada flat
            buttonBorracha.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonCorCaneta.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            for (int i = 2; i <= 100; i += 2)//espessura da caneta de 2 em 2
            {
                CbExpressuraCaneta.Items.Add(i);
            }
            CbExpressuraCaneta.Text = "12";//texto que irá aparecer na comboBox
            CbExpressuraCaneta.MaxDropDownItems = 10;//define o numero de itens a ser exibido em um comboBox
            CbExpressuraCaneta.IntegralHeight = false;// esse é necessario para que seja possivel definir a quantidade de itens do combobox
            colorBorracha = panelPintura.BackColor; //especifica a cor padrao da borracha do painel
            //Graphics
            graphicsPainelPintura = panelPintura.CreateGraphics();// o graphics permite desenho sobre o controle
            espessuraCaneta = float.Parse(CbExpressuraCaneta.Text);//converte o texto da comboBox Expressura para o tipo float(numero real)

           

            imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); //imagem para salvar
            graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo  graphics da imagem para salvar de forma a podermos desenhar nela
            graphicsImagemASalvar.Clear(panelPintura.BackColor);//preenchemos com a cor de fundo do painel
        
        }

        private void buttonCorCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog(); //é uma caixa de seleção de cores
            var corEscolha = colorDialog.ShowDialog(); //Exibe na forma modal -  a applicação fica travada até o usuario fazer sua escolha
            
            if(corEscolha == DialogResult.OK) //verificando se usuario clicou em OK
            {
                buttonCorCaneta.BackColor = colorDialog.Color;//alterando a cor do botao para a selecionada pelo usuario
            }
        }

        private void panelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        private void panelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }

        private void panelPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPintar)
            {
                if (!flagApagar)
                {
                    //desenhamos uma elipse
                    graphicsPainelPintura.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    graphicsImagemASalvar.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    //desenhamos uma elipse
                    graphicsPainelPintura.DrawRectangle(new Pen(colorBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                   
                    //desenhamos  na imagem para salvar
                    graphicsImagemASalvar.DrawRectangle(new Pen(colorBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                
            }
               
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            //verificando se o usuario quer limpar o desenho
            if(MessageBox.Show("Tem certeza disso? todo o desenho será excluido", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White); //limpando desenho e preenchendo o fundo de branco

                imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); //imagem para salvar
                graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo  graphics da imagem para salvar de forma a podermos desenhar nela
                graphicsImagemASalvar.Clear(panelPintura.BackColor);//preenchemos com a cor de fundo do painel
            }
        }

        private void CbExpressuraCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(CbExpressuraCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var colorDialog = new ColorDialog();
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorBorracha = colorDialog.Color;//usuario seleciona a cor da borracha
                 }
            }
            else
            {
                if (!flagApagar) //operador ! antes ira virar o valor de flag ao contrario, de true ficará false
                {
                    flagApagar = true;
                    buttonBorracha.BackColor = colorBorracha; //cor do botao sera o mesmo da borracha
                }
                else
                {
                    flagApagar = false;//borracha nao esta apagando
                    buttonBorracha.BackColor = Color.Black;//setando a cor black
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg"; //atribuindo as estensoes
           
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {   //definindo a extensao da imagem que iremos salvar
                switch (saveFileDialog.FilterIndex)
                { 
                    case 1:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }
    }
}
