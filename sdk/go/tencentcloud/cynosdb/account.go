// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cynosdb

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a cynosdb account
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cynosdb"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Cynosdb.NewAccount(ctx, "account", &Cynosdb.AccountArgs{
//				AccountName:        pulumi.String("terraform_test"),
//				AccountPassword:    pulumi.String("Password@1234"),
//				ClusterId:          pulumi.String("cynosdbmysql-bws8h88b"),
//				Description:        pulumi.String("terraform test"),
//				Host:               pulumi.String("%"),
//				MaxUserConnections: pulumi.Int(2),
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
// cynosdb account can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Cynosdb/account:Account account account_id
// ```
type Account struct {
	pulumi.CustomResourceState

	// Account name, including alphanumeric _, Start with a letter, end with a letter or number, length 1-16.
	AccountName pulumi.StringOutput `pulumi:"accountName"`
	// Password, with a length range of 8 to 64 characters.
	AccountPassword pulumi.StringOutput `pulumi:"accountPassword"`
	// Cluster ID.
	ClusterId pulumi.StringOutput `pulumi:"clusterId"`
	// describe.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// main engine.
	Host pulumi.StringOutput `pulumi:"host"`
	// The maximum number of user connections cannot be greater than 10240.
	MaxUserConnections pulumi.IntPtrOutput `pulumi:"maxUserConnections"`
}

// NewAccount registers a new resource with the given unique name, arguments, and options.
func NewAccount(ctx *pulumi.Context,
	name string, args *AccountArgs, opts ...pulumi.ResourceOption) (*Account, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.AccountPassword == nil {
		return nil, errors.New("invalid value for required argument 'AccountPassword'")
	}
	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	if args.Host == nil {
		return nil, errors.New("invalid value for required argument 'Host'")
	}
	if args.AccountPassword != nil {
		args.AccountPassword = pulumi.ToSecret(args.AccountPassword).(pulumi.StringInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"accountPassword",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Account
	err := ctx.RegisterResource("tencentcloud:Cynosdb/account:Account", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAccount gets an existing Account resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AccountState, opts ...pulumi.ResourceOption) (*Account, error) {
	var resource Account
	err := ctx.ReadResource("tencentcloud:Cynosdb/account:Account", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Account resources.
type accountState struct {
	// Account name, including alphanumeric _, Start with a letter, end with a letter or number, length 1-16.
	AccountName *string `pulumi:"accountName"`
	// Password, with a length range of 8 to 64 characters.
	AccountPassword *string `pulumi:"accountPassword"`
	// Cluster ID.
	ClusterId *string `pulumi:"clusterId"`
	// describe.
	Description *string `pulumi:"description"`
	// main engine.
	Host *string `pulumi:"host"`
	// The maximum number of user connections cannot be greater than 10240.
	MaxUserConnections *int `pulumi:"maxUserConnections"`
}

type AccountState struct {
	// Account name, including alphanumeric _, Start with a letter, end with a letter or number, length 1-16.
	AccountName pulumi.StringPtrInput
	// Password, with a length range of 8 to 64 characters.
	AccountPassword pulumi.StringPtrInput
	// Cluster ID.
	ClusterId pulumi.StringPtrInput
	// describe.
	Description pulumi.StringPtrInput
	// main engine.
	Host pulumi.StringPtrInput
	// The maximum number of user connections cannot be greater than 10240.
	MaxUserConnections pulumi.IntPtrInput
}

func (AccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*accountState)(nil)).Elem()
}

type accountArgs struct {
	// Account name, including alphanumeric _, Start with a letter, end with a letter or number, length 1-16.
	AccountName string `pulumi:"accountName"`
	// Password, with a length range of 8 to 64 characters.
	AccountPassword string `pulumi:"accountPassword"`
	// Cluster ID.
	ClusterId string `pulumi:"clusterId"`
	// describe.
	Description *string `pulumi:"description"`
	// main engine.
	Host string `pulumi:"host"`
	// The maximum number of user connections cannot be greater than 10240.
	MaxUserConnections *int `pulumi:"maxUserConnections"`
}

// The set of arguments for constructing a Account resource.
type AccountArgs struct {
	// Account name, including alphanumeric _, Start with a letter, end with a letter or number, length 1-16.
	AccountName pulumi.StringInput
	// Password, with a length range of 8 to 64 characters.
	AccountPassword pulumi.StringInput
	// Cluster ID.
	ClusterId pulumi.StringInput
	// describe.
	Description pulumi.StringPtrInput
	// main engine.
	Host pulumi.StringInput
	// The maximum number of user connections cannot be greater than 10240.
	MaxUserConnections pulumi.IntPtrInput
}

func (AccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*accountArgs)(nil)).Elem()
}

type AccountInput interface {
	pulumi.Input

	ToAccountOutput() AccountOutput
	ToAccountOutputWithContext(ctx context.Context) AccountOutput
}

func (*Account) ElementType() reflect.Type {
	return reflect.TypeOf((**Account)(nil)).Elem()
}

func (i *Account) ToAccountOutput() AccountOutput {
	return i.ToAccountOutputWithContext(context.Background())
}

func (i *Account) ToAccountOutputWithContext(ctx context.Context) AccountOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccountOutput)
}

