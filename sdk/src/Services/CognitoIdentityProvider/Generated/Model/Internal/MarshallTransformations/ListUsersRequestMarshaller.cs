/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListUsers Request Marshaller
    /// </summary>       
    public class ListUsersRequestMarshaller : IMarshaller<IRequest, ListUsersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListUsersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListUsersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.ListUsers";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributesToGet())
                {
                    context.Writer.WritePropertyName("AttributesToGet");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttributesToGetListValue in publicRequest.AttributesToGet)
                    {
                            context.Writer.Write(publicRequestAttributesToGetListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLimit())
                {
                    context.Writer.WritePropertyName("Limit");
                    context.Writer.Write(publicRequest.Limit);
                }

                if(publicRequest.IsSetPaginationToken())
                {
                    context.Writer.WritePropertyName("PaginationToken");
                    context.Writer.Write(publicRequest.PaginationToken);
                }

                if(publicRequest.IsSetUserPoolId())
                {
                    context.Writer.WritePropertyName("UserPoolId");
                    context.Writer.Write(publicRequest.UserPoolId);
                }

                if(publicRequest.IsSetUserStatus())
                {
                    context.Writer.WritePropertyName("UserStatus");
                    context.Writer.Write(publicRequest.UserStatus);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}