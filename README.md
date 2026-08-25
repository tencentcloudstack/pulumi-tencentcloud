# Pulumi TencentCloud Resource Provider

[![Apache 2.0 License](https://img.shields.io/github/license/tencentcloudstack/pulumi-tencentcloud.svg)](LICENSE)
[![NPM version](https://img.shields.io/npm/v/@tencentcloud_iac/pulumi.svg)](https://www.npmjs.com/package/@tencentcloud_iac/pulumi)
[![PyPI version](https://img.shields.io/pypi/v/tencentcloud-iac-pulumi.svg)](https://pypi.org/project/tencentcloud-iac-pulumi/)
[![Go Reference](https://pkg.go.dev/badge/github.com/tencentcloudstack/pulumi-tencentcloud/sdk.svg)](https://pkg.go.dev/github.com/tencentcloudstack/pulumi-tencentcloud/sdk)
[![NuGet version](https://img.shields.io/nuget/v/TencentCloudIAC.PulumiPackage.Tencentcloud.svg)](https://www.nuget.org/packages/TencentCloudIAC.PulumiPackage.Tencentcloud)

<div>
  <p>
    <a href="https://www.tencentcloud.com">
        <img src=".github/01_Tcloud_logo_Eng.png" alt="logo" title="Terraform" height="69">
    </a>
    <br>
    <i>Tencent Infrastructure Automation for Pulumi.</i>
    <br>
  </p>
</div>

The Pulumi TencentCloud Resource Provider lets you manage [TencentCloud](https://www.tencentcloud.com/) resources using Pulumi.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

```bash
npm install @tencentcloud_iac/pulumi   # or: yarn add @tencentcloud_iac/pulumi
```

### Python

```bash
pip install tencentcloud-iac-pulumi
```

### Go

```bash
go get github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/...
```

### .NET

```bash
dotnet add package TencentCloudIAC.PulumiPackage.Tencentcloud
```

> **Note:** Package auto-download of the provider plugin is not yet
> supported. Install the provider plugin manually before running
> `pulumi up`:
>
> ```bash
> pulumi plugin install resource tencentcloud --server github://api.github.com/tencentcloudstack
> ```

## Configuration

The following configuration points are available for the `tencentcloud` provider:

| Key | Required | Description | Environment Variable |
|---|---|---|---|
| `secretId` | Yes | The API Secret ID | `TENCENTCLOUD_SECRET_ID` |
| `secretKey` | Yes | The API Secret Key | `TENCENTCLOUD_SECRET_KEY` |
| `region` | Yes | The region in which to deploy resources | `TENCENTCLOUD_REGION` |
| `securityToken` | No | The Security Token for temporary access | `TENCENTCLOUD_SECURITY_TOKEN` |

Set them via `pulumi config`:

```bash
pulumi config set tencentcloud:secretId <your-secret-id> --secret
pulumi config set tencentcloud:secretKey <your-secret-key> --secret
pulumi config set tencentcloud:region ap-singapore
```

## Example

```typescript
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const vpc = new tencentcloud.vpc.Instance("my-vpc", {
    name: "pulumi-vpc",
    cidrBlock: "10.0.0.0/20",
});
```

See [examples/](./examples) for complete, runnable projects.

## Reference

For detailed reference documentation, see the [docs](./docs) directory or the
[Pulumi Registry](https://www.pulumi.com/registry/packages/tencentcloud/).

## Contributing

Please read [CONTRIBUTING.md](./CONTRIBUTING.md) for details on our code of
conduct and the process for submitting pull requests.

## License

This project is licensed under the Apache 2.0 License — see [LICENSE](./LICENSE).
