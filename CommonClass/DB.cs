using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Diagnostics;

namespace CommonClass
{
    public enum DBCode
    {
        ConnSucceed = 0,
        EmptyConnString = 1,
        EmptyCmdText = 2,
        ConnFaild = 3,
        HasRecord = 4,
        NoRecord = 5,
        InsSucceed = 6,
        InsFaild = 7,
        UpdateSucceed = 8,
        UpdateFaild = 9,
        DelSucceed = 10,
        DelFailed = 11,
        DBError = 100,
        ExecuteSucceed = 12,
        ExecuteFailed = 13,
    };

    public enum SQLMethod
    {
        SELECT = 0,
        INSERT = 1,
        UPDATE = 2,
        DELETE = 3,
    };

    public class DB
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbTransaction tran;

        public DB(string connStr)
        {
            conn.ConnectionString = connStr;
        }

        public string CommandText
        {
            get { return cmd.CommandText; }
            set { cmd.CommandText = value; }
        }

        public string ConnectionString
        {
            get { return conn.ConnectionString; }
            set { conn.ConnectionString = value; }
        }

        private DBCode InitDB()
        {
            if (conn.ConnectionString == "")
            {
                return DBCode.EmptyConnString;
            }
            else
            {
                try
                {
                    conn.Open();
                    return DBCode.ConnSucceed;
                }
                catch (Exception err)
                {
                    Trace.Write("Err. Message:" + err.Message);
                    return DBCode.ConnFaild;
                }
            }
        }

        public void CloseDB()
        {
            conn.Close();
        }

