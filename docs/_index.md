---
title: TencentCloud
meta_desc: Provides an overview of the Tencent Cloud Provider for Pulumi.
layout: overview
---

The Tencent Cloud provider for Pulumi can be used to provision any of the cloud resources available in [Tencent Cloud](https://tencentcloud.com).  
The Tencent Cloud provider must be configured with credentials to deploy and update resources in Tencent Cloud.

## Examples

These examples show how to use multi-language to create a COS Bucket.

{{< chooser language "javascript,typescript,python,go,csharp" >}}

{{% choosable language javascript %}}

```javascript
const tencentcloud = require("@tencentcloud_iac/pulumi");

~async function () {
    const info = await tencentcloud.user.getInfo();
    const myBucket = new tencentcloud.cos.Bucket("myBucket", {
        acl: "private",
        bucket: `pulumi-created-${info.appId}`,
    });
}()

```

{{% /choosable %}} {{% choosable language typescript %}}

```typescript
import * as tencentcloud from "@tencentcloud_iac/pulumi";

~async function () {
    const info = await tencentcloud.user.getInfo();
    const myBucket = new tencentcloud.cos.Bucket("myBucket", {
        acl: "private",
        bucket: `pulumi-created-${info.appId}`,
    });
}()
```

{{% /choosable %}} {{% choosable language python %}}

```python
import tencentcloud_iac_pulumi as tencentcloud

info = tencentcloud.user.get_info()
my_bucket = tencentcloud.cos.Bucket("myBucket",
    acl="private",
    bucket=f"pulumi-created-{info.app_id}")

```

{{% /choosable %}} {{% choosable language go %}}

```go
package main

import (
	"fmt"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/cos"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/user"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		info, err := user.GetInfo(ctx, nil, nil)
		if err != nil {
			return err
		}
		_, err = cos.NewBucket(ctx, "myBucket", &cos.BucketArgs{
			Acl:    pulumi.String("private"),
			Bucket: pulumi.String(fmt.Sprintf("%v%v", "pulumi-created-", info.AppId)),
		})
		if err != nil {
			return err
		}
		return nil
	})
}
```

{{% /choosable %}} {{% choosable language csharp %}}

```csharp
using Tencentcloud = TencentcloudIAC.PulumiPackage.TencentCloud;

class MyStack : Stack
{
    public MyStack()
    {
        var info = Output.Create(Tencentcloud.User.GetInfo.InvokeAsync());
        var myBucket = new Tencentcloud.Cos.Bucket("myBucket", new Tencentcloud.Cos.BucketArgs
        {
            Acl = "private",
            Bucket = info.Apply(info => $"pulumi-created-{info.AppId}"),
        });
    }

}

```

{{% /choosable %}}

{{< /chooser >}}