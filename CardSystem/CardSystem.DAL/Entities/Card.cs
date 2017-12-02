using System;
using System.Collections.Generic;

namespace CardSystem.DAL
{
	public class Card
	{
		public CardID CardId { get; set; }
		public string Language { get; set; }
		public string Word { get; set; }
		public string Translate { get; set; }
		public List<String> PossibleTranslates { get; set; }
	}
}
