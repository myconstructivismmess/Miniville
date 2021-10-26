﻿#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core {
	public class CardStack {
		private List<Card> _cards;

		private static Random _random = new Random();
		public CardStack() {
			// Creating a new stack of card with 6 of each cards
			_cards = new List<Card>();

			for (int i = 0; i < 6; i++) {
				if (i < 4) {
					// Only 4 of these because of the start deck of each players
					_cards.Add(new WheatField());
					_cards.Add(new Bakery());
				}
				_cards.Add(new Farm());
				_cards.Add(new Forest());
				_cards.Add(new Stadium());
				_cards.Add(new GroceryStore());
				_cards.Add(new CoffeeShop());
				_cards.Add(new Restaurant());
			}
		}

		public int GetCardCount(CardType type) {
			return _cards.Sum(x => x.CardType == type ? 1 : 0);
		}

		public Card? PickCard(CardType type) {
			Card? result = null;
			foreach (var card in _cards) {
				if (card.CardType == type) {
					result = card;
					_cards.Remove(card);
					break;
				}
			}

			return result;
		}
	}
}