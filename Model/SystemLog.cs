using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Model
{
    [Serializable]
    public class SystemLog
    {
        public string LogID
        {
            get { return LogID; }
            set { LogID = value; }
        }

        public string Operator
        {
            get { return Operator; }
            set { Operator = value; }
        }

        public string DateTimes
        {
            get { return DateTimes; }
            set { DateTimes = value; }
        }

        public string Activity
        {
            get { return Activity; }
            set { Activity = value; }
        }

        public string Status
        {
            get { return Status; }
            set { Status = value; }
        }

        public string IPAdd
        {
            get { return IPAdd; }
            set { IPAdd = value; }
        }

        public string DetailInfo
        {
            get { return DetailInfo; }
            set { DetailInfo = value; }
        }



        public SystemLog(string Operator, string Activity, string Status, string IPAdd)
        {
            this.LogID = LogID;
            this.Operator = Operator;
            this.DateTimes = DateTime.Now.ToString();
            this.Activity = Activity;
            this.Status = Status;
            this.IPAdd = IPAdd;
            this.DetailInfo = "defalt";
        }
        public SystemLog()
        {

        }
    }
}
