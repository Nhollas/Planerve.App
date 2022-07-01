# Planerve App API

- [Planerve App API](#planerve-app-api)
  - [Account](#account)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)
  - [Application](#application)
    - [GetById](#getbyid)
      - [Application Request](#application-request)
      - [Application Response](#application-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)


## Application

### GetBytId

```js
GET {{host}}/application/get/{{id}}
```


#### GetById Request

```json
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
}
```

#### GetById Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "token": "eyJhb..z9dqcnXoY"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "amichai@mantinband.com",
    "password": "Amiko1232!"
}
```

```js
200 OK
```

#### Login Response

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "token": "eyJhb..hbbQ"
}
```