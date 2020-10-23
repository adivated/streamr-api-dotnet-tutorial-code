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
    /// CreateDataUnionSecret
    /// </summary>
    [DataContract]
    public partial class CreateDataUnionSecret :  IEquatable<CreateDataUnionSecret>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataUnionSecret" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDataUnionSecret() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataUnionSecret" /> class.
        /// </summary>
        /// <param name="name">Name of the data union secret (required).</param>
        /// <param name="secret">Data union join requests containing this secret will be automatically accepted. (required).</param>
        public CreateDataUnionSecret(string name = default(string), string secret = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateDataUnionSecret and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new InvalidDataException("secret is a required property for CreateDataUnionSecret and cannot be null");
            }
            else
            {
                this.Secret = secret;
            }
        }
        
        /// <summary>
        /// Name of the data union secret
        /// </summary>
        /// <value>Name of the data union secret</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Data union join requests containing this secret will be automatically accepted.
        /// </summary>
        /// <value>Data union join requests containing this secret will be automatically accepted.</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDataUnionSecret {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
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
            return this.Equals(input as CreateDataUnionSecret);
        }

        /// <summary>
        /// Returns true if CreateDataUnionSecret instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDataUnionSecret to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDataUnionSecret input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
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
