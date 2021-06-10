using System.Text;
using System;

namespace ConversorNumerosRomanos
{
    public class ArabicosParaRomanos : Algarismos
    {
        public string ConverterParaArabicos(string entrada)
        {
            
            string algarismoRomano = "";
            int numeroRomano = Convert.ToInt32(entrada);

            StringBuilder saida = new StringBuilder();
            int valorParaConversao = numeroRomano;

            foreach (int valor in valoresConversao.Keys)
            {
                while (valorParaConversao >= valor)
                {
                    saida.Append(valoresConversao[valor]);
                    valorParaConversao -= valor;
                }
            }
            algarismoRomano = (saida.ToString()).ToUpper();

            return algarismoRomano;
        }
    }
}
