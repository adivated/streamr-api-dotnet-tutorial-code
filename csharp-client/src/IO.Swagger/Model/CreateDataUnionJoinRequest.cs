/* 
 * Streamr API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// CreateDataUnionJoinRequest
    /// </summary>
    [DataContract]
    public partial class CreateDataUnionJoinRequest :  IEquatable<CreateDataUnionJoinRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataUnionJoinRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDataUnionJoinRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataUnionJoinRequest" /> class.
        /// </summary>
        /// <param name="memberAddress">Ethereum address of the member to join (required).</param>
        /// <param name="secret">A secret shared by the data union. The join request is automatically accepted if a valid secret is provided..</param>
        /// <param name="metadata">Application specific key-value pairs..</param>
        public CreateDataUnionJoinRequest(string memberAddress = default(string), string secret = default(string), Object metadata = default(Object))
        {
            // to ensure "memberAddress" is required (not null)
            if (memberAddress == null)
            {
                throw new InvalidDataException("memberAddress is a required property for CreateDataUnionJoinRequest and cannot be null");
            }
            else
            {
                this.MemberAddress = memberAddress;
            }
            this.Secret = secret;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Ethereum address of the member to join
        /// </summary>
        /// <value>Ethereum address of the member to join</value>
        [DataMember(Name="memberAddress", EmitDefaultValue=false)]
        public string MemberAddress { get; set; }

        /// <summary>
        /// A secret shared by the data union. The join request is automatically accepted if a valid secret is provided.
        /// </summary>
        /// <value>A secret shared by the data union. The join request is automatically accepted if a valid secret is provided.</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Application specific key-value pairs.
        /// </summary>
        /// <value>Application specific key-value pairs.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDataUnionJoinRequest {\n");
            sb.Append("  MemberAddress: ").Append(MemberAddress).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDataUnionJoinRequest);
        }

        /// <summary>
        /// Returns true if CreateDataUnionJoinRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDataUnionJoinRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDataUnionJoinRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MemberAddress == input.MemberAddress ||
                    (this.MemberAddress != null &&
                    this.MemberAddress.Equals(input.MemberAddress))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MemberAddress != null)
                    hashCode = hashCode * 59 + this.MemberAddress.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
