// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./getInstances";
export * from "./getNamespaces";
export * from "./getRepositories";
export * from "./getTokens";
export * from "./getVpcAttachments";
export * from "./instance";
export * from "./namespace";
export * from "./repository";
export * from "./token";
export * from "./vpcAttachment";

// Import resources to register:
import { Instance } from "./instance";
import { Namespace } from "./namespace";
import { Repository } from "./repository";
import { Token } from "./token";
import { VpcAttachment } from "./vpcAttachment";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Tcr/instance:Instance":
                return new Instance(name, <any>undefined, { urn })
            case "tencentcloud:Tcr/namespace:Namespace":
                return new Namespace(name, <any>undefined, { urn })
            case "tencentcloud:Tcr/repository:Repository":
                return new Repository(name, <any>undefined, { urn })
            case "tencentcloud:Tcr/token:Token":
                return new Token(name, <any>undefined, { urn })
            case "tencentcloud:Tcr/vpcAttachment:VpcAttachment":
                return new VpcAttachment(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Tcr/instance", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Tcr/namespace", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Tcr/repository", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Tcr/token", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Tcr/vpcAttachment", _module)
