// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package css

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a css liveTranscodeRuleAttachment
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Css"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			task, err := Css.NewPullStreamTask(ctx, "task", &Css.PullStreamTaskArgs{
//				SourceType: pulumi.String("%s"),
//				SourceUrls: pulumi.StringArray{
//					pulumi.String("%s"),
//				},
//				DomainName: pulumi.String("%s"),
//				AppName:    pulumi.String("%s"),
//				StreamName: pulumi.String("%s"),
//				StartTime:  pulumi.String("%s"),
//				EndTime:    pulumi.String("%s"),
//				Operator:   pulumi.String("%s"),
//				Comment:    pulumi.String("This is a demo."),
//			})
//			if err != nil {
//				return err
//			}
//			temp, err := Css.NewLiveTranscodeTemplate(ctx, "temp", &Css.LiveTranscodeTemplateArgs{
//				TemplateName: pulumi.String("xxx"),
//				Acodec:       pulumi.String("aac"),
//				VideoBitrate: pulumi.Int(100),
//				Vcodec:       pulumi.String("origin"),
//				Description:  pulumi.String("This_is_a_tf_test_temp."),
//				NeedVideo:    pulumi.Int(1),
//				NeedAudio:    pulumi.Int(1),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Css.NewLiveTranscodeRuleAttachment(ctx, "liveTranscodeRuleAttachment", &Css.LiveTranscodeRuleAttachmentArgs{
//				DomainName: task.DomainName,
//				AppName:    task.AppName,
//				StreamName: task.StreamName,
//				TemplateId: temp.ID(),
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
// css live_transcode_rule_attachment can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Css/liveTranscodeRuleAttachment:LiveTranscodeRuleAttachment live_transcode_rule_attachment liveTranscodeRuleAttachment_id
// ```
type LiveTranscodeRuleAttachment struct {
	pulumi.CustomResourceState

	// app name which you want to bind, can be empty string if not binding specific app name.
	AppName pulumi.StringOutput `pulumi:"appName"`
	// create time.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// domain name hich you want to bind the transcode template.
	DomainName pulumi.StringOutput `pulumi:"domainName"`
	// stream name which you want to bind, can be empty string if not binding specific stream.
	StreamName pulumi.StringOutput `pulumi:"streamName"`
	// template created by css_live_transcode_template.
	TemplateId pulumi.IntOutput `pulumi:"templateId"`
	// update time.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
}

// NewLiveTranscodeRuleAttachment registers a new resource with the given unique name, arguments, and options.
func NewLiveTranscodeRuleAttachment(ctx *pulumi.Context,
	name string, args *LiveTranscodeRuleAttachmentArgs, opts ...pulumi.ResourceOption) (*LiveTranscodeRuleAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AppName == nil {
		return nil, errors.New("invalid value for required argument 'AppName'")
	}
	if args.DomainName == nil {
		return nil, errors.New("invalid value for required argument 'DomainName'")
	}
	if args.StreamName == nil {
		return nil, errors.New("invalid value for required argument 'StreamName'")
	}
	if args.TemplateId == nil {
		return nil, errors.New("invalid value for required argument 'TemplateId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource LiveTranscodeRuleAttachment
	err := ctx.RegisterResource("tencentcloud:Css/liveTranscodeRuleAttachment:LiveTranscodeRuleAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLiveTranscodeRuleAttachment gets an existing LiveTranscodeRuleAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLiveTranscodeRuleAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LiveTranscodeRuleAttachmentState, opts ...pulumi.ResourceOption) (*LiveTranscodeRuleAttachment, error) {
	var resource LiveTranscodeRuleAttachment
	err := ctx.ReadResource("tencentcloud:Css/liveTranscodeRuleAttachment:LiveTranscodeRuleAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LiveTranscodeRuleAttachment resources.
type liveTranscodeRuleAttachmentState struct {
	// app name which you want to bind, can be empty string if not binding specific app name.
	AppName *string `pulumi:"appName"`
	// create time.
	CreateTime *string `pulumi:"createTime"`
	// domain name hich you want to bind the transcode template.
	DomainName *string `pulumi:"domainName"`
	// stream name which you want to bind, can be empty string if not binding specific stream.
	StreamName *string `pulumi:"streamName"`
	// template created by css_live_transcode_template.
	TemplateId *int `pulumi:"templateId"`
	// update time.
	UpdateTime *string `pulumi:"updateTime"`
}

type LiveTranscodeRuleAttachmentState struct {
	// app name which you want to bind, can be empty string if not binding specific app name.
	AppName pulumi.StringPtrInput
	// create time.
	CreateTime pulumi.StringPtrInput
	// domain name hich you want to bind the transcode template.
	DomainName pulumi.StringPtrInput
	// stream name which you want to bind, can be empty string if not binding specific stream.
	StreamName pulumi.StringPtrInput
	// template created by css_live_transcode_template.
	TemplateId pulumi.IntPtrInput
	// update time.
	UpdateTime pulumi.StringPtrInput
}

func (LiveTranscodeRuleAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*liveTranscodeRuleAttachmentState)(nil)).Elem()
}

type liveTranscodeRuleAttachmentArgs struct {
	// app name which you want to bind, can be empty string if not binding specific app name.
	AppName string `pulumi:"appName"`
	// domain name hich you want to bind the transcode template.
	DomainName string `pulumi:"domainName"`
	// stream name which you want to bind, can be empty string if not binding specific stream.
	StreamName string `pulumi:"streamName"`
	// template created by css_live_transcode_template.
	TemplateId int `pulumi:"templateId"`
}

// The set of arguments for constructing a LiveTranscodeRuleAttachment resource.
type LiveTranscodeRuleAttachmentArgs struct {
	// app name which you want to bind, can be empty string if not binding specific app name.
	AppName pulumi.StringInput
	// domain name hich you want to bind the transcode template.
	DomainName pulumi.StringInput
	// stream name which you want to bind, can be empty string if not binding specific stream.
	StreamName pulumi.StringInput
	// template created by css_live_transcode_template.
	TemplateId pulumi.IntInput
}

func (LiveTranscodeRuleAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*liveTranscodeRuleAttachmentArgs)(nil)).Elem()
}

type LiveTranscodeRuleAttachmentInput interface {
	pulumi.Input

	ToLiveTranscodeRuleAttachmentOutput() LiveTranscodeRuleAttachmentOutput
	ToLiveTranscodeRuleAttachmentOutputWithContext(ctx context.Context) LiveTranscodeRuleAttachmentOutput
}

func (*LiveTranscodeRuleAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((**LiveTranscodeRuleAttachment)(nil)).Elem()
}

func (i *LiveTranscodeRuleAttachment) ToLiveTranscodeRuleAttachmentOutput() LiveTranscodeRuleAttachmentOutput {
	return i.ToLiveTranscodeRuleAttachmentOutputWithContext(context.Background())
}

func (i *LiveTranscodeRuleAttachment) ToLiveTranscodeRuleAttachmentOutputWithContext(ctx context.Context) LiveTranscodeRuleAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LiveTranscodeRuleAttachmentOutput)
}

