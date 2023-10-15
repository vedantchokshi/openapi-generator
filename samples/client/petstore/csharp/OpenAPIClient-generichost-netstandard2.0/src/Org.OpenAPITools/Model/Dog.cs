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
    /// Dog
    /// </summary>
    public partial class Dog : Animal, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog" /> class.
        /// </summary>
        /// <param name="className">className</param>
        /// <param name="breed">breed</param>
        /// <param name="color">color (default to &quot;red&quot;)</param>
        [JsonConstructor]
        public Dog(string className, Option<string> breed = default, Option<string> color = default) : base(className, color)
        {
            Breed = breed;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Breed
        /// </summary>
        [JsonPropertyName("breed")]
        public Option<string> Breed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Dog {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Breed: ").Append(Breed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Dog" />
    /// </summary>
    public class DogJsonConverter : JsonConverter<Dog>
    {
        /// <summary>
        /// Deserializes json to <see cref="Dog" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Dog Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> className = default;
            Option<string> breed = default;
            Option<string> color = default;

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
                        case "className":
                            className = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "breed":
                            breed = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "color":
                            color = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!className.IsSet)
                throw new ArgumentException("Property is required for class Dog.", nameof(className));

            if (className.Value == null)
                throw new ArgumentNullException(nameof(className), "Property is not nullable for class Dog.");

            if (breed.Value == null)
                throw new ArgumentNullException(nameof(breed), "Property is not nullable for class Dog.");

            if (color.Value == null)
                throw new ArgumentNullException(nameof(color), "Property is not nullable for class Dog.");

            string classNameParsedValue = className.Value;
            Option<string> breedParsedValue = new Option<string>(breed.Value);
            Option<string> colorParsedValue = new Option<string>(color.Value);

            return new Dog(classNameParsedValue, breedParsedValue, colorParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="Dog" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dog"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Dog dog, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, dog, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Dog" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dog"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Dog dog, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dog.ClassName == null)
                throw new ArgumentNullException(nameof(dog.ClassName), "Property is required for class Dog.");

            if (dog.Breed.Value == null)
                throw new ArgumentNullException(nameof(dog.Breed), "Property is required for class Dog.");

            if (dog.Color.Value == null)
                throw new ArgumentNullException(nameof(dog.Color), "Property is required for class Dog.");

            writer.WriteString("className", dog.ClassName);            if (dog.Breed.IsSet)
                writer.WriteString("breed", dog.Breed.Value);            if (dog.Color.IsSet)
                writer.WriteString("color", dog.Color.Value);
        }
    }
}
