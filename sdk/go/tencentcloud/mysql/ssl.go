// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a mysql ssl
//
// ## Example Usage
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Mysql.NewSsl(ctx, "ssl", &Mysql.SslArgs{
//				InstanceId: pulumi.String("cdb-j5rprr8n"),
//				Status:     pulumi.String("OFF"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
//
// ## Import
//
// mysql ssl can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Mysql/ssl:Ssl ssl instanceId
// ```
type Ssl struct {
	pulumi.CustomResourceState

	// Instance ID. Example value: cdb-c1nl9rpv.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Whether to enable SSL. `ON` means enabled, `OFF` means not enabled.
	Status pulumi.StringOutput `pulumi:"status"`
	// The certificate download link. Example value: http://testdownload.url.
	Url pulumi.StringOutput `pulumi:"url"`
}

// NewSsl registers a new resource with the given unique name, arguments, and options.
func NewSsl(ctx *pulumi.Context,
	name string, args *SslArgs, opts ...pulumi.ResourceOption) (*Ssl, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.Status == nil {
		return nil, errors.New("invalid value for required argument 'Status'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Ssl
	err := ctx.RegisterResource("tencentcloud:Mysql/ssl:Ssl", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSsl gets an existing Ssl resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSsl(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SslState, opts ...pulumi.ResourceOption) (*Ssl, error) {
	var resource Ssl
	err := ctx.ReadResource("tencentcloud:Mysql/ssl:Ssl", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Ssl resources.
type sslState struct {
	// Instance ID. Example value: cdb-c1nl9rpv.
	InstanceId *string `pulumi:"instanceId"`
	// Whether to enable SSL. `ON` means enabled, `OFF` means not enabled.
	Status *string `pulumi:"status"`
	// The certificate download link. Example value: http://testdownload.url.
	Url *string `pulumi:"url"`
}

type SslState struct {
	// Instance ID. Example value: cdb-c1nl9rpv.
	InstanceId pulumi.StringPtrInput
	// Whether to enable SSL. `ON` means enabled, `OFF` means not enabled.
	Status pulumi.StringPtrInput
	// The certificate download link. Example value: http://testdownload.url.
	Url pulumi.StringPtrInput
}

func (SslState) ElementType() reflect.Type {
	return reflect.TypeOf((*sslState)(nil)).Elem()
}

type sslArgs struct {
	// Instance ID. Example value: cdb-c1nl9rpv.
	InstanceId string `pulumi:"instanceId"`
	// Whether to enable SSL. `ON` means enabled, `OFF` means not enabled.
	Status string `pulumi:"status"`
}

// The set of arguments for constructing a Ssl resource.
type SslArgs struct {
	// Instance ID. Example value: cdb-c1nl9rpv.
	InstanceId pulumi.StringInput
	// Whether to enable SSL. `ON` means enabled, `OFF` means not enabled.
	Status pulumi.StringInput
}

func (SslArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sslArgs)(nil)).Elem()
}

type SslInput interface {
	pulumi.Input

	ToSslOutput() SslOutput
	ToSslOutputWithContext(ctx context.Context) SslOutput
}

func (*Ssl) ElementType() reflect.Type {
	return reflect.TypeOf((**Ssl)(nil)).Elem()
}

func (i *Ssl) ToSslOutput() SslOutput {
	return i.ToSslOutputWithContext(context.Background())
}

func (i *Ssl) ToSslOutputWithContext(ctx context.Context) SslOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SslOutput)
}

// SslArrayInput is an input type that accepts SslArray and SslArrayOutput values.
// You can construct a concrete instance of `SslArrayInput` via:
//
//	SslArray{ SslArgs{...} }
type SslArrayInput interface {
	pulumi.Input

	ToSslArrayOutput() SslArrayOutput
	ToSslArrayOutputWithContext(context.Context) SslArrayOutput
}

type SslArray []SslInput

func (SslArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Ssl)(nil)).Elem()
}

func (i SslArray) ToSslArrayOutput() SslArrayOutput {
	return i.ToSslArrayOutputWithContext(context.Background())
}

func (i SslArray) ToSslArrayOutputWithContext(ctx context.Context) SslArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SslArrayOutput)
}

// SslMapInput is an input type that accepts SslMap and SslMapOutput values.
// You can construct a concrete instance of `SslMapInput` via:
//
//	SslMap{ "key": SslArgs{...} }
type SslMapInput interface {
	pulumi.Input

	ToSslMapOutput() SslMapOutput
	ToSslMapOutputWithContext(context.Context) SslMapOutput
}

type SslMap map[string]SslInput

func (SslMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Ssl)(nil)).Elem()
}

func (i SslMap) ToSslMapOutput() SslMapOutput {
	return i.ToSslMapOutputWithContext(context.Background())
}

func (i SslMap) ToSslMapOutputWithContext(ctx context.Context) SslMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SslMapOutput)
}

type SslOutput struct{ *pulumi.OutputState }

func (SslOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Ssl)(nil)).Elem()
}

func (o SslOutput) ToSslOutput() SslOutput {
	return o
}

func (o SslOutput) ToSslOutputWithContext(ctx context.Context) SslOutput {
	return o
}

// Instance ID. Example value: cdb-c1nl9rpv.
func (o SslOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *Ssl) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Whether to enable SSL. `ON` means enabled, `OFF` means not enabled.
func (o SslOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *Ssl) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// The certificate download link. Example value: http://testdownload.url.
func (o SslOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *Ssl) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

type SslArrayOutput struct{ *pulumi.OutputState }

func (SslArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Ssl)(nil)).Elem()
}

func (o SslArrayOutput) ToSslArrayOutput() SslArrayOutput {
	return o
}

func (o SslArrayOutput) ToSslArrayOutputWithContext(ctx context.Context) SslArrayOutput {
	return o
}

func (o SslArrayOutput) Index(i pulumi.IntInput) SslOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Ssl {
		return vs[0].([]*Ssl)[vs[1].(int)]
	}).(SslOutput)
}

type SslMapOutput struct{ *pulumi.OutputState }

func (SslMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Ssl)(nil)).Elem()
}

func (o SslMapOutput) ToSslMapOutput() SslMapOutput {
	return o
}

func (o SslMapOutput) ToSslMapOutputWithContext(ctx context.Context) SslMapOutput {
	return o
}

func (o SslMapOutput) MapIndex(k pulumi.StringInput) SslOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Ssl {
		return vs[0].(map[string]*Ssl)[vs[1].(string)]
	}).(SslOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SslInput)(nil)).Elem(), &Ssl{})
	pulumi.RegisterInputType(reflect.TypeOf((*SslArrayInput)(nil)).Elem(), SslArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SslMapInput)(nil)).Elem(), SslMap{})
	pulumi.RegisterOutputType(SslOutput{})
	pulumi.RegisterOutputType(SslArrayOutput{})
	pulumi.RegisterOutputType(SslMapOutput{})
}