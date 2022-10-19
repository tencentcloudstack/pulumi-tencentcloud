package info

import (
	"encoding/json"
	"log"
	"os"
)

func WriteInfos() error {
	rOut := GetResourceOutput()
	dOut := GetDataSourceOutput()
	rContent, err := json.MarshalIndent(rOut, "", "  ")
	if err != nil {
		log.Printf("marshal resource error: %s", err.Error())
		return err
	}
	dContent, err := json.MarshalIndent(dOut, "", "  ")
	if err != nil {
		log.Printf("marshal datasource error: %s", err.Error())
		return err
	}
	err = os.WriteFile("./resources.json", rContent, 0622)
	if err != nil {
		log.Printf("write resources error: %s", err.Error())
		return err
	}
	err = os.WriteFile("./datasouroces.json", dContent, 0622)
	if err != nil {
		log.Printf("write datasouroces error: %s", err.Error())
		return err
	}
	return nil
}
