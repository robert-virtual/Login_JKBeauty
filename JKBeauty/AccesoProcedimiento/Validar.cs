using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AccesoProcedimiento
{
    public class Validar
    {

        public void NumPositivo(int num)
        {
        }
        private static bool EsFecha(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool esfecha(string fecha)
        {
            return EsFecha(fecha);
        }

        private bool IsNumeric(string num)
        {
            try
            {

                float.Parse(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EsFlotante(string num)
        {
            return IsNumeric(num);
        }

    }
}