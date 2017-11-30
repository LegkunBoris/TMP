using System.Data.SqlClient;
namespace Translator.DAL
{
	public class Database
	{
		private SqlDataReader 	_reader 	= null;
		private SqlConnection 	_connection = new SqlConnection();
		private SqlCommand 		_sqlCmd 	= new SqlCommand();
		public Database(string connectionString)
		{
			_connection.ConnectionString = connectionString;
			_sqlCmd.CommandType = System.Data.CommandType.Text;
			_sqlCmd.Connection = _connection;
		}
		public SqlCommand SqlCmd
		{
			get{ return _sqlCmd;}
		}
		public SqlConnection Connection
		{
			get { return _connection; }
		}
		public SqlDataReader GetReader(string request)
		{
			if (!string.IsNullOrEmpty(request))
			{
				_sqlCmd.CommandText = request;
				_connection.Open();
				_reader = _sqlCmd.ExecuteReader();
				return _reader;
			}
			return null;
		}
	}
}
