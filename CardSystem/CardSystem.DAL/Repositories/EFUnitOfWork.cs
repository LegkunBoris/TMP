using System;
namespace CardSystem.DAL
{
	public class EFUnitOfWork : IUnitOfWork
	{
		private SystemContext _db;
		private CardRepository _cardRepository;
		private CardGroupRepository _cardGroupRepository;
		public EFUnitOfWork(string connectionString)
		{
			_db = new SystemContext(connectionString);
		}

		public IRepository<Card> Cards
		{
			get
			{
				if (_cardRepository == null)
					_cardRepository = new CardRepository(_db);
				return _cardRepository;
					
			}
		}
		public IRepository<CardGroup> Groups
		{
			get
			{
				if(_cardGroupRepository == null )
					_cardGroupRepository = new CardGroupRepository(_db);
				return _cardGroupRepository;
			}
		}
		public void Save()
		{
			_db.SaveChanges();
		}

		private bool _disposed = false;

		public virtual void Dispose(bool disposing)
		{
			if (!_disposed)
				_db.Dispose();

			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
