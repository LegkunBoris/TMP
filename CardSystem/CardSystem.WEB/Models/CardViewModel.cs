using System;
using System.Collections.Generic;

namespace CardSystem.WEB
{
	public class CardViewModel
	{
		public int Id { get; set; }
		public string Language { get; set; }
		public string Word { get; set; }
		public string Translate { get; set; }
		public List<String> PossibleTranslates { get; set; }
	}
}
