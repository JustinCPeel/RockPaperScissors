using System;
using NUnit;
using NUnit.Framework;

namespace Rock_Paper_Scissors
{
    [TestFixture]
    public class Rock_PaperScissors_Tests
    {
        [Test]
        public void Play_GivenPlayerHasPaper_AndOpponentHasRock_ShouldReturnPlayerWins()
        {
            //Arrange
            var userChoice = Choices.Paper;
            var aiChoice = Choices.Rock;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Wins";

            //Assert
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void Play_GivenPlayerHasPaper_AndOpponentHasScissors_ShouldReturnPlayerLoses()
        {
            //Arrange
            var userChoice = Choices.Paper;
            var aiChoice = Choices.Scissors;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Loss";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasPaper_AndOpponentHasPaper_ShouldReturnDraw()
        {
            //Arrange
            var userChoice = Choices.Paper;
            var aiChoice = Choices.Paper;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Draw";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasRock_AndOpponentHasRock_ShouldReturnDraw()
        {
            //Arrange
            var userChoice = Choices.Rock;
            var aiChoice = Choices.Rock;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Draw";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasRock_AndOpponentHasScissors_ShouldReturnPlayerWins()
        {
            //Arrange
            var userChoice = Choices.Rock;
            var aiChoice = Choices.Scissors;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Wins";

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Play_GivenPlayerHasRock_AndOpponentHasPaper_ShouldReturnPlayerLoses()
        {
            //Arrange
            var userChoice = Choices.Rock;
            var aiChoice = Choices.Paper;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Loss";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasScissor_AndOpponentHasRock_ShouldReturnPlayerLoses()
        {
            //Arrange
            var userChoice = Choices.Scissors;
            var aiChoice = Choices.Rock;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Loss";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasScissors_AndOpponentHasPaper_ShouldReturnPlayerWins()
        {
            //Arrange
            var userChoice = Choices.Scissors;
            var aiChoice = Choices.Paper;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Wins";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasScissors_AndOpponentHasScissors_ShouldReturnDraw()
        {
            //Arrange
            var userChoice = Choices.Scissors;
            var aiChoice = Choices.Scissors;

            //act
            var actual = Play(userChoice, aiChoice);
            var expected = "Draw";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private string Play(Choices userChoice, Choices aiChoice)
        {
            if (aiChoice == userChoice)
                return "Draw";

            switch (userChoice)
            {
                case Choices.Paper:
                    if (aiChoice == Choices.Rock)
                        return "Wins";
                    return "Loss";
                case Choices.Rock:
                    if (aiChoice == Choices.Paper)
                        return "Loss";
                   return "Wins";
                case Choices.Scissors:
                    if (aiChoice == Choices.Paper)
                        return "Wins";
                    return "Loss";
            }
            return "";
        }
    }

    enum Choices
    {
        Rock,
        Paper,
        Scissors
    }
}
