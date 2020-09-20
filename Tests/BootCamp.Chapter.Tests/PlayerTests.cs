using BootCamp.Chapter.Gambling;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PlayerTests
    {
        /*
          public Player(string name, Hand hand)
        */

        [Fact]
        public void NullHand_throws_ArgumentNullException()
        {
            string name = It.IsAny<string>();
            Hand hand = null;

            Action action = () => new Player(name, hand);

            Assert.Throws<ArgumentNullException>(action);
        }

        [Fact]
        public void NullName_throws_ArgumentNullException()
        {
            string name = null;
            Hand hand = new Hand();

            Action action = () => new Player(name, hand);

            Assert.Throws<ArgumentNullException>(action);
        }
    }
}
