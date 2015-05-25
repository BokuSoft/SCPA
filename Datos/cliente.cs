using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region cliente
	/// <summary>
	/// This object represents the properties and methods of a cliente.
	/// </summary>
	public class cliente
	{
		private int _id;
		private string _nombre = String.Empty;
		private string _apellidos = String.Empty;
		private string _direccion = String.Empty;
		private DateTime _fechaNamiento;
		private string _ciudad = String.Empty;
		private string _telefono = String.Empty;
		
		public cliente()
		{
		}
		
		public cliente(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idCliente", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM cliente WHERE idCliente = @idCliente");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("cliente does not exist.");
			}
		}
		
		public cliente(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		protected void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _nombre = reader.GetString(1);
				if (!reader.IsDBNull(2)) _apellidos = reader.GetString(2);
				if (!reader.IsDBNull(3)) _direccion = reader.GetString(3);
				if (!reader.IsDBNull(4)) _fechaNamiento = reader.GetDateTime(4);
				if (!reader.IsDBNull(5)) _ciudad = reader.GetString(5);
				if (!reader.IsDBNull(6)) _telefono = reader.GetString(6);
			}
		}
		
		public void Delete()
		{
			cliente.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idCliente", MySqlDbType.Int32, Id);
			queryParameters.Append("idCliente = @idCliente");

			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append(", nombre = @nombre");
			sql.AddParameter("@apellidos", MySqlDbType.VarChar, apellidos);
			queryParameters.Append(", apellidos = @apellidos");
			sql.AddParameter("@direccion", MySqlDbType.VarChar, direccion);
			queryParameters.Append(", direccion = @direccion");
			sql.AddParameter("@fechaNamiento", MySqlDbType.DateTime, fechaNamiento);
			queryParameters.Append(", fechaNamiento = @fechaNamiento");
			sql.AddParameter("@ciudad", MySqlDbType.VarChar, ciudad);
			queryParameters.Append(", ciudad = @ciudad");
			sql.AddParameter("@telefono", MySqlDbType.VarChar, telefono);
			queryParameters.Append(", telefono = @telefono");

			string query = String.Format("Update cliente Set {0} Where idCliente = @idCliente", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append("@nombre");
			sql.AddParameter("@apellidos", MySqlDbType.VarChar, apellidos);
			queryParameters.Append(", @apellidos");
			sql.AddParameter("@direccion", MySqlDbType.VarChar, direccion);
			queryParameters.Append(", @direccion");
			sql.AddParameter("@fechaNamiento", MySqlDbType.DateTime, fechaNamiento);
			queryParameters.Append(", @fechaNamiento");
			sql.AddParameter("@ciudad", MySqlDbType.VarChar, ciudad);
			queryParameters.Append(", @ciudad");
			sql.AddParameter("@telefono", MySqlDbType.VarChar, telefono);
			queryParameters.Append(", @telefono");

			string query = String.Format("Insert Into cliente ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static cliente Newcliente(int id)
		{
			cliente newEntity = new cliente();
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

		public string apellidos
		{
			get {return _apellidos;}
			set {_apellidos = value;}
		}

		public string direccion
		{
			get {return _direccion;}
			set {_direccion = value;}
		}

		public DateTime fechaNamiento
		{
			get {return _fechaNamiento;}
			set {_fechaNamiento = value;}
		}

		public string ciudad
		{
			get {return _ciudad;}
			set {_ciudad = value;}
		}

		public string telefono
		{
			get {return _telefono;}
			set {_telefono = value;}
		}
		#endregion
		
		public static cliente Getcliente(int id)
		{
			return new cliente(id);
		}

        public List<cliente> GetAllcliente() {
            List<cliente> lista = new List<cliente>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM cliente");
            cliente obj;

            while (reader.Read()) {
                obj = new cliente();
                obj.LoadFromReader(reader);
                lista.Add(obj);
            }
            reader.Close();
            return lista;
        }

		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idCliente", MySqlDbType.Int32, id);
	
			MySqlDataReader reader = sql.ExecuteSqlReader("Delete From cliente Where idCliente = @idCliente");
		}
	}
	#endregion
}

