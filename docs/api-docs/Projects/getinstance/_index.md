
---
title: "getInstance"
title_tag: "tencentcloud.Projects.getInstance"
meta_desc: "Documentation for the tencentcloud.Projects.getInstance function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of tag project

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const project = tencentcloud.Projects.getInstance({
    allList: 1,
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

project = tencentcloud.Projects.get_instance(all_list=1)
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var project = Tencentcloud.Projects.GetInstance.Invoke(new()
    {
        AllList = 1,
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Projects"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Projects.GetInstance(ctx, &projects.GetInstanceArgs{
			AllList: 1,
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
import com.pulumi.tencentcloud.Projects.ProjectsFunctions;
import com.pulumi.tencentcloud.Projects.inputs.GetInstanceArgs;
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
        final var project = ProjectsFunctions.getInstance(GetInstanceArgs.builder()
            .allList(1)
            .build());

    }
}
```
```yaml
variables:
  project:
    fn::invoke:
      Function: tencentcloud:Projects:getInstance
      Arguments:
        allList: 1
```
<!--End PulumiCodeChooser -->




## Using getInstance {#using}

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
><span class="k">function </span>getInstance<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetInstanceArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetInstanceResult</a></span>></span
><span class="k">
function </span>getInstanceOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetInstanceOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetInstanceResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_instance<span class="p">(</span><span class="nx">all_list</span><span class="p">:</span> <span class="nx">Optional[int]</span> = None<span class="p">,</span>
                 <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                 <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetInstanceResult</span
><span class="k">
def </span>get_instance_output<span class="p">(</span><span class="nx">all_list</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[int]]</span> = None<span class="p">,</span>
                 <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                 <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetInstanceResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetInstance<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetInstanceArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetInstanceResult</a></span>, error)</span
><span class="k">
func </span>GetInstanceOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetInstanceOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetInstanceResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetInstance` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetInstance </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetInstanceResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetInstanceArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetInstanceResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetInstanceInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetInstanceResult</a></span>> </span>getInstance<span class="p">(</span><span class="nx">GetInstanceArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Projects/getInstance:getInstance
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="alllist_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_csharp" style="color: inherit; text-decoration: inherit;">All<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>1 means to list all project, 0 means to list visible project.</p>
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
        <span id="alllist_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_go" style="color: inherit; text-decoration: inherit;">All<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>1 means to list all project, 0 means to list visible project.</p>
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
        <span id="alllist_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_java" style="color: inherit; text-decoration: inherit;">all<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>1 means to list all project, 0 means to list visible project.</p>
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
        <span id="alllist_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_nodejs" style="color: inherit; text-decoration: inherit;">all<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>1 means to list all project, 0 means to list visible project.</p>
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
        <span id="all_list_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#all_list_python" style="color: inherit; text-decoration: inherit;">all_<wbr>list</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>1 means to list all project, 0 means to list visible project.</p>
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
        <span id="alllist_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_yaml" style="color: inherit; text-decoration: inherit;">all<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>1 means to list all project, 0 means to list visible project.</p>
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




## getInstance Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="alllist_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_csharp" style="color: inherit; text-decoration: inherit;">All<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="projects_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projects_csharp" style="color: inherit; text-decoration: inherit;">Projects</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstanceproject">List&lt;Tencent<wbr>Cloud<wbr>IAC.<wbr>Pulumi<wbr>Package.<wbr>Tencentcloud.<wbr>Projects.<wbr>Outputs.<wbr>Get<wbr>Instance<wbr>Project&gt;</a></span>
    </dt>
    <dd><p>List of projects.</p>
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
        <span id="alllist_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_go" style="color: inherit; text-decoration: inherit;">All<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="projects_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projects_go" style="color: inherit; text-decoration: inherit;">Projects</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstanceproject">[]Get<wbr>Instance<wbr>Project</a></span>
    </dt>
    <dd><p>List of projects.</p>
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
        <span id="alllist_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_java" style="color: inherit; text-decoration: inherit;">all<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="projects_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projects_java" style="color: inherit; text-decoration: inherit;">projects</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstanceproject">List&lt;Get<wbr>Instance<wbr>Project&gt;</a></span>
    </dt>
    <dd><p>List of projects.</p>
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
        <span id="alllist_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_nodejs" style="color: inherit; text-decoration: inherit;">all<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="projects_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projects_nodejs" style="color: inherit; text-decoration: inherit;">projects</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstanceproject">Get<wbr>Instance<wbr>Project[]</a></span>
    </dt>
    <dd><p>List of projects.</p>
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
        <span id="all_list_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#all_list_python" style="color: inherit; text-decoration: inherit;">all_<wbr>list</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="projects_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projects_python" style="color: inherit; text-decoration: inherit;">projects</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstanceproject">Get<wbr>Instance<wbr>Project]</a></span>
    </dt>
    <dd><p>List of projects.</p>
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
        <span id="alllist_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#alllist_yaml" style="color: inherit; text-decoration: inherit;">all<wbr>List</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="projects_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projects_yaml" style="color: inherit; text-decoration: inherit;">projects</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstanceproject">List&lt;Property Map&gt;</a></span>
    </dt>
    <dd><p>List of projects.</p>
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




## Supporting Types


<h4 id="getinstanceproject">Get<wbr>Instance<wbr>Project</h4>



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="createtime_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#createtime_csharp" style="color: inherit; text-decoration: inherit;">Create<wbr>Time</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Create time.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="creatoruin_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#creatoruin_csharp" style="color: inherit; text-decoration: inherit;">Creator<wbr>Uin</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Uin of Creator.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectid_csharp" style="color: inherit; text-decoration: inherit;">Project<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>ID of Project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectinfo_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectinfo_csharp" style="color: inherit; text-decoration: inherit;">Project<wbr>Info</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Description of project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectname_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectname_csharp" style="color: inherit; text-decoration: inherit;">Project<wbr>Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of Project.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="createtime_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#createtime_go" style="color: inherit; text-decoration: inherit;">Create<wbr>Time</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Create time.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="creatoruin_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#creatoruin_go" style="color: inherit; text-decoration: inherit;">Creator<wbr>Uin</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Uin of Creator.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectid_go" style="color: inherit; text-decoration: inherit;">Project<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>ID of Project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectinfo_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectinfo_go" style="color: inherit; text-decoration: inherit;">Project<wbr>Info</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Description of project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectname_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectname_go" style="color: inherit; text-decoration: inherit;">Project<wbr>Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of Project.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="createtime_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#createtime_java" style="color: inherit; text-decoration: inherit;">create<wbr>Time</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Create time.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="creatoruin_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#creatoruin_java" style="color: inherit; text-decoration: inherit;">creator<wbr>Uin</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Uin of Creator.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectid_java" style="color: inherit; text-decoration: inherit;">project<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>ID of Project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectinfo_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectinfo_java" style="color: inherit; text-decoration: inherit;">project<wbr>Info</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Description of project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectname_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectname_java" style="color: inherit; text-decoration: inherit;">project<wbr>Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Name of Project.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="createtime_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#createtime_nodejs" style="color: inherit; text-decoration: inherit;">create<wbr>Time</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Create time.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="creatoruin_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#creatoruin_nodejs" style="color: inherit; text-decoration: inherit;">creator<wbr>Uin</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Uin of Creator.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectid_nodejs" style="color: inherit; text-decoration: inherit;">project<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>ID of Project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectinfo_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectinfo_nodejs" style="color: inherit; text-decoration: inherit;">project<wbr>Info</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Description of project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectname_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectname_nodejs" style="color: inherit; text-decoration: inherit;">project<wbr>Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of Project.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="create_time_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#create_time_python" style="color: inherit; text-decoration: inherit;">create_<wbr>time</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Create time.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="creator_uin_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#creator_uin_python" style="color: inherit; text-decoration: inherit;">creator_<wbr>uin</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Uin of Creator.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="project_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#project_id_python" style="color: inherit; text-decoration: inherit;">project_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>ID of Project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="project_info_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#project_info_python" style="color: inherit; text-decoration: inherit;">project_<wbr>info</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Description of project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="project_name_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#project_name_python" style="color: inherit; text-decoration: inherit;">project_<wbr>name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Name of Project.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="createtime_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#createtime_yaml" style="color: inherit; text-decoration: inherit;">create<wbr>Time</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Create time.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="creatoruin_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#creatoruin_yaml" style="color: inherit; text-decoration: inherit;">creator<wbr>Uin</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Uin of Creator.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectid_yaml" style="color: inherit; text-decoration: inherit;">project<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>ID of Project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectinfo_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectinfo_yaml" style="color: inherit; text-decoration: inherit;">project<wbr>Info</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Description of project.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="projectname_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#projectname_yaml" style="color: inherit; text-decoration: inherit;">project<wbr>Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Name of Project.</p>
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
