using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CardSystem.DAL
{
	public class SystemContext : DbContext
	{
		public DbSet<Card> Cards { get; set; }
		public DbSet<CardGroup> CardGroups { get; set; }

		static SystemContext()
		{
			Database.SetInitializer<SystemContext>(new StoreDbInitializer());
		}
		public SystemContext(string connectionString)
            : base(connectionString)
        {
		}
		public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<SystemContext>
		{
			protected override void Seed(SystemContext db)
			{
				db.Cards.Add(new Card { CardId = 0, Language = "English",
					Word = "cat",Translate = "кот", PossibleTranslates = new List<string> {"собака","дом","кровать","небо"} });

				db.SaveChanges();
			}
		}
	}
}
