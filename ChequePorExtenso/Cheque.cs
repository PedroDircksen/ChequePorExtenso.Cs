using System;
using System.Collections.Generic;

namespace ChequePorExtenso
{
    public class Cheque
    {
        public string strValor, cem, mil, milhoes, bilhoes;
        public double valor;
        public string resultado;
        public string[] valoresSeparadosString;
        public double[] valoresSeparadosDouble = new double[20];
        EscrevePorExtenso escreve = new EscrevePorExtenso();

        public Cheque(double v)
        {
            valor = v;
            strValor = valor.ToString("000000000000.00");
            resultado = validarNumero(valor);
            if (resultado != "Número Inválido")
            {
                SeparadorNumero(ref valoresSeparadosString);
                EscrevedorNumero();
            }
        }

        private string validarNumero(double valor)
        {
            if (valor > 999999999999.99)
                resultado = "Número Inválido";
            else
                resultado = "";

            return resultado;
        }

        private void EscrevedorNumero()
        {
            resultado = escreve.EscreveNumeroAteTresDigitos(Convert.ToDouble(bilhoes));

            if (Convert.ToDouble(bilhoes) != 0)
            {
                if (Convert.ToDouble(bilhoes) == 1)
                    resultado += "bilhão ";
                else
                    resultado += "bilhões ";
            }

            resultado += escreve.EscreveNumeroAteTresDigitos(Convert.ToDouble(milhoes));

            if (Convert.ToDouble(milhoes) != 0)
            {
                if (Convert.ToDouble(milhoes) == 1)
                    resultado += "milhão ";
                else
                    resultado += "milhões ";
            }

            resultado += escreve.EscreveNumeroAteTresDigitos(Convert.ToDouble(mil));

            if (Convert.ToDouble(mil) != 0)
            {
                if (cem.Substring(0, 1) != "0" && cem.Substring(1, 1) == "0" && cem.Substring(2, 1) == "0")
                    resultado += "mil e ";
                else
                    resultado += "mil ";
            }

            resultado += escreve.EscreveNumeroAteTresDigitos(Convert.ToDouble(cem));

            if(valoresSeparadosDouble[0] != 0)
            {
                if (Convert.ToDouble(valoresSeparadosDouble[0]) == 1 && Convert.ToDouble(valoresSeparadosDouble[1]) != 0)
                    resultado += " real e ";
                else if (Convert.ToDouble(valoresSeparadosDouble[0]) > 1 && Convert.ToDouble(valoresSeparadosDouble[1]) != 0)
                    resultado += "reais e ";
                else if (Convert.ToDouble(valoresSeparadosDouble[0]) == 1 && Convert.ToDouble(valoresSeparadosDouble[1]) == 0)
                    resultado += "real";
                else if (Convert.ToDouble(valoresSeparadosDouble[0]) > 1 && Convert.ToDouble(valoresSeparadosDouble[1]) == 0)
                    resultado += "reais";
            }

            resultado += escreve.EscreveOsCentavos(valoresSeparadosDouble[1]);

            if (valoresSeparadosDouble[1] != 0)
            {
                if (Convert.ToDouble(valoresSeparadosDouble[1]) == 1)
                    resultado += "centavo de real";
                else
                    resultado += "centavos de real";
            }
        }

        private void SeparadorReaisECentavos(ref string strValor, ref double[] valoresSeparadosDouble)
        {
            valoresSeparadosString = strValor.Split('.', ',');
            valoresSeparadosDouble[0] = Convert.ToDouble(valoresSeparadosString[0]);
            valoresSeparadosDouble[1] = Convert.ToDouble(valoresSeparadosString[1]);
        }

        private void SeparadorNumero(ref string[] valoresSeparadosString)
        {
            SeparadorReaisECentavos(ref strValor, ref valoresSeparadosDouble);
            bilhoes = valoresSeparadosString[0].Substring(0, 3);
            milhoes = valoresSeparadosString[0].Substring(3, 3);
            mil = valoresSeparadosString[0].Substring(6, 3);
            cem = valoresSeparadosString[0].Substring(9, 3);
        }
    }
}