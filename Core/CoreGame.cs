﻿namespace Core
{
    public abstract class CoreGame
    {
        protected readonly CardStack Stack;
		protected Player HumanPlayer { get; }
		protected Player ComputerPlayer { get; }
		protected Dice GameDice { get; }

        protected CoreGame(string playerName)
        {
            HumanPlayer = new Player(playerName);
            ComputerPlayer = new Player("IA");
            Stack = new CardStack();
			GameDice = new Dice();
		}

		public abstract void Run();

		public abstract void HumanTurn();
		
		public abstract void ComputerTurn();

		protected bool IsPlayerWin() {
			return HumanPlayer.Wallet >= 20;
		}

		protected bool IsComputerWin() {
			return ComputerPlayer.Wallet >= 20;
		}


	}
}