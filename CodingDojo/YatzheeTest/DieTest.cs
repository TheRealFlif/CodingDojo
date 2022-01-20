using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using Yatzhee;

namespace YatzheeTest
{
    public class DieTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Read_Die2()
        {
            // Arrangera
            var die = new Die(2);

            // Agera
            var dots = die.Read();

            // Attestera
            Assert.That(dots, Is.EqualTo(2));
        }
        [Test]
        public void Read_Die3()
        {
            // Arrangera
            var die = new Die(3);

            // Agera
            var dots = die.Read();

            // Attestera
            Assert.That(dots, Is.EqualTo(3));
        }

    }
}