# TencentCloud Resource Provider

The TencentCloud Resource Provider lets you manage [TencentCloud](https://cloud.tencent.com/) resources.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @pulumi/tencentcloud
```

or `yarn`:

```bash
yarn add @pulumi/tencentcloud
```

### Python

To use from Python, install using `pip`:

```bash
pip install pulumi_tencentcloud
```

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/...
```

### .NET

To use from .NET, install using `dotnet add package`:

```bash
dotnet add package Pulumi.TencentCloud
```

## Configuration

The following configuration points are available for the `tencentcloud` provider:

- `tencentcloud:secretId` (environment: `TENCENTCLOUD_SECRET_ID`) - the API Secret ID for `tencentcloud`
- `tencentcloud:secretKey` (environment: `TENCENTCLOUD_SECRET_KEY`) - the API Secret Key for `tencentcloud`
- `tencentcloud:region` (environment: `TENCENTCLOUD_REGION`) - the region in which to deploy resources

## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/tencentcloud/api-docs/).
