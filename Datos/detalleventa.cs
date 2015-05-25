using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region detalleventa
	/// <summary>
	/// This object represents the properties and methods of a detalleventa.
	/// </summary>
	public class detalleventa
	{
		private int _id;
		private int _idVenta;
		private int _idProducto;
		private int _cantidad;
		private double _precio;
		
		public detalleventa()
		{
		}
		
		public detalleventa(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idDetalleVenta", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM detalleventa WHERE idDetalleVenta = @idDetalleVenta");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("detalleventa does not exist.");
			}
		}
		
		public detalleventa(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		protected void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _idVenta = reader.GetInt32(1);
				if (!reader.IsDBNull(2)) _idProducto = reader.GetInt32(2);
				if (!reader.IsDBNull(3)) _cantidad = reader.GetInt32(3);
				if (!reader.IsDBNull(4)) _precio = reader.GetDouble(4);
			}
		}
		
		public void Delete()
		{
			detalleventa.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idDetalleVenta", MySqlDbType.Int32, Id);
			queryParameters.Append("idDetalleVenta = @idDetalleVenta");

			sql.AddParameter("@idVenta", MySqlDbType.Int32, idVenta);
			queryParameters.Append(", idVenta = @idVenta");
			sql.AddParameter("@idProducto", MySqlDbType.Int32, idProducto);
			queryParameters.Append(", idProducto = @idProducto");
			sql.AddParameter("@cantidad", MySqlDbType.Int32, cantidad);
			queryParameters.Append(", cantidad = @cantidad");
			sql.AddParameter("@precio", MySqlDbType.Double, precio);
			queryParameters.Append(", precio = @precio");

			string query = String.Format("Update detalleventa Set {0} Where idDetalleVenta = @idDetalleVenta", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idVenta", MySqlDbType.Int32, idVenta);
			queryParameters.Append("@idVenta");
			sql.AddParameter("@idProducto", MySqlDbType.Int32, idProducto);
			queryParameters.Append(", @idProducto");
			sql.AddParameter("@cantidad", MySqlDbType.Int32, cantidad);
			queryParameters.Append(", @cantidad");
			sql.AddParameter("@precio", MySqlDbType.Double, precio);
			queryParameters.Append(", @precio");

			string query = String.Format("Insert Into detalleventa ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static detalleventa Newdetalleventa(int id)
		{
			detalleventa newEntity = new detalleventa();
			newEntity._id = id;

			return newEntity;
		}
		
		#region Public Properties
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}
		
		public int idVenta
		{
			get {return _idVenta;}
			set {_idVenta = value;}
		}

		public int idProducto
		{
			get {return _idProducto;}
			set {_idProducto = value;}
		}

		public int cantidad
		{
			get {return _cantidad;}
			set {_cantidad = value;}
		}

		public double precio
		{
			get {return _precio;}
			set {_precio = value;}
		}
		#endregion
		
		public static detalleventa Getdetalleventa(int id)
		{
			return new detalleventa(id);
		}

        public List<detalleventa> GetAlldetalleventa() {
            List<detalleventa> lista = new List<detalleventa>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM detalleventa");
            detalleventa obj;

            while (reader.Read()) {
                obj = new detalleventa();
                obj.LoadFromReader(reader);
                lista.Add(obj);
            }
            reader.Close();
            return lista;
        }
		
		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idDetalleVenta", MySqlDbType.Int32, id);
	
			MySqlDataReader reader = sql.ExecuteSqlReader("Delete From detalleventa Where idDetalleVenta = @idDetalleVenta");
		}
	}
	#endregion
}

