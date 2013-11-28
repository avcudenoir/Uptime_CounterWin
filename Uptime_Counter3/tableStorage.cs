using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uptime_Counter3
{
    public class tableStorage
    {
        private Stack<String> beginDateTime;
        private Stack<String> endDateTime;
        private Stack<String> elapsedTime;
        private Stack<String> offlineTime;
        private Stack<String> realTime;

        public Stack<String> getBeginDateTime() { return beginDateTime; }
        public Stack<String> getEndDateTime() { return endDateTime; }
        public Stack<String> getElapsedTime() { return elapsedTime; }
        public Stack<String> getofflineTime() { return offlineTime; }
        public Stack<String> getRealTime() { return realTime; }

        public tableStorage()
        {
            beginDateTime = new Stack<String>();
            endDateTime = new Stack<String>();
            elapsedTime = new Stack<String>();
            offlineTime = new Stack<String>();
            realTime = new Stack<String>();
        }

        public void Clear()
        {
            beginDateTime.Clear();
            endDateTime.Clear();
            elapsedTime.Clear();
            offlineTime.Clear();
            realTime.Clear();
        }
        public void insert(string s1, string s2, string s3, string s4, string s5)
        {
            beginDateTime.Push(s1); endDateTime.Push(s2); elapsedTime.Push(Counter.convertFrom(Convert.ToUInt32(s3)));
            offlineTime.Push(Counter.convertFrom(Convert.ToUInt32(s4)));
            realTime.Push(Counter.convertFrom(Convert.ToUInt32(s5)));
        }
    }
}
