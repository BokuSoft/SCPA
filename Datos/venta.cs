using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region venta
	/// <summary>
	/// This object represents the properties and methods of a venta.
	/// </summary>
	public class venta
	{
		private int _id;
		private int _idCliente;
		private int _idUsuario;
		private int _idSucursal;
		private DateTime _fecha;
		private double _total;
		
		public venta()
		{
		}
		
		public venta(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idVenta", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM venta WHERE idVenta = @idVenta");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("venta does not exist.");
			}
		}
		
		public venta(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		protected void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _idCliente = reader.GetInt32(1);
				if (!reader.IsDBNull(2)) _idUsuario = reader.GetInt32(2);
				if (!reader.IsDBNull(3)) _idSucursal = reader.GetInt32(3);
				if (!reader.IsDBNull(4)) _fecha = reader.GetDateTime(4);
				if (!reader.IsDBNull(5)) _total = reader.GetDouble(5);
			}
		}
		
		public void Delete()
		{
			venta.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idVenta", MySqlDbType.Int32, Id);
			queryParameters.Append("idVenta = @idVenta");

			sql.AddParameter("@idCliente", MySqlDbType.Int32, idCliente);
			queryParameters.Append(", idCliente = @idCliente");
			sql.AddParameter("@idUsuario", MySqlDbType.Int32, idUsuario);
			queryParameters.Append(", idUsuario = @idUsuario");
			sql.AddParameter("@idSucursal", MySqlDbType.Int32, idSucursal);
			queryParameters.Append(", idSucursal = @idSucursal");
			sql.AddParameter("@fecha", MySqlDbType.DateTime, fecha);
			queryParameters.Append(", fecha = @fecha");
			sql.AddParameter("@total", MySqlDbType.Double, total);
			queryParameters.Append(", total = @total");

			string query = String.Format("Update venta Set {0} Where idVenta = @idVenta", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idCliente", MySqlDbType.Int32, idCliente);
			queryParameters.Append("@idCliente");
			sql.AddParameter("@idUsuario", MySqlDbType.Int32, idUsuario);
			queryParameters.Append(", @idUsuario");
			sql.AddParameter("@idSucursal", MySqlDbType.Int32, idSucursal);
			queryParameters.Append(", @idSucursal");
			sql.AddParameter("@fecha", MySqlDbType.DateTime, fecha);
			queryParameters.Append(", @fecha");
			sql.AddParameter("@total", MySqlDbType.Double, total);
			queryParameters.Append(", @total");

			string query = String.Format("Insert Into venta ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static venta Newventa(int id)
		{
			venta newEntity = new venta();
			newEntity._id = id;

			return newEntity;
		}
		
		#region Public Properties
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}
		
		public int idCliente
		{
			get {return _idCliente;}
			set {_idCliente = value;}
		}

		public int idUsuario
		{
			get {return _idUsuario;}
			set {_idUsuario = value;}
		}

		public int idSucursal
		{
			get {return _idSucursal;}
			set {_idSucursal = value;}
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
		
		public static venta Getventa(int id)
		{
			return new venta(id);
		}

        public List<venta> GetAllventa() {
            List<venta> lista = new List<venta>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM venta");
            venta obj;

            while (reader.Read()) {
                obj = new venta();
                obj.LoadFromReader(reader);
                lista.Add(obj);
            }
            reader.Close();
            return lista;
        }

		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idVenta", MySqlDbType.Int32, id);
	
			MySqlDataReader reader = sql.ExecuteSqlReader("Delete From venta Where idVenta = @idVenta");
		}
	}
	#endregion
}

