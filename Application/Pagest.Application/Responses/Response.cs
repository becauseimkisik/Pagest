﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pagest.Application.Responses
{
    public class Response<T>
    {
        public Response()
        {

        }

        public Response(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }

        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Error { get; set; }
        public T Data { get; set; }

    }
}
