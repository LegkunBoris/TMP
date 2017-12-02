using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
namespace CardSystem.DAL
{
	public class CardGroupRepository : IRepository<CardGroup>
	{
		private SystemContext _db;
		public CardGroupRepository(SystemContext context)
		{
			_db = context;
		}
		public void Create(CardGroup item)
		{
			_db.CardGroups.Add(item);
		}

		public void Delete(int id)
		{
			var card = _db.CardGroups.Find(id);
			if (card != null)
				_db.CardGroups.Remove(card);
		}

		public IEnumerable<CardGroup> Find(Func<CardGroup, bool> predicate)
		{
			return _db.CardGroups.Where(predicate).ToList();
		}

		public CardGroup Get(int id)
		{
			return _db.CardGroups.Find(id);
		}

		public IEnumerable<CardGroup> GetAll()
		{
			return _db.CardGroups;
		}

		public void Update(CardGroup item)
		{
			_db.Entry(item).State = EntityState.Modified;
		}
	}
}
