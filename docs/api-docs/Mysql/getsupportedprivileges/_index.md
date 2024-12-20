
---
title: "getSupportedPrivileges"
title_tag: "tencentcloud.Mysql.getSupportedPrivileges"
meta_desc: "Documentation for the tencentcloud.Mysql.getSupportedPrivileges function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of mysql supported_privileges

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const supportedPrivileges = tencentcloud.Mysql.getSupportedPrivileges({
    instanceId: "cdb-fitq5t9h",
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

supported_privileges = tencentcloud.Mysql.get_supported_privileges(instance_id="cdb-fitq5t9h")
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var supportedPrivileges = Tencentcloud.Mysql.GetSupportedPrivileges.Invoke(new()
    {
        InstanceId = "cdb-fitq5t9h",
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Mysql.GetSupportedPrivileges(ctx, &mysql.GetSupportedPrivilegesArgs{
			InstanceId: "cdb-fitq5t9h",
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
import com.pulumi.tencentcloud.Mysql.MysqlFunctions;
import com.pulumi.tencentcloud.Mysql.inputs.GetSupportedPrivilegesArgs;
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
        final var supportedPrivileges = MysqlFunctions.getSupportedPrivileges(GetSupportedPrivilegesArgs.builder()
            .instanceId("cdb-fitq5t9h")
            .build());

    }
}
```
```yaml
variables:
  supportedPrivileges:
    fn::invoke:
      Function: tencentcloud:Mysql:getSupportedPrivileges
      Arguments:
        instanceId: cdb-fitq5t9h
```
<!--End PulumiCodeChooser -->




## Using getSupportedPrivileges {#using}

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
><span class="k">function </span>getSupportedPrivileges<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetSupportedPrivilegesArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetSupportedPrivilegesResult</a></span>></span
><span class="k">
function </span>getSupportedPrivilegesOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetSupportedPrivilegesOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetSupportedPrivilegesResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_supported_privileges<span class="p">(</span><span class="nx">instance_id</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                             <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                             <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetSupportedPrivilegesResult</span
><span class="k">
def </span>get_supported_privileges_output<span class="p">(</span><span class="nx">instance_id</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                             <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                             <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetSupportedPrivilegesResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetSupportedPrivileges<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetSupportedPrivilegesArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetSupportedPrivilegesResult</a></span>, error)</span
><span class="k">
func </span>GetSupportedPrivilegesOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetSupportedPrivilegesOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetSupportedPrivilegesResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetSupportedPrivileges` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetSupportedPrivileges </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetSupportedPrivilegesResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetSupportedPrivilegesArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetSupportedPrivilegesResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetSupportedPrivilegesInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetSupportedPrivilegesResult</a></span>> </span>getSupportedPrivileges<span class="p">(</span><span class="nx">GetSupportedPrivilegesArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Mysql/getSupportedPrivileges:getSupportedPrivileges
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="instanceid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="instanceid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="instanceid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="instanceid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="instance_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_id_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="instanceid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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




## getSupportedPrivileges Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="columnsupportedprivileges_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#columnsupportedprivileges_csharp" style="color: inherit; text-decoration: inherit;">Column<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd><p>The database column permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="databasesupportedprivileges_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#databasesupportedprivileges_csharp" style="color: inherit; text-decoration: inherit;">Database<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd><p>Database permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="globalsupportedprivileges_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#globalsupportedprivileges_csharp" style="color: inherit; text-decoration: inherit;">Global<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd><p>Global permissions supported by the instance.</p>
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
        <span id="instanceid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tablesupportedprivileges_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tablesupportedprivileges_csharp" style="color: inherit; text-decoration: inherit;">Table<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd><p>Database table permissions supported by the instance.</p>
</dd><dt class="property-"
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
        <span id="columnsupportedprivileges_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#columnsupportedprivileges_go" style="color: inherit; text-decoration: inherit;">Column<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd><p>The database column permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="databasesupportedprivileges_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#databasesupportedprivileges_go" style="color: inherit; text-decoration: inherit;">Database<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd><p>Database permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="globalsupportedprivileges_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#globalsupportedprivileges_go" style="color: inherit; text-decoration: inherit;">Global<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd><p>Global permissions supported by the instance.</p>
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
        <span id="instanceid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tablesupportedprivileges_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tablesupportedprivileges_go" style="color: inherit; text-decoration: inherit;">Table<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd><p>Database table permissions supported by the instance.</p>
</dd><dt class="property-"
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
        <span id="columnsupportedprivileges_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#columnsupportedprivileges_java" style="color: inherit; text-decoration: inherit;">column<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>The database column permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="databasesupportedprivileges_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#databasesupportedprivileges_java" style="color: inherit; text-decoration: inherit;">database<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Database permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="globalsupportedprivileges_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#globalsupportedprivileges_java" style="color: inherit; text-decoration: inherit;">global<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Global permissions supported by the instance.</p>
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
        <span id="instanceid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tablesupportedprivileges_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tablesupportedprivileges_java" style="color: inherit; text-decoration: inherit;">table<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Database table permissions supported by the instance.</p>
</dd><dt class="property-"
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
        <span id="columnsupportedprivileges_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#columnsupportedprivileges_nodejs" style="color: inherit; text-decoration: inherit;">column<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd><p>The database column permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="databasesupportedprivileges_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#databasesupportedprivileges_nodejs" style="color: inherit; text-decoration: inherit;">database<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd><p>Database permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="globalsupportedprivileges_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#globalsupportedprivileges_nodejs" style="color: inherit; text-decoration: inherit;">global<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd><p>Global permissions supported by the instance.</p>
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
        <span id="instanceid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tablesupportedprivileges_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tablesupportedprivileges_nodejs" style="color: inherit; text-decoration: inherit;">table<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd><p>Database table permissions supported by the instance.</p>
</dd><dt class="property-"
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
        <span id="column_supported_privileges_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#column_supported_privileges_python" style="color: inherit; text-decoration: inherit;">column_<wbr>supported_<wbr>privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd><p>The database column permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="database_supported_privileges_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_supported_privileges_python" style="color: inherit; text-decoration: inherit;">database_<wbr>supported_<wbr>privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd><p>Database permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="global_supported_privileges_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#global_supported_privileges_python" style="color: inherit; text-decoration: inherit;">global_<wbr>supported_<wbr>privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd><p>Global permissions supported by the instance.</p>
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
        <span id="instance_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_id_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="table_supported_privileges_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#table_supported_privileges_python" style="color: inherit; text-decoration: inherit;">table_<wbr>supported_<wbr>privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd><p>Database table permissions supported by the instance.</p>
</dd><dt class="property-"
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
        <span id="columnsupportedprivileges_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#columnsupportedprivileges_yaml" style="color: inherit; text-decoration: inherit;">column<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>The database column permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="databasesupportedprivileges_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#databasesupportedprivileges_yaml" style="color: inherit; text-decoration: inherit;">database<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Database permissions supported by the instance.</p>
</dd><dt class="property-"
            title="">
        <span id="globalsupportedprivileges_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#globalsupportedprivileges_yaml" style="color: inherit; text-decoration: inherit;">global<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Global permissions supported by the instance.</p>
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
        <span id="instanceid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tablesupportedprivileges_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tablesupportedprivileges_yaml" style="color: inherit; text-decoration: inherit;">table<wbr>Supported<wbr>Privileges</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Database table permissions supported by the instance.</p>
</dd><dt class="property-"
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

