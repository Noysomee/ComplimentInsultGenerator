﻿using System;
using System.Collections;

namespace Insult_Generator_Thing
{
    public class NegativeAdjectives
    {
        //ArrayList negadjectives created full of negative adjectives for use in app
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

        /// <summary>
        /// Method that returns randomly selected adjective from the negadjectives arraylist
        /// </summary>
        /// <returns></returns>
        public string NegativeAdjGen()
        {
            //returns the randomly selected element from the negadjectives arraylist using the random function
            return negadjectives[new Random().Next(negadjectives.Count)] as string;
        }
    }
}