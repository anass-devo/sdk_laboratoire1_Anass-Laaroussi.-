using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public static string Transformer(string lettre)
        {
            string note;

            switch (lettre.ToUpper())
            {
                case "A":
                    note = "LA";
                    break;
                case "B":
                    note = "SI";
                    break;
                case "C":
                    note = "DO";
                    break;
                case "D":
                    note = "RÉ";
                    break;
                case "E":
                    note = "MI";
                    break;
                case "F":
                    note = "FA";
                    break;
                case "G":
                    note = "SOL";
                    break;
                default:
                    note = "";
                    break;
            }

            return note;
        }
    }
}