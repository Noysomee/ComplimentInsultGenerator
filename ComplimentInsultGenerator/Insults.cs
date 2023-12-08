using System;
using System.Collections;

namespace Insult_Generator_Thing
{
    public class Insults
    {
        //ArrayList insults created full of structure insults for use in app
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

        //Initialising class BodyParts so the method BodyPartGenerator can be used within this class
        BodyParts bodyparts = new BodyParts();
        //Initialising class NegativeAdjectives so the method NegativeAdjGen can be used within this class
        NegativeAdjectives neg = new NegativeAdjectives();

        /// <summary>
        /// Method that returns the generated insult created within the method
        /// </summary>
        /// <returns></returns>
        public string InsultGenerator()
        {
            //Uses random to select a random element (within the range of the array) in the insults arraylist and assign it to the variable insult 
            string insult = insults[new Random().Next(insults.Count)] as string;

            //If statement that checks if the selected element within the array contains the word BODYPART
            if (insult.Contains("BODYPART"))
            {
                //If it does...the word BODYPART is replaced by the randomly selected body part returned from the BodyPartGenerator method
                insult = insult.Replace("BODYPART", bodyparts.BodyPartGenerator());
            }
            //If statement that checks if the selected element within the array contains the word NEGATIVEADJECTIVE
            if (insult.Contains("NEGATIVEADJECTIVE"))
            {
                //If it does...the word NEGATIVEADJECTIVE is replaced by the randomly selected adjective returned from the NegativeAdjGen method
                insult = insult.Replace("NEGATIVEADJECTIVE", neg.NegativeAdjGen());
            }
            //returns generated insult out of method
            return insult;
        }
    }
}