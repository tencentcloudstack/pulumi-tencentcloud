
---
title: "getInstanceDiskNum"
title_tag: "tencentcloud.Lighthouse.getInstanceDiskNum"
meta_desc: "Documentation for the tencentcloud.Lighthouse.getInstanceDiskNum function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of lighthouse instance_disk_num

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const instanceDiskNum = tencentcloud.Lighthouse.getInstanceDiskNum({
    instanceIds: ["lhins-xxxxxx"],
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

instance_disk_num = tencentcloud.Lighthouse.get_instance_disk_num(instance_ids=["lhins-xxxxxx"])
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var instanceDiskNum = Tencentcloud.Lighthouse.GetInstanceDiskNum.Invoke(new()
    {
        InstanceIds = new[]
        {
            "lhins-xxxxxx",
        },
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Lighthouse"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Lighthouse.GetInstanceDiskNum(ctx, &lighthouse.GetInstanceDiskNumArgs{
			InstanceIds: []string{
				"lhins-xxxxxx",
			},
		}, nil)
		if err != nil {
			return err
		}
		return nil
	})
}
```
```java
package generated_program;

import com.pulumi.Context;
import com.pulumi.Pulumi;
import com.pulumi.core.Output;
import com.pulumi.tencentcloud.Lighthouse.LighthouseFunctions;
import com.pulumi.tencentcloud.Lighthouse.inputs.GetInstanceDiskNumArgs;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.io.File;
import java.nio.file.Files;
import java.nio.file.Paths;

public class App {
    public static void main(String[] args) {
        Pulumi.run(App::stack);
    }

    public static void stack(Context ctx) {
        final var instanceDiskNum = LighthouseFunctions.getInstanceDiskNum(GetInstanceDiskNumArgs.builder()
            .instanceIds("lhins-xxxxxx")
            .build());

    }
}
```
```yaml
variables:
  instanceDiskNum:
    fn::invoke:
      Function: tencentcloud:Lighthouse:getInstanceDiskNum
      Arguments:
        instanceIds:
          - lhins-xxxxxx
