// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package teo

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "tencentcloud:Teo/accelerationDomain:AccelerationDomain":
		r = &AccelerationDomain{}
	case "tencentcloud:Teo/applicationProxy:ApplicationProxy":
		r = &ApplicationProxy{}
	case "tencentcloud:Teo/applicationProxyRule:ApplicationProxyRule":
		r = &ApplicationProxyRule{}
	case "tencentcloud:Teo/certificateConfig:CertificateConfig":
		r = &CertificateConfig{}
	case "tencentcloud:Teo/function:Function":
		r = &Function{}
	case "tencentcloud:Teo/functionRule:FunctionRule":
		r = &FunctionRule{}
	case "tencentcloud:Teo/functionRulePriority:FunctionRulePriority":
		r = &FunctionRulePriority{}
	case "tencentcloud:Teo/functionRuntimeEnvironment:FunctionRuntimeEnvironment":
		r = &FunctionRuntimeEnvironment{}
	case "tencentcloud:Teo/l4Proxy:L4Proxy":
		r = &L4Proxy{}
	case "tencentcloud:Teo/originGroup:OriginGroup":
		r = &OriginGroup{}
	case "tencentcloud:Teo/ownershipVerify:OwnershipVerify":
		r = &OwnershipVerify{}
	case "tencentcloud:Teo/realtimeLogDelivery:RealtimeLogDelivery":
		r = &RealtimeLogDelivery{}
	case "tencentcloud:Teo/ruleEngine:RuleEngine":
		r = &RuleEngine{}
	case "tencentcloud:Teo/securityIpGroup:SecurityIpGroup":
		r = &SecurityIpGroup{}
	case "tencentcloud:Teo/zone:Zone":
		r = &Zone{}
	case "tencentcloud:Teo/zoneSetting:ZoneSetting":
		r = &ZoneSetting{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := internal.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/accelerationDomain",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/applicationProxy",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/applicationProxyRule",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/certificateConfig",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/function",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/functionRule",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/functionRulePriority",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/functionRuntimeEnvironment",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/l4Proxy",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/originGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/ownershipVerify",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/realtimeLogDelivery",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/ruleEngine",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/securityIpGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/zone",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Teo/zoneSetting",
		&module{version},
	)
}
