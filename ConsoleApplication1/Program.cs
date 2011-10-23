using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP.Entities;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SOSPostoDataContext())
            {
                var _tanque = new tanque();
                _tanque.capacidade = 1000;
                ctx.tanque.AddObject(_tanque);
                ctx.SaveChanges();
                Console.WriteLine("Saved {0}", _tanque.Tanque_ID);
            }
            using (var ctx = new SOSPostoDataContext())
            {
                var _tanque = ctx.tanque.First();
                Console.WriteLine("Found {0}", _tanque.Tanque_ID);
            }

            //Espera
            Console.ReadKey();
        }
    }
}
