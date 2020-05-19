using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        class Teacher
        {
            public String name;
            public String subject;

        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "남하빈", subject = "뉴미디어콘텐츠제작" });
            list.Add(new Teacher() { name = "남치코", subject = "귀여움" });
            list.Add(new Teacher() { name = "함기훈", subject = "정보컴퓨터" });
            list.Add(new Teacher() { name = "이규응", subject = "컴퓨터구조" });
            list.Add(new Teacher() { name = "우호식", subject = "수학" });
            list.Add(new Teacher() { name = "이은주", subject = "영어" });

            foreach(var item in list)
            {
                Console.Write(item.name+":"+item.subject);
            }

        }
    }
}
