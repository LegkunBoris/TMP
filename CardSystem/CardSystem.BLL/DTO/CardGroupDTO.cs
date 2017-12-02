using System;
using System.Collections.Generic;
using CardSystem.DAL;

namespace CardSystem.BLL
{
	public class CardGroupDTO
	{
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public List<int> Cards { get; set; }
	}
}
