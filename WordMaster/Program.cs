using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMaster.Domain.Contracts.Managers;

namespace WordMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            var ioc = new Container(new RuntimeRegistry());
            
            ioc.GetInstance<IWordsManager>().Process(args);

            ioc.GetInstance<IProgramFinisher>().Finish();
        }
    }
}
