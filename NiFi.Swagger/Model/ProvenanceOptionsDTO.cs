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
    /// ProvenanceOptionsDTO
    /// </summary>
    [DataContract]
    public partial class ProvenanceOptionsDTO :  IEquatable<ProvenanceOptionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceOptionsDTO" /> class.
        /// </summary>
        /// <param name="searchableFields">The available searchable field for the NiFi..</param>
        public ProvenanceOptionsDTO(List<ProvenanceSearchableFieldDTO> searchableFields = default(List<ProvenanceSearchableFieldDTO>))
        {
            this.SearchableFields = searchableFields;
        }
        
        /// <summary>
        /// The available searchable field for the NiFi.
        /// </summary>
        /// <value>The available searchable field for the NiFi.</value>
        [DataMember(Name="searchableFields", EmitDefaultValue=false)]
        public List<ProvenanceSearchableFieldDTO> SearchableFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvenanceOptionsDTO {\n");
            sb.Append("  SearchableFields: ").Append(this.SearchableFields).Append("\n");
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
            return this.Equals(input as ProvenanceOptionsDTO);
        }

        /// <summary>
        /// Returns true if ProvenanceOptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProvenanceOptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProvenanceOptionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchableFields == input.SearchableFields ||
                    this.SearchableFields != null &&
                    this.SearchableFields.SequenceEqual(input.SearchableFields)
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
                if (this.SearchableFields != null)
                    hashCode = hashCode * 59 + this.SearchableFields.GetHashCode();
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