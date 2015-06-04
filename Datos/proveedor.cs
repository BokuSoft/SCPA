using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region proveedor
	/// <summary>
	/// This object represents the properties and methods of a proveedor.
	/// </summary>
	public class proveedor
	{
		private int _id;
		private string _nombre = String.Empty;
		private string _nombreJefe = String.Empty;
		private string _direccion = String.Empty;
		private string _ciudad = String.Empty;
		private string _telefono = String.Empty;
		
		public proveedor()
		{
		}
		
		public proveedor(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idProveedor", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM proveedor WHERE idProveedor = @idProveedor");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("proveedor does not exist.");
			}
		}
		
		public proveedor(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		protected void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _nombre = reader.GetString(1);
				if (!reader.IsDBNull(2)) _nombreJefe = reader.GetString(2);
				if (!reader.IsDBNull(3)) _direccion = reader.GetString(3);
				if (!reader.IsDBNull(4)) _ciudad = reader.GetString(4);
				if (!reader.IsDBNull(5)) _telefono = reader.GetString(5);
			}
		}
		
		public void Delete()
		{
			proveedor.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idProveedor", MySqlDbType.Int32, Id);
			queryParameters.Append("idProveedor = @idProveedor");

			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append(", nombre = @nombre");
			sql.AddParameter("@nombreJefe", MySqlDbType.VarChar, nombreJefe);
			queryParameters.Append(", nombreJefe = @nombreJefe");
			sql.AddParameter("@direccion", MySqlDbType.VarChar, direccion);
			queryParameters.Append(", direccion = @direccion");
			sql.AddParameter("@ciudad", MySqlDbType.VarChar, ciudad);
			queryParameters.Append(", ciudad = @ciudad");
			sql.AddParameter("@telefono", MySqlDbType.VarChar, telefono);
			queryParameters.Append(", telefono = @telefono");

			string query = String.Format("Update proveedor Set {0} Where idProveedor = @idProveedor", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();
            
			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append("@nombre");
			sql.AddParameter("@nombreJefe", MySqlDbType.VarChar, nombreJefe);
			queryParameters.Append(", @nombreJefe");
			sql.AddParameter("@direccion", MySqlDbType.VarChar, direccion);
			queryParameters.Append(", @direccion");
			sql.AddParameter("@ciudad", MySqlDbType.VarChar, ciudad);
			queryParameters.Append(", @ciudad");
			sql.AddParameter("@telefono", MySqlDbType.VarChar, telefono);
			queryParameters.Append(", @telefono");

			string query = String.Format("Insert Into proveedor ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static proveedor Newproveedor(int id)
		{
			proveedor newEntity = new proveedor();
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

		public string nombreJefe
		{
			get {return _nombreJefe;}
			set {_nombreJefe = value;}
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

		public string telefono
		{
			get {return _telefono;}
			set {_telefono = value;}
		}
		#endregion
		
		public static proveedor Getproveedor(int id)
		{
			return new proveedor(id);
		}

        public List<proveedor> GetAllproveedor() {
            List<proveedor> lista = new List<proveedor>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM proveedor");
            proveedor obj;

            while (reader.Read()) {
                obj = new proveedor();
                obj.LoadFromReader(reader);
                lista.Add(obj);
            }
            reader.Close();
            return lista;
        }

		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idProveedor", MySqlDbType.Int32, id);

            MySqlDataReader reader = sql.ExecuteSqlReader("Delete From proveedor Where idProveedor = @idProveedor");
		}

        public override string ToString() {
            if (nombre != null) return nombre;
            return "null";
        }
	}
	#endregion
}

