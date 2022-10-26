package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/vpc"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := vpc.NewInstance(ctx, "bucket", &vpc.InstanceArgs{
			Name:      pulumi.String("pulumi-vpc"),
			CidrBlock: pulumi.String("10.0.0.0/20"),
		})
		if err != nil {
			return err
		}
		return nil
	})
}
