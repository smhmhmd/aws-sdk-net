/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A leaf node condition which can be used to specify a tag condition, for example, <code>HAVE
    /// BPO = 123</code>.
    /// </summary>
    public partial class TagCondition
    {
        private string _tagKey;
        private string _tagValue;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The tag key in the tag condition.
        /// </para>
        /// </summary>
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The tag value in the tag condition.
        /// </para>
        /// </summary>
        public string TagValue
        {
            get { return this._tagValue; }
            set { this._tagValue = value; }
        }

        // Check to see if TagValue property is set
        internal bool IsSetTagValue()
        {
            return this._tagValue != null;
        }

    }
}