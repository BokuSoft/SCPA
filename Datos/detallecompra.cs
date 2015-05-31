using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region detallecompra
	/// <summary>
	/// This object represents the properties and methods of a detallecompra.
	/// </summary>
	public class detallecompra
	{
		private int _id;
		private int _idCompra;
		private int _idProducto;
		private int _cantidad;
		private double _precio;
		
		public detallecompra()
		{
		}
		
		public detallecompra(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idDetalleCompra", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM detallecompra WHERE idDetalleCompra = @idDetalleCompra");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("detallecompra does not exist.");
			}
		}
		
		public detallecompra(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		protected void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _idCompra = reader.GetInt32(1);
				if (!reader.IsDBNull(2)) _idProducto = reader.GetInt32(2);
				if (!reader.IsDBNull(3)) _cantidad = reader.GetInt32(3);
				if (!reader.IsDBNull(4)) _precio = reader.GetDouble(4);
			}
		}
		
		public void Delete()
		{
			detallecompra.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idDetalleCompra", MySqlDbType.Int32, Id);
			queryParameters.Append("idDetalleCompra = @idDetalleCompra");

			sql.AddParameter("@idCompra", MySqlDbType.Int32, idCompra);
			queryParameters.Append(", idCompra = @idCompra");
			sql.AddParameter("@idProducto", MySqlDbType.Int32, idProducto);
			queryParameters.Append(", idProducto = @idProducto");
			sql.AddParameter("@cantidad", MySqlDbType.Int32, cantidad);
			queryParameters.Append(", cantidad = @cantidad");
			sql.AddParameter("@precio", MySqlDbType.Double, precio);
			queryParameters.Append(", precio = @precio");

			string query = String.Format("Update detallecompra Set {0} Where idDetalleCompra = @idDetalleCompra", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idCompra", MySqlDbType.Int32, idCompra);
			queryParameters.Append("@idCompra");
			sql.AddParameter("@idProducto", MySqlDbType.Int32, idProducto);
			queryParameters.Append(", @idProducto");
			sql.AddParameter("@cantidad", MySqlDbType.Int32, cantidad);
			queryParameters.Append(", @cantidad");
			sql.AddParameter("@precio", MySqlDbType.Double, precio);
			queryParameters.Append(", @precio");

			string query = String.Format("Insert Into detallecompra ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static detallecompra Newdetallecompra(int id)
		{
			detallecompra newEntity = new detallecompra();
			newEntity._id = id;

			return newEntity;
		}
		
		#region Public Properties
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}
		
		public int idCompra
		{
			get {return _idCompra;}
			set {_idCompra = value;}
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
		
		public static detallecompra Getdetallecompra(int id)
		{
			return new detallecompra(id);
		}

        public List<detallecompra> GetAlldetallecompra() {
            List<detallecompra> lista = new List<detallecompra>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM detallecompra");
            detallecompra obj;

            while (reader.Read()) {
                obj = new detallecompra();
                obj.LoadFromReader(reader);
                lista.Add(obj);
            }
            reader.Close();
            return lista;
        }

		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idDetalleCompra", MySqlDbType.Int32, id);
	
			MySqlDataReader reader = sql.ExecuteSqlReader("Delete From detallecompra Where idDetalleCompra = @idDetalleCompra");
		}
	}
	#endregion
}

