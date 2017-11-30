using System;
using System.Collections.Generic;

namespace Translator.DAL
{
	public class CardGroup
	{
		public GroupID id { get; set; }
		public string GroupName { get; set; }
		public List<CardID> Cards { get; set; }
	}
}
