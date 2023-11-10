using BBBWebMVC.Models;
using MySql.Data.MySqlClient;
using Dapper;

namespace BBBWebMVC.Repository
{
	public class GadgetRepository : IGadgetRepository
	{
		public MySqlConnection _conn;
		public GadgetRepository (MySqlConnection conn)
		{
			_conn = conn;
		}

		public IEnumerable<GadgetModel> FindAll()
		{
			return _conn.Query<GadgetModel>("SELECT * FROM gadgets");
		}

		public void Create(GadgetModel model)
		{
			_conn.Execute("INSERT INTO gadgets (GadgetsId, Name) VALUES (@gadgetId, @name)", new { gadgetId = model.Id, name = model.Name });
		}
	}
}
