# RESTful API

## What is an API?
Application Programming Interface <br>
![Image](./images/05-api.png)

> An API helps clients communicate what htey want to the sevice so it can understand and fulfill the request.

## What is REST?
REpresentational State Transfer <br>
![Image](./images/06-rest.png) 

> A set of guiding principles that impose conditions on how an API should work

## What is a REST API?
A REST or RESTFUL API is one that conforms to the REST architectural style

## How to identify resources in a REST API?
A resources in any object, document or thing that the API can receive from or send to the clients. <br>
![image](./images/07-uri.png)

## How to interact with a REST API?
![Image](./images/08-crud-operation.png)

### Get All Games - HTTP GET
![Image](./images/09-http-get.png) 

### GET A Specific Game - HTTP GET
![Image](./images/10-http-get-specified.png)

### Create A Game - HTTP POST
![Image](./images/11-http-post-create-agame.png)

### Update A Game - HTTP PUT
![Image](./images/12-http-put.png) 

### Delete A Game - HTTP DELETE
![Image](./images/13-http-delete.png)

### Conclusion REST API
```
GET /games
GET /games/1
POST /games
PUT /games/1
DELETE /games/1
```

## Test HTTP
* create file `games.http`: `GET <your localhost>`
* make sure you download ext REST Client
* `dotnet run`
* Send request

![Image](./images/14-testing-get.png)
or just CTRL + ALT + R

---
How to prevent browser open when we are in the debugging session?
* CTRL + SHIFT + E
* launchSetting.json > `launchBrowser: false`