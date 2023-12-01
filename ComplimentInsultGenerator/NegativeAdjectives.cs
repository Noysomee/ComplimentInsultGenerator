using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Insult_Generator_Thing
{
    internal class NegativeAdjectives
    {
        ArrayList negadjectives = new ArrayList()
        {"abhorrent",
          "belligerent",
          "callous",
          "dismal",
          "obnoxious",
          "vapid",
          "yucky",
          "cantankerous",
          "gruesome",
          "wretched",
          "grating",
          "obtuse",
          "rancid",
          "stupid",
          "moronic",
          "gross",
          "weasly",
          "scummy",
          "minky",
          "smelly",
          "stinky",
          "ugly",
          "boring",
          "dumb",
          "foul",
          "clapped",
          "freaky",
          "lecherous",
          "dirty",
          "pompous",
          "cringe"
        };

        public string NegativeAdjGen()
        {
            return negadjectives[new Random().Next(negadjectives.Count)] as string;
        }
    }
}