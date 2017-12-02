using System;
using System.Collections.Generic;

namespace CardSystem.BLL
{
	public class CardDTO
	{
		public CardID CardId { get; set; }
		public string Word { get; set; }
		public string Translate { get; set; }
		public List<String> PossibleTranslates { get; set; }
	}
}
