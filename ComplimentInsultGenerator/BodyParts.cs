using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insult_Generator_Thing
{
    internal class BodyParts
    {
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

        public string BodyPartGenerator()
        {
            return bodyparts[new Random().Next(bodyparts.Count)] as string;
        }
    }
}