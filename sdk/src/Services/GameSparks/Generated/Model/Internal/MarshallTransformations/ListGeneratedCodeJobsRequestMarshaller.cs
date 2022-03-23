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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameSparks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameSparks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListGeneratedCodeJobs Request Marshaller
    /// </summary>       
    public class ListGeneratedCodeJobsRequestMarshaller : IMarshaller<IRequest, ListGeneratedCodeJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListGeneratedCodeJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListGeneratedCodeJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameSparks");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-17";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetGameName())
                throw new AmazonGameSparksException("Request object does not have required field GameName set");
            request.AddPathResource("{GameName}", StringUtils.FromString(publicRequest.GameName));
            if (!publicRequest.IsSetSnapshotId())
                throw new AmazonGameSparksException("Request object does not have required field SnapshotId set");
            request.AddPathResource("{SnapshotId}", StringUtils.FromString(publicRequest.SnapshotId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/game/{GameName}/snapshot/{SnapshotId}/generated-sdk-code-jobs";
            request.UseQueryString = true;

            return request;
        }
        private static ListGeneratedCodeJobsRequestMarshaller _instance = new ListGeneratedCodeJobsRequestMarshaller();        

        internal static ListGeneratedCodeJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListGeneratedCodeJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}