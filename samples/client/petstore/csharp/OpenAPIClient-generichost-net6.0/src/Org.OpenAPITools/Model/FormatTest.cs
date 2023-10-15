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
    /// FormatTest
    /// </summary>
    public partial class FormatTest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        /// <param name="varByte">varByte</param>
        /// <param name="date">date</param>
        /// <param name="number">number</param>
        /// <param name="password">password</param>
        /// <param name="binary">binary</param>
        /// <param name="dateTime">dateTime</param>
        /// <param name="varDecimal">varDecimal</param>
        /// <param name="varDouble">varDouble</param>
        /// <param name="varFloat">varFloat</param>
        /// <param name="int32">int32</param>
        /// <param name="int64">int64</param>
        /// <param name="integer">integer</param>
        /// <param name="patternWithBackslash">None</param>
        /// <param name="patternWithDigits">A string that is a 10 digit number. Can have leading zeros.</param>
        /// <param name="patternWithDigitsAndDelimiter">A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</param>
        /// <param name="varString">varString</param>
        /// <param name="unsignedInteger">unsignedInteger</param>
        /// <param name="unsignedLong">unsignedLong</param>
        /// <param name="uuid">uuid</param>
        [JsonConstructor]
        public FormatTest(byte[] varByte, DateTime date, decimal number, string password, Option<System.IO.Stream> binary = default, Option<DateTime> dateTime = default, Option<decimal> varDecimal = default, Option<double> varDouble = default, Option<float> varFloat = default, Option<int> int32 = default, Option<long> int64 = default, Option<int> integer = default, Option<string> patternWithBackslash = default, Option<string> patternWithDigits = default, Option<string> patternWithDigitsAndDelimiter = default, Option<string> varString = default, Option<uint> unsignedInteger = default, Option<ulong> unsignedLong = default, Option<Guid> uuid = default)
        {
            VarByte = varByte;
            Date = date;
            Number = number;
            Password = password;
            Binary = binary;
            DateTime = dateTime;
            VarDecimal = varDecimal;
            VarDouble = varDouble;
            VarFloat = varFloat;
            Int32 = int32;
            Int64 = int64;
            Integer = integer;
            PatternWithBackslash = patternWithBackslash;
            PatternWithDigits = patternWithDigits;
            PatternWithDigitsAndDelimiter = patternWithDigitsAndDelimiter;
            VarString = varString;
            UnsignedInteger = unsignedInteger;
            UnsignedLong = unsignedLong;
            Uuid = uuid;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets VarByte
        /// </summary>
        [JsonPropertyName("byte")]
        public byte[] VarByte { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /// <example>Sun Feb 02 00:00:00 UTC 2020</example>
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public decimal Number { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [JsonPropertyName("binary")]
        public Option<System.IO.Stream> Binary { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        /// <example>2007-12-03T10:15:30+01:00</example>
        [JsonPropertyName("dateTime")]
        public Option<DateTime> DateTime { get; set; }

        /// <summary>
        /// Gets or Sets VarDecimal
        /// </summary>
        [JsonPropertyName("decimal")]
        public Option<decimal> VarDecimal { get; set; }

        /// <summary>
        /// Gets or Sets VarDouble
        /// </summary>
        [JsonPropertyName("double")]
        public Option<double> VarDouble { get; set; }

        /// <summary>
        /// Gets or Sets VarFloat
        /// </summary>
        [JsonPropertyName("float")]
        public Option<float> VarFloat { get; set; }

        /// <summary>
        /// Gets or Sets Int32
        /// </summary>
        [JsonPropertyName("int32")]
        public Option<int> Int32 { get; set; }

        /// <summary>
        /// Gets or Sets Int64
        /// </summary>
        [JsonPropertyName("int64")]
        public Option<long> Int64 { get; set; }

        /// <summary>
        /// Gets or Sets Integer
        /// </summary>
        [JsonPropertyName("integer")]
        public Option<int> Integer { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [JsonPropertyName("pattern_with_backslash")]
        public Option<string> PatternWithBackslash { get; set; }

        /// <summary>
        /// A string that is a 10 digit number. Can have leading zeros.
        /// </summary>
        /// <value>A string that is a 10 digit number. Can have leading zeros.</value>
        [JsonPropertyName("pattern_with_digits")]
        public Option<string> PatternWithDigits { get; set; }

        /// <summary>
        /// A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.
        /// </summary>
        /// <value>A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</value>
        [JsonPropertyName("pattern_with_digits_and_delimiter")]
        public Option<string> PatternWithDigitsAndDelimiter { get; set; }

        /// <summary>
        /// Gets or Sets VarString
        /// </summary>
        [JsonPropertyName("string")]
        public Option<string> VarString { get; set; }

        /// <summary>
        /// Gets or Sets UnsignedInteger
        /// </summary>
        [JsonPropertyName("unsigned_integer")]
        public Option<uint> UnsignedInteger { get; set; }

        /// <summary>
        /// Gets or Sets UnsignedLong
        /// </summary>
        [JsonPropertyName("unsigned_long")]
        public Option<ulong> UnsignedLong { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        /// <example>72f98069-206d-4f12-9f12-3d1e525a8e84</example>
        [JsonPropertyName("uuid")]
        public Option<Guid> Uuid { get; set; }

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
            sb.Append("class FormatTest {\n");
            sb.Append("  VarByte: ").Append(VarByte).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  VarDecimal: ").Append(VarDecimal).Append("\n");
            sb.Append("  VarDouble: ").Append(VarDouble).Append("\n");
            sb.Append("  VarFloat: ").Append(VarFloat).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  PatternWithBackslash: ").Append(PatternWithBackslash).Append("\n");
            sb.Append("  PatternWithDigits: ").Append(PatternWithDigits).Append("\n");
            sb.Append("  PatternWithDigitsAndDelimiter: ").Append(PatternWithDigitsAndDelimiter).Append("\n");
            sb.Append("  VarString: ").Append(VarString).Append("\n");
            sb.Append("  UnsignedInteger: ").Append(UnsignedInteger).Append("\n");
            sb.Append("  UnsignedLong: ").Append(UnsignedLong).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            // Number (decimal) maximum
            if (this.Number > (decimal)543.2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value less than or equal to 543.2.", new [] { "Number" });
            }

            // Number (decimal) minimum
            if (this.Number < (decimal)32.1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value greater than or equal to 32.1.", new [] { "Number" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 10.", new [] { "Password" });
            }

            // VarDouble (double) maximum
            if (this.VarDouble.IsSet && this.VarDouble.Value > (double)123.4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarDouble, must be a value less than or equal to 123.4.", new [] { "VarDouble" });
            }

            // VarDouble (double) minimum
            if (this.VarDouble.IsSet && this.VarDouble.Value < (double)67.8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarDouble, must be a value greater than or equal to 67.8.", new [] { "VarDouble" });
            }

            // VarFloat (float) maximum
            if (this.VarFloat.IsSet && this.VarFloat.Value > (float)987.6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarFloat, must be a value less than or equal to 987.6.", new [] { "VarFloat" });
            }

            // VarFloat (float) minimum
            if (this.VarFloat.IsSet && this.VarFloat.Value < (float)54.3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarFloat, must be a value greater than or equal to 54.3.", new [] { "VarFloat" });
            }

            // Int32 (int) maximum
            if (this.Int32.IsSet && this.Int32.Value > (int)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value less than or equal to 200.", new [] { "Int32" });
            }

            // Int32 (int) minimum
            if (this.Int32.IsSet && this.Int32.Value < (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value greater than or equal to 20.", new [] { "Int32" });
            }

            // Integer (int) maximum
            if (this.Integer.IsSet && this.Integer.Value > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value less than or equal to 100.", new [] { "Integer" });
            }

            // Integer (int) minimum
            if (this.Integer.IsSet && this.Integer.Value < (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value greater than or equal to 10.", new [] { "Integer" });
            }

            if (this.PatternWithBackslash.Value != null) {
                // PatternWithBackslash (string) pattern
                Regex regexPatternWithBackslash = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\/([0-9]|[1-2][0-9]|3[0-2]))$", RegexOptions.CultureInvariant);
                if (!regexPatternWithBackslash.Match(this.PatternWithBackslash.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithBackslash, must match a pattern of " + regexPatternWithBackslash, new [] { "PatternWithBackslash" });
                }
            }

            if (this.PatternWithDigits.Value != null) {
                // PatternWithDigits (string) pattern
                Regex regexPatternWithDigits = new Regex(@"^\d{10}$", RegexOptions.CultureInvariant);
                if (!regexPatternWithDigits.Match(this.PatternWithDigits.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigits, must match a pattern of " + regexPatternWithDigits, new [] { "PatternWithDigits" });
                }
            }

            if (this.PatternWithDigitsAndDelimiter.Value != null) {
                // PatternWithDigitsAndDelimiter (string) pattern
                Regex regexPatternWithDigitsAndDelimiter = new Regex(@"^image_\d{1,3}$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
                if (!regexPatternWithDigitsAndDelimiter.Match(this.PatternWithDigitsAndDelimiter.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigitsAndDelimiter, must match a pattern of " + regexPatternWithDigitsAndDelimiter, new [] { "PatternWithDigitsAndDelimiter" });
                }
            }

            if (this.VarString.Value != null) {
                // VarString (string) pattern
                Regex regexVarString = new Regex(@"[a-z]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
                if (!regexVarString.Match(this.VarString.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarString, must match a pattern of " + regexVarString, new [] { "VarString" });
                }
            }

            // UnsignedInteger (uint) maximum
            if (this.UnsignedInteger.IsSet && this.UnsignedInteger.Value > (uint)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnsignedInteger, must be a value less than or equal to 200.", new [] { "UnsignedInteger" });
            }

            // UnsignedInteger (uint) minimum
            if (this.UnsignedInteger.IsSet && this.UnsignedInteger.Value < (uint)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnsignedInteger, must be a value greater than or equal to 20.", new [] { "UnsignedInteger" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FormatTest" />
    /// </summary>
    public class FormatTestJsonConverter : JsonConverter<FormatTest>
    {
        /// <summary>
        /// The format to use to serialize Date
        /// </summary>
        public static string DateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize DateTime
        /// </summary>
        public static string DateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="FormatTest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FormatTest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<byte[]> varByte = default;
            Option<DateTime?> date = default;
            Option<decimal?> number = default;
            Option<string> password = default;
            Option<System.IO.Stream> binary = default;
            Option<DateTime?> dateTime = default;
            Option<decimal?> varDecimal = default;
            Option<double?> varDouble = default;
            Option<float?> varFloat = default;
            Option<int?> int32 = default;
            Option<long?> int64 = default;
            Option<int?> integer = default;
            Option<string> patternWithBackslash = default;
            Option<string> patternWithDigits = default;
            Option<string> patternWithDigitsAndDelimiter = default;
            Option<string> varString = default;
            Option<uint?> unsignedInteger = default;
            Option<ulong?> unsignedLong = default;
            Option<Guid?> uuid = default;

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
                        case "byte":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varByte = new Option<byte[]>(JsonSerializer.Deserialize<byte[]>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "date":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                date = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                number = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "password":
                            password = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "binary":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                binary = new Option<System.IO.Stream>(JsonSerializer.Deserialize<System.IO.Stream>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "dateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "decimal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varDecimal = new Option<decimal?>(JsonSerializer.Deserialize<decimal>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "double":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varDouble = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "float":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varFloat = new Option<float?>((float)utf8JsonReader.GetDouble());
                            break;
                        case "int32":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                int32 = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "int64":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                int64 = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "integer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                integer = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "pattern_with_backslash":
                            patternWithBackslash = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "pattern_with_digits":
                            patternWithDigits = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "pattern_with_digits_and_delimiter":
                            patternWithDigitsAndDelimiter = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "string":
                            varString = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "unsigned_integer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                unsignedInteger = new Option<uint?>(utf8JsonReader.GetUInt32());
                            break;
                        case "unsigned_long":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                unsignedLong = new Option<ulong?>(utf8JsonReader.GetUInt64());
                            break;
                        case "uuid":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                uuid = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!varByte.IsSet)
                throw new ArgumentException("Property is required for class FormatTest.", nameof(varByte));

            if (!date.IsSet)
                throw new ArgumentException("Property is required for class FormatTest.", nameof(date));

            if (!number.IsSet)
                throw new ArgumentException("Property is required for class FormatTest.", nameof(number));

            if (!password.IsSet)
                throw new ArgumentException("Property is required for class FormatTest.", nameof(password));

            if (varByte.Value == null)
                throw new ArgumentNullException(nameof(varByte), "Property is not nullable for class FormatTest.");

            if (date.Value == null)
                throw new ArgumentNullException(nameof(date), "Property is not nullable for class FormatTest.");

            if (number.Value == null)
                throw new ArgumentNullException(nameof(number), "Property is not nullable for class FormatTest.");

            if (password.Value == null)
                throw new ArgumentNullException(nameof(password), "Property is not nullable for class FormatTest.");

            if (binary.Value == null)
                throw new ArgumentNullException(nameof(binary), "Property is not nullable for class FormatTest.");

            if (dateTime.Value == null)
                throw new ArgumentNullException(nameof(dateTime), "Property is not nullable for class FormatTest.");

            if (varDecimal.Value == null)
                throw new ArgumentNullException(nameof(varDecimal), "Property is not nullable for class FormatTest.");

            if (varDouble.Value == null)
                throw new ArgumentNullException(nameof(varDouble), "Property is not nullable for class FormatTest.");

            if (varFloat.Value == null)
                throw new ArgumentNullException(nameof(varFloat), "Property is not nullable for class FormatTest.");

            if (int32.Value == null)
                throw new ArgumentNullException(nameof(int32), "Property is not nullable for class FormatTest.");

            if (int64.Value == null)
                throw new ArgumentNullException(nameof(int64), "Property is not nullable for class FormatTest.");

            if (integer.Value == null)
                throw new ArgumentNullException(nameof(integer), "Property is not nullable for class FormatTest.");

            if (patternWithBackslash.Value == null)
                throw new ArgumentNullException(nameof(patternWithBackslash), "Property is not nullable for class FormatTest.");

            if (patternWithDigits.Value == null)
                throw new ArgumentNullException(nameof(patternWithDigits), "Property is not nullable for class FormatTest.");

            if (patternWithDigitsAndDelimiter.Value == null)
                throw new ArgumentNullException(nameof(patternWithDigitsAndDelimiter), "Property is not nullable for class FormatTest.");

            if (varString.Value == null)
                throw new ArgumentNullException(nameof(varString), "Property is not nullable for class FormatTest.");

            if (unsignedInteger.Value == null)
                throw new ArgumentNullException(nameof(unsignedInteger), "Property is not nullable for class FormatTest.");

            if (unsignedLong.Value == null)
                throw new ArgumentNullException(nameof(unsignedLong), "Property is not nullable for class FormatTest.");

            if (uuid.Value == null)
                throw new ArgumentNullException(nameof(uuid), "Property is not nullable for class FormatTest.");

            byte[] varByteParsedValue = varByte.Value;
            DateTime dateParsedValue = date.Value.Value;
            decimal numberParsedValue = number.Value.Value;
            string passwordParsedValue = password.Value;
            Option<System.IO.Stream> binaryParsedValue = new Option<System.IO.Stream>(binary.Value);
            Option<DateTime> dateTimeParsedValue = new Option<DateTime>(dateTime.Value.Value);
            Option<decimal> varDecimalParsedValue = new Option<decimal>(varDecimal.Value.Value);
            Option<double> varDoubleParsedValue = new Option<double>(varDouble.Value.Value);
            Option<float> varFloatParsedValue = new Option<float>(varFloat.Value.Value);
            Option<int> int32ParsedValue = new Option<int>(int32.Value.Value);
            Option<long> int64ParsedValue = new Option<long>(int64.Value.Value);
            Option<int> integerParsedValue = new Option<int>(integer.Value.Value);
            Option<string> patternWithBackslashParsedValue = new Option<string>(patternWithBackslash.Value);
            Option<string> patternWithDigitsParsedValue = new Option<string>(patternWithDigits.Value);
            Option<string> patternWithDigitsAndDelimiterParsedValue = new Option<string>(patternWithDigitsAndDelimiter.Value);
            Option<string> varStringParsedValue = new Option<string>(varString.Value);
            Option<uint> unsignedIntegerParsedValue = new Option<uint>(unsignedInteger.Value.Value);
            Option<ulong> unsignedLongParsedValue = new Option<ulong>(unsignedLong.Value.Value);
            Option<Guid> uuidParsedValue = new Option<Guid>(uuid.Value.Value);

            return new FormatTest(varByteParsedValue, dateParsedValue, numberParsedValue, passwordParsedValue, binaryParsedValue, dateTimeParsedValue, varDecimalParsedValue, varDoubleParsedValue, varFloatParsedValue, int32ParsedValue, int64ParsedValue, integerParsedValue, patternWithBackslashParsedValue, patternWithDigitsParsedValue, patternWithDigitsAndDelimiterParsedValue, varStringParsedValue, unsignedIntegerParsedValue, unsignedLongParsedValue, uuidParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="FormatTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="formatTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FormatTest formatTest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, formatTest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FormatTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="formatTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, FormatTest formatTest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (formatTest.VarByte == null)
                throw new ArgumentNullException(nameof(formatTest.VarByte), "Property is required for class FormatTest.");

            if (formatTest.Password == null)
                throw new ArgumentNullException(nameof(formatTest.Password), "Property is required for class FormatTest.");

            if (formatTest.Binary.Value == null)
                throw new ArgumentNullException(nameof(formatTest.Binary), "Property is required for class FormatTest.");

            if (formatTest.PatternWithBackslash.Value == null)
                throw new ArgumentNullException(nameof(formatTest.PatternWithBackslash), "Property is required for class FormatTest.");

            if (formatTest.PatternWithDigits.Value == null)
                throw new ArgumentNullException(nameof(formatTest.PatternWithDigits), "Property is required for class FormatTest.");

            if (formatTest.PatternWithDigitsAndDelimiter.Value == null)
                throw new ArgumentNullException(nameof(formatTest.PatternWithDigitsAndDelimiter), "Property is required for class FormatTest.");

            if (formatTest.VarString.Value == null)
                throw new ArgumentNullException(nameof(formatTest.VarString), "Property is required for class FormatTest.");

            writer.WritePropertyName("byte");
            JsonSerializer.Serialize(writer, formatTest.VarByte, jsonSerializerOptions);
            writer.WriteString("date", formatTest.Date.ToString(DateFormat));            writer.WriteNumber("number", formatTest.Number);            writer.WriteString("password", formatTest.Password);            if (formatTest.Binary.IsSet)
                writer.WritePropertyName("binary");
                JsonSerializer.Serialize(writer, formatTest.Binary, jsonSerializerOptions);
            if (formatTest.DateTime.IsSet)
                writer.WriteString("dateTime", formatTest.DateTime.Value.ToString(DateTimeFormat));            if (formatTest.VarDecimal.IsSet)
                writer.WritePropertyName("decimal");
                JsonSerializer.Serialize(writer, formatTest.VarDecimal, jsonSerializerOptions);
            if (formatTest.VarDouble.IsSet)
                writer.WriteNumber("double", formatTest.VarDouble.Value);            if (formatTest.VarFloat.IsSet)
                writer.WriteNumber("float", formatTest.VarFloat.Value);            if (formatTest.Int32.IsSet)
                writer.WriteNumber("int32", formatTest.Int32.Value);            if (formatTest.Int64.IsSet)
                writer.WriteNumber("int64", formatTest.Int64.Value);            if (formatTest.Integer.IsSet)
                writer.WriteNumber("integer", formatTest.Integer.Value);            if (formatTest.PatternWithBackslash.IsSet)
                writer.WriteString("pattern_with_backslash", formatTest.PatternWithBackslash.Value);            if (formatTest.PatternWithDigits.IsSet)
                writer.WriteString("pattern_with_digits", formatTest.PatternWithDigits.Value);            if (formatTest.PatternWithDigitsAndDelimiter.IsSet)
                writer.WriteString("pattern_with_digits_and_delimiter", formatTest.PatternWithDigitsAndDelimiter.Value);            if (formatTest.VarString.IsSet)
                writer.WriteString("string", formatTest.VarString.Value);            if (formatTest.UnsignedInteger.IsSet)
                writer.WriteNumber("unsigned_integer", formatTest.UnsignedInteger.Value);            if (formatTest.UnsignedLong.IsSet)
                writer.WriteNumber("unsigned_long", formatTest.UnsignedLong.Value);            if (formatTest.Uuid.IsSet)
                writer.WriteString("uuid", formatTest.Uuid.Value);
        }
    }
}
