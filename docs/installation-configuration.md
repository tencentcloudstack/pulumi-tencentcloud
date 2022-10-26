---
title: TencentCloud Setup
meta_desc: Provides an overview on how to configure credentials and region for the Pulumi Tencent Cloud Provider
layout: installation
---

The Pulumi Tencent Cloud Provider uses Tencent Cloud SDK to manage and provision resources.

## Installation

The Tencent Cloud provider is available as a package in the following Pulumi languages:

- JavaScript/TypeScript: [@tencentcloud_iac/pulumi](https://www.npmjs.com/package/@tencentcloud_iac/pulumi)
- Python: [tencentcloud-iac-pulumi](https://pypi.org/manage/project/tencentcloud-iac-pulumi/releases)
- Go: [github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go](github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go)
- .Net: [TencentCloudIAC.PulumiPackage.Tencentcloud](https://www.nuget.org/packages/TencentCloudIAC.PulumiPackage.Tencentcloud) 

## Configurations

The following configuration are available for the `tencentcloud` provider:
- `secretId`: (Required) The API Secret ID.
- `secretIKey`: (Required) The API Secret Key.
- `region`: (Required) The region in which to deploy resources.
- `securityToken`: (Optional) The Security Token for temporary access.

Run `pulumi config set` to configure:

```bash
pulumi config set tencentcloud:secretId <your_secret_id> --secret
pulumi config set tencentcloud:secretKey <your_secret_key> --secret
pulumi config set tencentcloud:region ap-singapore

pulumi config set tencentcloud:securityToken <your_security_token_if_needed> --secret
```

You can also configure these value by environment variables:

```bash
export TENCENTCLOUD_SECRET_ID=<your_secret_id>
export TENCENTCLOUD_SECRET_KEY=<your_secret_key>
export TENCENTCLOUD_REGION=ap-singapore

export TENCENTCLOUD_SECURITY_TOKEN=<your_secret_token_if_needed>
```
