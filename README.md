# ringcentral-cs-client

RingCentral C# client.

This is just a proof of concept release, please don't use it in production (yet)!


## URL Builder

```cs
var rc = new RestClient("appKey", "appSecret"); // you can use fake key and secret if you don't talk to api server.
var account = rc.Restapi().Account();
var extension = account.Extension();
account.CallLog().Endpoint(); // "/restapi/v1.0/account/~/call-log"
extension.CallLog("123456").Endpoint(); // "/restapi/v1.0/account/~/extension/~/call-log/123456"
extension.CallLog("123456").Url(); // "https://platform.devtest.ringcentral.com/restapi/v1.0/account/~/extension/~/call-log/123456"
```

Or you can specify all of the IDs explicitly:

```cs
rc.Restapi("v1.0").Account("~").Extension("12345678").CallLog("87654321").Endpoint(); // "/restapi/v1.0/account/~/extension/12345678/call-log/87654321"
```


## Http Request sample

Get extension list:

```cs
var rc = new RestClient("appKey", "appSecret", "apiServer");
var endpoint = rc.Restapi().Account().Extension().Endpoint(); // /restapi/v1.0/account/~/extension/~
var response = rc.Get(endpoint).Result;
var json = response.Content.ReadAsStringAsync().Result;
```

## Models

This is **not** ready yet. But you can get the idea:

Following code snippets are equivalent:

##### traditional solution:

```cs
var endpoint = "/restapi/v1.0/dictionary/timezone/6"; // hard code string
var response = rc.Get(endpoint).Result; // make http request
var json = response.Content.ReadAsStringAsync().Result; // get response json
var timezone = JsonConvert.DeserializeObject<Timezone>(); // convert json to model
```

##### URL Builder + generics programming:

```cs
var endpoint = rc.Restapi().Dictionary().Timezone(6).Endpoint();
var timezone = rc.Get<Timezone>(endpoint);
```

##### Most intuitive:

```cs
var timezone = rc.Restapi().Dictionary().Timezone(6).Get(); // This is the shortest solution.
```
