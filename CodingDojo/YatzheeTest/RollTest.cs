using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using Yatzhee;

namespace YatzheeTest
{
    public class RollTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void NewRoll_5Dices()
        {
            // Arrangera
            var roll = new Roll(1,1,1,1,1);

            // Agera
            var numberOfDices = roll.Dices.Count;

            // Attestera
            Assert.That(numberOfDices, Is.EqualTo(5));
        }
        [Test]
        public void Newroll_Pair()
        {
            // Arrangera
            var roll = new Roll(2,2,2,2,2);

            // Agera
            int pairScore = roll.PairScore();

            // Attestera
            Assert.That(pairScore, Is.EqualTo(4));
        }
        [Test]
        public void Newroll_Pair2()
        {
            // Arrangera
            var roll = new Roll(6,6,6,6,6);

            // Agera
            int pairScore = roll.PairScore();

            // Attestera
            Assert.That(pairScore, Is.EqualTo(12));
        }
    }
}