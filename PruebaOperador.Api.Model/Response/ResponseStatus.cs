using PruebaOperador.Api.Model.DTO.ResponseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperador.Api.Model.Response
{
    public class ResponseStatus
    {
        public static ResponseServices<T> ResponseSucessful<T>(T data)
        {
            return new ResponseServices<T>() { StatusCode = System.Net.HttpStatusCode.OK, Data = data };
        }

        public static ResponseServices<T> ResponseWithoutData<T>(string message)
        {
            return new ResponseServices<T>() { StatusCode = System.Net.HttpStatusCode.NotFound, Message = message };
        }

        public static ResponseServices<T> ResponseError<T>(string message)
        {
            return new ResponseServices<T>() { StatusCode = System.Net.HttpStatusCode.BadRequest, Message = message };
        }

        public static ResponseServices<T> ResponseErrors<T>(IEnumerable<string> errors)
        {
            return new ResponseServices<T>() { StatusCode = System.Net.HttpStatusCode.BadRequest, Errors = errors };
        }
    }
}
