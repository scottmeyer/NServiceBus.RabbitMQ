﻿namespace EasyNetQ
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    class EasyNetQException : Exception
    {
        public EasyNetQException() {}
        public EasyNetQException(string message) : base(message) {}
        public EasyNetQException(string format, params string[] args) : base(string.Format(format, args)) {}
        public EasyNetQException(string message, Exception inner) : base(message, inner) {}

        protected EasyNetQException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {}
    }

    [Serializable]
    class EasyNetQInvalidMessageTypeException : EasyNetQException
    {
        public EasyNetQInvalidMessageTypeException() {}
        public EasyNetQInvalidMessageTypeException(string message) : base(message) {}
        public EasyNetQInvalidMessageTypeException(string format, params string[] args) : base(format, args) {}
        public EasyNetQInvalidMessageTypeException(string message, Exception inner) : base(message, inner) {}
        protected EasyNetQInvalidMessageTypeException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}