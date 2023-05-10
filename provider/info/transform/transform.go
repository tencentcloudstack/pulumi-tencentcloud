package transform

import (
	"fmt"
	"strings"

	"github.com/hashicorp/terraform-plugin-sdk/v2/helper/schema"
)

var hardCodedAlters = map[string][]string{
	"tencentcloud_kms_keys": {"key_state", "KmsKeyState"},
	"tencentcloud_kms_key":  {"key_state", "KmsKeyState"},
	"tencentcloud_tsf_task": {"task_state", "TsfTaskState"},
}

func GetConflictFieldOfCsharpModule(key string, fields map[string]*schema.Schema) map[string]string {
	module, entity := ResolveModuleEntity(key)
	result := map[string]string{}
	if v, ok := hardCodedAlters[key]; ok {
		result[v[0]] = v[1]
	}
	for field := range fields {
		if entity == field {
			result[field] = ToPascal(module) + ToPascal(field)
			break
		}
	}
	if len(result) == 0 {
		return nil
	}
	return result
}

func ResolveModuleEntity(key string) (module, entity string) {
	seps := strings.Split(key, "_")[1:] // tencentcloud_foo_bar -> ["foo", "bar"]
	if len(seps) <= 1 {
		return seps[0], "instance"
	}

	if prefix := "tencentcloud_api_gateway"; strings.HasPrefix(key, prefix) {
		return "api_gateway", strings.Join(seps[2:], "_")
	}
	if prefix := "tencentcloud_private_dns"; strings.HasPrefix(key, prefix) {
		return "private_dns", strings.Join(seps[2:], "_")
	}

	return seps[0], strings.Join(seps[1:], "_")
}

func ToPascal(s string) string {
	result := ""
	for _, v := range strings.Split(s, "_") {
		result += fmt.Sprintf("%s%s", strings.ToUpper(v[0:1]), v[1:])
	}
	return result
}
