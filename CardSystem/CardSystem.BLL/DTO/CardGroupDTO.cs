using System;
using System.Collections.Generic;

namespace CardSystem.BLL
{
	public class CardGroupDTO
	{
		public GroupID GroupId { get; set; }
		public string GroupName { get; set; }
		public List<CardID> Cards { get; set; }
	}
}
