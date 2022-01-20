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
            var roll = new Roll();

            // Agera
            var numberOfDices = roll.Dices.Count;

            // Attestera
            Assert.That(numberOfDices, Is.EqualTo(5));
        }

    }
}