// AccountArrayInput is an input type that accepts AccountArray and AccountArrayOutput values.
// You can construct a concrete instance of `AccountArrayInput` via:
//
//	AccountArray{ AccountArgs{...} }
type AccountArrayInput interface {
	pulumi.Input

	ToAccountArrayOutput() AccountArrayOutput
	ToAccountArrayOutputWithContext(context.Context) AccountArrayOutput
}

type AccountArray []AccountInput

func (AccountArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Account)(nil)).Elem()
}

func (i AccountArray) ToAccountArrayOutput() AccountArrayOutput {
	return i.ToAccountArrayOutputWithContext(context.Background())
}

func (i AccountArray) ToAccountArrayOutputWithContext(ctx context.Context) AccountArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccountArrayOutput)
}

// AccountMapInput is an input type that accepts AccountMap and AccountMapOutput values.
// You can construct a concrete instance of `AccountMapInput` via:
//
//	AccountMap{ "key": AccountArgs{...} }
type AccountMapInput interface {
	pulumi.Input

	ToAccountMapOutput() AccountMapOutput
	ToAccountMapOutputWithContext(context.Context) AccountMapOutput
}

type AccountMap map[string]AccountInput

func (AccountMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Account)(nil)).Elem()
}

func (i AccountMap) ToAccountMapOutput() AccountMapOutput {
	return i.ToAccountMapOutputWithContext(context.Background())
}

func (i AccountMap) ToAccountMapOutputWithContext(ctx context.Context) AccountMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccountMapOutput)
}

type AccountOutput struct{ *pulumi.OutputState }

func (AccountOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Account)(nil)).Elem()
}

func (o AccountOutput) ToAccountOutput() AccountOutput {
	return o
}

func (o AccountOutput) ToAccountOutputWithContext(ctx context.Context) AccountOutput {
	return o
}

// Account name, including alphanumeric _, Start with a letter, end with a letter or number, length 1-16.
func (o AccountOutput) AccountName() pulumi.StringOutput {
	return o.ApplyT(func(v *Account) pulumi.StringOutput { return v.AccountName }).(pulumi.StringOutput)
}

// Password, with a length range of 8 to 64 characters.
func (o AccountOutput) AccountPassword() pulumi.StringOutput {
	return o.ApplyT(func(v *Account) pulumi.StringOutput { return v.AccountPassword }).(pulumi.StringOutput)
}

// Cluster ID.
func (o AccountOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v *Account) pulumi.StringOutput { return v.ClusterId }).(pulumi.StringOutput)
}

// describe.
func (o AccountOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Account) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// main engine.
func (o AccountOutput) Host() pulumi.StringOutput {
	return o.ApplyT(func(v *Account) pulumi.StringOutput { return v.Host }).(pulumi.StringOutput)
}

// The maximum number of user connections cannot be greater than 10240.
func (o AccountOutput) MaxUserConnections() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Account) pulumi.IntPtrOutput { return v.MaxUserConnections }).(pulumi.IntPtrOutput)
}

type AccountArrayOutput struct{ *pulumi.OutputState }

func (AccountArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Account)(nil)).Elem()
}

func (o AccountArrayOutput) ToAccountArrayOutput() AccountArrayOutput {
	return o
}

func (o AccountArrayOutput) ToAccountArrayOutputWithContext(ctx context.Context) AccountArrayOutput {
	return o
}

func (o AccountArrayOutput) Index(i pulumi.IntInput) AccountOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Account {
		return vs[0].([]*Account)[vs[1].(int)]
	}).(AccountOutput)
}

type AccountMapOutput struct{ *pulumi.OutputState }

func (AccountMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Account)(nil)).Elem()
}

func (o AccountMapOutput) ToAccountMapOutput() AccountMapOutput {
	return o
}

func (o AccountMapOutput) ToAccountMapOutputWithContext(ctx context.Context) AccountMapOutput {
	return o
}

func (o AccountMapOutput) MapIndex(k pulumi.StringInput) AccountOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Account {
		return vs[0].(map[string]*Account)[vs[1].(string)]
	}).(AccountOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AccountInput)(nil)).Elem(), &Account{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccountArrayInput)(nil)).Elem(), AccountArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccountMapInput)(nil)).Elem(), AccountMap{})
	pulumi.RegisterOutputType(AccountOutput{})
	pulumi.RegisterOutputType(AccountArrayOutput{})
	pulumi.RegisterOutputType(AccountMapOutput{})
}
