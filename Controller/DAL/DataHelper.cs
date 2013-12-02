using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace DAL
{
    public class DataHelper
    {
        public SQLiteConnection GetConn()
        {
            SQLiteConnection conn = null;
            try
            {
                 conn = new SQLiteConnection("db.db");
            }
            catch (Exception ex)
            {
 
            }

            return conn;
        }

        public DataTable GetDataBySql(string sql)
        {
            DataTable dt = new DataTable();
            SQLiteConnection conn = this.GetConn();

            try
            {
                SQLiteCommand comm = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(comm);

                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                InitDB();
            }

            return dt;
        }

        public void ExecuteSql(string sql)
        {
            try
            {
                SQLiteConnection conn = this.GetConn();
                SQLiteCommand comm = new SQLiteCommand(sql, conn);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InitDB()
        {
            try
            {
                string sql = "create table tb_area (id integer primary key autoincreament, name varchar(50))";
                this.ExecuteSql(sql);
                sql = "create table tb_module (id integer primary key autoincreatment, name varchar(50), ip varchar(20), port integer,"+
                    "fun1 varchar(20),fun2 varchar(20),fun3 varchar(20),fun4 varchar(20),fun5 varchar(20),fun6 varchar(20))";
                this.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
