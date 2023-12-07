using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insult_Generator_Thing
{
    public class Compliments
    {
        //ArrayList compliments created full of structure compliments for use in app
        ArrayList compliments = new ArrayList()
        {"Wow, your BODYPART is sooooooo POSITIVEADJECTIVE",
         "I really love your BODYPART",
         "You just radiate POSITIVEADJECTIVE",
         "The shape of your BODYPART is simply POSITIVEADJECTIVE",
         "Your BODYPART is truly one of your best qualities",
         "Your BODYPART always brightens my day; it's like a burst of sunshine!",
         "You bring a sense of POSITIVEADJECTIVE to every room you enter",
         "Your BODYPART has such a graceful presence, it really elevates your look",
         "Your BODYPART has a way of telling a story; it's like a canvas of experiences",
         "I've always admired the way you embrace and celebrate your unique BODYPART"};

        //Initialising class BodyParts so the method BodyPartGenerator can be used within this class
        BodyParts bodyparts = new BodyParts();
        //Initialising class PositiveAdjectives so the method PositiveAdjGen can be used within this class
        PositiveAdjectives pos = new PositiveAdjectives();

        /// <summary>
        /// Method that returns the generated compliment created within the method
        /// </summary>
        /// <returns></returns>
        public string ComplimentGenerator()
        {
            //Uses random to select a random element (within the range of the array) in the compliments arraylist and assign it to the variable compliment
            string compliment = compliments[new Random().Next(compliments.Count)] as string;

            //If statement that checks if the selected element within the array contains the word BODYPART
            if (compliment.Contains("BODYPART"))
            {
                //If it does...the word BODYPART is replaced by the randomly selected body part returned from the BodyPartGenerator method
                compliment = compliment.Replace("BODYPART", bodyparts.BodyPartGenerator());
            }
            //If statement that checks if the selected element within the array contains the word POSITIVEADJECTIVE
            if (compliment.Contains("POSITIVEADJECTIVE"))
            {
                //If it does...the word POSITIVEADJECTIVE is replaced by the randomly selected adjective returned from the PositiveAdjGen method
                compliment = compliment.Replace("POSITIVEADJECTIVE", pos.PositiveAdjGen());
            }
            //returns generated insult out of method
            return compliment;
        }
        public string UserComplimentGenerator()
        {
            //Uses random to select a random element (within the range of the array) in the compliments arraylist and assign it to the variable compliment
            string usercompliment = compliments[new Random().Next(compliments.Count)] as string;

            return "";
        }
    }
}