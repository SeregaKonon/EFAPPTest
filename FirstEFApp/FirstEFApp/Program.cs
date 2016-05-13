using FirstEFApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SomeTableContext db = new SomeTableContext())
            {
                List<SomeTable> st = new List<SomeTable>();
                for (int i = 0; i < 10; i++)
                {
                    st.Add(new SomeTable { SomeName = "Name_" + i.ToString(), SomeDouble = i/0.123 });
                }
                st.ForEach(s => db.SomeTables.Add(s));
                db.SaveChanges();


                //what was loaded in table?
                var res = db.SomeTables;
                foreach (var r in res)
                {
                    Console.WriteLine("id={0} \t name={1} \t double={2}",r.ID, r.SomeName, r.SomeDouble);
                }
                Console.ReadKey();

            }
        }
    }
}
