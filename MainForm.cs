/*
 * Criado por SharpDevelop.
 * Usuário: adrya
 * Data: 18/10/2022
 * Hora: 21:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JOGO21
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void PlacarCOM()
		{
			int placarC = int.Parse(label7.Text);
			placarC = int.Parse(label7.Text) + 1;
			label7.Text = placarC.ToString();
		}
		void Resetar()
		{
			pictureBox3.Enabled = false;
			pictureBox4.Enabled = false;
			pictureBox5.Enabled = false;
			button2.Enabled = false;
			button1.Enabled = true;
		}
		void ZerarPlacar()
		{
			label7.Text = "0";
			label6.Text = "0";
		}
		void DesabilitaTest()
		{
			button1.Enabled = true;
			button3.Enabled = false;
		}
		
		Random rnd = new Random(); // Constante de declaração de dados
		int n6, n7; //pontuação do computador
		
		// START
		void Button1Click(object sender, EventArgs e)
		{
			pictureBox3.Load("Rodar.png");
			pictureBox4.Load("Rodar.png");
			pictureBox5.Load("Rodar.png");
			pictureBox6.Load("Rodar.png");
			pictureBox7.Load("Rodar.png");
			button3.Enabled = false;
			
			label3.Text = "0";
			label4.Text = "0";
			
			button2.Enabled = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			
			int n1 = rnd.Next(1,7); // (minimo, máximo)
			pictureBox1.Load("dado"+ n1 +".png"); // dado1.png
			
			int n2 = rnd.Next(1,7);  
			pictureBox2.Load("dado"+ n2 +".png");
			
			int soma = n1 + n2;
			label4.Text = soma.ToString();
			
			// Dados do computador recebem valor
			n6 = rnd.Next(1,7);
			n7 = rnd.Next(1,7);
			
			pictureBox3.Enabled = true;
			button1.Enabled = false;
			button2.Enabled = true;
		}
		
		// DADO 03
		void PictureBox3Click(object sender, EventArgs e)
		{
			int placarJ = int.Parse(label6.Text) + 1;
			int placarC = int.Parse(label7.Text) + 1;
			
			int n3 = rnd.Next(1,7);
			pictureBox3.Load("dado"+ n3 +".png");
			
			int soma = int.Parse(label4.Text) + n3;
			label4.Text = soma.ToString();
			
			if(soma > 13)
			{
				MessageBox.Show("Perdeu playboy! Passou de 13 já era.");
				label7.Text = placarC.ToString();
				button1.Enabled = true;
				button2.Enabled = false;
			} 
			else
			{
				pictureBox4.Visible = true;
			} 
			pictureBox3.Enabled = false;
			pictureBox4.Enabled = true;
		}
		
		// DADO 04
		void PictureBox4Click(object sender, EventArgs e)
		{
			int placarJ = int.Parse(label6.Text) + 1;
			int placarC = int.Parse(label7.Text) + 1;
			
			int n4 = rnd.Next(1,7);
			pictureBox4.Load("dado"+ n4 +".png");
			
			int soma = int.Parse(label4.Text) + n4;
			label4.Text = soma.ToString();
			
			if(soma > 19)
			{
				MessageBox.Show("Perdeu playboy! Passou de 19 já era.");
				label7.Text = placarC.ToString();
				button1.Enabled = true;
				button2.Enabled = false;
			}
			else
			{
				pictureBox5.Visible = true;
			}
			pictureBox4.Enabled = false;
			pictureBox5.Enabled = true;
			button2.Enabled = true;
		}
		
		// DADO 05
		void PictureBox5Click(object sender, EventArgs e)
		{
			int placarJ = int.Parse(label6.Text) + 1;
			int placarC = int.Parse(label7.Text) + 1;
			
			int n5 = rnd.Next(1,7);
			pictureBox5.Load("dado"+ n5 +".png");
			
			int soma = int.Parse(label4.Text) + n5;
			label4.Text = soma.ToString();
			
			if(soma > 21)
			{
				MessageBox.Show("Perdeu playboy! Passou de 21 já era.");
				label7.Text = placarC.ToString();
				button1.Enabled = true;
				button2.Enabled = false;
			}
			pictureBox5.Enabled = false;
		}
		
		// FINISH
		void Button2Click(object sender, EventArgs e)
		{
			int somaJ = int.Parse(label4.Text);
			
			label4.Text = somaJ.ToString();
			
			int n6 = rnd.Next(1,7);
			pictureBox6.Load("dado"+ n6 +".png");
			
			int n7 = rnd.Next(1,7);  
			pictureBox7.Load("dado"+ n7 +".png");
			
			int soma = n6 + n7;
			label3.Text = soma.ToString();
			
			int placarJ = int.Parse(label6.Text);
			int placarC = int.Parse(label7.Text);
			
			// PONTUAÇÃO
			if(somaJ < 12 && somaJ < soma && pictureBox4.Visible == false)
			{
				MessageBox.Show("Perdeu essa de bobeira, triste");
				PlacarCOM();
				Resetar();
				
			} 
			else if(somaJ < 12 && somaJ < soma && pictureBox4.Visible == true)
			{
				MessageBox.Show("Perdeu com mais cartas que a CPU, se deu mal.");
				PlacarCOM();
				Resetar();
				
			} 
			else if (somaJ > soma)
			{
				MessageBox.Show("Legal, tu ganhou!");
				Resetar();
				
				placarJ = int.Parse(label6.Text) + 1;
				label6.Text = placarJ.ToString();
			}
			else if (pictureBox4.Visible == false && somaJ == soma)
			{
				MessageBox.Show("Deu empate!");
				Resetar();
				
				placarC = int.Parse(label7.Text) + 0;
				placarJ = int.Parse(label6.Text) + 0;
				label6.Text = placarJ.ToString();
				label7.Text = placarC.ToString();
			}
			else if (pictureBox4.Visible == true && somaJ == soma)
			{
				MessageBox.Show("Empatou com mais cartas que a CPU!\nPerdeu, que patético HAHAHA!");
				Resetar();
				PlacarCOM();
			}
			
			if(int.Parse(label6.Text) == 3 || int.Parse(label7.Text) == 3){
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = true;
				MessageBox.Show("Clique em Test para ver o resultado final.");
			}
		}
				
		// TEST
		void Button3Click(object sender, EventArgs e)
		{
			int placarJ = int.Parse(label6.Text);
			int placarC = int.Parse(label7.Text);
			
			// PLACAR
			if(placarJ == 3 && placarC == 0)
			{
				MessageBox.Show("Você ganhou de lavada, parabéns!");
				ZerarPlacar();
				DesabilitaTest();
			}
			else if(placarC == 3 && placarJ == 0)
			{
				MessageBox.Show("Você PERDEU de lavada, tomi!");
				ZerarPlacar();
				DesabilitaTest();
			}
			else if(placarJ == 3 && placarC <= 2)
			{
				MessageBox.Show("Você ganhou na melhor de 5, parabéns!");
				ZerarPlacar();
				DesabilitaTest();
			}
			else if(placarC == 3 && placarJ <= 2)
			{
				MessageBox.Show("Você perdeu na melhor de 5, que peninha!\nTenta de novo, quem sabe você ganha.");
				ZerarPlacar();
				DesabilitaTest();
			}			
		}
	}
}
