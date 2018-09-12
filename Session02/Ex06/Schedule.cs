using System;
using System.Collections;

namespace  Ex06
{
    class Schedule
    {
        Hashtable ht;

        public Schedule()
        {
            this.ht = new Hashtable();
        }

        public string this[DateTime date]
        {
            get { return (string) ht[date]; }
            set { ht[date] = value; }
        }

        public string this[string date]
        {
            get { return (string) ht[DateTime.Parse(date)]; }
            set { ht[DateTime.Parse(date)] = value; }
        }

        public ICollection Keys
        {
            get {return ht.Keys; }
        }

        public ICollection Values
        {
            get { return ht.Values; }
        }
    }
}