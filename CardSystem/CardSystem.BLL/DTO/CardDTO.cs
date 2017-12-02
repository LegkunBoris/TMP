using System;
using System.Collections.Generic;
using CardSystem.DAL;

namespace CardSystem.BLL
{
	public class CardDTO
	{
		public int CardId { get; set; }
		public string Word { get; set; }
		public string Translate { get; set; }
		public List<String> PossibleTranslates { get; set; }
	}
}
