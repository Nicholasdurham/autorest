// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyByte.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Runtime.Serialization;
#if !PORTABLE && !DNXCORE50
    using System.Security.Permissions;
#endif

    /// <summary>
    /// Exception thrown for an invalid response with Error information.
    /// </summary>
#if !PORTABLE && !DNXCORE50
    [Serializable]
#endif
    public class ErrorException : HttpOperationException
    {
        /// <summary>
        /// Gets or sets the error object.
        /// </summary>
        public Error Error { get; set; }

        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        public ErrorException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorException(string message)
            : this(message, (Exception)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">The inner exception.</param>
        public ErrorException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="error">The response content as Error type.</param>
        public ErrorException(string message, Error error)
            : base(message, null)
        {
            Error = error;
        }

#if !PORTABLE && !DNXCORE50
        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected ErrorException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Serializes content of the exception.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            info.AddValue("Request", Request);
            info.AddValue("Response", Response);
            info.AddValue("Error", Error);
        }
#endif
    }
}
