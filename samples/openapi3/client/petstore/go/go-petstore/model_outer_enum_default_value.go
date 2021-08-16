/*
OpenAPI Petstore

This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\

API version: 1.0.0
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package petstore

import (
	"encoding/json"
	"fmt"
)

// OuterEnumDefaultValue the model 'OuterEnumDefaultValue'
type OuterEnumDefaultValue string

// List of OuterEnumDefaultValue
const (
	OUTERENUMDEFAULTVALUE_PLACED OuterEnumDefaultValue = "placed"
	OUTERENUMDEFAULTVALUE_APPROVED OuterEnumDefaultValue = "approved"
	OUTERENUMDEFAULTVALUE_DELIVERED OuterEnumDefaultValue = "delivered"
)

var allowedOuterEnumDefaultValueEnumValues = []OuterEnumDefaultValue{
	"placed",
	"approved",
	"delivered",
}

func (v *OuterEnumDefaultValue) UnmarshalJSON(src []byte) error {
	var value string
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := OuterEnumDefaultValue(value)
	for _, existing := range allowedOuterEnumDefaultValueEnumValues {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid OuterEnumDefaultValue", value)
}

// NewOuterEnumDefaultValueFromValue returns a pointer to a valid OuterEnumDefaultValue
// for the value passed as argument, or an error if the value passed is not allowed by the enum
func NewOuterEnumDefaultValueFromValue(v string) (*OuterEnumDefaultValue, error) {
	ev := OuterEnumDefaultValue(v)
	if ev.IsValid() {
		return &ev, nil
	} else {
		return nil, fmt.Errorf("invalid value '%v' for OuterEnumDefaultValue: valid values are %v", v, allowedOuterEnumDefaultValueEnumValues)
	}
}

// IsValid return true if the value is valid for the enum, false otherwise
func (v OuterEnumDefaultValue) IsValid() bool {
	for _, existing := range allowedOuterEnumDefaultValueEnumValues {
		if existing == v {
			return true
		}
	}
	return false
}

// Ptr returns reference to OuterEnumDefaultValue value
func (v OuterEnumDefaultValue) Ptr() *OuterEnumDefaultValue {
	return &v
}

type NullableOuterEnumDefaultValue struct {
	value *OuterEnumDefaultValue
	isSet bool
}

func (v NullableOuterEnumDefaultValue) Get() *OuterEnumDefaultValue {
	return v.value
}

func (v *NullableOuterEnumDefaultValue) Set(val *OuterEnumDefaultValue) {
	v.value = val
	v.isSet = true
}

func (v NullableOuterEnumDefaultValue) IsSet() bool {
	return v.isSet
}

func (v *NullableOuterEnumDefaultValue) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableOuterEnumDefaultValue(val *OuterEnumDefaultValue) *NullableOuterEnumDefaultValue {
	return &NullableOuterEnumDefaultValue{value: val, isSet: true}
}

func (v NullableOuterEnumDefaultValue) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableOuterEnumDefaultValue) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
