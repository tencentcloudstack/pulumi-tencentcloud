# TencentCloud Resource Provider

The TencentCloud Resource Provider lets you manage [TencentCloud](https://cloud.tencent.com/) resources.

## Installing

### Install tencentcloud provider

The sdks installation will fully support package auto download in the future, now we recommend downloading manually:

```bash
pulumi plugin install resource tencentcloud --server github://api.github.com/tencentcloudstack
```

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @tencentcloud_iac/pulumi
```

or `yarn`:

```bash
yarn add @tencentcloud_iac/pulumi
```

### Python

To use from Python, install using `pip`:

```bash
pip install tencentcloud_iac_pulumi
```

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/...
```

## Configuration

The following configuration points are available for the `tencentcloud` provider:

#### Secret ID
The API Secret ID, read from environment variable `TENCENTCLOUD_SECRET_ID` if not preset.

    $ pulumi config set tencentcloud:secretId [your-secret-id] --secret

#### Secret Key
The API Secret Key, read from environment variable `TENCENTCLOUD_SECRET_KEY` if not preset.

    $ pulumi config set tencentcloud:secretKey [your-secret-key] --secret

#### Security Token
The Security Token for temporary access, read from environment variable `TENCENTCLOUD_SECURITY_TOKEN` if not preset.

    $ pulumi config set tencentcloud:securityToken [your-security-token] --secret

#### Region
The region in which to deploy resources, read from environment variable `TENCENTCLOUD_REGION` if not preset.

    $ pulumi config set tencentcloud:region ap-singapore


## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/tencentcloud/api-docs/).