// LiveTranscodeRuleAttachmentArrayInput is an input type that accepts LiveTranscodeRuleAttachmentArray and LiveTranscodeRuleAttachmentArrayOutput values.
// You can construct a concrete instance of `LiveTranscodeRuleAttachmentArrayInput` via:
//
//	LiveTranscodeRuleAttachmentArray{ LiveTranscodeRuleAttachmentArgs{...} }
type LiveTranscodeRuleAttachmentArrayInput interface {
	pulumi.Input

	ToLiveTranscodeRuleAttachmentArrayOutput() LiveTranscodeRuleAttachmentArrayOutput
	ToLiveTranscodeRuleAttachmentArrayOutputWithContext(context.Context) LiveTranscodeRuleAttachmentArrayOutput
}

type LiveTranscodeRuleAttachmentArray []LiveTranscodeRuleAttachmentInput

func (LiveTranscodeRuleAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LiveTranscodeRuleAttachment)(nil)).Elem()
}

func (i LiveTranscodeRuleAttachmentArray) ToLiveTranscodeRuleAttachmentArrayOutput() LiveTranscodeRuleAttachmentArrayOutput {
	return i.ToLiveTranscodeRuleAttachmentArrayOutputWithContext(context.Background())
}

func (i LiveTranscodeRuleAttachmentArray) ToLiveTranscodeRuleAttachmentArrayOutputWithContext(ctx context.Context) LiveTranscodeRuleAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LiveTranscodeRuleAttachmentArrayOutput)
}

// LiveTranscodeRuleAttachmentMapInput is an input type that accepts LiveTranscodeRuleAttachmentMap and LiveTranscodeRuleAttachmentMapOutput values.
// You can construct a concrete instance of `LiveTranscodeRuleAttachmentMapInput` via:
//
//	LiveTranscodeRuleAttachmentMap{ "key": LiveTranscodeRuleAttachmentArgs{...} }
type LiveTranscodeRuleAttachmentMapInput interface {
	pulumi.Input

	ToLiveTranscodeRuleAttachmentMapOutput() LiveTranscodeRuleAttachmentMapOutput
	ToLiveTranscodeRuleAttachmentMapOutputWithContext(context.Context) LiveTranscodeRuleAttachmentMapOutput
}

type LiveTranscodeRuleAttachmentMap map[string]LiveTranscodeRuleAttachmentInput

func (LiveTranscodeRuleAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LiveTranscodeRuleAttachment)(nil)).Elem()
}

func (i LiveTranscodeRuleAttachmentMap) ToLiveTranscodeRuleAttachmentMapOutput() LiveTranscodeRuleAttachmentMapOutput {
	return i.ToLiveTranscodeRuleAttachmentMapOutputWithContext(context.Background())
}