```
<!--End PulumiCodeChooser -->




## Using getInstanceDiskNum {#using}

Two invocation forms are available. The direct form accepts plain
arguments and either blocks until the result value is available, or
returns a Promise-wrapped result. The output form accepts
Input-wrapped arguments and returns an Output-wrapped result.

<div>
<pulumi-chooser type="language" options="typescript,python,go,csharp,java,yaml"></pulumi-chooser>
</div>


<div>
<pulumi-choosable type="language" values="javascript,typescript">
<div class="highlight"
><pre class="chroma"><code class="language-typescript" data-lang="typescript"
><span class="k">function </span>getInstanceDiskNum<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetInstanceDiskNumArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetInstanceDiskNumResult</a></span>></span
><span class="k">
function </span>getInstanceDiskNumOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetInstanceDiskNumOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetInstanceDiskNumResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_instance_disk_num<span class="p">(</span><span class="nx">instance_ids</span><span class="p">:</span> <span class="nx">Optional[Sequence[str]]</span> = None<span class="p">,</span>
                          <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                          <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetInstanceDiskNumResult</span
><span class="k">
def </span>get_instance_disk_num_output<span class="p">(</span><span class="nx">instance_ids</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]</span> = None<span class="p">,</span>
                          <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                          <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetInstanceDiskNumResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetInstanceDiskNum<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetInstanceDiskNumArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetInstanceDiskNumResult</a></span>, error)</span
><span class="k">
func </span>GetInstanceDiskNumOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetInstanceDiskNumOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetInstanceDiskNumResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetInstanceDiskNum` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetInstanceDiskNum </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetInstanceDiskNumResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetInstanceDiskNumArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetInstanceDiskNumResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetInstanceDiskNumInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetInstanceDiskNumResult</a></span>> </span>getInstanceDiskNum<span class="p">(</span><span class="nx">GetInstanceDiskNumArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Lighthouse/getInstanceDiskNum:getInstanceDiskNum
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="instanceids_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd><p>List of instance IDs.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_csharp" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="instanceids_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd><p>List of instance IDs.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_go" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="instanceids_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>List of instance IDs.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_java" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="instanceids_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd><p>List of instance IDs.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_nodejs" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="instance_ids_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_ids_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd><p>List of instance IDs.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="result_output_file_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#result_output_file_python" style="color: inherit; text-decoration: inherit;">result_<wbr>output_<wbr>file</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="instanceids_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>List of instance IDs.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_yaml" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>




## getInstanceDiskNum Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="attachdetailsets_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attachdetailsets_csharp" style="color: inherit; text-decoration: inherit;">Attach<wbr>Detail<wbr>Sets</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancedisknumattachdetailset">List&lt;Tencent<wbr>Cloud<wbr>IAC.<wbr>Pulumi<wbr>Package.<wbr>Tencentcloud.<wbr>Lighthouse.<wbr>Outputs.<wbr>Get<wbr>Instance<wbr>Disk<wbr>Num<wbr>Attach<wbr>Detail<wbr>Set&gt;</a></span>
    </dt>
    <dd><p>Mount information list.</p>
</dd><dt class="property-"
            title="">
        <span id="id_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_csharp" style="color: inherit; text-decoration: inherit;">Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceids_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="resultoutputfile_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_csharp" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="attachdetailsets_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attachdetailsets_go" style="color: inherit; text-decoration: inherit;">Attach<wbr>Detail<wbr>Sets</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancedisknumattachdetailset">[]Get<wbr>Instance<wbr>Disk<wbr>Num<wbr>Attach<wbr>Detail<wbr>Set</a></span>
    </dt>
    <dd><p>Mount information list.</p>
</dd><dt class="property-"
            title="">
        <span id="id_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_go" style="color: inherit; text-decoration: inherit;">Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceids_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="resultoutputfile_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_go" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="attachdetailsets_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attachdetailsets_java" style="color: inherit; text-decoration: inherit;">attach<wbr>Detail<wbr>Sets</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancedisknumattachdetailset">List&lt;Get<wbr>Instance<wbr>Disk<wbr>Num<wbr>Attach<wbr>Detail<wbr>Set&gt;</a></span>
    </dt>
    <dd><p>Mount information list.</p>
</dd><dt class="property-"
            title="">
        <span id="id_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_java" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceids_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="resultoutputfile_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_java" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="attachdetailsets_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attachdetailsets_nodejs" style="color: inherit; text-decoration: inherit;">attach<wbr>Detail<wbr>Sets</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancedisknumattachdetailset">Get<wbr>Instance<wbr>Disk<wbr>Num<wbr>Attach<wbr>Detail<wbr>Set[]</a></span>
    </dt>
    <dd><p>Mount information list.</p>
</dd><dt class="property-"
            title="">
        <span id="id_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_nodejs" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceids_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="resultoutputfile_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_nodejs" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="attach_detail_sets_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attach_detail_sets_python" style="color: inherit; text-decoration: inherit;">attach_<wbr>detail_<wbr>sets</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancedisknumattachdetailset">Get<wbr>Instance<wbr>Disk<wbr>Num<wbr>Attach<wbr>Detail<wbr>Set]</a></span>
    </dt>
    <dd><p>Mount information list.</p>
</dd><dt class="property-"
            title="">
        <span id="id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_python" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instance_ids_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_ids_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="result_output_file_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#result_output_file_python" style="color: inherit; text-decoration: inherit;">result_<wbr>output_<wbr>file</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="attachdetailsets_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attachdetailsets_yaml" style="color: inherit; text-decoration: inherit;">attach<wbr>Detail<wbr>Sets</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancedisknumattachdetailset">List&lt;Property Map&gt;</a></span>
    </dt>
    <dd><p>Mount information list.</p>
</dd><dt class="property-"
            title="">
        <span id="id_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_yaml" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceids_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceids_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="resultoutputfile_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_yaml" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>




## Supporting Types


<h4 id="getinstancedisknumattachdetailset">Get<wbr>Instance<wbr>Disk<wbr>Num<wbr>Attach<wbr>Detail<wbr>Set</h4>



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="attacheddiskcount_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attacheddiskcount_csharp" style="color: inherit; text-decoration: inherit;">Attached<wbr>Disk<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of elastic cloud disks mounted to the instance.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance Id.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="maxattachcount_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#maxattachcount_csharp" style="color: inherit; text-decoration: inherit;">Max<wbr>Attach<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of elastic cloud disks that can be mounted.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="attacheddiskcount_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attacheddiskcount_go" style="color: inherit; text-decoration: inherit;">Attached<wbr>Disk<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of elastic cloud disks mounted to the instance.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance Id.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="maxattachcount_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#maxattachcount_go" style="color: inherit; text-decoration: inherit;">Max<wbr>Attach<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of elastic cloud disks that can be mounted.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="attacheddiskcount_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attacheddiskcount_java" style="color: inherit; text-decoration: inherit;">attached<wbr>Disk<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Number of elastic cloud disks mounted to the instance.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Instance Id.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="maxattachcount_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#maxattachcount_java" style="color: inherit; text-decoration: inherit;">max<wbr>Attach<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Number of elastic cloud disks that can be mounted.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="attacheddiskcount_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attacheddiskcount_nodejs" style="color: inherit; text-decoration: inherit;">attached<wbr>Disk<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Number of elastic cloud disks mounted to the instance.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance Id.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="maxattachcount_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#maxattachcount_nodejs" style="color: inherit; text-decoration: inherit;">max<wbr>Attach<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Number of elastic cloud disks that can be mounted.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="attached_disk_count_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attached_disk_count_python" style="color: inherit; text-decoration: inherit;">attached_<wbr>disk_<wbr>count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of elastic cloud disks mounted to the instance.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instance_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_id_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Instance Id.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="max_attach_count_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#max_attach_count_python" style="color: inherit; text-decoration: inherit;">max_<wbr>attach_<wbr>count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of elastic cloud disks that can be mounted.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="attacheddiskcount_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attacheddiskcount_yaml" style="color: inherit; text-decoration: inherit;">attached<wbr>Disk<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Number of elastic cloud disks mounted to the instance.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Instance Id.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="maxattachcount_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#maxattachcount_yaml" style="color: inherit; text-decoration: inherit;">max<wbr>Attach<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Number of elastic cloud disks that can be mounted.</p>
</dd></dl>
</pulumi-choosable>
</div>





<h2 id="package-details">Package Details</h2>
<dl class="package-details">
	<dt>Repository</dt>
	<dd><a href="https://github.com/tencentcloudstack/pulumi-tencentcloud">tencentcloud tencentcloudstack/pulumi-tencentcloud</a></dd>
	<dt>License</dt>
	<dd>Apache-2.0</dd>
	<dt>Notes</dt>
	<dd><p>This Pulumi package is based on the <a href="https://github.com/tencentcloudstack/terraform-provider-tencentcloud"><code>tencentcloud</code> Terraform Provider</a>.</p>
</dd>
</dl>
