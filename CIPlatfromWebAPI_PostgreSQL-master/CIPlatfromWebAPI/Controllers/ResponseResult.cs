﻿namespace Web_API.Controllers
{
    public class ResponseResult
    {
        public object Data { get; set; }
        public ResponseStatus Result { get; set; }
        public string Message { get; set; }
    }
    public enum ResponseStatus
    {
        Error,
        Success
    }
}