using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Uptime_Counter3
{
    public class DatabaseWrapper
    {
        SQLiteConnection sqlConn;
        SQLiteCommand sqlCmd;
        SQLiteDataReader sqlRead;
        string initDateTime;
        private bool saveState = false;

        bool getSaveState() { return saveState; }

        void switchSaveState() { saveState = !saveState; }

        public string getInitDateTime() { return initDateTime;}

        private static string getFPath(string filename)
        {
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
        }

        public DatabaseWrapper(string filename)
        {
            bool _new = false;

            if (!File.Exists(getFPath(filename)))
            {
                SQLiteConnection.CreateFile(filename);
                _new = true;
            }
            sqlConn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
            sqlConn.Open();
            initDateTime = getCurrentDateTime();
            if (_new) { execSimpleCmd("create table historia (rozp datetime, zak datetime,roznica bigint, hiber bigint, real bigint);");
            execSimpleCmd("create trigger nowy after INSERT on historia BEGIN" +
           " UPDATE historia SET roznica = (select strftime('%s',(select new.zak)) - strftime('%s',(select new.rozp))) where rozp=new.rozp; END;");
            execSimpleCmd("create trigger update_roznicy after UPDATE OF zak on historia BEGIN" +
                " UPDATE historia SET roznica = (select strftime('%s',(select new.zak)) - strftime('%s',(select new.rozp))) where rozp=new.rozp;"
                + "END;");
            }
        }

        public UInt32 getTotalTime(UInt32 add)
        {
            UInt32 sum = 0;
            bindConnCmdRead("select roznica from historia", true);
            while (sqlRead.Read())
            {
               sum= sum + Convert.ToUInt32(sqlRead[0].ToString());
            }
            sum = sum + add;
            return sum;
        }

        public UInt32 getTotalOfflineTime()
        {
            UInt32 sum = 0;
            bindConnCmdRead("select hiber from historia", true);
            while (sqlRead.Read())
            {
                sum = sum + Convert.ToUInt32(sqlRead[0].ToString());
            }
            return sum;
        }

        public bool execSimpleCmd(string cmd)
        {
            sqlCmd = new SQLiteCommand(cmd, sqlConn);
            try
            {
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception) { return false; }
        }

        public void saveTimer()
        {
            string cmd;
            if (!saveState) { cmd = "insert into historia(rozp,zak,hiber,real) values('" + initDateTime + "','" + getCurrentDateTime() + "',0,0);"; switchSaveState(); }
            else { cmd = "update historia set zak='"+getCurrentDateTime()+"' where rozp='"+initDateTime+"';"
                + "UPDATE historia SET real = (roznica - hiber) where rozp='" + initDateTime + "';";
            }
            bindConnCmdRead(cmd, false);
        }

        public int countRunx()
        {
            try
            {
                bindConnCmdRead("select count(*) from historia;", true);
                sqlRead.Read();
                return Convert.ToInt32(sqlRead[0].ToString());
            }
            catch (Exception) { return 0; }
        }

        private void bindConnCmdRead(string sqlcmdstring, bool execute)
        {
            sqlCmd = new SQLiteCommand(sqlcmdstring, sqlConn);
            if (execute) { sqlRead = sqlCmd.ExecuteReader(); }
            else { sqlCmd.ExecuteNonQuery(); }
        }

        public void populateTableStorage(tableStorage tS)
        {
            string sql = "select * from historia;";
            bindConnCmdRead(sql, true);
            while(sqlRead.Read())
            {
                tS.insert(sqlRead[0].ToString(),sqlRead[1].ToString(),sqlRead[2].ToString(),sqlRead[3].ToString(), sqlRead[4].ToString());
            }
        }

        public UInt32 getLongest()
        {
            try
            {
                bindConnCmdRead("select max(real) from historia;", true);
                sqlRead.Read();
                return Convert.ToUInt32(sqlRead[0].ToString());
            }
            catch (Exception) { return 0; }
        }

        public string getCurrentDateTime()
        {
            bindConnCmdRead("select datetime('now', 'localtime');", true);
            sqlRead.Read();
            return sqlRead[0].ToString();
        }

        public int subtractTime(string savedString)
        {
            bindConnCmdRead("select strftime('%s','now') - strftime('%s','" + savedString +"');", true);
            sqlRead.Read();
            return Convert.ToInt32(sqlRead[0].ToString());
        }
    }
}
