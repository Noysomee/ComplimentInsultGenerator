using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insult_Generator_Thing
{
    public class PositiveAdjectives
    {
        ArrayList posadjectives = new ArrayList()
        {"wonderful",
         "amazing",
         "cool",
         "beautiful",
         "sublime",
         "awesome",
         "swell",
         "tremendous",
         "sexy",
         "fabulous",
         "brilliant",
         "charming",
         "cute",
         "fantastic",
         "glamorous",
         "whimsical",
         "rakish",
         "canny",
         "eloquent", 
         "wise",
         "jovial",
         "clever",
         "gallant",
         "dapper",
         "valiant",
         "esteemed",
         "noble",
         "zestful",
         "nice",
         "illustrious"};

        public string PositiveAdjGen()
        {
            return posadjectives[new Random().Next(posadjectives.Count)] as string;
        }
    }
}