        public int InsertData(string tablename, Hashtable data)
        {
            int id = 0;
            switch (conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return id;
                default:
                    return id;
            }
            string cmdText = GenSQL(SQLMethod.INSERT, tablename, data);
            Debug.WriteLine(cmdText);
            cmd.Parameters.Clear();
            cmd.CommandText = "InsertDataSQL";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sql", OleDbType.VarChar);
            cmd.Parameters["@sql"].Value = cmdText;
            cmd.Parameters.Add("@id", OleDbType.Integer);
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                cmd.ExecuteNonQuery();
                id = int.Parse(cmd.Parameters["@id"].Value.ToString());
                return id;
            }
            catch (System.Data.OleDb.OleDbException err)
            {
                Trace.Write(err.ToString());
                cmd.Parameters.Clear();
                //CloseDB();
                return id;
            }
        }

        public DBCode ExecuteCommand(string sql,OleDbParameter[] parameters)
        {
            switch (conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return DBCode.ConnFaild;
                default:
                    return DBCode.DBError;
            }
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(parameters);
            try
            {
                cmd.ExecuteNonQuery();
                return DBCode.ExecuteSucceed;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return DBCode.ExecuteFailed;
            }
        }

        public DBCode UpdateRecord(string tablename, Hashtable data, string filter)
        {
            switch (conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return DBCode.ConnFaild;
                default:
                    return DBCode.DBError;
            }
            string cmdText = GenSQL(SQLMethod.UPDATE, tablename, data, filter);
            //cmd.CommandText = cmdtext.Replace("$tablename$", tablename).Replace("$values$", values.TrimEnd(',')).Replace("$filter$", filter);
            cmd.CommandText = cmdText;
            cmd.CommandType = CommandType.Text;
            Debug.WriteLine(cmd.CommandText);
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.ToString());
            }
            if (result >= 1)
            {
                //CloseDB();
                return DBCode.UpdateSucceed;
            }
            else
            {
                //CloseDB();
                return DBCode.UpdateFaild;
            }
        }
        public DBCode UpdateRecord(string tablename, Hashtable data)
        {
            switch (conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return DBCode.ConnFaild;
                default:
                    return DBCode.DBError;
            }
            string cmdText = GenSQL(SQLMethod.UPDATE, tablename, data);
            //cmd.CommandText = cmdtext.Replace("$tablename$", tablename).Replace("$values$", values.TrimEnd(','));
            cmd.CommandText = cmdText;
            cmd.CommandType = CommandType.Text;
            Debug.WriteLine(cmd.CommandText);
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.ToString());
            }
            if (result >= 1)
            {
                //CloseDB();
                return DBCode.UpdateSucceed;
            }
            else
            {
                //CloseDB();
                return DBCode.UpdateFaild;
            }
        }

        public OleDbDataReader GetData(string sql)
        {
            switch(conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return null;
                default:
                    return null;
            }
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteReader();
        }

        public DBCode HasRecord(string table,string filter)
        {
            switch (conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return DBCode.ConnFaild;
                default:
                    return DBCode.DBError;
            }
            string sql = "SELECT COUNT(1) FROM " + table + " WHERE " + filter;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            Debug.WriteLine(cmd.CommandText);
            int count = (int)cmd.ExecuteScalar();
            if (count >= 1)
                return DBCode.HasRecord;
            else
                return DBCode.NoRecord;
        }

        public DBCode DelRecord(string table,string filter="")
        {
            switch (conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return DBCode.ConnFaild;
                default:
                    return DBCode.DBError;
            }
            if (filter == "")
            {
                return DBCode.DelFailed;
            }
            else
            {
                string sql = "DELETE FROM " + table + " WHERE " + filter;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                if(cmd.ExecuteNonQuery()==1)
                {
                    return DBCode.DelSucceed;
                }
                else
                {
                    return DBCode.DelFailed;
                }
            }
        }

        public bool BeginTransaction()
        {
            switch(conn.State)
            {
                case ConnectionState.Open:
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        break;
                    }
                    else
                        return false;
                default:
                    return false;
            }
            tran = conn.BeginTransaction(IsolationLevel.RepeatableRead);
            if (tran != null)
            {
                cmd.Transaction = tran;
                return true;
            }
            else
            {
                cmd.Transaction = null;
                return false;
            }
        }

        public void EndTransaction()
        {
            tran.Commit();
            cmd.Transaction = null;
            CloseDB();
        }

        public void RollbackTransaction()
        {
            tran.Rollback();
            CloseDB();
        }

        public object ExecProcedure(string procName,OleDbParameter[] parameters)
        {
            switch (conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return null;
                default:
                    return null;
            }
            cmd.Parameters.Clear();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            try
            {
                cmd.ExecuteNonQuery();
                foreach(OleDbParameter para in parameters)
                {
                    if(para.Direction==ParameterDirection.InputOutput|| para.Direction==ParameterDirection.Output)
                    {
                        return para.Value;
                    }
                }
                return null;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                return null;
            }
        }

        public OleDbDataReader ExecProcedureReader(string procName, OleDbParameter[] parameters)
        {
            switch (conn.State)
            {
                case ConnectionState.Open:
                    cmd.Connection = conn;
                    break;
                case ConnectionState.Closed:
                    if (InitDB() == DBCode.ConnSucceed)
                    {
                        cmd.Connection = conn;
                        break;
                    }
                    else
                        return null;
                default:
                    return null;
            }
            cmd.Parameters.Clear();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            try
            {
                return cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                return null;
            }
        }

        public string GenSQL(SQLMethod method, string tablename, Hashtable data, string filter = null)
        {
            string cmdText="";
            string columns = "";
            string values="";
            switch(method)
            {
                case SQLMethod.SELECT:
                    if (filter != null)
                    {
                        cmdText = "SELECT $columns$ FROM $tablename$ WHERE $filter$";
                        cmdText = cmdText.Replace("$filter$", filter);
                    }
                    else
                    {
                        cmdText = "SELECT $columns$ FROM $tablename$";
                    }
                    foreach (DictionaryEntry de in data)
                    {
                        columns += (de.Key + ",");
                    }
                    cmdText = cmdText.Replace("$tablename$", tablename);
                    cmdText = cmdText.Replace("$columns$", columns.TrimEnd(','));
                    break;
                case SQLMethod.INSERT:
                    if (filter != null)
                    {
                        cmdText = "INSERT INTO $tablename$ ($columns$) VALUES($values$) WHERE $filter$";
                        cmdText = cmdText.Replace("$filter$", filter);
                    }
                    else
                    {
                        cmdText = "INSERT INTO $tablename$ ($columns$) VALUES($values$)";
                    }
                    foreach (DictionaryEntry de in data)
                    {
                        columns += (de.Key + ",");
                        if (de.Value is string)
                        {
                            values += ("'" + de.Value + "'" + ",");
                        }
                        else
                        {
                            values += (de.Value + ",");
                        }
                    }
                    cmdText = cmdText.Replace("$tablename$", tablename);
                    cmdText = cmdText.Replace("$columns$", columns.TrimEnd(','));
                    cmdText = cmdText.Replace("$values$", values.TrimEnd(','));
                    break;
                case SQLMethod.UPDATE:
                    if (filter != null)
                    {
                        cmdText = "UPDATE $tablename$ SET $values$ WHERE $filter$";
                        cmdText = cmdText.Replace("$filter$", filter);
                    }
                    else
                    {
                        cmdText = "UPDATE $tablename$ SET $values$";
                    }
                    foreach (DictionaryEntry de in data)
                    {
                        if (de.Value is string)

                        {
                            values += (de.Key + "='" + de.Value + "',");
                        }
                        else
                        {
                            values += (de.Key + "=" + de.Value + ",");
                        }
                    }
                    cmdText = cmdText.Replace("$tablename$", tablename).Replace("$values$", values.TrimEnd(','));
                    break;
                case SQLMethod.DELETE:
                    if (filter != null)
                    {
                        cmdText = "DELETE FROM $tablename$ WHERE $filter$";
                        cmdText = cmdText.Replace("$filter$", filter);
                    }
                    else
                    {
                        cmdText = "DELETE FROM $tablename$";
                    }
                    break;
                default:
                    cmdText = "";
                    break;
            }
            return cmdText;
        }
    }
}
