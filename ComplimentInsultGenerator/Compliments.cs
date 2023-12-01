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

        BodyParts bodyparts = new BodyParts();
        PositiveAdjectives pos = new PositiveAdjectives();

        public string ComplimentGenerator()
        {
            string compliment = compliments[new Random().Next(compliments.Count)] as string;


            if (compliment.Contains("BODYPART"))
            {
                compliment = compliment.Replace("BODYPART", bodyparts.BodyPartGenerator());
            }
            if (compliment.Contains("POSITIVEADJECTIVE"))
            {
                compliment = compliment.Replace("POSITIVEADJECTIVE", pos.PositiveAdjGen());
            }
            return compliment;
        }
    }
}