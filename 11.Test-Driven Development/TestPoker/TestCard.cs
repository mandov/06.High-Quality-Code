namespace TestCard
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class TestCard
    {
        [TestMethod]
        public void ToStringShouldPrintFaceAndSuit()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var expectedValue = "The card is Ace Clubs";
            Assert.AreEqual(expectedValue, card.ToString(), "ToString method don't work correct");
        }
    }
}
