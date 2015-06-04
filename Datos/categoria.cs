using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region categoria
	/// <summary>
	/// This object represents the properties and methods of a categoria.
	/// </summary>
	public class categoria
	{
		private int _id;
		private string _nombre = String.Empty;
		
		public categoria()
		{
		}
		
		public categoria(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idCategoria", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM categoria WHERE idCategoria = @idCategoria");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("categoria does not exist.");
			}
		}
		
		public categoria(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		protected void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _nombre = reader.GetString(1);
			}
		}
		
		public void Delete()
		{
			categoria.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idCategoria", MySqlDbType.Int32, Id);
			queryParameters.Append("idCategoria = @idCategoria");

			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append(", nombre = @nombre");

			string query = String.Format("Update categoria Set {0} Where idCategoria = @idCategoria", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append("@nombre");

			string query = String.Format("Insert Into categoria ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static categoria Newcategoria(int id)
		{
			categoria newEntity = new categoria();
			newEntity._id = id;

			return newEntity;
		}
		
		#region Public Properties
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}
		
		public string nombre
		{
			get {return _nombre;}
			set {_nombre = value;}
		}
		#endregion
		
		public static categoria Getcategoria(int id)
		{
			return new categoria(id);
		}

        public List<categoria> GetAllcategoria() {
            List<categoria> lista = new List<categoria>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM categoria");
            categoria obj;

            while (reader.Read()) {
                obj = new categoria();
                obj.LoadFromReader(reader);
                lista.Add(obj);
            }
            reader.Close();
            return lista;
        }

		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idCategoria", MySqlDbType.Int32, id);
	
			MySqlDataReader reader = sql.ExecuteSqlReader("Delete From categoria Where idCategoria = @idCategoria");
		}

        public override string ToString() {
            if (nombre != null) return nombre;
            return "null";
        }

        public override bool Equals(object obj) {
            try {
                categoria c = (categoria)obj;
                return Id == c.Id;
            } catch (Exception ex) {
                return base.Equals(obj);
            }
        }
	}
	#endregion
}

