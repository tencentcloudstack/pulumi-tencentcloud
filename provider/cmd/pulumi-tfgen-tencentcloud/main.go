// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package main

import (
	"encoding/json"
	"log"
	"os"
	"regexp"
	"strings"

	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfgen"
	"github.com/pulumi/pulumi/pkg/v3/codegen/schema"
	tencentcloud "github.com/tencentcloudstack/pulumi-tencentcloud/provider"
	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/pkg/version"
)

func main() {
	tfgen.Main("tencentcloud", version.Version, tencentcloud.Provider())
	temporaryReplaceCodeExampleImportStatement()
}

// Hacking import statement replacement '@pulumi/tencentcloud' -> '@tencentcloud_iac/pulumi'
// This function takes NO effect to example of `sdk/nodejs`
func temporaryReplaceCodeExampleImportStatement() {
	schemaPath := "./provider/cmd/pulumi-resource-tencentcloud/schema.json"
	schemaContents, err := os.ReadFile(schemaPath)
	if err != nil {
		log.Fatal(err)
	}

	var packageSpec schema.PackageSpec
	err = json.Unmarshal(schemaContents, &packageSpec)
	if err != nil {
		log.Fatalf("cannot deserialize schema: %v", err)
	}

	mismatchImportPathRE := regexp.MustCompile(`import \* as pulumi from "@tencentcloud_iac/pulumi";`)

	for i := range packageSpec.Functions {
		f := packageSpec.Functions[i]
		desc := f.Description
		f.Description = mismatchImportPathRE.ReplaceAllString(desc, "")
		f.Description = strings.ReplaceAll(desc,
			"\nimport * as tencentcloud from \"@pulumi/tencentcloud\";",
			"\nimport * as tencentcloud from \"@tencentcloud_iac/pulumi\";")
		packageSpec.Functions[i] = f
	}

	for i := range packageSpec.Resources {
		r := packageSpec.Resources[i]
		desc := r.Description
		r.Description = mismatchImportPathRE.ReplaceAllString(desc, "")
		r.Description = strings.ReplaceAll(desc,
			"\nimport * as tencentcloud from \"@pulumi/tencentcloud\";",
			"\nimport * as tencentcloud from \"@tencentcloud_iac/pulumi\";")
		packageSpec.Resources[i] = r
	}

	b, err := json.MarshalIndent(packageSpec, "", "    ")
	if err != nil {
		log.Fatal(err) // Check the error returned by json.MarshalIndent
	}

	if err := os.WriteFile(schemaPath, b, 0600); err != nil {
		log.Fatal(err)
	}
}
