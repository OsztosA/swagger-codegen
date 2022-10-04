/*
 * Swagger Petstore
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class PartMaster : IEquatable<PartMaster>
    { 
        /// <summary>
        /// Gets or Sets Destination
        /// </summary>

        [DataMember(Name="destination")]
        public OneOfPartMasterDestination Destination { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>

        [DataMember(Name="origin")]
        public OneOfPartMasterOrigin Origin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartMaster {\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((PartMaster)obj);
        }

        /// <summary>
        /// Returns true if PartMaster instances are equal
        /// </summary>
        /// <param name="other">Instance of PartMaster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartMaster other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Destination == other.Destination ||
                    Destination != null &&
                    Destination.Equals(other.Destination)
                ) && 
                (
                    Origin == other.Origin ||
                    Origin != null &&
                    Origin.Equals(other.Origin)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Destination != null)
                    hashCode = hashCode * 59 + Destination.GetHashCode();
                    if (Origin != null)
                    hashCode = hashCode * 59 + Origin.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PartMaster left, PartMaster right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PartMaster left, PartMaster right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
