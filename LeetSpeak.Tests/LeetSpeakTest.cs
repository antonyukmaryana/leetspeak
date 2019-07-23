using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak.Models;

namespace LeetSpeak.Tests
{
    [TestClass]
    public class LeetSpeakTest
    {
        [TestMethod]
        public void SpeakLeet_eTurnsTo3_3gg()
        {
            Leet l33tspeak = new Leet();
            Assert.AreEqual("3gg", l33tspeak.SpeakLeet("egg"));
        }
        [TestMethod]
        public void SpeakLeet_0TurnsToO_d0()
        {
            Leet l33tspeak = new Leet();
            Assert.AreEqual("d0", l33tspeak.SpeakLeet("d0"));
        }   

         [TestMethod]
        public void SpeakLeet_STurnsToz_saZZ()
        {
            Leet l33tspeak = new Leet();
            Assert.AreEqual("sazz sazz sazz", l33tspeak.SpeakLeet("sass sass sass"));
        }       
    }

    
}