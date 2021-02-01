using Newtonsoft.Json.Linq;
using System;

namespace Jobject
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var obj = new JObject { { "Name", "Lucy" } };
            //var company = new JObject { { "Cmp", "上海网络有限公司" }, { "Tel", "0112-1263589" } };
            //obj.Add("Company", company);
            //Console.WriteLine(obj);
            ////解读：创建一个json对象，有2个字段Name，Company其中Company是一个对象


            //var jarray = new JArray();
            //var lucy = new JObject { { "Name", "Lucy" }, { "Age", 18 } };
            //var tom = new JObject { { "Name", "Tom" }, { "Age", 20 } };
            //jarray.Add(lucy);
            //jarray.Add(tom);
            //Console.WriteLine(jarray);
            ////解读：创建了一个json数组，包括了2个对象：每个对象都有2个字段：Name，Age

            //var obj = new JObject();
            //var student = new JArray
            //{
            //new JObject {{ "Name", "Lucy" }, { "Age", 18 } },
            //new JObject {{ "Name", "Tom" }, { "Age", 20 } }
            // };
            //var study = new JArray
            //{
            //new JObject {{ "Subject", "语文"}, { "Score", 100}},
            //new JObject {{ "Subject", "数学" }, { "Score", 88}}
            // };
            //obj.Add("Student", student);
            //obj.Add("Study", study);

            //Console.WriteLine(obj);
            //////解读：json对象有2个数组：Student，Study。数组分别有两个对象


            var lucy = new JObject { { "Name", "Lucy" }, { "Age", 18 } };
            var study = new JArray
                 {
                        new JObject {{ "Subject", "语文"}, { "Score", 100}},
                        new JObject {{ "Subject", "数学" }, { "Score", 88}}
                  };
            lucy.Add("Study", study);
            Console.WriteLine(lucy);
        }

        // 解读：json对象的study字段是一个数组
    }

}
