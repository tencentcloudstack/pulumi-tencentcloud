package main

//go:generate go run main.go
import "github.com/tencentcloudstack/pulumi-tencentcloud/provider/info"

func main() {
	info.WriteInfos()
}
