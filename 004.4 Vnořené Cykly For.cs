using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* vnější cyklus se stará o tisk
           * správného řádku
           */

            for (int řádek = 1; řádek <= 4; řádek++)
            {
                /*Vnitřní cyklus se stará o tisk
                 * jednoho řádku,
                 * tj. o správný počet sloupců
                 */
                for (int sloupec = 1; sloupec <= 6; sloupec++)
                    Console.Write("*");
                /* po dokončení tisku řádku 
                 * je potřeba odřádkovat
                 */
                Console.WriteLine();
            }
            
            
            
            
            
            
            Console.ReadLine();

        }
    }
}
