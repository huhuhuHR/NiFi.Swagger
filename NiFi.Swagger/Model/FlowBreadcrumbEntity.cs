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
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// FlowBreadcrumbEntity
    /// </summary>
    [DataContract]
    public partial class FlowBreadcrumbEntity :  IEquatable<FlowBreadcrumbEntity>, IValidatableObject
    {
        /// <summary>
        /// The current state of the Process Group, as it relates to the Versioned Flow
        /// </summary>
        /// <value>The current state of the Process Group, as it relates to the Versioned Flow</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionedFlowStateEnum
        {
            
            /// <summary>
            /// Enum LOCALLYMODIFIED for value: LOCALLY_MODIFIED
            /// </summary>
            [EnumMember(Value = "LOCALLY_MODIFIED")]
            LOCALLYMODIFIED = 1,
            
            /// <summary>
            /// Enum STALE for value: STALE
            /// </summary>
            [EnumMember(Value = "STALE")]
            STALE = 2,
            
            /// <summary>
            /// Enum LOCALLYMODIFIEDANDSTALE for value: LOCALLY_MODIFIED_AND_STALE
            /// </summary>
            [EnumMember(Value = "LOCALLY_MODIFIED_AND_STALE")]
            LOCALLYMODIFIEDANDSTALE = 3,
            
            /// <summary>
            /// Enum UPTODATE for value: UP_TO_DATE
            /// </summary>
            [EnumMember(Value = "UP_TO_DATE")]
            UPTODATE = 4,
            
            /// <summary>
            /// Enum SYNCFAILURE for value: SYNC_FAILURE
            /// </summary>
            [EnumMember(Value = "SYNC_FAILURE")]
            SYNCFAILURE = 5
        }

        /// <summary>
        /// The current state of the Process Group, as it relates to the Versioned Flow
        /// </summary>
        /// <value>The current state of the Process Group, as it relates to the Versioned Flow</value>
        [DataMember(Name="versionedFlowState", EmitDefaultValue=false)]
        public VersionedFlowStateEnum? VersionedFlowState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowBreadcrumbEntity" /> class.
        /// </summary>
        /// <param name="id">The id of this ancestor ProcessGroup..</param>
        /// <param name="permissions">The permissions for this ancestor ProcessGroup..</param>
        /// <param name="breadcrumb">This breadcrumb..</param>
        /// <param name="parentBreadcrumb">The parent breadcrumb for this breadcrumb..</param>
        public FlowBreadcrumbEntity(string id = default(string), PermissionsDTO permissions = default(PermissionsDTO), FlowBreadcrumbDTO breadcrumb = default(FlowBreadcrumbDTO), FlowBreadcrumbEntity parentBreadcrumb = default(FlowBreadcrumbEntity))
        {
            this.Id = id;
            this.Permissions = permissions;
            this.Breadcrumb = breadcrumb;
            this.ParentBreadcrumb = parentBreadcrumb;
        }
        
        /// <summary>
        /// The id of this ancestor ProcessGroup.
        /// </summary>
        /// <value>The id of this ancestor ProcessGroup.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The permissions for this ancestor ProcessGroup.
        /// </summary>
        /// <value>The permissions for this ancestor ProcessGroup.</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public PermissionsDTO Permissions { get; set; }


        /// <summary>
        /// This breadcrumb.
        /// </summary>
        /// <value>This breadcrumb.</value>
        [DataMember(Name="breadcrumb", EmitDefaultValue=false)]
        public FlowBreadcrumbDTO Breadcrumb { get; set; }

        /// <summary>
        /// The parent breadcrumb for this breadcrumb.
        /// </summary>
        /// <value>The parent breadcrumb for this breadcrumb.</value>
        [DataMember(Name="parentBreadcrumb", EmitDefaultValue=false)]
        public FlowBreadcrumbEntity ParentBreadcrumb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowBreadcrumbEntity {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Permissions: ").Append(this.Permissions).Append("\n");
            sb.Append("  VersionedFlowState: ").Append(this.VersionedFlowState).Append("\n");
            sb.Append("  Breadcrumb: ").Append(this.Breadcrumb).Append("\n");
            sb.Append("  ParentBreadcrumb: ").Append(this.ParentBreadcrumb).Append("\n");
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
            return this.Equals(input as FlowBreadcrumbEntity);
        }

        /// <summary>
        /// Returns true if FlowBreadcrumbEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowBreadcrumbEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowBreadcrumbEntity input)
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
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.VersionedFlowState == input.VersionedFlowState ||
                    (this.VersionedFlowState != null &&
                    this.VersionedFlowState.Equals(input.VersionedFlowState))
                ) && 
                (
                    this.Breadcrumb == input.Breadcrumb ||
                    (this.Breadcrumb != null &&
                    this.Breadcrumb.Equals(input.Breadcrumb))
                ) && 
                (
                    this.ParentBreadcrumb == input.ParentBreadcrumb ||
                    (this.ParentBreadcrumb != null &&
                    this.ParentBreadcrumb.Equals(input.ParentBreadcrumb))
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
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.VersionedFlowState != null)
                    hashCode = hashCode * 59 + this.VersionedFlowState.GetHashCode();
                if (this.Breadcrumb != null)
                    hashCode = hashCode * 59 + this.Breadcrumb.GetHashCode();
                if (this.ParentBreadcrumb != null)
                    hashCode = hashCode * 59 + this.ParentBreadcrumb.GetHashCode();
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