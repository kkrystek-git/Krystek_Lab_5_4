using System;
using System.Drawing;

namespace Krystek_Lab_5_4
{
	class Program
	{
		public struct Mario
		{
			public enum Size
			{
				Small,
				Large
			}

			public int numOfLives;
			public string currentLevel;
			public Size sizeOfMario;
			public bool canShootFireBalls;
			public bool isJumping;
			public int numOfCoins;
			public string ColorOfHat;
			public string Job;
			public string Brother;
			public bool canPunchBricks;
			public bool canRideDinosaur;

		}

		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.30.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 5_4
			// =========================================================================
			//
			//
			// 1.Create List of Things Mario Needs.
			// 2.Create Struct of Things Mario Needs.
			// 3.Create Mario and Give Him Values.
			// 4. Change Mario's Values as He Moves Through Levels.
			//

			// 1.Create List of Things Mario Needs.
			// 2.Create Struct of Things Mario Needs.
			//		See Struct above.


			// 3.Create Mario and Give Him Values.

			Mario mario = new Mario();
			mario.numOfLives = 3;
			mario.currentLevel = "World 1-1";
			mario.sizeOfMario = Mario.Size.Small;
			mario.canShootFireBalls = false;
			mario.isJumping = false;
			mario.ColorOfHat = "Red";
			mario.Job = "Plumber";
			mario.Brother = "Luigi";
			mario.canPunchBricks = true;
			mario.canRideDinosaur = true;


			Console.WriteLine("Mario is a " + mario.ColorOfHat + "-hat-wearing " + mario.Job + " and has a sibling named " + mario.Brother + ".");
			Console.WriteLine("Mario's ability to punch bricks is " + mario.canPunchBricks + ", and it's " + mario.canRideDinosaur + " that he can ride a dinosaur!\n");




			Console.WriteLine("Mario is running through the level and meets a Gooba.\nSet Mario to jumping so he can kill it");
			mario.currentLevel = "World 1-1";
			mario.isJumping = true;
			Console.WriteLine("The Current Level = " + mario.currentLevel + ".");
			Console.WriteLine("Mario is Jumping = " + mario.isJumping + ".\n");

			Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
			mario.isJumping = false;
			Console.WriteLine("Mario is Jumping = " + mario.isJumping + ".\n");

			Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
			mario.numOfLives = mario.numOfLives + 1;
			Console.WriteLine("Number of Lives = " + mario.numOfLives + ".\n");

			Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
			mario.canShootFireBalls = true;
			Console.WriteLine("Ability to Shoot Fire Balls = " + mario.canShootFireBalls + ".\n");

			Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario!");
			mario.sizeOfMario = Mario.Size.Large;
			Console.WriteLine("Size of Mario = " + mario.sizeOfMario + ".\n");

			Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
			mario.numOfCoins = mario.numOfCoins + 10;
			Console.WriteLine("Number of Coins = " + mario.numOfCoins + ".\n");

			Console.WriteLine("Mario finishes the level! Change Mario's current level to World 1-2.");
			mario.currentLevel = "World 1-2";
			Console.WriteLine("The Current Level = " + mario.currentLevel + ".\n");

			Console.WriteLine("\nMario is TRANSFORMED!\n");
			mario.ColorOfHat = "Blue";
			mario.Job = "Chief Executive Officer";
			mario.canPunchBricks = false;
			mario.canRideDinosaur = false;
			Console.WriteLine("Mario is a " + mario.ColorOfHat + "-hat-wearing " + mario.Job + " and has a sibling named " + mario.Brother + ".");
			Console.WriteLine("Mario's ability to punch bricks is " + mario.canPunchBricks + ", and it's " + mario.canRideDinosaur + " that he can ride a dinosaur!\n");


			// End

		}

	}
}
