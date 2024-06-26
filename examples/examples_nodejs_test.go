//go:build nodejs || all
// +build nodejs all

package examples

import (
	"path/filepath"
	"testing"

	"github.com/pulumi/pulumi/pkg/v3/testing/integration"
)

func getJSBaseOptions(t *testing.T) integration.ProgramTestOptions {
	base := getBaseOptions()
	baseJS := base.With(integration.ProgramTestOptions{
		Dependencies: []string{
			"@tencentcloud_iac/pulumi",
		},
	})
	return baseJS
}

func TestAccTencentCloudVPCTypeScript(t *testing.T) {
	test := getJSBaseOptions(t).
		With(integration.ProgramTestOptions{
			Dir:     filepath.Join(getCwd(t), "vpc", "ts"),
			Config:  config,
			Secrets: secrets,
		})
	integration.ProgramTest(t, &test)
}
