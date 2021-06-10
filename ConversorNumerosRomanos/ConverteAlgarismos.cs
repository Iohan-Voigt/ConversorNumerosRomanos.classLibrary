namespace ConversorNumerosRomanos
{
    public class ConverteAlgarismos
    {
        readonly RomanosParaArabicos ConverteNumerosParaRomanos = new RomanosParaArabicos();
        readonly ArabicosParaRomanos ConverteRomanosParaArabicos = new ArabicosParaRomanos();       

        public string ConverteParaRomanos(string algarismo) 
        {
            string algarismoConvertido = "";
            algarismoConvertido = ConverteNumerosParaRomanos.ConverterParaArabicos(algarismo);
            return algarismoConvertido;
        }

        public string ConverteParaArabicos(string algarismo)
        {
            string algarismoConvertido = "";
            algarismoConvertido = ConverteRomanosParaArabicos.ConverterParaArabicos(algarismo);
            return algarismoConvertido;
        }

    }
}
