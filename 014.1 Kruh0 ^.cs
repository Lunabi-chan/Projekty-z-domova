using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Class1
    {
        //Datová složka třídy - field
        int poloměr;

        //metoda
        double PLocha()
        {
            return Math.PI * poloměr * poloměr;
        }
    }
}
