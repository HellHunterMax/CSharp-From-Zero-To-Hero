using BootCamp.Chapter.Gambling;
using BootCamp.Chapter.Gambling.Poker;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PokerHandTests
    {
        //TODO test validateHandSize
        //TODO test if validateHAndSize gets called
        //TODO test if cards get added to AddCards

        [Fact]
        public void AddCards_Adds_cards()
        {
            PokerHand pokerhand = new PokerHand();
            Card[] cards = BuildArrayOfCards(5);

            pokerhand.AddCards(cards);

            Assert.Equal(cards, pokerhand.Reveal());
        }

        [Fact]
        public void AddCards_Given_6_Cards_Throws_InvalidPokerHandException()
        {
            PokerHand pokerhand = new PokerHand();
            Card[] cards = BuildArrayOfCards(6);

            Action action = () => pokerhand.AddCards(cards);

            Assert.Throws<InvalidPokerHandException>(action);
        }

        private Card card = new Card(Card.Suites.Clubs, Card.Ranks.Ace);

        private Card[] BuildArrayOfCards(int numberOfCards)
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < numberOfCards; i++)
            {
                cards.Add(card);
            }

            return cards.ToArray();
        }
        
    }
}
