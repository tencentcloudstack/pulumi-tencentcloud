package examples

import "os"

var config = map[string]string{
	"tencentcloud:region": "ap-singapore",
}

var secrets = map[string]string{
	"tencentcloud:secretId":  os.Getenv("TENCENTCLOUD_SECRET_ID"),
	"tencentcloud:secretKey": os.Getenv("TENCENTCLOUD_SECRET_KEY"),
}
