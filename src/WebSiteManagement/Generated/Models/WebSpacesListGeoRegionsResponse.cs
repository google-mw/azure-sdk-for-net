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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// The List Geo Regions operation response.
    /// </summary>
    public partial class WebSpacesListGeoRegionsResponse : OperationResponse, IEnumerable<WebSpacesListGeoRegionsResponse.GeoRegion>
    {
        private IList<WebSpacesListGeoRegionsResponse.GeoRegion> _geoRegions;
        
        /// <summary>
        /// Optional. The available geo regions.
        /// </summary>
        public IList<WebSpacesListGeoRegionsResponse.GeoRegion> GeoRegions
        {
            get { return this._geoRegions; }
            set { this._geoRegions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSpacesListGeoRegionsResponse
        /// class.
        /// </summary>
        public WebSpacesListGeoRegionsResponse()
        {
            this.GeoRegions = new List<WebSpacesListGeoRegionsResponse.GeoRegion>();
        }
        
        /// <summary>
        /// Gets the sequence of GeoRegions.
        /// </summary>
        public IEnumerator<WebSpacesListGeoRegionsResponse.GeoRegion> GetEnumerator()
        {
            return this.GeoRegions.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of GeoRegions.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// An available geo region for a web space.
        /// </summary>
        public partial class GeoRegion
        {
            private string _description;
            
            /// <summary>
            /// Optional. Description of the geo region.
            /// </summary>
            public string Description
            {
                get { return this._description; }
                set { this._description = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. Name of the geo region.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private int? _sortOrder;
            
            /// <summary>
            /// Optional. Sort order for the geo region.
            /// </summary>
            public int? SortOrder
            {
                get { return this._sortOrder; }
                set { this._sortOrder = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the GeoRegion class.
            /// </summary>
            public GeoRegion()
            {
            }
        }
    }
}
