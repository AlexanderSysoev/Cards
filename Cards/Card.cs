namespace Cards
{
    public class Card
    {
        public string From { get; set; }

        public string To { get; set; }

        public override string ToString()
        {
            return $"{From} - {To}";
        }
    }
}
