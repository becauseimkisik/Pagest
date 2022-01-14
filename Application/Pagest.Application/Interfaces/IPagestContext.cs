using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pagest.Application.Interfaces
{
    public interface IPagestContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
