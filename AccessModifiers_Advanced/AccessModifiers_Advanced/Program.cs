namespace AccessModifiers_Advanced
{
    class Program
    {
        static void Main()
        {
            var offer = new Offers();
            offer.OfferOne(); // accessible since Offers is in same assembly and method is public
            // offer.OfferTw(); // inaccessible since Offer may be in the same assembly but method is private
        }
    }
}
