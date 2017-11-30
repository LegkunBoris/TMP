using System;
using System.Collections.Generic;

namespace Translator.DAL
{
	public class Card
	{
		public CardID CardId { get; set; }
		public string FromLanguage { get; set; }
		public string ToLanguage { get; set; }
		public string Word { get; set; }
		public string RightAnswer { get; set; }
		public List<String> PossibleAnswers { get; set; }
	}
}
