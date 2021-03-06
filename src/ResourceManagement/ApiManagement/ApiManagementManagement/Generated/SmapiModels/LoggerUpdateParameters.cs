// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Parameters supplied to the Update Logger operation.
    /// </summary>
    public partial class LoggerUpdateParameters
    {
        private IDictionary<string, string> _credentials;
        
        /// <summary>
        /// Optional. Gets or sets Logger credentials.
        /// </summary>
        public IDictionary<string, string> Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets Logger description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private bool? _isBuffered;
        
        /// <summary>
        /// Optional. Gets or sets whether records are buffered in the logger
        /// before publishing. Default is assumed to be true.
        /// </summary>
        public bool? IsBuffered
        {
            get { return this._isBuffered; }
            set { this._isBuffered = value; }
        }
        
        private LoggerTypeContract _type;
        
        /// <summary>
        /// Required. Gets or sets Logger type.
        /// </summary>
        public LoggerTypeContract Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LoggerUpdateParameters class.
        /// </summary>
        public LoggerUpdateParameters()
        {
            this.Credentials = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the LoggerUpdateParameters class with
        /// required arguments.
        /// </summary>
        public LoggerUpdateParameters(LoggerTypeContract type)
            : this()
        {
            this.Type = type;
        }
    }
}
