using System;
using System.Collections.Generic;

namespace CardSystem.DAL
{
	public class CardGroup
	{
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public List<int> Cards { get; set; }
		public override bool Equals(object obj)
		{
			var group = obj as CardGroup;
			if (GroupId != group.GroupId)
				return false;
			return true;
		}
		public override int GetHashCode()
		{
			return GroupId.GetHashCode();
		}
	}
}
