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
    /// Pet
    /// </summary>
    public partial class Pet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pet" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="photoUrls">photoUrls</param>
        /// <param name="category">category</param>
        /// <param name="id">id</param>
        /// <param name="status">pet status in the store</param>
        /// <param name="tags">tags</param>
        [JsonConstructor]
        public Pet(string name, List<string> photoUrls, Option<Category> category = default, Option<long> id = default, Option<StatusEnum> status = default, Option<List<Tag>> tags = default)
        {
            Name = name;
            PhotoUrls = photoUrls;
            Category = category;
            Id = id;
            Status = status;
            Tags = tags;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            Available = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            Pending = 2,

            /// <summary>
            /// Enum Sold for value: sold
            /// </summary>
            Sold = 3
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("available"))
                return StatusEnum.Available;

            if (value.Equals("pending"))
                return StatusEnum.Pending;

            if (value.Equals("sold"))
                return StatusEnum.Sold;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("available"))
                return StatusEnum.Available;

            if (value.Equals("pending"))
                return StatusEnum.Pending;

            if (value.Equals("sold"))
                return StatusEnum.Sold;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Available)
                return "available";

            if (value == StatusEnum.Pending)
                return "pending";

            if (value == StatusEnum.Sold)
                return "sold";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        [JsonPropertyName("status")]
        public Option<StatusEnum> Status { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>doggie</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PhotoUrls
        /// </summary>
        [JsonPropertyName("photoUrls")]
        public List<string> PhotoUrls { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonPropertyName("category")]
        public Option<Category> Category { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public Option<long> Id { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [JsonPropertyName("tags")]
        public Option<List<Tag>> Tags { get; set; }

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
            sb.Append("class Pet {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhotoUrls: ").Append(PhotoUrls).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
    /// A Json converter for type <see cref="Pet" />
    /// </summary>
    public class PetJsonConverter : JsonConverter<Pet>
    {
        /// <summary>
        /// Deserializes json to <see cref="Pet" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Pet Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<List<string>?> photoUrls = default;
            Option<Category?> category = default;
            Option<long?> id = default;
            Option<Pet.StatusEnum?> status = default;
            Option<List<Tag>?> tags = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "photoUrls":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                photoUrls = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "category":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                category = new Option<Category?>(JsonSerializer.Deserialize<Category>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<Pet.StatusEnum?>(Pet.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "tags":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tags = new Option<List<Tag>?>(JsonSerializer.Deserialize<List<Tag>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class Pet.", nameof(name));

            if (!photoUrls.IsSet)
                throw new ArgumentException("Property is required for class Pet.", nameof(photoUrls));

            if (name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class Pet.");

            if (photoUrls.Value == null)
                throw new ArgumentNullException(nameof(photoUrls), "Property is not nullable for class Pet.");

            if (category.Value == null)
                throw new ArgumentNullException(nameof(category), "Property is not nullable for class Pet.");

            if (id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Pet.");

            if (status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class Pet.");

            if (tags.Value == null)
                throw new ArgumentNullException(nameof(tags), "Property is not nullable for class Pet.");

            string nameParsedValue = name.Value;
            List<string> photoUrlsParsedValue = photoUrls.Value;
            Option<Category> categoryParsedValue = new Option<Category>(category.Value);
            Option<long> idParsedValue = new Option<long>(id.Value.Value);
            Option<Pet.StatusEnum> statusParsedValue = new Option<Pet.StatusEnum>(status.Value.Value);
            Option<List<Tag>> tagsParsedValue = new Option<List<Tag>>(tags.Value);

            return new Pet(nameParsedValue, photoUrlsParsedValue, categoryParsedValue, idParsedValue, statusParsedValue, tagsParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="Pet" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pet"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Pet pet, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, pet, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Pet" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pet"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Pet pet, JsonSerializerOptions jsonSerializerOptions)
        {
            if (pet.Name == null)
                throw new ArgumentNullException(nameof(pet.Name), "Property is required for class Pet.");

            if (pet.PhotoUrls == null)
                throw new ArgumentNullException(nameof(pet.PhotoUrls), "Property is required for class Pet.");

            if (pet.Category.Value == null)
                throw new ArgumentNullException(nameof(pet.Category), "Property is required for class Pet.");

            if (pet.Tags.Value == null)
                throw new ArgumentNullException(nameof(pet.Tags), "Property is required for class Pet.");

            writer.WriteString("name", pet.Name);            writer.WritePropertyName("photoUrls");
            JsonSerializer.Serialize(writer, pet.PhotoUrls, jsonSerializerOptions);
            if (pet.Category.IsSet)
                writer.WritePropertyName("category");
                JsonSerializer.Serialize(writer, pet.Category, jsonSerializerOptions);
            if (pet.Id.IsSet)
                writer.WriteNumber("id", pet.Id.Value);            var statusRawValue = Pet.StatusEnumToJsonValue(pet.Status.Value);
            if (statusRawValue != null)
                writer.WriteString("status", statusRawValue);
            else
                writer.WriteNull("status");

            if (pet.Tags.IsSet)
                writer.WritePropertyName("tags");
                JsonSerializer.Serialize(writer, pet.Tags, jsonSerializerOptions);
        }
    }
}
