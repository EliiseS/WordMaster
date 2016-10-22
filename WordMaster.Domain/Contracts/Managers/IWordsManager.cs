using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMaster.Domain.Contracts.Managers
{
    public interface IWordsManager
    {
        void Process(string[] args);
    }
}
