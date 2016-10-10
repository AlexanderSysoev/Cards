using System.Collections.Generic;
using NUnit.Framework;

namespace Cards.UnitTests
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void SortCards_UnsortedCards_ReturnsSortedCards()
        {
            //Arrange
            var cards = new List<Card>
            {
                new Card {From = "Москва", To = "Париж"},
                new Card {From = "Мельбурн", To = "Кельн"},
                new Card {From = "Кельн", To = "Москва"}
            };

            //Act
            var mainClass = new MainClass();
            var result = mainClass.SortCards(cards);

            //Assert
            Assert.AreEqual(result[0], cards[1]);
            Assert.AreEqual(result[1], cards[2]);
            Assert.AreEqual(result[2], cards[0]);

        }
    }
}
