// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// OuterComposite
    /// </summary>
    public partial class OuterComposite : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OuterComposite" /> class.
        /// </summary>
        /// <param name="myBoolean">myBoolean</param>
        /// <param name="myNumber">myNumber</param>
        /// <param name="myString">myString</param>
        [JsonConstructor]
        public OuterComposite(Option<bool> myBoolean = default, Option<decimal> myNumber = default, Option<string> myString = default)
        {
            MyBoolean = myBoolean;
            MyNumber = myNumber;
            MyString = myString;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets MyBoolean
        /// </summary>
        [JsonPropertyName("my_boolean")]
        public Option<bool> MyBoolean { get; set; }

        /// <summary>
        /// Gets or Sets MyNumber
        /// </summary>
        [JsonPropertyName("my_number")]
        public Option<decimal> MyNumber { get; set; }

        /// <summary>
        /// Gets or Sets MyString
        /// </summary>
        [JsonPropertyName("my_string")]
        public Option<string> MyString { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OuterComposite {\n");
            sb.Append("  MyBoolean: ").Append(MyBoolean).Append("\n");
            sb.Append("  MyNumber: ").Append(MyNumber).Append("\n");
            sb.Append("  MyString: ").Append(MyString).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="OuterComposite" />
    /// </summary>
    public class OuterCompositeJsonConverter : JsonConverter<OuterComposite>
    {
        /// <summary>
        /// Deserializes json to <see cref="OuterComposite" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override OuterComposite Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> myBoolean = default;
            Option<decimal?> myNumber = default;
            Option<string?> myString = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "my_boolean":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                myBoolean = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "my_number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                myNumber = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "my_string":
                            myString = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (myBoolean.Value == null)
                throw new ArgumentNullException(nameof(myBoolean), "Property is not nullable for class OuterComposite.");

            if (myNumber.Value == null)
                throw new ArgumentNullException(nameof(myNumber), "Property is not nullable for class OuterComposite.");

            if (myString.Value == null)
                throw new ArgumentNullException(nameof(myString), "Property is not nullable for class OuterComposite.");

            Option<bool> myBooleanParsedValue = new Option<bool>(myBoolean.Value.Value);
            Option<decimal> myNumberParsedValue = new Option<decimal>(myNumber.Value.Value);
            Option<string> myStringParsedValue = new Option<string>(myString.Value);

            return new OuterComposite(myBooleanParsedValue, myNumberParsedValue, myStringParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="OuterComposite" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerComposite"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, OuterComposite outerComposite, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, outerComposite, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="OuterComposite" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerComposite"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, OuterComposite outerComposite, JsonSerializerOptions jsonSerializerOptions)
        {
            if (outerComposite.MyString.Value == null)
                throw new ArgumentNullException(nameof(outerComposite.MyString), "Property is required for class OuterComposite.");

            if (outerComposite.MyBoolean.IsSet)
                writer.WriteBoolean("my_boolean", outerComposite.MyBoolean.Value);            if (outerComposite.MyNumber.IsSet)
                writer.WriteNumber("my_number", outerComposite.MyNumber.Value);            if (outerComposite.MyString.IsSet)
                writer.WriteString("my_string", outerComposite.MyString.Value);
        }
    }
}
