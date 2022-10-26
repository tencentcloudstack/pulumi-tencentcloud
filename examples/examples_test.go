package examples

import (
	"os"
	"path/filepath"
	"testing"

	"github.com/pulumi/pulumi/pkg/v3/testing/integration"
)

func getCwd(t *testing.T) string {
	cwd, err := os.Getwd()
	if err != nil {
		t.FailNow()
	}

	return cwd
}

func getBaseOptions() integration.ProgramTestOptions {
	return integration.ProgramTestOptions{
		RunUpdateTest:        false,
		ExpectRefreshChanges: true,
	}
}

func TestAccTencentCloudVPCGo(t *testing.T) {
	test := getBaseOptions().
		With(integration.ProgramTestOptions{
			Dir:     filepath.Join(getCwd(t), "vpc", "go"),
			Config:  config,
			Secrets: secrets,
		})
	integration.ProgramTest(t, &test)
}
