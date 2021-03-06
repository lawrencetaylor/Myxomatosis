﻿using Myxomatosis.Logging;
using Myxomatosis.Serialization;
using System;

namespace Myxomatosis.Configuration
{
    public class DefaultConfiguration : IConnectionConfig
    {
        #region Constructors

        public DefaultConfiguration()
        {
            Serializer = DefaultSerializer.Instance;
            VirtualHost = "/";
            UserName = "test";
            Password = "test";
            HostName = Environment.MachineName;
            Logger = new RabbitMqConsoleLogger();
        }

        #endregion Constructors

        #region IConnectionConfig Members

        public string VirtualHost { get; internal set; }

        public string UserName { get; internal set; }

        public string Password { get; internal set; }

        public string HostName { get; internal set; }

        public ISerializer Serializer { get; internal set; }

        public IRabbitMqClientLogger Logger { get; internal set; }

        public ushort PrefetchCount { get; internal set; }

        #endregion IConnectionConfig Members
    }
}