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
    /// VersionInfoDTO
    /// </summary>
    [DataContract]
    public partial class VersionInfoDTO :  IEquatable<VersionInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfoDTO" /> class.
        /// </summary>
        /// <param name="niFiVersion">The version of this NiFi..</param>
        /// <param name="javaVendor">Java JVM vendor.</param>
        /// <param name="javaVersion">Java version.</param>
        /// <param name="osName">Host operating system name.</param>
        /// <param name="osVersion">Host operating system version.</param>
        /// <param name="osArchitecture">Host operating system architecture.</param>
        /// <param name="buildTag">Build tag.</param>
        /// <param name="buildRevision">Build revision or commit hash.</param>
        /// <param name="buildBranch">Build branch.</param>
        /// <param name="buildTimestamp">Build timestamp.</param>
        public VersionInfoDTO(string niFiVersion = default(string), string javaVendor = default(string), string javaVersion = default(string), string osName = default(string), string osVersion = default(string), string osArchitecture = default(string), string buildTag = default(string), string buildRevision = default(string), string buildBranch = default(string), DateTime? buildTimestamp = default(DateTime?))
        {
            this.NiFiVersion = niFiVersion;
            this.JavaVendor = javaVendor;
            this.JavaVersion = javaVersion;
            this.OsName = osName;
            this.OsVersion = osVersion;
            this.OsArchitecture = osArchitecture;
            this.BuildTag = buildTag;
            this.BuildRevision = buildRevision;
            this.BuildBranch = buildBranch;
            this.BuildTimestamp = buildTimestamp;
        }
        
        /// <summary>
        /// The version of this NiFi.
        /// </summary>
        /// <value>The version of this NiFi.</value>
        [DataMember(Name="niFiVersion", EmitDefaultValue=false)]
        public string NiFiVersion { get; set; }

        /// <summary>
        /// Java JVM vendor
        /// </summary>
        /// <value>Java JVM vendor</value>
        [DataMember(Name="javaVendor", EmitDefaultValue=false)]
        public string JavaVendor { get; set; }

        /// <summary>
        /// Java version
        /// </summary>
        /// <value>Java version</value>
        [DataMember(Name="javaVersion", EmitDefaultValue=false)]
        public string JavaVersion { get; set; }

        /// <summary>
        /// Host operating system name
        /// </summary>
        /// <value>Host operating system name</value>
        [DataMember(Name="osName", EmitDefaultValue=false)]
        public string OsName { get; set; }

        /// <summary>
        /// Host operating system version
        /// </summary>
        /// <value>Host operating system version</value>
        [DataMember(Name="osVersion", EmitDefaultValue=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Host operating system architecture
        /// </summary>
        /// <value>Host operating system architecture</value>
        [DataMember(Name="osArchitecture", EmitDefaultValue=false)]
        public string OsArchitecture { get; set; }

        /// <summary>
        /// Build tag
        /// </summary>
        /// <value>Build tag</value>
        [DataMember(Name="buildTag", EmitDefaultValue=false)]
        public string BuildTag { get; set; }

        /// <summary>
        /// Build revision or commit hash
        /// </summary>
        /// <value>Build revision or commit hash</value>
        [DataMember(Name="buildRevision", EmitDefaultValue=false)]
        public string BuildRevision { get; set; }

        /// <summary>
        /// Build branch
        /// </summary>
        /// <value>Build branch</value>
        [DataMember(Name="buildBranch", EmitDefaultValue=false)]
        public string BuildBranch { get; set; }

        /// <summary>
        /// Build timestamp
        /// </summary>
        /// <value>Build timestamp</value>
        [DataMember(Name="buildTimestamp", EmitDefaultValue=false)]
        public DateTime? BuildTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionInfoDTO {\n");
            sb.Append("  NiFiVersion: ").Append(this.NiFiVersion).Append("\n");
            sb.Append("  JavaVendor: ").Append(this.JavaVendor).Append("\n");
            sb.Append("  JavaVersion: ").Append(this.JavaVersion).Append("\n");
            sb.Append("  OsName: ").Append(this.OsName).Append("\n");
            sb.Append("  OsVersion: ").Append(this.OsVersion).Append("\n");
            sb.Append("  OsArchitecture: ").Append(this.OsArchitecture).Append("\n");
            sb.Append("  BuildTag: ").Append(this.BuildTag).Append("\n");
            sb.Append("  BuildRevision: ").Append(this.BuildRevision).Append("\n");
            sb.Append("  BuildBranch: ").Append(this.BuildBranch).Append("\n");
            sb.Append("  BuildTimestamp: ").Append(this.BuildTimestamp).Append("\n");
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
            return this.Equals(input as VersionInfoDTO);
        }

        /// <summary>
        /// Returns true if VersionInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NiFiVersion == input.NiFiVersion ||
                    (this.NiFiVersion != null &&
                    this.NiFiVersion.Equals(input.NiFiVersion))
                ) && 
                (
                    this.JavaVendor == input.JavaVendor ||
                    (this.JavaVendor != null &&
                    this.JavaVendor.Equals(input.JavaVendor))
                ) && 
                (
                    this.JavaVersion == input.JavaVersion ||
                    (this.JavaVersion != null &&
                    this.JavaVersion.Equals(input.JavaVersion))
                ) && 
                (
                    this.OsName == input.OsName ||
                    (this.OsName != null &&
                    this.OsName.Equals(input.OsName))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.OsArchitecture == input.OsArchitecture ||
                    (this.OsArchitecture != null &&
                    this.OsArchitecture.Equals(input.OsArchitecture))
                ) && 
                (
                    this.BuildTag == input.BuildTag ||
                    (this.BuildTag != null &&
                    this.BuildTag.Equals(input.BuildTag))
                ) && 
                (
                    this.BuildRevision == input.BuildRevision ||
                    (this.BuildRevision != null &&
                    this.BuildRevision.Equals(input.BuildRevision))
                ) && 
                (
                    this.BuildBranch == input.BuildBranch ||
                    (this.BuildBranch != null &&
                    this.BuildBranch.Equals(input.BuildBranch))
                ) && 
                (
                    this.BuildTimestamp == input.BuildTimestamp ||
                    (this.BuildTimestamp != null &&
                    this.BuildTimestamp.Equals(input.BuildTimestamp))
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
                if (this.NiFiVersion != null)
                    hashCode = hashCode * 59 + this.NiFiVersion.GetHashCode();
                if (this.JavaVendor != null)
                    hashCode = hashCode * 59 + this.JavaVendor.GetHashCode();
                if (this.JavaVersion != null)
                    hashCode = hashCode * 59 + this.JavaVersion.GetHashCode();
                if (this.OsName != null)
                    hashCode = hashCode * 59 + this.OsName.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.OsArchitecture != null)
                    hashCode = hashCode * 59 + this.OsArchitecture.GetHashCode();
                if (this.BuildTag != null)
                    hashCode = hashCode * 59 + this.BuildTag.GetHashCode();
                if (this.BuildRevision != null)
                    hashCode = hashCode * 59 + this.BuildRevision.GetHashCode();
                if (this.BuildBranch != null)
                    hashCode = hashCode * 59 + this.BuildBranch.GetHashCode();
                if (this.BuildTimestamp != null)
                    hashCode = hashCode * 59 + this.BuildTimestamp.GetHashCode();
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