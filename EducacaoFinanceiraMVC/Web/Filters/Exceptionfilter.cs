using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web.Filters
{
	public class Exceptionfilter : ExceptionFilterAttribute
    {
		public override void OnException(ExceptionContext exceptionContext)
		{
            Console.WriteLine("Ocorreu um erro na nossa aplicação as: " + DateTime.Now.ToLongDateString());
            Console.WriteLine(exceptionContext.Exception.Message);
		}
	}
}

