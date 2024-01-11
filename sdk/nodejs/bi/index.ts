// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./datasource";
export * from "./datasourceCloud";
export * from "./embedIntervalApply";
export * from "./embedTokenApply";
export * from "./getProject";
export * from "./getUserProject";
export * from "./project";
export * from "./projectUserRole";
export * from "./userRole";

// Import resources to register:
import { Datasource } from "./datasource";
import { DatasourceCloud } from "./datasourceCloud";
import { EmbedIntervalApply } from "./embedIntervalApply";
import { EmbedTokenApply } from "./embedTokenApply";
import { Project } from "./project";
import { ProjectUserRole } from "./projectUserRole";
import { UserRole } from "./userRole";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Bi/datasource:Datasource":
                return new Datasource(name, <any>undefined, { urn })
            case "tencentcloud:Bi/datasourceCloud:DatasourceCloud":
                return new DatasourceCloud(name, <any>undefined, { urn })
            case "tencentcloud:Bi/embedIntervalApply:EmbedIntervalApply":
                return new EmbedIntervalApply(name, <any>undefined, { urn })
            case "tencentcloud:Bi/embedTokenApply:EmbedTokenApply":
                return new EmbedTokenApply(name, <any>undefined, { urn })
            case "tencentcloud:Bi/project:Project":
                return new Project(name, <any>undefined, { urn })
            case "tencentcloud:Bi/projectUserRole:ProjectUserRole":
                return new ProjectUserRole(name, <any>undefined, { urn })
            case "tencentcloud:Bi/userRole:UserRole":
                return new UserRole(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Bi/datasource", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Bi/datasourceCloud", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Bi/embedIntervalApply", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Bi/embedTokenApply", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Bi/project", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Bi/projectUserRole", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Bi/userRole", _module)