﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EventStore
{
    /// <summary>
    /// Represents a single element in a stream of events.
    /// </summary>
    [DataContract, Serializable]
    public class EventMessage
    {
        /// <summary>
        /// Gets the metadata which provides additional, unstructured information about this message.
        /// </summary>
        [DataMember]
        public Dictionary<string, object> Headers { get; private set; }

        /// <summary>
        /// Gets or sets the actual event message body.
        /// </summary>
        [DataMember]
        public object Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the EventMessage class.
        /// </summary>
        public EventMessage()
        {
            Headers = new Dictionary<string, object>();
        }

        public EventMessage(object body)
            : this()
        {
            Body = body;
        }
    }
}