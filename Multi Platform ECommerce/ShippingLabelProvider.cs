using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce
{
    public static class LabelGenerator
    {
        public static void simplelabel(List<string> addressString, string outfile)
        {
            int pagesNeeded = 0;
            int places = addressString.Count;
            pagesNeeded = (int)Math.Ceiling(places / 14.0);
            int spots = pagesNeeded * 14;
            string h = "<!DOCTYPE html><meta content=\"text/html; charset = UTF-8\"http-equiv=Content-Type><link href=./m2.css rel=stylesheet>";
            h += "<div class=\"page\">";
            int pg = 1;
            for (int i = 0; i < spots; i++)
            {
                if (i < places)
                {
                    h += $"<div class=\"shipping-label\" contenteditable=\"true\">{addressString[i]}</div>";
                }
                else
                {
                    h += "<div class=\"shipping-label\"></div>";
                }
                int f = i + 1;
                if (f % 14 == 0)
                {
                    h += "</div>";
                    if (f < spots)
                    {
                        h += "<!DOCTYPE html><meta content=\"text/html; charset = UTF-8\"http-equiv=Content-Type><link href=../styles.css rel=stylesheet>";
                        h += "<div class=\"page\">";
                        ++pg;
                    }
                }
            }
            File.WriteAllText(outfile, h);
        }   
    }
}
