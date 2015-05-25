using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region compra
	/// <summary>
	/// This object represents the properties and methods of a compra.
	/// </summary>
	public class compra
	{
		private int _id;
		private int _idSucursal;
		private int _idProveedor;
		private int _idUsuario;
		private DateTime _fecha;
		private double _total;
		
		public compra()
		{
		}
		
		public compra(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idCompra", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM compra WHERE idCompra = @idCompra");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("compra does not exist.");
			}
		}
		
		public compra(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		protected void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _idSucursal = reader.GetInt32(1);
				if (!reader.IsDBNull(2)) _idProveedor = reader.GetInt32(2);
				if (!reader.IsDBNull(3)) _idUsuario = reader.GetInt32(3);
				if (!reader.IsDBNull(4)) _fecha = reader.GetDateTime(4);
				if (!reader.IsDBNull(5)) _total = reader.GetDouble(5);
			}
		}
		
		public void Delete()
		{
			compra.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idCompra", MySqlDbType.Int32, Id);
			queryParameters.Append("idCompra = @idCompra");

			sql.AddParameter("@idSucursal", MySqlDbType.Int32, idSucursal);
			queryParameters.Append(", idSucursal = @idSucursal");
			sql.AddParameter("@idProveedor", MySqlDbType.Int32, idProveedor);
			queryParameters.Append(", idProveedor = @idProveedor");
			sql.AddParameter("@idUsuario", MySqlDbType.Int32, idUsuario);
			queryParameters.Append(", idUsuario = @idUsuario");
			sql.AddParameter("@fecha", MySqlDbType.DateTime, fecha);
			queryParameters.Append(", fecha = @fecha");
			sql.AddParameter("@total", MySqlDbType.Double, total);
			queryParameters.Append(", total = @total");

			string query = String.Format("Update compra Set {0} Where idCompra = @idCompra", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idSucursal", MySqlDbType.Int32, idSucursal);
			queryParameters.Append("@idSucursal");
			sql.AddParameter("@idProveedor", MySqlDbType.Int32, idProveedor);
			queryParameters.Append(", @idProveedor");
			sql.AddParameter("@idUsuario", MySqlDbType.Int32, idUsuario);
			queryParameters.Append(", @idUsuario");
			sql.AddParameter("@fecha", MySqlDbType.DateTime, fecha);
			queryParameters.Append(", @fecha");
			sql.AddParameter("@total", MySqlDbType.Double, total);
			queryParameters.Append(", @total");

			string query = String.Format("Insert Into compra ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static compra Newcompra(int id)
		{
			compra newEntity = new compra();
			newEntity._id = id;

			return newEntity;
		}
		
		#region Public Properties
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}
		
		public int idSucursal
		{
			get {return _idSucursal;}
			set {_idSucursal = value;}
		}

		public int idProveedor
		{
			get {return _idProveedor;}
			set {_idProveedor = value;}
		}

		public int idUsuario
		{
			get {return _idUsuario;}
			set {_idUsuario = value;}
		}

		public DateTime fecha
		{
			get {return _fecha;}
			set {_fecha = value;}
		}

		public double total
		{
			get {return _total;}
			set {_total = value;}
		}
		#endregion
		
		public static compra Getcompra(int id)
		{
			return new compra(id);
		}

        public List<compra> GetAllcompra() {
            List<compra> lista = new List<compra>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM compra");
            compra obj;

            while (reader.Read()) {
                obj = new compra();
                obj.LoadFromReader(reader);
                lista.Add(obj);
            }
            reader.Close();
            return lista;
        }

		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idCompra", MySqlDbType.Int32, id);
	
			MySqlDataReader reader = sql.ExecuteSqlReader("Delete From compra Where idCompra = @idCompra");
		}
	}
	#endregion
}

