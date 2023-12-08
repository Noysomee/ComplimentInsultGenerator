using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Insult_Generator_Thing;
using Windows.ApplicationModel.VoiceCommands;
using System.Collections;

namespace ComplimentInsultTest1
{
    [TestClass]
    public class UnitTest1
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

        [TestMethod]
        public void BodyPartNotNull()
        {
            BodyParts body = new BodyParts();

            string testresult = body.BodyPartGenerator();

            Assert.IsNotNull(testresult);
        }
        [TestMethod]
        public void BodyPartWithinArray()
        {
            BodyParts body = new BodyParts();

            string testresult = body.BodyPartGenerator();

            foreach (string s in bodyparts)
                if (s == testresult)
                {
                    string selectedword = testresult;
                    Assert.AreEqual(selectedword, testresult);
                }
        }
        [TestMethod]
        public void NegAdjNotNull()
        {
            NegativeAdjectives neg = new NegativeAdjectives();

            string testresult = neg.NegativeAdjGen();

            Assert.IsNotNull(testresult);
        }
        [TestMethod]
        public void NegAdjWithinArray()
        {
            NegativeAdjectives neg = new NegativeAdjectives();

            string testresult = neg.NegativeAdjGen();

            foreach (string s in negadjectives)
                if (s == testresult)
                {
                    string selectedword = testresult;
                    Assert.AreEqual(selectedword, testresult);
                }
        }
        [TestMethod]
        public void PosAdjNotNull()
        {
            PositiveAdjectives pos = new PositiveAdjectives();

            string testresult = pos.PositiveAdjGen();

            Assert.IsNotNull(testresult);
        }
        [TestMethod]
        public void PosAdjWithinArray()
        {
            PositiveAdjectives pos = new PositiveAdjectives();

            string testresult = pos.PositiveAdjGen();

            foreach (string s in posadjectives)
                if (s == testresult)
                {
                    string selectedword = testresult;
                    Assert.AreEqual(selectedword, testresult);
                }
        }
        [TestMethod]
        public void InsultNotNull()
        {
            Insults insult = new Insults();

            string testinsultgenerated = insult.InsultGenerator();

            Assert.IsNotNull(testinsultgenerated);
        }
        [TestMethod]
        public void InsultContainsBodyPart()
        {
            Insults insult = new Insults();

            string testinsultgenerated = insult.InsultGenerator();
            foreach (string s in bodyparts)
                if (testinsultgenerated.Contains(s))
                {
                    Assert.IsTrue(testinsultgenerated.Contains(s));
                }
        }
        [TestMethod]
        public void InsultContainsNegAdj()
        {
            Insults insult = new Insults();

            string testinsultgenerated = insult.InsultGenerator();
            foreach (string s in negadjectives)
                if (testinsultgenerated.Contains(s))
                {
                    Assert.IsTrue(testinsultgenerated.Contains(s));
                }
        }
        [TestMethod]
        public void ComplimentNotNull()
        {
            Compliments comp = new Compliments();

            string testcomplimentgenerated = comp.ComplimentGenerator();

            Assert.IsNotNull(testcomplimentgenerated);
        }
        [TestMethod]
        public void ComplimentContainsBodyPart()
        {
            Compliments comp = new Compliments();

            string testinsultgenerated = comp.ComplimentGenerator();
            foreach (string s in bodyparts)
                if (testinsultgenerated.Contains(s))
                {
                    Assert.IsTrue(testinsultgenerated.Contains(s));
                }
        }
        [TestMethod]
        public void ComplimentContainsPosAdj()
        {
            Compliments comp = new Compliments();

            string testinsultgenerated = comp.ComplimentGenerator();
            foreach (string s in posadjectives)
                if (testinsultgenerated.Contains(s))
                {
                    Assert.IsTrue(testinsultgenerated.Contains(s));
                }
        }
    }
}