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
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// LineageResultsDTO
    /// </summary>
    [DataContract]
    public partial class LineageResultsDTO :  IEquatable<LineageResultsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineageResultsDTO" /> class.
        /// </summary>
        /// <param name="errors">Any errors that occurred while generating the lineage..</param>
        /// <param name="nodes">The nodes in the lineage..</param>
        /// <param name="links">The links between the nodes in the lineage..</param>
        public LineageResultsDTO(List<string> errors = default(List<string>), List<ProvenanceNodeDTO> nodes = default(List<ProvenanceNodeDTO>), List<ProvenanceLinkDTO> links = default(List<ProvenanceLinkDTO>))
        {
            this.Errors = errors;
            this.Nodes = nodes;
            this.Links = links;
        }
        
        /// <summary>
        /// Any errors that occurred while generating the lineage.
        /// </summary>
        /// <value>Any errors that occurred while generating the lineage.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// The nodes in the lineage.
        /// </summary>
        /// <value>The nodes in the lineage.</value>
        [DataMember(Name="nodes", EmitDefaultValue=false)]
        public List<ProvenanceNodeDTO> Nodes { get; set; }

        /// <summary>
        /// The links between the nodes in the lineage.
        /// </summary>
        /// <value>The links between the nodes in the lineage.</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<ProvenanceLinkDTO> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineageResultsDTO {\n");
            sb.Append("  Errors: ").Append(this.Errors).Append("\n");
            sb.Append("  Nodes: ").Append(this.Nodes).Append("\n");
            sb.Append("  Links: ").Append(this.Links).Append("\n");
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
            return this.Equals(input as LineageResultsDTO);
        }

        /// <summary>
        /// Returns true if LineageResultsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LineageResultsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineageResultsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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