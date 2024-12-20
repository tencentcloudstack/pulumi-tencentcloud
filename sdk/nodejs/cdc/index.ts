// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export { DedicatedClusterArgs, DedicatedClusterState } from "./dedicatedCluster";
export type DedicatedCluster = import("./dedicatedCluster").DedicatedCluster;
export const DedicatedCluster: typeof import("./dedicatedCluster").DedicatedCluster = null as any;
utilities.lazyLoad(exports, ["DedicatedCluster"], () => require("./dedicatedCluster"));

export { GetDedicatedClusterHostsArgs, GetDedicatedClusterHostsResult, GetDedicatedClusterHostsOutputArgs } from "./getDedicatedClusterHosts";
export const getDedicatedClusterHosts: typeof import("./getDedicatedClusterHosts").getDedicatedClusterHosts = null as any;
export const getDedicatedClusterHostsOutput: typeof import("./getDedicatedClusterHosts").getDedicatedClusterHostsOutput = null as any;
utilities.lazyLoad(exports, ["getDedicatedClusterHosts","getDedicatedClusterHostsOutput"], () => require("./getDedicatedClusterHosts"));

export { GetDedicatedClusterInstanceTypesArgs, GetDedicatedClusterInstanceTypesResult, GetDedicatedClusterInstanceTypesOutputArgs } from "./getDedicatedClusterInstanceTypes";
export const getDedicatedClusterInstanceTypes: typeof import("./getDedicatedClusterInstanceTypes").getDedicatedClusterInstanceTypes = null as any;
export const getDedicatedClusterInstanceTypesOutput: typeof import("./getDedicatedClusterInstanceTypes").getDedicatedClusterInstanceTypesOutput = null as any;
utilities.lazyLoad(exports, ["getDedicatedClusterInstanceTypes","getDedicatedClusterInstanceTypesOutput"], () => require("./getDedicatedClusterInstanceTypes"));

export { GetDedicatedClusterOrdersArgs, GetDedicatedClusterOrdersResult, GetDedicatedClusterOrdersOutputArgs } from "./getDedicatedClusterOrders";
export const getDedicatedClusterOrders: typeof import("./getDedicatedClusterOrders").getDedicatedClusterOrders = null as any;
export const getDedicatedClusterOrdersOutput: typeof import("./getDedicatedClusterOrders").getDedicatedClusterOrdersOutput = null as any;
utilities.lazyLoad(exports, ["getDedicatedClusterOrders","getDedicatedClusterOrdersOutput"], () => require("./getDedicatedClusterOrders"));

export { SiteArgs, SiteState } from "./site";
export type Site = import("./site").Site;
export const Site: typeof import("./site").Site = null as any;
utilities.lazyLoad(exports, ["Site"], () => require("./site"));


const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Cdc/dedicatedCluster:DedicatedCluster":
                return new DedicatedCluster(name, <any>undefined, { urn })
            case "tencentcloud:Cdc/site:Site":
                return new Site(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Cdc/dedicatedCluster", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cdc/site", _module)
