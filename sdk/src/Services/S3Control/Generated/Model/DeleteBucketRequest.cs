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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBucket operation.
    /// <note> 
    /// <para>
    /// This action deletes an Amazon S3 on Outposts bucket. To delete an S3 bucket, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
    /// in the <i>Amazon S3 API Reference</i>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Deletes the Amazon S3 on Outposts bucket. All objects (including all object versions
    /// and delete markers) in the bucket must be deleted before the bucket itself can be
    /// deleted. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
    /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// All Amazon S3 on Outposts REST API requests for this action require an additional
    /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
    /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
    /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
    /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
    /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html#API_control_DeleteBucket_Examples">Examples</a>
    /// section.
    /// </para>
    ///  <p class="title"> <b>Related Resources</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html">GetBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteBucketRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _bucket;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the Outposts bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// Specifies the bucket being deleted.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with Amazon S3 on Outposts with the REST API, you must specify
        /// the name and the x-amz-outpost-id as well.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with S3 on Outposts with the AWS SDK and CLI, you must specify
        /// the ARN of the bucket accessed in the format <code>arn:aws:s3-outposts:&lt;Region&gt;:&lt;account-id&gt;:outpost/&lt;outpost-id&gt;/bucket/&lt;my-bucket-name&gt;</code>.
        /// For example, to access the bucket <code>reports</code> through outpost <code>my-outpost</code>
        /// owned by account <code>123456789012</code> in Region <code>us-west-2</code>, use the
        /// URL encoding of <code>arn:aws:s3-outposts:us-west-2:123456789012:outpost/my-outpost/bucket/reports</code>.
        /// The value must be URL encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

    }
}