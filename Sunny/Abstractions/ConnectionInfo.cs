﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sunny
{
    /// <summary>
    /// 请求底层连接的信息。
    /// </summary>
    public abstract class ConnectionInfo
    {
        /// <summary>
        /// Gets or sets a unique identifier to represent this connection.
        /// </summary>
        public abstract string Id { get; set; }

        public abstract IPAddress RemoteIpAddress { get; set; }

        public abstract int RemotePort { get; set; }

        public abstract IPAddress LocalIpAddress { get; set; }

        public abstract int LocalPort { get; set; }

        public abstract X509Certificate2 ClientCertificate { get; set; }

        public abstract Task<X509Certificate2> GetClientCertificateAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
