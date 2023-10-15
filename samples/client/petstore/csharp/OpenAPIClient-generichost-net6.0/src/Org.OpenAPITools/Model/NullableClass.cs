// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
    /// NullableClass
    /// </summary>
    public partial class NullableClass : Dictionary<String, Object>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullableClass" /> class.
        /// </summary>
        /// <param name="arrayItemsNullable">arrayItemsNullable</param>
        /// <param name="objectItemsNullable">objectItemsNullable</param>
        /// <param name="arrayAndItemsNullableProp">arrayAndItemsNullableProp</param>
        /// <param name="arrayNullableProp">arrayNullableProp</param>
        /// <param name="booleanProp">booleanProp</param>
        /// <param name="dateProp">dateProp</param>
        /// <param name="datetimeProp">datetimeProp</param>
        /// <param name="integerProp">integerProp</param>
        /// <param name="numberProp">numberProp</param>
        /// <param name="objectAndItemsNullableProp">objectAndItemsNullableProp</param>
        /// <param name="objectNullableProp">objectNullableProp</param>
        /// <param name="stringProp">stringProp</param>
        [JsonConstructor]
        public NullableClass(Option<List<Object>> arrayItemsNullable = default, Option<Dictionary<string, Object>> objectItemsNullable = default, Option<List<Object>> arrayAndItemsNullableProp = default, Option<List<Object>> arrayNullableProp = default, Option<bool?> booleanProp = default, Option<DateTime?> dateProp = default, Option<DateTime?> datetimeProp = default, Option<int?> integerProp = default, Option<decimal?> numberProp = default, Option<Dictionary<string, Object>> objectAndItemsNullableProp = default, Option<Dictionary<string, Object>> objectNullableProp = default, Option<string> stringProp = default) : base()
        {
            ArrayItemsNullable = arrayItemsNullable;
            ObjectItemsNullable = objectItemsNullable;
            ArrayAndItemsNullableProp = arrayAndItemsNullableProp;
            ArrayNullableProp = arrayNullableProp;
            BooleanProp = booleanProp;
            DateProp = dateProp;
            DatetimeProp = datetimeProp;
            IntegerProp = integerProp;
            NumberProp = numberProp;
            ObjectAndItemsNullableProp = objectAndItemsNullableProp;
            ObjectNullableProp = objectNullableProp;
            StringProp = stringProp;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ArrayItemsNullable
        /// </summary>
        [JsonPropertyName("array_items_nullable")]
        public Option<List<Object>> ArrayItemsNullable { get; set; }

        /// <summary>
        /// Gets or Sets ObjectItemsNullable
        /// </summary>
        [JsonPropertyName("object_items_nullable")]
        public Option<Dictionary<string, Object>> ObjectItemsNullable { get; set; }

        /// <summary>
        /// Gets or Sets ArrayAndItemsNullableProp
        /// </summary>
        [JsonPropertyName("array_and_items_nullable_prop")]
        public Option<List<Object>> ArrayAndItemsNullableProp { get; set; }

        /// <summary>
        /// Gets or Sets ArrayNullableProp
        /// </summary>
        [JsonPropertyName("array_nullable_prop")]
        public Option<List<Object>> ArrayNullableProp { get; set; }

        /// <summary>
        /// Gets or Sets BooleanProp
        /// </summary>
        [JsonPropertyName("boolean_prop")]
        public Option<bool?> BooleanProp { get; set; }

        /// <summary>
        /// Gets or Sets DateProp
        /// </summary>
        [JsonPropertyName("date_prop")]
        public Option<DateTime?> DateProp { get; set; }

        /// <summary>
        /// Gets or Sets DatetimeProp
        /// </summary>
        [JsonPropertyName("datetime_prop")]
        public Option<DateTime?> DatetimeProp { get; set; }

        /// <summary>
        /// Gets or Sets IntegerProp
        /// </summary>
        [JsonPropertyName("integer_prop")]
        public Option<int?> IntegerProp { get; set; }

        /// <summary>
        /// Gets or Sets NumberProp
        /// </summary>
        [JsonPropertyName("number_prop")]
        public Option<decimal?> NumberProp { get; set; }

        /// <summary>
        /// Gets or Sets ObjectAndItemsNullableProp
        /// </summary>
        [JsonPropertyName("object_and_items_nullable_prop")]
        public Option<Dictionary<string, Object>> ObjectAndItemsNullableProp { get; set; }

        /// <summary>
        /// Gets or Sets ObjectNullableProp
        /// </summary>
        [JsonPropertyName("object_nullable_prop")]
        public Option<Dictionary<string, Object>> ObjectNullableProp { get; set; }

        /// <summary>
        /// Gets or Sets StringProp
        /// </summary>
        [JsonPropertyName("string_prop")]
        public Option<string> StringProp { get; set; }

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
            sb.Append("class NullableClass {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ArrayItemsNullable: ").Append(ArrayItemsNullable).Append("\n");
            sb.Append("  ObjectItemsNullable: ").Append(ObjectItemsNullable).Append("\n");
            sb.Append("  ArrayAndItemsNullableProp: ").Append(ArrayAndItemsNullableProp).Append("\n");
            sb.Append("  ArrayNullableProp: ").Append(ArrayNullableProp).Append("\n");
            sb.Append("  BooleanProp: ").Append(BooleanProp).Append("\n");
            sb.Append("  DateProp: ").Append(DateProp).Append("\n");
            sb.Append("  DatetimeProp: ").Append(DatetimeProp).Append("\n");
            sb.Append("  IntegerProp: ").Append(IntegerProp).Append("\n");
            sb.Append("  NumberProp: ").Append(NumberProp).Append("\n");
            sb.Append("  ObjectAndItemsNullableProp: ").Append(ObjectAndItemsNullableProp).Append("\n");
            sb.Append("  ObjectNullableProp: ").Append(ObjectNullableProp).Append("\n");
            sb.Append("  StringProp: ").Append(StringProp).Append("\n");
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="NullableClass" />
    /// </summary>
    public class NullableClassJsonConverter : JsonConverter<NullableClass>
    {
        /// <summary>
        /// The format to use to serialize DateProp
        /// </summary>
        public static string DatePropFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize DatetimeProp
        /// </summary>
        public static string DatetimePropFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="NullableClass" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NullableClass Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Object>> arrayItemsNullable = default;
            Option<Dictionary<string, Object>> objectItemsNullable = default;
            Option<List<Object>> arrayAndItemsNullableProp = default;
            Option<List<Object>> arrayNullableProp = default;
            Option<bool?> booleanProp = default;
            Option<DateTime?> dateProp = default;
            Option<DateTime?> datetimeProp = default;
            Option<int?> integerProp = default;
            Option<decimal?> numberProp = default;
            Option<Dictionary<string, Object>> objectAndItemsNullableProp = default;
            Option<Dictionary<string, Object>> objectNullableProp = default;
            Option<string> stringProp = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "array_items_nullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayItemsNullable = new Option<List<Object>>(JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "object_items_nullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectItemsNullable = new Option<Dictionary<string, Object>>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "array_and_items_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayAndItemsNullableProp = new Option<List<Object>>(JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "array_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayNullableProp = new Option<List<Object>>(JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "boolean_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                booleanProp = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "date_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateProp = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "datetime_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                datetimeProp = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "integer_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                integerProp = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "number_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                numberProp = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "object_and_items_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectAndItemsNullableProp = new Option<Dictionary<string, Object>>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "object_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectNullableProp = new Option<Dictionary<string, Object>>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "string_prop":
                            stringProp = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (arrayItemsNullable.Value == null)
                throw new ArgumentNullException(nameof(arrayItemsNullable), "Property is not nullable for class NullableClass.");

            if (objectItemsNullable.Value == null)
                throw new ArgumentNullException(nameof(objectItemsNullable), "Property is not nullable for class NullableClass.");

            Option<List<Object>> arrayItemsNullableParsedValue = new Option<List<Object>>(arrayItemsNullable.Value);
            Option<Dictionary<string, Object>> objectItemsNullableParsedValue = new Option<Dictionary<string, Object>>(objectItemsNullable.Value);

            return new NullableClass(arrayItemsNullableParsedValue, objectItemsNullableParsedValue, arrayAndItemsNullableProp, arrayNullableProp, booleanProp, dateProp, datetimeProp, integerProp, numberProp, objectAndItemsNullableProp, objectNullableProp, stringProp);
        }

        /// <summary>
        /// Serializes a <see cref="NullableClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NullableClass nullableClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, nullableClass, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NullableClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, NullableClass nullableClass, JsonSerializerOptions jsonSerializerOptions)
        {
            if (nullableClass.ArrayItemsNullable.Value == null)
                throw new ArgumentNullException(nameof(nullableClass.ArrayItemsNullable), "Property is required for class NullableClass.");

            if (nullableClass.ObjectItemsNullable.Value == null)
                throw new ArgumentNullException(nameof(nullableClass.ObjectItemsNullable), "Property is required for class NullableClass.");

            if (nullableClass.ArrayItemsNullable.IsSet)
                writer.WritePropertyName("array_items_nullable");
                JsonSerializer.Serialize(writer, nullableClass.ArrayItemsNullable, jsonSerializerOptions);
            if (nullableClass.ObjectItemsNullable.IsSet)
                writer.WritePropertyName("object_items_nullable");
                JsonSerializer.Serialize(writer, nullableClass.ObjectItemsNullable, jsonSerializerOptions);
            if (nullableClass.ArrayAndItemsNullableProp.IsSet)
                if (nullableClass.ArrayAndItemsNullableProp.Value != null)
                {
                    writer.WritePropertyName("array_and_items_nullable_prop");
                    JsonSerializer.Serialize(writer, nullableClass.ArrayAndItemsNullableProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("array_and_items_nullable_prop");
            if (nullableClass.ArrayNullableProp.IsSet)
                if (nullableClass.ArrayNullableProp.Value != null)
                {
                    writer.WritePropertyName("array_nullable_prop");
                    JsonSerializer.Serialize(writer, nullableClass.ArrayNullableProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("array_nullable_prop");
            if (nullableClass.BooleanProp.IsSet)
                if (nullableClass.BooleanProp.Value != null)
                    writer.WriteBoolean("boolean_prop", nullableClass.BooleanProp.Value.Value);
                else
                    writer.WriteNull("boolean_prop");            if (nullableClass.DateProp.IsSet)
                if (nullableClass.DateProp.Value != null)
                    writer.WriteString("date_prop", nullableClass.DateProp.Value.Value.ToString(DatePropFormat));
                else
                    writer.WriteNull("date_prop");            if (nullableClass.DatetimeProp.IsSet)
                if (nullableClass.DatetimeProp.Value != null)
                    writer.WriteString("datetime_prop", nullableClass.DatetimeProp.Value.Value.ToString(DatetimePropFormat));
                else
                    writer.WriteNull("datetime_prop");            if (nullableClass.IntegerProp.IsSet)
                if (nullableClass.IntegerProp.Value != null)
                    writer.WriteNumber("integer_prop", nullableClass.IntegerProp.Value.Value);
                else
                    writer.WriteNull("integer_prop");            if (nullableClass.NumberProp.IsSet)
                if (nullableClass.NumberProp.Value != null)
                    writer.WriteNumber("number_prop", nullableClass.NumberProp.Value.Value);
                else
                    writer.WriteNull("number_prop");            if (nullableClass.ObjectAndItemsNullableProp.IsSet)
                if (nullableClass.ObjectAndItemsNullableProp.Value != null)
                {
                    writer.WritePropertyName("object_and_items_nullable_prop");
                    JsonSerializer.Serialize(writer, nullableClass.ObjectAndItemsNullableProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("object_and_items_nullable_prop");
            if (nullableClass.ObjectNullableProp.IsSet)
                if (nullableClass.ObjectNullableProp.Value != null)
                {
                    writer.WritePropertyName("object_nullable_prop");
                    JsonSerializer.Serialize(writer, nullableClass.ObjectNullableProp, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("object_nullable_prop");
            if (nullableClass.StringProp.IsSet)
                if (nullableClass.StringProp.Value != null)
                    writer.WriteString("string_prop", nullableClass.StringProp.Value);
                else
                    writer.WriteNull("string_prop");
        }
    }
}
