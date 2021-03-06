/*
   Copyright 2011 Microsoft Corp.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.

*/

/*******************************************************************************
 *  AWS SDK for WP7
 */

using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// The ChangeMessageVisibility action extends the read lock timeout of the specified message
    /// from the specified queue to the specified value.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2009-02-01/", IsNullable = false)]
    public class ChangeMessageVisibilityRequest
    {
        private string queueUrlField;
        private string receiptHandleField;
        private Decimal? visibilityTimeoutField;
        private List<Attribute> attributeField;

        /// <summary>
        /// Gets and sets the QueueUrl property.
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the QueueUrl property
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        public ChangeMessageVisibilityRequest WithQueueUrl(string queueUrl)
        {
            this.queueUrlField = queueUrl;
            return this;
        }

        /// <summary>
        /// Checks if QueueUrl property is set
        /// </summary>
        /// <returns>true if QueueUrl property is set</returns>
        public bool IsSetQueueUrl()
        {
            return this.queueUrlField != null;
        }

        /// <summary>
        /// Gets and sets the ReceiptHandle property.
        /// The receipt handle associated with the message whose visibility timeout you want to change.
        /// This parameter is returned by the ReceiveMessage action.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReceiptHandle")]
        public string ReceiptHandle
        {
            get { return this.receiptHandleField; }
            set { this.receiptHandleField = value; }
        }

        /// <summary>
        /// Sets the ReceiptHandle property
        /// </summary>
        /// <param name="receiptHandle">The receipt handle associated with the message whose visibility timeout you want to change.
        /// This parameter is returned by the ReceiveMessage action.</param>
        /// <returns>this instance</returns>
        public ChangeMessageVisibilityRequest WithReceiptHandle(string receiptHandle)
        {
            this.receiptHandleField = receiptHandle;
            return this;
        }

        /// <summary>
        /// Checks if ReceiptHandle property is set
        /// </summary>
        /// <returns>true if ReceiptHandle property is set</returns>
        public bool IsSetReceiptHandle()
        {
            return this.receiptHandleField != null;
        }

        /// <summary>
        /// Gets and sets the VisibilityTimeout property.
        /// The new value for the message's visibility timeout (in seconds).
        /// </summary>
        [XmlElementAttribute(ElementName = "VisibilityTimeout")]
        public Decimal VisibilityTimeout
        {
            get { return this.visibilityTimeoutField.GetValueOrDefault(); }
            set { this.visibilityTimeoutField = value; }
        }

        /// <summary>
        /// Sets the VisibilityTimeout property
        /// </summary>
        /// <param name="visibilityTimeout">The new value for the message's visibility timeout (in seconds).</param>
        /// <returns>this instance</returns>
        public ChangeMessageVisibilityRequest WithVisibilityTimeout(Decimal visibilityTimeout)
        {
            this.visibilityTimeoutField = visibilityTimeout;
            return this;
        }

        /// <summary>
        /// Checks if VisibilityTimeout property is set
        /// </summary>
        /// <returns>true if VisibilityTimeout property is set</returns>
        public bool IsSetVisibilityTimeout()
        {
            return this.visibilityTimeoutField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Attribute property.
        /// Name and value pair of an attribute associated with the queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public List<Attribute> Attribute
        {
            get
            {
                if (this.attributeField == null)
                {
                    this.attributeField = new List<Attribute>();
                }
                return this.attributeField;
            }
        }

        /// <summary>
        /// Sets the Attribute property
        /// </summary>
        /// <param name="list">Name and value pair of an attribute associated with the queue.</param>
        /// <returns>this instance</returns>
        public ChangeMessageVisibilityRequest WithAttribute(params Attribute[] list)
        {
            foreach (Attribute item in list)
            {
                Attribute.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Attribute property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return (Attribute.Count > 0);
        }

    }
}
