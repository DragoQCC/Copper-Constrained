using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pastel;

namespace Copper_Constrained.UI
{
    public class Ui
    {
        public static void Banner()
        {
            Console.WriteLine(
              " ██████╗ ██████╗ ██████╗ ██████╗ ███████╗██████╗      ██████╗ ██████╗ ███╗   ██╗███████╗████████╗██████╗  █████╗ ██╗███╗   ██╗███████╗██████╗\n".Pastel(Color.FromArgb(184, 115, 51)) +
              "██╔════╝██╔═══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗    ██╔════╝██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██║████╗  ██║██╔════╝██╔══██╗\n".Pastel(Color.FromArgb(184, 115, 51)) +
              "██║     ██║   ██║██████╔╝██████╔╝█████╗  ██████╔╝    ██║     ██║   ██║██╔██╗ ██║███████╗   ██║   ██████╔╝███████║██║██╔██╗ ██║█████╗  ██║  ██║\n".Pastel(Color.FromArgb(184, 115, 51)) +
              "██║     ██║   ██║██╔═══╝ ██╔═══╝ ██╔══╝  ██╔══██╗    ██║     ██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══██╗██╔══██║██║██║╚██╗██║██╔══╝  ██║  ██║\n".Pastel(Color.FromArgb(184, 115, 51)) +
              "╚██████╗╚██████╔╝██║     ██║     ███████╗██║  ██║    ╚██████╗╚██████╔╝██║ ╚████║███████║   ██║   ██║  ██║██║  ██║██║██║ ╚████║███████╗██████╔╝\n".Pastel(Color.FromArgb(184, 115, 51)) +
              " ╚═════╝ ╚═════╝ ╚═╝     ╚═╝     ╚══════╝╚═╝  ╚═╝     ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝╚══════╝╚═════╝ \n".Pastel(Color.FromArgb(184, 115, 51)) +
                "\n" +
               "Author: Jon @QueenCityCyber \n".Pastel(Color.SkyBlue) +
               "https://github.com/Queen-City-Cyber \n".Pastel(Color.FromArgb(52, 152, 52))
                );
        }
    }
}
