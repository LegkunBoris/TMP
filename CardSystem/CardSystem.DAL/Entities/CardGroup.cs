using System;
using System.Collections.Generic;

namespace CardSystem.DAL
{
	public class CardGroup
	{
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public List<CardID> Cards { get; set; }
	}
}
