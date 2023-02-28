using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web.Filters
{
    public class ResultData
    {
        public DateTime CurrentDateTime { get; set; }
        public object? Value { get; set; }
        public ResultData(object _Value)
        {
            CurrentDateTime = DateTime.Now;
            Value = _Value;
        }
    }
    public class ResultFilter : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext resultExecutingContext)
        {
            var data = resultExecutingContext.Result as ObjectResult;
            if (data == null) return;
            if (data.Value == null) return;
            data.Value = new ResultData(data.Value);
        }
    }
}

