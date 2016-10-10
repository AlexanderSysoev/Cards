using System.Collections.Generic;
using System.Linq;

namespace Cards
{
    public class MainClass
    {
        public List<Card> SortCards(IEnumerable<Card> cards)
        {
            var destinations = cards.Select(x => x.To);
            var start = cards.Select(x => x.From).Except(destinations).Single();
            var cardsDictionary = cards.ToDictionary(card => card.From);
            var cardsCount = cards.Count();
            var result = new List<Card>(cardsCount) {cardsDictionary[start]};

            for (var i=0; i < cardsCount - 1; i++)
            {
                result.Add(cardsDictionary[result[i].To]);
            }

            return result;
        }
    }
}
