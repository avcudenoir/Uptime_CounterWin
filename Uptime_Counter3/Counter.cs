using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uptime_Counter3
{
    public class Counter
    {
        private UInt32 days, hours, minutes, seconds;
        private bool dueSave = false;
        private bool dueOfflineCheck = false;
        private string offlineCheckString;
        public int offlineTotalTime=0;

        public Counter() { seconds = 0; minutes = 0; hours = 0; days = 0; }
        public bool checkSaveNeed() { return dueSave; }
        public void flipSaveNeed() { dueSave = !dueSave; }
        public bool checkOfflineCheckNeed() { return dueOfflineCheck; }
        public void flipOfflineCheckNeed() { dueOfflineCheck = !dueOfflineCheck; }
        public void setOfflineCheckString(string s) { offlineCheckString = s; }
        public string getOfflineCheckString(string s) { return offlineCheckString; }

        public bool checkOfflineState(DatabaseWrapper dbWrap)
        {
            int tmp = dbWrap.subtractTime(offlineCheckString);
            if (tmp > 62)
            { offlineTotalTime = offlineTotalTime + tmp; offlineCheckString = dbWrap.getCurrentDateTime(); return true; }
            else { offlineCheckString = dbWrap.getCurrentDateTime(); return false; }
        }

        public string getTimeString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(days).Append(" d  ");
            if (hours < 10) { sb.Append("0" + hours + " : "); } else { sb.Append(hours + " : "); }
            if (minutes < 10) { sb.Append("0" + minutes + " : "); } else { sb.Append(minutes + " : "); }
            if (seconds < 10) { sb.Append("0" + seconds); } else { sb.Append(seconds); }
            return sb.ToString();
        }


        private static string getTimeStringNonDefault(UInt32 days, UInt32 hours, UInt32 minutes, UInt32 seconds)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(days).Append(" d  ");
            if (hours < 10) { sb.Append("0" + hours + " : "); } else { sb.Append(hours + " : "); }
            if (minutes < 10) { sb.Append("0" + minutes + " : "); } else { sb.Append(minutes + " : "); }
            if (seconds < 10) { sb.Append("0" + seconds); } else { sb.Append(seconds); }
            return sb.ToString();
        }

        public static string convertFrom(UInt32 secSum)
        {
            UInt32 m = secSum / 60;
            UInt32 temps = secSum - m * 60;
            UInt32 h = m / 60;
            UInt32 tempm = m - h * 60;
            UInt32 d = h / 24;
            UInt32 temph = h - (d * 24);
            return getTimeStringNonDefault(d, temph, tempm, temps);
        }

        public UInt32 convertTo() { return (days * 24 * 60 * 60 + hours * 60 * 60 + minutes * 60 + seconds); }

        public void countUP()
        {
            if (seconds == 59)
            {
                seconds = 0;
                if (minutes == 59)
                {
                    minutes = 0; dueOfflineCheck = true;
                    if (hours == 23) { hours = 0; days = days + 1; dueSave = true; }
                    else { hours = hours + 1; dueSave = true; }
                }
                else { minutes = minutes + 1; dueOfflineCheck = true; }
            }
            else
            {
                seconds = seconds + 1;
            }
        }

    }
}
