using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QL_ChungCu
{
    class KetNoi
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter adapter = new SqlDataAdapter();
        public DataTable table = new DataTable();
        public string dtb = @"Data Source=LAPTOP-GL3J5C27\SQLEXPRESS;Initial Catalog=QLCC;Integrated Security=True";

        public void Ket_noi()
        {
            conn = new SqlConnection(dtb);
            conn.Open();
        }

        public void Huy_Ket_noi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public void Thuc_thi(string query)
        {
            Ket_noi();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Huy_Ket_noi();
        }

        public DataTable Lay_du_lieu(string query)
        {
            Ket_noi();
            adapter = new SqlDataAdapter(query, conn);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
