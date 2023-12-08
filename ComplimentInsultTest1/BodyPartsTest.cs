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

            foreach (string i in bodyparts)
                if (i == testresult)
                {
                    string selectedword = testresult;
                    Assert.AreEqual(selectedword, testresult);
                }
        }
    }
}