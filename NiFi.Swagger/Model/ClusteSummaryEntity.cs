/* 
 * NiFi Rest Api
 *
 * The Rest Api provides programmatic access to command and control a NiFi instance in real time. Start and                                              stop processors, monitor queues, query provenance data, and more. Each endpoint below includes a description,                                             definitions of the expected input and output, potential response codes, and the authorizations required                                             to invoke each service.
 *
 * OpenAPI spec version: 1.9.1
 * Contact: dev@nifi.apache.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace NiFi.Swagger.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// ClusteSummaryEntity
    /// </summary>
    [DataContract]
    public partial class ClusteSummaryEntity :  IEquatable<ClusteSummaryEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteSummaryEntity" /> class.
        /// </summary>
        /// <param name="clusterSummary">clusterSummary.</param>
        public ClusteSummaryEntity(ClusterSummaryDTO clusterSummary = default(ClusterSummaryDTO))
        {
            this.ClusterSummary = clusterSummary;
        }
        
        /// <summary>
        /// Gets or Sets ClusterSummary
        /// </summary>
        [DataMember(Name="clusterSummary", EmitDefaultValue=false)]
        public ClusterSummaryDTO ClusterSummary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusteSummaryEntity {\n");
            sb.Append("  ClusterSummary: ").Append(this.ClusterSummary).Append("\n");
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
            return this.Equals(input as ClusteSummaryEntity);
        }

        /// <summary>
        /// Returns true if ClusteSummaryEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusteSummaryEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusteSummaryEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterSummary == input.ClusterSummary ||
                    (this.ClusterSummary != null &&
                    this.ClusterSummary.Equals(input.ClusterSummary))
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
                if (this.ClusterSummary != null)
                    hashCode = hashCode * 59 + this.ClusterSummary.GetHashCode();
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