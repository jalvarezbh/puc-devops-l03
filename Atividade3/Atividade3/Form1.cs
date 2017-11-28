﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valorDecimal = Convert.ToDecimal(txtValor.Text);

                int valorInteiro = Convert.ToInt32(valorDecimal);

                if (valorInteiro <= 0)
                    throw new Exception();

                lstValoresTexto.Items.Add($"{txtValor.Text} - {ConvertTextual(valorInteiro.ToString())}");
            }
            catch (Exception)
            {
                lstValoresTexto.Items.Add($"{txtValor.Text} - Valor inválido");
            }
            
        }

        private string ConvertTextual(string numero)
        {
            int tamanho = numero.Length;
            int quadroValor = 0;
            StringBuilder retorno = new StringBuilder();
            while (quadroValor != tamanho)
            {
                switch (tamanho - quadroValor)
                {
                    case 3:
                        retorno.Append(VerificaCentena(Convert.ToInt16(numero.Substring(quadroValor, 1))));
                        break;
                    case 2:
                        var dezena = VerificaDezena(Convert.ToInt16(numero.Substring(quadroValor, 1)));
                        if (dezena.dez)
                        {
                            retorno.Append(VerificaUnidadeDecimal(Convert.ToInt16(numero.Substring(quadroValor + 1, 1))));
                            quadroValor = tamanho - 1;
                        }
                        else
                            retorno.Append(dezena.descricao);
                        break;
                    case 1:
                        retorno.Append(VerificaUnidade(Convert.ToInt16(numero.Substring(quadroValor, 1))));
                        break;
                    default:
                        retorno.Append("Valor Inválido");
                        break;
                }

                retorno.Append(" ");
                quadroValor++;
            }

            if (numero.Equals("1"))
                retorno.Append("real");
            else
                retorno.Append("reais");

            var resultado = retorno.ToString();
            resultado = resultado.First().ToString().ToUpper() + resultado.Substring(1);
            return resultado;

        }

        private string VerificaUnidade(short unidade)
        {
            switch (unidade)
            {
                case 1:
                    return "um";
                case 2:
                    return "dois";
                case 3:
                    return "três";
                case 4:
                    return "quatro";
                case 5:
                    return "cinco";
                case 6:
                    return "seis";
                case 7:
                    return "sete";
                case 8:
                    return "oito";
                case 9:
                    return "nove";
                default:
                    return string.Empty;
            }
        }

        private string VerificaUnidadeDecimal(short unidade)
        {
            switch (unidade)
            {
                case 0:
                    return "dez";
                case 1:
                    return "onze";
                case 2:
                    return "doze";
                case 3:
                    return "treze";
                case 4:
                    return "quatorze";
                case 5:
                    return "quinze";
                case 6:
                    return "dezesseis";
                case 7:
                    return "dezessete";
                case 8:
                    return "dezoito";
                case 9:
                    return "dezenove";
                default:
                    return string.Empty;
            }
        }

        private (string descricao, bool dez) VerificaDezena(short dezena)
        {
            switch (dezena)
            {
                case 1:
                    return ("",true);
                case 2:
                    return ("vinte", false);
                case 3:
                    return ("trinta", false);
                case 4:
                    return ("quarenta", false);
                case 5:
                    return ("cinquenta", false);
                case 6:
                    return ("sessenta", false);
                case 7:
                    return ("setenta", false);
                case 8:
                    return ("oitenta", false);
                case 9:
                    return ("noventa", false);
                default:
                    return (string.Empty,false);
            }

        }

        private string VerificaCentena(short centena)
        {
            switch (centena)
            {
                case 1:
                    return "cem";
                case 2:
                    return "duzentos";
                case 3:
                    return "trezentos";
                case 4:
                    return "quatrocentos";
                case 5:
                    return "quinhentos";
                case 6:
                    return "seiscentos";
                case 7:
                    return "setecentos";
                case 8:
                    return "oitocentos";
                case 9:
                    return "novecentos";
                default:
                    return string.Empty;
            }

        }
    }
}
