
---
title: "getOrgShareArea"
title_tag: "tencentcloud.Organization.getOrgShareArea"
meta_desc: "Documentation for the tencentcloud.Organization.getOrgShareArea function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of organization org_share_area

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const orgShareArea = tencentcloud.Organization.getOrgShareArea({
    lang: "zh",
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

org_share_area = tencentcloud.Organization.get_org_share_area(lang="zh")
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var orgShareArea = Tencentcloud.Organization.GetOrgShareArea.Invoke(new()
    {
        Lang = "zh",
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Organization"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Organization.GetOrgShareArea(ctx, &organization.GetOrgShareAreaArgs{
			Lang: pulumi.StringRef("zh"),
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
import com.pulumi.tencentcloud.Organization.OrganizationFunctions;
import com.pulumi.tencentcloud.Organization.inputs.GetOrgShareAreaArgs;
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
        final var orgShareArea = OrganizationFunctions.getOrgShareArea(GetOrgShareAreaArgs.builder()
            .lang("zh")
            .build());

    }
}
```
```yaml
variables:
  orgShareArea:
    fn::invoke:
      Function: tencentcloud:Organization:getOrgShareArea
      Arguments:
        lang: zh
```
<!--End PulumiCodeChooser -->




## Using getOrgShareArea {#using}

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
><span class="k">function </span>getOrgShareArea<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetOrgShareAreaArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetOrgShareAreaResult</a></span>></span
><span class="k">
function </span>getOrgShareAreaOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetOrgShareAreaOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetOrgShareAreaResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_org_share_area<span class="p">(</span><span class="nx">lang</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                       <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                       <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetOrgShareAreaResult</span
><span class="k">
def </span>get_org_share_area_output<span class="p">(</span><span class="nx">lang</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                       <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                       <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetOrgShareAreaResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetOrgShareArea<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetOrgShareAreaArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetOrgShareAreaResult</a></span>, error)</span
><span class="k">
func </span>GetOrgShareAreaOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetOrgShareAreaOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetOrgShareAreaResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetOrgShareArea` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetOrgShareArea </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetOrgShareAreaResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetOrgShareAreaArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetOrgShareAreaResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetOrgShareAreaInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetOrgShareAreaResult</a></span>> </span>getOrgShareArea<span class="p">(</span><span class="nx">GetOrgShareAreaArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Organization/getOrgShareArea:getOrgShareArea
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="lang_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_csharp" style="color: inherit; text-decoration: inherit;">Lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Language.default zh.
Valid values:</p>
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
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="lang_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_go" style="color: inherit; text-decoration: inherit;">Lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Language.default zh.
Valid values:</p>
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
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="lang_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_java" style="color: inherit; text-decoration: inherit;">lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Language.default zh.
Valid values:</p>
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
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="lang_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_nodejs" style="color: inherit; text-decoration: inherit;">lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Language.default zh.
Valid values:</p>
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
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="lang_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_python" style="color: inherit; text-decoration: inherit;">lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Language.default zh.
Valid values:</p>
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
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="lang_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_yaml" style="color: inherit; text-decoration: inherit;">lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Language.default zh.
Valid values:</p>
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




## getOrgShareArea Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
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
        <span id="items_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_csharp" style="color: inherit; text-decoration: inherit;">Items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getorgshareareaitem">List&lt;Tencent<wbr>Cloud<wbr>IAC.<wbr>Pulumi<wbr>Package.<wbr>Tencentcloud.<wbr>Organization.<wbr>Outputs.<wbr>Get<wbr>Org<wbr>Share<wbr>Area<wbr>Item&gt;</a></span>
    </dt>
    <dd><p>Area list.</p>
</dd><dt class="property-"
            title="">
        <span id="lang_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_csharp" style="color: inherit; text-decoration: inherit;">Lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
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
        <span id="id_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_go" style="color: inherit; text-decoration: inherit;">Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="items_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_go" style="color: inherit; text-decoration: inherit;">Items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getorgshareareaitem">[]Get<wbr>Org<wbr>Share<wbr>Area<wbr>Item</a></span>
    </dt>
    <dd><p>Area list.</p>
</dd><dt class="property-"
            title="">
        <span id="lang_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_go" style="color: inherit; text-decoration: inherit;">Lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
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
        <span id="id_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_java" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="items_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_java" style="color: inherit; text-decoration: inherit;">items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getorgshareareaitem">List&lt;Get<wbr>Org<wbr>Share<wbr>Area<wbr>Item&gt;</a></span>
    </dt>
    <dd><p>Area list.</p>
</dd><dt class="property-"
            title="">
        <span id="lang_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_java" style="color: inherit; text-decoration: inherit;">lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
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
        <span id="id_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_nodejs" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="items_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_nodejs" style="color: inherit; text-decoration: inherit;">items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getorgshareareaitem">Get<wbr>Org<wbr>Share<wbr>Area<wbr>Item[]</a></span>
    </dt>
    <dd><p>Area list.</p>
</dd><dt class="property-"
            title="">
        <span id="lang_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_nodejs" style="color: inherit; text-decoration: inherit;">lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
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
        <span id="id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_python" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="items_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_python" style="color: inherit; text-decoration: inherit;">items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getorgshareareaitem">Get<wbr>Org<wbr>Share<wbr>Area<wbr>Item]</a></span>
    </dt>
    <dd><p>Area list.</p>
</dd><dt class="property-"
            title="">
        <span id="lang_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_python" style="color: inherit; text-decoration: inherit;">lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
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
        <span id="id_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_yaml" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="items_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_yaml" style="color: inherit; text-decoration: inherit;">items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getorgshareareaitem">List&lt;Property Map&gt;</a></span>
    </dt>
    <dd><p>Area list.</p>
</dd><dt class="property-"
            title="">
        <span id="lang_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#lang_yaml" style="color: inherit; text-decoration: inherit;">lang</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
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


<h4 id="getorgshareareaitem">Get<wbr>Org<wbr>Share<wbr>Area<wbr>Item</h4>



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="area_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#area_csharp" style="color: inherit; text-decoration: inherit;">Area</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Region identifier.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="areaid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#areaid_csharp" style="color: inherit; text-decoration: inherit;">Area<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Region ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="name_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_csharp" style="color: inherit; text-decoration: inherit;">Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Region name.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="area_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#area_go" style="color: inherit; text-decoration: inherit;">Area</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Region identifier.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="areaid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#areaid_go" style="color: inherit; text-decoration: inherit;">Area<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Region ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="name_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_go" style="color: inherit; text-decoration: inherit;">Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Region name.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="area_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#area_java" style="color: inherit; text-decoration: inherit;">area</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Region identifier.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="areaid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#areaid_java" style="color: inherit; text-decoration: inherit;">area<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Region ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="name_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_java" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Region name.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="area_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#area_nodejs" style="color: inherit; text-decoration: inherit;">area</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Region identifier.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="areaid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#areaid_nodejs" style="color: inherit; text-decoration: inherit;">area<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Region ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="name_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_nodejs" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Region name.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="area_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#area_python" style="color: inherit; text-decoration: inherit;">area</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Region identifier.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="area_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#area_id_python" style="color: inherit; text-decoration: inherit;">area_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Region ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="name_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_python" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Region name.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="area_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#area_yaml" style="color: inherit; text-decoration: inherit;">area</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Region identifier.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="areaid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#areaid_yaml" style="color: inherit; text-decoration: inherit;">area<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Region ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="name_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_yaml" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Region name.</p>
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
