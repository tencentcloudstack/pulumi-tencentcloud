import { vpc } from "@tencentcloud_iac/pulumi"

~async function () {
    try {
        await new vpc.Instance("my-vpc", {
            name: "pulumi-vpc",
            cidrBlock: "10.0.0.0/20"
        })
    } catch (e) {
        console.error(e)
    }
}()