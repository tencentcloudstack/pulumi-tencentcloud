// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./folder";
export * from "./getCheckSavepoint";
export * from "./getClusters";
export * from "./getJobEvents";
export * from "./getJobSubmissionLog";
export * from "./getMetaTable";
export * from "./getResourceRelatedJob";
export * from "./getSavepointList";
export * from "./getSystemResource";
export * from "./getTreeJobs";
export * from "./getTreeResources";
export * from "./getWorkSpaces";
export * from "./job";
export * from "./jobConfig";
export * from "./jobCopy";
export * from "./resource";
export * from "./resourceConfig";
export * from "./runJob";
export * from "./stopJob";
export * from "./triggerJobSavepoint";
export * from "./workSpace";

// Import resources to register:
import { Folder } from "./folder";
import { Job } from "./job";
import { JobConfig } from "./jobConfig";
import { JobCopy } from "./jobCopy";
import { Resource } from "./resource";
import { ResourceConfig } from "./resourceConfig";
import { RunJob } from "./runJob";
import { StopJob } from "./stopJob";
import { TriggerJobSavepoint } from "./triggerJobSavepoint";
import { WorkSpace } from "./workSpace";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Oceanus/folder:Folder":
                return new Folder(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/job:Job":
                return new Job(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/jobConfig:JobConfig":
                return new JobConfig(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/jobCopy:JobCopy":
                return new JobCopy(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/resource:Resource":
                return new Resource(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/resourceConfig:ResourceConfig":
                return new ResourceConfig(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/runJob:RunJob":
                return new RunJob(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/stopJob:StopJob":
                return new StopJob(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/triggerJobSavepoint:TriggerJobSavepoint":
                return new TriggerJobSavepoint(name, <any>undefined, { urn })
            case "tencentcloud:Oceanus/workSpace:WorkSpace":
                return new WorkSpace(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/folder", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/job", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/jobConfig", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/jobCopy", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/resource", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/resourceConfig", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/runJob", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/stopJob", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/triggerJobSavepoint", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Oceanus/workSpace", _module)