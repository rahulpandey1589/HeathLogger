using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
