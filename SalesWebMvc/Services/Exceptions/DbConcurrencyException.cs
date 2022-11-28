using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string messege) : base(messege)
        {
        }
    }
}
