//go:build nodejs || all
// +build nodejs all

package examples

import (
	"testing"

	"github.com/pulumi/pulumi/pkg/v3/testing/integration"
)

func getJSBaseOptions(t *testing.T) integration.ProgramTestOptions {
	base := getBaseOptions()
	baseJS := base.With(integration.ProgramTestOptions{
		Dependencies: []string{
			"@pulumi/tencentcloud",
		},
	})
	return baseJS
}


func TestFoo(t *testing.T) {
	t.Errorf("I will not implement this e2e testcase until the personal account binding was figured out!")
}
