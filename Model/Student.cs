using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Student
    {
        #region fields
        private object id = "加载失败或无记录";//学号
        private string pincodes = "加载失败或无记录";//身份证号
        private string name = "加载失败或无记录";//姓名
        private string sex = "加载失败或无记录";//性别
        private string political = "加载失败或无记录";//政治面貌

        private object grade = "加载失败或无记录";//年级
        private string college = "加载失败或无记录";//学院
        private string major = "加载失败或无记录";//专业
        private string classes = "加载失败或无记录";//班级
        private string direction = "加载失败或无记录";//方向

        private string address = "加载失败或无记录";//地址
        private string postcodes = "加载失败或无记录";//邮编
        private string imgurl = "9.jpg";//相片
        private string text = "加载失败或无记录";//备注
        private string idbiye = "加载失败或无记录";//毕业证书编号

        private string dayChusheng = "加载失败或无记录";//出生日期
        private string dayRuxue = "加载失败或无记录";//入学日期
        private string dayBiye = "";//毕业日期
        private bool main = false;//是否已初始化





        #endregion

        #region properties
        public bool Main
        {
            get { return main; }
            set { main = value; }
        }
        public string Biye
        {
            get { return dayBiye == "" ? "未毕业" : "已毕业"; }
            set { }
        }
        public string IDbiye
        {
            get { return idbiye; }
            set { idbiye = value; }
        }
        public string DayBiye
        {
            get { return dayBiye; }
            set { dayBiye = value; }
        }
        public string DayRuxue
        {
            get { return dayRuxue; }
            set { dayRuxue = value; }
        }
        public string DayChusheng
        {
            get { return dayChusheng; }
            set { dayChusheng = value; }

        }
        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public string Postcodes
        {
            get { return postcodes; }
            set { postcodes = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string Political
        {
            get { return political; }
            set { political = value; }
        }

        public object Id
        {
            get { return id; }
            set { id = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Classes
        {
            get { return classes; }
            set { classes = value; }

        }
        public string Major
        {
            get { return major; }
            set { major = value; }

        }
        public string College
        {
            get { return college; }
            set { college = value; }

        }
        public object Grade
        {
            get { return grade; }
            set { grade = value; }

        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }

        }
        public string Address
        {
            get { return address; }
            set { address = value; }

        }
        public string Pincodes
        {
            get { return pincodes; }
            set { pincodes = value; }

        }
        public string Imgurl
        {
            get { return imgurl; }
            set { imgurl = value; }

        }
        #endregion
        public Student(object id, string name, string classes, string major, string college, object grade, string sex, string address, string pincodes, string imgurl)
        {
            this.id = id;
            this.name = name;
            this.classes = classes;
            this.major = major;
            this.college = college;
            this.grade = grade;
            this.sex = sex;
            this.address = address;
            this.pincodes = pincodes;
            this.imgurl = imgurl;


        }
        public Student()
        {

        }
    }
}
