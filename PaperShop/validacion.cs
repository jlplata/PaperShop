using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperShop
{
    class validacion
    {
        public static void soloLetras(KeyPressEventArgs e)
        {
           if (Char.IsLetter(e.KeyChar))
           {
               e.Handled = false;
           }
           else if (Char.IsControl(e.KeyChar))
           {
               e.Handled = false;
           }
           else if (Char.IsSeparator(e.KeyChar))
           {
               e.Handled = false;
           }
           else
           {
               e.Handled = true;
           }
        }



        public static void solonumeros(KeyPressEventArgs evento)
        {
            if (char.IsNumber(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else if (char.IsControl(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else if (char.IsSeparator(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else
            {
                evento.Handled = true;
            }
        }
        public static void numsLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        public bool validarcorr(string seMailAComprobar)
        {

            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

    }
}
