using System;
using System.Collections.Generic;

namespace CardSystem.WEB
{
	public class GroupViewModel
	{
		public int Id { get; set; }
		public string GroupName { get; set; }
		public List<CardID> Cards { get; set; }
	}
}
