namespace UdelasCore.Negocio.Helpers
{
    public static class FormatearCedula
    {

        public static string FormatearCedulaPanama(string parametro)
        {
            if (string.IsNullOrWhiteSpace(parametro))
                return parametro;

            char charRange = '-';
            int startIndex = parametro.IndexOf(charRange) + 1;
            int endIndex = parametro.LastIndexOf(charRange);
            int length = endIndex - startIndex;
            int endIndexFolio = parametro.LastIndexOf(charRange) + 1;

            if (startIndex > 0 && endIndex > startIndex)
            {
                string prov = parametro.Substring(0, Math.Max(parametro.IndexOf('-'), 0));
                string tomo = parametro.Substring(startIndex, length);
                string folio = parametro.Substring(endIndexFolio);

                if (prov.Length == 1)
                    prov = "0" + prov;

                tomo = tomo.PadLeft(4, '0');
                folio = folio.PadLeft(5, '0');

                return prov + "00" + tomo + folio;
            }

            return parametro;
        }
    }
}
