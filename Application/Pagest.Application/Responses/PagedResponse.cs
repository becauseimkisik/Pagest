using System;
using System.Collections.Generic;
using System.Text;

namespace Pagest.Application.Responses
{
    public class PagedResponse<T> : Response<T>
    {
        public int TotalRecords { get; set; }

        public PagedResponse(T data, int totalRecords)
        {
            this.TotalRecords = totalRecords;
            this.Data = data;
            this.Message = null;
            this.Error = null;
            this.Succeeded = true;
        }
    }

}
