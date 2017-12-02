using System;
namespace CardSystem.DAL
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<Card> Cards { get; }
		IRepository<CardGroup> Groups { get; }

		void Save();
	}
}
