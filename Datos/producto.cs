using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
	#region producto
	/// <summary>
	/// This object represents the properties and methods of a producto.
	/// </summary>
	public class producto
	{
		private int _id;
		private int _idCategoria;
		private int _idProveedor;
		private string _nombre = String.Empty;
		private int _cantidad;
		private double _precio;
		private short _descontinuado;
		
		public producto()
		{
		}
		
		public producto(int id)
		{
            		// NOTE: If this reference doesn't exist then add SqlService.cs from the template directory to your solution.
			SqlService sql = new SqlService();
			sql.AddParameter("@idProducto", MySqlDbType.Int32, id);
			MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM producto WHERE idProducto = @idProducto");
			
			if (reader.Read()) 
			{
				this.LoadFromReader(reader);
				reader.Close();
			}
			else
			{
				if (!reader.IsClosed) reader.Close();
				throw new ApplicationException("producto does not exist.");
			}
		}
		
		public producto(MySqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		
		protected void LoadFromReader(MySqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				_id = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) _idCategoria = reader.GetInt32(1);
				if (!reader.IsDBNull(2)) _idProveedor = reader.GetInt32(2);
				if (!reader.IsDBNull(3)) _nombre = reader.GetString(3);
				if (!reader.IsDBNull(4)) _cantidad = reader.GetInt32(4);
				if (!reader.IsDBNull(5)) _precio = reader.GetDouble(5);
				if (!reader.IsDBNull(6)) _descontinuado = reader.GetInt16(6);
			}
		}
		
		public void Delete()
		{
			producto.Delete(_id);
		}
		
		public void Update()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idProducto", MySqlDbType.Int32, Id);
			queryParameters.Append("idProducto = @idProducto");

			sql.AddParameter("@idCategoria", MySqlDbType.Int32, idCategoria);
			queryParameters.Append(", idCategoria = @idCategoria");
			sql.AddParameter("@idProveedor", MySqlDbType.Int32, idProveedor);
			queryParameters.Append(", idProveedor = @idProveedor");
			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append(", nombre = @nombre");
			sql.AddParameter("@cantidad", MySqlDbType.Int32, cantidad);
			queryParameters.Append(", cantidad = @cantidad");
			sql.AddParameter("@precio", MySqlDbType.Double, precio);
			queryParameters.Append(", precio = @precio");
			sql.AddParameter("@descontinuado", MySqlDbType.Bit, descontinuado);
			queryParameters.Append(", descontinuado = @descontinuado");

			string query = String.Format("Update producto Set {0} Where idProducto = @idProducto", queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public void Create()
		{
			SqlService sql = new SqlService();
			StringBuilder queryParameters = new StringBuilder();

			sql.AddParameter("@idCategoria", MySqlDbType.Int32, idCategoria);
			queryParameters.Append("@idCategoria");
			sql.AddParameter("@idProveedor", MySqlDbType.Int32, idProveedor);
			queryParameters.Append(", @idProveedor");
			sql.AddParameter("@nombre", MySqlDbType.VarChar, nombre);
			queryParameters.Append(", @nombre");
			sql.AddParameter("@cantidad", MySqlDbType.Int32, cantidad);
			queryParameters.Append(", @cantidad");
			sql.AddParameter("@precio", MySqlDbType.Double, precio);
			queryParameters.Append(", @precio");
			sql.AddParameter("@descontinuado", MySqlDbType.Bit, descontinuado);
			queryParameters.Append(", @descontinuado");

			string query = String.Format("Insert Into producto ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
			MySqlDataReader reader = sql.ExecuteSqlReader(query);
		}
		
		public static producto Newproducto(int id)
		{
			producto newEntity = new producto();
			newEntity._id = id;

			return newEntity;
		}
		
		#region Public Properties
		public int Id
		{
			get {return _id;}
			set {_id = value;}
		}
		
		public int idCategoria
		{
			get {return _idCategoria;}
			set {_idCategoria = value;}
		}

		public int idProveedor
		{
			get {return _idProveedor;}
			set {_idProveedor = value;}
		}

		public string nombre
		{
			get {return _nombre;}
			set {_nombre = value;}
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

		public short descontinuado
		{
			get {return _descontinuado;}
			set {_descontinuado = value;}
		}
		#endregion
		
		public static producto Getproducto(int id)
		{
			return new producto(id);
		}

        public List<producto> GetAllproducto() {
            List<producto> lista = new List<producto>();
            SqlService sql = new SqlService();
            MySqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM producto");
            producto obj;

            while (reader.Read()) {
                obj = new producto();
                obj.LoadFromReader(reader);
                lista.Add(obj);
            }
            reader.Close();
            return lista;
        }
		
		public static void Delete(int id)
		{
			SqlService sql = new SqlService();
			sql.AddParameter("@idProducto", MySqlDbType.Int32, id);
	
			MySqlDataReader reader = sql.ExecuteSqlReader("Delete From producto Where idProducto = @idProducto");
		}
	}
	#endregion
}

