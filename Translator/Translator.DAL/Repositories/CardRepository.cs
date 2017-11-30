using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Translator.DAL
{
	public class CardRepository : IRepository<Card>
	{
		private Database _database;

		public CardRepository(Database database)
		{
			_database = database;
		}
		public void Create(Card item)
		{
			string request = "INSERT INTO Cards (FLang,TLang,Word,PAnswers) Values (@FLang,@TLang,@Word,@PAnswers)";
			_database.SqlCmd.CommandText = request;
			FillQuery(item);
			int inserted = RunQuery();
		}

		public void Delete(int id)
		{
			string request = $"delete from Cards where CardId={id}";
			_database.SqlCmd.CommandText = request;
			int delted = RunQuery();
		}

		public Card Get(int id)
		{
			string request = $"Select * from Cards where CardId={id}";
			var reader = _database.GetReader(request);

			Card card = null;
			while (reader.Read())
			{
				card = GenerateCard(reader);
			}
			_database.Connection.Close();
			return card;
		}

		public IEnumerable<Card> GetAll()
		{
			string request = "Select * from Cards";
			var reader = _database.GetReader(request);

			List<Card> cards = new List<Card>();
			while (reader.Read())
			{
				cards.Add( GenerateCard(reader));
			}
			_database.Connection.Close();

			return cards;
		}

		public void Update(Card item)
		{
			string request = "UPDATE Cards SET FLang = @flang, TLang = @tlang, Word = @word, PAnswers = @answ Where CardId = @id";
			_database.SqlCmd.CommandText = request;
			_database.SqlCmd.Parameters.AddWithValue("@id",item.CardId.ID);
			FillQuery(item);
			int delted = RunQuery();
		}
		private Card GenerateCard(SqlDataReader reader)
		{
			Card card = new Card();
			card.CardId = new CardID { ID = Convert.ToInt32(reader.GetValue(0)) };
			card.FromLanguage = reader.GetValue(1).ToString();
			card.ToLanguage = reader.GetValue(2).ToString();
			card.Word = reader.GetValue(3).ToString();
			card.RightAnswer = reader.GetValue(4).ToString();
			card.PossibleAnswers = reader.GetValue(5).ToString().Split(';').ToList();

			return card;
		}
		private int RunQuery()
		{
			_database.Connection.Open();
			int n = _database.SqlCmd.ExecuteNonQuery();
			_database.Connection.Close();

			return n;
		}
		private void FillQuery(Card item)
		{
			_database.SqlCmd.Parameters.AddWithValue("@FLang", item.FromLanguage);
			_database.SqlCmd.Parameters.AddWithValue("@TLang", item.ToLanguage);
			_database.SqlCmd.Parameters.AddWithValue("@Word", item.Word);
			_database.SqlCmd.Parameters.AddWithValue("@PAnswers", string.Join(";", item.PossibleAnswers.ToArray()));
		}
	}
}
