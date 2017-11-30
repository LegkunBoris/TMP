using System;
using System.Collections.Generic;

namespace Translator.DAL
{
	public class CardGroupRepository : IRepository<CardGroup>
	{
		private Database _database;
		public CardGroupRepository(Database database)
		{
			_database = database;
		}

		public void Create(CardGroup item)
		{
			string request = "INSERT INTO CardGroups (Name,Cards,Word,PAnswers) Values (@FLang,@TLang,@Word,@PAnswers)";
			_database.SqlCmd.CommandText = request;
			FillQuery(item);
			int inserted = RunQuery();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public CardGroup Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<CardGroup> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Update(CardGroup item)
		{
			throw new NotImplementedException();
		}
		private int RunQuery()
		{
			_database.Connection.Open();
			int n = _database.SqlCmd.ExecuteNonQuery();
			_database.Connection.Close();

			return n;
		}
		private void FillQuery(CardGroup item)
		{
			_database.SqlCmd.Parameters.AddWithValue("@FLang", item.FromLanguage);
			_database.SqlCmd.Parameters.AddWithValue("@TLang", item.ToLanguage);
			_database.SqlCmd.Parameters.AddWithValue("@Word", item.Word);
			_database.SqlCmd.Parameters.AddWithValue("@PAnswers", string.Join(";", item.PossibleAnswers.ToArray()));
		}
	}
}
