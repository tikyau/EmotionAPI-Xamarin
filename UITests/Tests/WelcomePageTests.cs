﻿using NUnit.Framework;

using Xamarin.UITest;

namespace FaceOff.UITests
{
	public class WelcomePageTests : TestSetUp
	{
		public WelcomePageTests(Platform platform) : base(platform)
		{
		}

		[Test]
		public void LaunchApp()
		{
		}

		[Test]
		public void TapSubmitButton_NoPlayerNameEntered()
		{
			//Arrange

			//Act
			WelcomePage.TapStartGameButton();

			//Assert
			Assert.IsTrue(WelcomePage.IsErrorMessageDisplayed());
		}

		[Test]
		public void TapSubmitButton_Player1NameEntered_NoPlayer2NameEntered()
		{
			//Arrange
			var player1Name = "First Player";

			//Act
			WelcomePage.EnterPlayer1Name(player1Name);
			WelcomePage.TapStartGameButton();

			//Assert
			Assert.IsTrue(WelcomePage.IsErrorMessageDisplayed());
		}

		[Test]
		public void TapSubmitButton_Player2NameEntered_NoPlayer1NameEntered()
		{
			//Arrange
			var player2Name = "Second Player";

			//Act
			WelcomePage.EnterPlayer2Name(player2Name);
			WelcomePage.TapStartGameButton();

			//Assert
			Assert.IsTrue(WelcomePage.IsErrorMessageDisplayed());
		}

		public void TapSubmitButton_BothPlayerNamesEntered()
		{
			//Arrange
			var player1Name = "First Player";
			var player2Name = "Second Player";

			//Act
			WelcomePage.EnterPlayer1Name(player1Name);
			WelcomePage.EnterPlayer2Name(player2Name);
			WelcomePage.TapStartGameButton();

			//Assert
			PicturePage.WaitForPicturePageToLoad();
		}
	}
}
