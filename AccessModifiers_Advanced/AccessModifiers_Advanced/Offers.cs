namespace AccessModifiers_Advanced
{
    /*
     * The internal access modifier is only available on the class level and it means that the given class is only available from
     * the same assembly.
     */
    internal class Offers
    {
        public void OfferOne() { }

        private void OfferTwo() { }
    }
}
