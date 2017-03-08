using SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //03.SalesDatabase
            var context = new SalesContext();
            context.Database.Initialize(true);



           
        
        }
    }
}
