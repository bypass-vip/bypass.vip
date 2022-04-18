package main

import (
	"bytes"
	"encoding/json"
	"fmt"
	"io/ioutil"
	"net/http"
)

var (
	ApiEndpoint = "https://api.bypass.vip/"
)

type BypassResponse struct {
	// You can rename any of these values to anything you want.
	Success   bool   `json:"success"`
	Website   string `json:"website"`
	Query     string `json:"query"`
	TimeTaken int    `json:"time_ms"`

	// Optional
	Response    string `json:"response"`
	Cache       bool   `json:"cache"`
	Destination string `json:"destination"`
}

func Bypass(url string) BypassResponse {
	var bResp BypassResponse
	jsonStr := []byte(`{"url":"` + url + `"}`)
	req, _ := http.NewRequest("POST", ApiEndpoint, bytes.NewBuffer(jsonStr))
	req.Header.Set("X-Custom-Header", "myvalue")
	req.Header.Set("Content-Type", "application/json")

	client := &http.Client{}
	resp, err := client.Do(req)
	if err != nil {
		panic(err)
	}
	defer resp.Body.Close()

	body, _ := ioutil.ReadAll(resp.Body)

	err2 := json.Unmarshal(body, &bResp)

	if err2 != nil {
		fmt.Println(err)
	}

	return bResp
}

func main() {
	bResp := Bypass("https://google.com/")
	fmt.Println("BypassResponse struct:", bResp)
	fmt.Println("Value of TimeTaken from the JSON Response:", bResp.TimeTaken)
}
