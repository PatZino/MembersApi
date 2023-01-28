using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembersApi.Contracts
{
    public interface IRepositoryWrapper
    {
        IMemberRepository Member { get; }
        void Save();
    }
}
