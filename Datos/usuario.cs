using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region usuario
	/// <summary>
	/// This object represents the properties and methods of a usuario.
	/// </summary>
	public class usuario
	{
		private int _id;
		private string _nombre = String.Empty;
		private string _apellidos = String.Empty;
		private string _direccion = String.Empty;
		private string _ciudad = String.Empty;
		private DateTime _fechaNacimiento;
		private string _telefono = String.Empty;
		private enum EnumTipoUsuario: int {
            ADMINISTRATOR,
            EMPLOYEE,
            CUSTOMER,
            GUEST
        }
        private EnumTipoUsuario _tipoUsuario;

		
		public usuario()
		{
		}
		
		public usuario(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idUsuario", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM usuario WHERE idUsuario = @idUsuario");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("usuario does not exist.");
			}
		}
		
		public usuario(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		public void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _nombre = reader.GetString(1);
				if (!reader.IsDBNull(2)) _apellidos = reader.GetString(2);
				if (!reader.IsDBNull(3)) _direccion = reader.GetString(3);
				if (!reader.IsDBNull(4)) _ciudad = reader.GetString(4);
				if (!reader.IsDBNull(5)) _fechaNacimiento = reader.GetDateTime(5);
				if (!reader.IsDBNull(6)) _telefono = reader.GetString(6);
				if (!reader.IsDBNull(7)) _tipoUsuario = (EnumTipoUsuario)reader.GetInt32(7);//dudas con lo que regrese
			}
		}
		
		public void Delete()
		{
			usuario.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idUsuario", MySqlDbType.Int32, Id);
			queryParameters.Append("idUsuario = @idUsuario");

			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append(", nombre = @nombre");
			sql.AddParameter("@apellidos", MySqlDbType.VarChar, apellidos);
			queryParameters.Append(", apellidos = @apellidos");
			sql.AddParameter("@direccion", MySqlDbType.VarChar, direccion);
			queryParameters.Append(", direccion = @direccion");
			sql.AddParameter("@ciudad", MySqlDbType.VarChar, ciudad);
			queryParameters.Append(", ciudad = @ciudad");
			sql.AddParameter("@fechaNacimiento", MySqlDbType.DateTime, fechaNacimiento);
			queryParameters.Append(", fechaNacimiento = @fechaNacimiento");
			sql.AddParameter("@telefono", MySqlDbType.VarChar, telefono);
			queryParameters.Append(", telefono = @telefono");
			sql.AddParameter("@tipoUsuario", MySqlDbType.Int32, tipoUsuario);
			queryParameters.Append(", tipoUsuario = @tipoUsuario");

			string query = String.Format("Update usuario Set {0} Where idUsuario = @idUsuario", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idUsuario", MySqlDbType.Int32, Id);
			queryParameters.Append("@idUsuario");

			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append(", @nombre");
			sql.AddParameter("@apellidos", MySqlDbType.VarChar, apellidos);
			queryParameters.Append(", @apellidos");
			sql.AddParameter("@direccion", MySqlDbType.VarChar, direccion);
			queryParameters.Append(", @direccion");
			sql.AddParameter("@ciudad", MySqlDbType.VarChar, ciudad);
			queryParameters.Append(", @ciudad");
			sql.AddParameter("@fechaNacimiento", MySqlDbType.DateTime, fechaNacimiento);
			queryParameters.Append(", @fechaNacimiento");
			sql.AddParameter("@telefono", MySqlDbType.VarChar, telefono);
			queryParameters.Append(", @telefono");
			sql.AddParameter("@tipoUsuario", MySqlDbType.Int32, tipoUsuario);
			queryParameters.Append(", @tipoUsuario");

			string query = String.Format("Insert Into usuario ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static usuario Newusuario(int id)
		{
			usuario newEntity = new usuario();
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

		public string ciudad
		{
			get {return _ciudad;}
			set {_ciudad = value;}
		}

		public DateTime fechaNacimiento
		{
			get {return _fechaNacimiento;}
			set {_fechaNacimiento = value;}
		}

		public string telefono
		{
			get {return _telefono;}
			set {_telefono = value;}
		}

		public EnumTipoUsuario tipoUsuario
		{
			get {return _tipoUsuario;}
			set {_tipoUsuario = value;}
		}
		#endregion
		
		public static usuario Getusuario(int id)
		{
			return new usuario(id);
		}

        public List<usuario> GetAllusuario() {
            List<usuario> lista = new List<usuario>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM usuario");
            usuario obj;

            while (reader.Read()) {
                obj = new usuario();
                obj.LoadFromReader(reader);
                lista.Add(obj);
                reader.Close();
            }
            return lista;
        }
		
		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idUsuario", MySqlDbType.Int32, id);
	
			MySqlDataReader reader = sql.ExecuteSqlReader("Delete usuario Where idUsuario = @idUsuario");
		}
	}
	#endregion
}

