using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotas
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<double> notasRegistradas = new List<double>();
        //COMBO BOXX
        private int limiteNotas = 5;



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string surfistaSelecionado = comboBox1.SelectedItem.ToString();
            lvlSurfista.Text = "Surfista selecionado: " + surfistaSelecionado;

            notasRegistradas.Clear();
            AtualizarLabelNotas();
            lblMediaPontuacoes.Text = "A definir";


        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNota.Text, out double nota))
            {
                if (nota >= 1 && nota <= 10)
                {
                    if (notasRegistradas.Count < limiteNotas)
                    {
                        notasRegistradas.Add(nota);
                        AtualizarLabelNotas();
                        txtNota.Clear();
                        CalcularMediaPontuacoes();

                    }
                    else
                    {
                        MessageBox.Show($"Limite de {limiteNotas} notas atingido.");
                    }

                }
                else
                {
                    MessageBox.Show("A nota deve estar entre 1 e 10.");
                }
            }
            else
            {
                MessageBox.Show("Insira uma nota válida.");
            }
        }

        private void AtualizarLabelNotas()
        {
            lblLookNota.Text = "Notas registradas: " + string.Join(", ", notasRegistradas);
        }

        private void CalcularMediaPontuacoes()
        {
            if (notasRegistradas.Count > 4)
            {
                notasRegistradas.Sort();

                notasRegistradas.RemoveAt(0);
                notasRegistradas.RemoveAt(notasRegistradas.Count - 1);

                double media = notasRegistradas.Average();

                lblMediaPontuacoes.Text = "Média das pontuações: " + media.ToString("0.00");
            }

        }

      

        private void btnHow_Click(object sender, EventArgs e)
        {
            Funcionamento funcionamento = new Funcionamento();
            funcionamento.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            notasRegistradas.Clear();
            AtualizarLabelNotas();
            lblMediaPontuacoes.Text = "A definir";

        }
    }

}
