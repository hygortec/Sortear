using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortear
{
    public partial class TelaPrincipal : Form
    {
        Random geradorAleatorio = new Random();
        List<int> numSorteados = new List<int>();

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void acaoBotaoSortear(object sender, EventArgs e)
        {
            //int sorteado = geradorAleatorio.Next(Convert.ToInt32(tbInicial.Text), Convert.ToInt32(tbFinal.Text));
            //numSorteados.Add(sorteado);

            if(!numSorteados.Count.Equals(0)){
                //MessageBox.Show("Encheu a lista");
                //String s ="";
                int indece = 0;
                Boolean aux = false;                
                int sorteado;
                int tamanhoIncialLista =  numSorteados.Count();

                while (tamanhoIncialLista == numSorteados.Count())
                {
                    sorteado = geradorAleatorio.Next(Convert.ToInt32(tbInicial.Text), Convert.ToInt32(tbFinal.Text));
                    do
                    {
                        if (sorteado == numSorteados[indece])
                        {
                            aux = true;
                        }
                        else
                        {
                            numSorteados.Add(sorteado);
                        }
                        indece++;
                    } while (!aux || indece == numSorteados.Count());
                }               
                    
                
            }

            //MessageBox.Show(Convert.ToString(sorteado));
        }
    }
}
