// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Amazon Marketplace Web Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AmazonMWS")]
    [Rest.Serialization.JsonTransformation]
    public partial class AmazonMWSLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AmazonMWSLinkedService class.
        /// </summary>
        public AmazonMWSLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AmazonMWSLinkedService class.
        /// </summary>
        /// <param name="endpoint">The endpoint of the Amazon MWS server, (i.e.
        /// mws.amazonservices.com)</param>
        /// <param name="marketplaceID">The Amazon Marketplace ID you want to
        /// retrieve data from. To retrive data from multiple Marketplace IDs,
        /// seperate them with a comma (,). (i.e. A2EUQ1WTGCTBG2)</param>
        /// <param name="sellerID">The Amazon seller ID.</param>
        /// <param name="accessKeyId">The access key id used to access
        /// data.</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="mwsAuthToken">The Amazon MWS authentication
        /// token.</param>
        /// <param name="secretKey">The secret key used to access data.</param>
        /// <param name="useEncryptedEndpoints">Specifies whether the data
        /// source endpoints are encrypted using HTTPS. The default value is
        /// true.</param>
        /// <param name="useHostVerification">Specifies whether to require the
        /// host name in the server's certificate to match the host name of the
        /// server when connecting over SSL. The default value is true.</param>
        /// <param name="usePeerVerification">Specifies whether to verify the
        /// identity of the server when connecting over SSL. The default value
        /// is true.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AmazonMWSLinkedService(object endpoint, object marketplaceID, object sellerID, object accessKeyId, IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), SecretBase mwsAuthToken = default(SecretBase), SecretBase secretKey = default(SecretBase), object useEncryptedEndpoints = default(object), object useHostVerification = default(object), object usePeerVerification = default(object), object encryptedCredential = default(object))
            : base(connectVia, description)
        {
            Endpoint = endpoint;
            MarketplaceID = marketplaceID;
            SellerID = sellerID;
            MwsAuthToken = mwsAuthToken;
            AccessKeyId = accessKeyId;
            SecretKey = secretKey;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint of the Amazon MWS server, (i.e.
        /// mws.amazonservices.com)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.endpoint")]
        public object Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the Amazon Marketplace ID you want to retrieve data
        /// from. To retrive data from multiple Marketplace IDs, seperate them
        /// with a comma (,). (i.e. A2EUQ1WTGCTBG2)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.marketplaceID")]
        public object MarketplaceID { get; set; }

        /// <summary>
        /// Gets or sets the Amazon seller ID.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sellerID")]
        public object SellerID { get; set; }

        /// <summary>
        /// Gets or sets the Amazon MWS authentication token.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mwsAuthToken")]
        public SecretBase MwsAuthToken { get; set; }

        /// <summary>
        /// Gets or sets the access key id used to access data.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessKeyId")]
        public object AccessKeyId { get; set; }

        /// <summary>
        /// Gets or sets the secret key used to access data.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.secretKey")]
        public SecretBase SecretKey { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are
        /// encrypted using HTTPS. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useEncryptedEndpoints")]
        public object UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require the host name in the
        /// server's certificate to match the host name of the server when
        /// connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useHostVerification")]
        public object UseHostVerification { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to verify the identity of the server
        /// when connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.usePeerVerification")]
        public object UsePeerVerification { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
            if (MarketplaceID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MarketplaceID");
            }
            if (SellerID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SellerID");
            }
            if (AccessKeyId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessKeyId");
            }
        }
    }
}
