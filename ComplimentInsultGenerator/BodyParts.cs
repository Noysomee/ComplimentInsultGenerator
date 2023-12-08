using System;
using System.Collections;

namespace Insult_Generator_Thing
{
    public class BodyParts
    {
        //ArrayList bodyparts created full of body parts for use in app
        ArrayList bodyparts = new ArrayList()
        {
            "arm",
            "leg",
            "finger",
            "hand",
            "nose",
            "ear",
            "foot",
            "teeth",
            "armpit",
            "toe",
            "nostril",
            "lip",
            "eyes",
            "eyebrows",
            "knee",
            "elbow",
            "knuckle",
            "neck",
            "ankle",
            "palms",
            "cheeks",
            "lungs",
            "liver",
            "kidneys",
            "nails",
            "tongue",
            "mouth",
            "chin",
            "hair",
            "butt",
            "navel"
        };

        /// <summary>
        /// Method that returns randomly selected body part from the bodyparts arraylist
        /// </summary>
        /// <returns></returns>
        public string BodyPartGenerator()
        {
            //returns the randomly selected element from the bodyparts arraylist using the random function
            return bodyparts[new Random().Next(bodyparts.Count)] as string;
        }
    }
}