using System;
using System.Collections.Generic;

namespace CardSystem.DAL
{
	public class Card
	{
		public int CardId { get; set; }
		public string Language { get; set; }
		public string Word { get; set; }
		public string Translate { get; set; }
		public List<String> PossibleTranslates { get; set; }

		public override bool Equals(object obj)
		{
			var card = obj as Card;
			if (card.CardId != CardId)
				return false;
			return true;
		}
		public override int GetHashCode()
		{
			return CardId.GetHashCode();
		}
	}
}
