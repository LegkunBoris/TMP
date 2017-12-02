using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
namespace CardSystem.DAL
{
	public class CardRepository : IRepository<Card>
	{
		private SystemContext _db;
		public CardRepository(SystemContext context)
		{
			_db = context;
		}
		public void Create(Card item)
		{
			_db.Cards.Add(item);
		}

		public void Delete(int id)
		{
			var card = _db.Cards.Find(id);
			if (card != null)
				_db.Cards.Remove(card);
		}

		public IEnumerable<Card> Find(Func<Card, bool> predicate)
		{
			return _db.Cards.Where(predicate).ToList();
		}

		public Card Get(int id)
		{
			return _db.Cards.Find(id);
		}

		public IEnumerable<Card> GetAll()
		{
			return _db.Cards;
		}

		public void Update(Card item)
		{
			_db.Entry(item).State = EntityState.Modified;
		}
	}
}