func (i LiveTranscodeRuleAttachmentMap) ToLiveTranscodeRuleAttachmentMapOutputWithContext(ctx context.Context) LiveTranscodeRuleAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LiveTranscodeRuleAttachmentMapOutput)
}

type LiveTranscodeRuleAttachmentOutput struct{ *pulumi.OutputState }

func (LiveTranscodeRuleAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LiveTranscodeRuleAttachment)(nil)).Elem()
}

func (o LiveTranscodeRuleAttachmentOutput) ToLiveTranscodeRuleAttachmentOutput() LiveTranscodeRuleAttachmentOutput {
	return o
}

func (o LiveTranscodeRuleAttachmentOutput) ToLiveTranscodeRuleAttachmentOutputWithContext(ctx context.Context) LiveTranscodeRuleAttachmentOutput {
	return o
}

// app name which you want to bind, can be empty string if not binding specific app name.
func (o LiveTranscodeRuleAttachmentOutput) AppName() pulumi.StringOutput {
	return o.ApplyT(func(v *LiveTranscodeRuleAttachment) pulumi.StringOutput { return v.AppName }).(pulumi.StringOutput)
}

// create time.
func (o LiveTranscodeRuleAttachmentOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *LiveTranscodeRuleAttachment) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// domain name hich you want to bind the transcode template.
func (o LiveTranscodeRuleAttachmentOutput) DomainName() pulumi.StringOutput {
	return o.ApplyT(func(v *LiveTranscodeRuleAttachment) pulumi.StringOutput { return v.DomainName }).(pulumi.StringOutput)
}

// stream name which you want to bind, can be empty string if not binding specific stream.
func (o LiveTranscodeRuleAttachmentOutput) StreamName() pulumi.StringOutput {
	return o.ApplyT(func(v *LiveTranscodeRuleAttachment) pulumi.StringOutput { return v.StreamName }).(pulumi.StringOutput)
}

// template created by css_live_transcode_template.
func (o LiveTranscodeRuleAttachmentOutput) TemplateId() pulumi.IntOutput {
	return o.ApplyT(func(v *LiveTranscodeRuleAttachment) pulumi.IntOutput { return v.TemplateId }).(pulumi.IntOutput)
}

// update time.
func (o LiveTranscodeRuleAttachmentOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *LiveTranscodeRuleAttachment) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

type LiveTranscodeRuleAttachmentArrayOutput struct{ *pulumi.OutputState }

func (LiveTranscodeRuleAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LiveTranscodeRuleAttachment)(nil)).Elem()
}

func (o LiveTranscodeRuleAttachmentArrayOutput) ToLiveTranscodeRuleAttachmentArrayOutput() LiveTranscodeRuleAttachmentArrayOutput {
	return o
}

func (o LiveTranscodeRuleAttachmentArrayOutput) ToLiveTranscodeRuleAttachmentArrayOutputWithContext(ctx context.Context) LiveTranscodeRuleAttachmentArrayOutput {
	return o
}

func (o LiveTranscodeRuleAttachmentArrayOutput) Index(i pulumi.IntInput) LiveTranscodeRuleAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *LiveTranscodeRuleAttachment {
		return vs[0].([]*LiveTranscodeRuleAttachment)[vs[1].(int)]
	}).(LiveTranscodeRuleAttachmentOutput)
}

type LiveTranscodeRuleAttachmentMapOutput struct{ *pulumi.OutputState }

func (LiveTranscodeRuleAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LiveTranscodeRuleAttachment)(nil)).Elem()
}

func (o LiveTranscodeRuleAttachmentMapOutput) ToLiveTranscodeRuleAttachmentMapOutput() LiveTranscodeRuleAttachmentMapOutput {
	return o
}

func (o LiveTranscodeRuleAttachmentMapOutput) ToLiveTranscodeRuleAttachmentMapOutputWithContext(ctx context.Context) LiveTranscodeRuleAttachmentMapOutput {
	return o
}

func (o LiveTranscodeRuleAttachmentMapOutput) MapIndex(k pulumi.StringInput) LiveTranscodeRuleAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *LiveTranscodeRuleAttachment {
		return vs[0].(map[string]*LiveTranscodeRuleAttachment)[vs[1].(string)]
	}).(LiveTranscodeRuleAttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LiveTranscodeRuleAttachmentInput)(nil)).Elem(), &LiveTranscodeRuleAttachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*LiveTranscodeRuleAttachmentArrayInput)(nil)).Elem(), LiveTranscodeRuleAttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*LiveTranscodeRuleAttachmentMapInput)(nil)).Elem(), LiveTranscodeRuleAttachmentMap{})
	pulumi.RegisterOutputType(LiveTranscodeRuleAttachmentOutput{})
	pulumi.RegisterOutputType(LiveTranscodeRuleAttachmentArrayOutput{})
	pulumi.RegisterOutputType(LiveTranscodeRuleAttachmentMapOutput{})
}
