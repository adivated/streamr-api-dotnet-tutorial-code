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
    /// ChallengeResponseChallenge
    /// </summary>
    [DataContract]
    public partial class ChallengeResponseChallenge :  IEquatable<ChallengeResponseChallenge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeResponseChallenge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChallengeResponseChallenge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeResponseChallenge" /> class.
        /// </summary>
        /// <param name="id">The challenge&#39;s ID (required).</param>
        /// <param name="challenge">Text that must have been signed by the private key (required).</param>
        public ChallengeResponseChallenge(string id = default(string), string challenge = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ChallengeResponseChallenge and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "challenge" is required (not null)
            if (challenge == null)
            {
                throw new InvalidDataException("challenge is a required property for ChallengeResponseChallenge and cannot be null");
            }
            else
            {
                this.Challenge = challenge;
            }
        }
        
        /// <summary>
        /// The challenge&#39;s ID
        /// </summary>
        /// <value>The challenge&#39;s ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Text that must have been signed by the private key
        /// </summary>
        /// <value>Text that must have been signed by the private key</value>
        [DataMember(Name="challenge", EmitDefaultValue=false)]
        public string Challenge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChallengeResponseChallenge {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Challenge: ").Append(Challenge).Append("\n");
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
            return this.Equals(input as ChallengeResponseChallenge);
        }

        /// <summary>
        /// Returns true if ChallengeResponseChallenge instances are equal
        /// </summary>
        /// <param name="input">Instance of ChallengeResponseChallenge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChallengeResponseChallenge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Challenge == input.Challenge ||
                    (this.Challenge != null &&
                    this.Challenge.Equals(input.Challenge))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Challenge != null)
                    hashCode = hashCode * 59 + this.Challenge.GetHashCode();
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
