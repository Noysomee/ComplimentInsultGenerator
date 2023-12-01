using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insult_Generator_Thing
{
    internal class Insults
    {
        ArrayList insults = new ArrayList()
        {"I actually despise your BODYPART",
         "Your BODYPART is NEGATIVEADJECTIVE",
         "The way your BODYPART looks is just so NEGATIVEADJECTIVE",
         "Your BODYPART is really the worst part about you",
         "Your aura of NEGATIVEADJECTIVE just kills the atmosphere",
         "Everytime i have to see your BODYPART, it fills me with dread",
         "The shape of your BODYPART is NEGATIVEADJECTIVE",
         "Your BODYPART couldn't be more NEGATIVEADJECTIVE if it tried",
         "The sheer NEGATIVEADJECTIVE-ness of your BODYPART is mind-boggling",
         "Your BODYPART is such a big disaster, its honestly impressive",
        };

        BodyParts bodyparts = new BodyParts();
        NegativeAdjectives neg = new NegativeAdjectives();

        public string InsultGenerator()
        {
            string insult = insults[new Random().Next(insults.Count)] as string;


            if (insult.Contains("BODYPART"))
            {
                insult = insult.Replace("BODYPART", bodyparts.BodyPartGenerator());
            }
            if (insult.Contains("NEGATIVEADJECTIVE"))
            {
                insult = insult.Replace("NEGATIVEADJECTIVE", neg.NegativeAdjGen());
            }
            return insult;
        }
    }
}