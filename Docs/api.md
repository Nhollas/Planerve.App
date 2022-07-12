### API
*12-07-2022*

- [API](#api)
  - [Authentication](#authentication)
    - **Login**
      - Login Request
      - Login Response
    - **Register**
      - Register Request
      - Register Response
  - [Application](#application)
    - **GetById**
      - GetById Response
    - **List**
      - List Response
    - **Delete**
      - Delete Response
    - **Copy**
      - Copy Request
      - Copy Response
    - **Share**
      - Share Request
      - Share Response
  - [Form](#form)
    - **GetById**
      - GetById Response
    - **Update**
      - Update Request

<br></br>

### Authentication
#### Login

```js
POST /api/authentication/login
```

##### Login Request

```json
{
  "username": "Nhollas",
  "password": "PasswordPhrase"
}
```

```js
200 OK
```

##### Login Response

```json
{
  "token": "eyJhb......."
}
```

<br></br>

#### Register

```js
POST /api/authentication/register
```

##### Register Request

```json
{
  "email": "test@test.com",
  "username": "Nhollas",
  "password": "PasswordPhrase"
}
```

```js
200 OK
```

##### Register Response

```json
{
  "userId": "0f6f866c-10a0-4352-b597-e19b6e3ed332",
  "email": "test@test.com",
  "username": "Nhollas"
}
```
<br></br>

### Application

#### Get

```js
GET /api/application/get/{id}
```


##### Get Response

```js
200 OK
```

```json

{
  "id": "f93200b9-23f5-43eb-9cb0-08da5df49c2d",
  "applicationReference": "PP-718129895",
  "applicationName": "Test Application",
  "versionNumber": "V1",
  "createdBy": "b18612d3-7a86-4899-9d6f-989019574d8c",
  "createdDate": "2022-07-04T19:37:20.0835602",
  "lastModifiedBy": null,
  "lastModifiedDate": "0001-01-01T00:00:00",
  "type": {
    "id": "f93200b9-23f5-43eb-9cb0-08da5df49c2d",
    "value": 1,
    "name": "Householder planning permission",
    "group": "Householder planning & prior approval",
    "description": "This is a description of the type of application",
    "categoryName": "Standard Application",
    "categoryDescription": "default"
  },
  "document": {
    "id": "f93200b9-23f5-43eb-9cb0-08da5df49c2d",
    "documentCount": 0,
    "completedRequirementsCount": 0,
    "totalRequirementCount": 2,
    "documentRequirements": [
      {
        "name": "Plans and drawings",
        "description": "This is a description of the requirement",
      },
      {
        "name": "Location plan",
        "description": "This is a description of the requirement"
      }
    ]
  },
  "progress": {
    "id": "f93200b9-23f5-43eb-9cb0-08da5df49c2d",
    "applicationStatus": "DRAFT",
    "progressPercentage": 10,
    "formSectionsComplete": false,
    "plansAndDocsComplete": false,
    "calculatedFee": false,
    "submittedToLocalAuthority": false
  }
}
```
<br></br>

#### List

```js
GET /api/application/list
```

##### List Response

```js
200 OK
```

```js
[
  {
     "ApplicationOne"
  },
  {
     "ApplicationTwo"
  },
  {
     "ApplicationThree"
  }
]
```

<br></br>

#### Delete

```js
DELETE /api/application/delete/{id}
```
##### Delete Response

```js
204 No Content
```

<br></br>

#### Copy

```js
POST /api/application/copy
```

##### Copy Request

```js
{
  "applicationId": "47121ca2-5399-4b62-9cb1-08da5df49c2d",
  "applicationName": "Test Application",
  "applicantDetails": true,
  "agentDetails": true,
  "siteDetails": true
}
```
##### Copy Response

```js
200 OK
```

```js
{
  "75956510-35b8-404a-9cb2-08da5df49c2d"
}
```

<br></br>

#### Share

```js
POST /api/application/share
```

##### Share Request

```js
{
  "applicationId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "usernameOrEmail": "Nhollas",
  "editPermission": true,
  "readApplication": true,
  "deleteApplication": true,
  "copyApplication": true,
  "archiveApplication": true,
  "shareApplication": true,
  "readForm": true,
  "updateForm": true,
  "downloadForm": true,
  "expiryDate": "2022-07-04T19:48:59.388Z"
}
```
##### Share Response

```js
204 No Content
```

<br></br>

### Form

#### Get

```js
GET /api/form/get/{id}/type/{type}
```


##### Get Response (Generic)

```js
200 OK
```

```json
{
  // Form Type 1
  "type": 1,
  "data": {
    "formId": "75956510-35b8-404a-9cb2-08da5df49c2d",
    "applicantSection": null,
    "agentSection": null,
    "proposalSection": null,
    "siteSection": null,
    "accessSection": null,
    "adviceSection": null,
    "treeAndHedgeSection": null,
    "parkingSection": null,
    "authorityMemberSection": null,
    "materialSection": null,
    "ownershipCertificationSection": null,
    "siteVisitSection": null,
    "createdBy": "b18612d3-7a86-4899-9d6f-989019574d8c",
    "createdDate": "2022-07-04T19:45:50.431856",
    "lastModifiedBy": null,
    "lastModifiedDate": null
  }
}
```

```json
{
  // Form Type 2
  "type": 2,
  "data": {
    "formId": "39b5d019-7ef6-4e92-b5b9-08da64555718",
    "siteSection": null,
    "applicantSection": null,
    "agentSection": null,
    "proposalSection": null,
    "existingUseSection": null,
    "materialSection": null,
    "accessSection": null,
    "parkingSection": null,
    "treeAndHedgeSection": null,
    "floodRiskSection": null,
    "biodiversitySection": null,
    "foulSewageSection": null,
    "wasteSection": null,
    "tradeEffluentSection": null,
    "residentialUnitsSection": null,
    "floorSpaceSection": null,
    "employmentSection": null,
    "openingHoursSection": null,
    "industrialMachinerySection": null,
    "hazardousSubstanceSection": null,
    "siteVisitSection": null,
    "adviceSection": null,
    "authorityMemberSection": null,
    "ownershipCertificationSection": null,
    "createdBy": "ee2c4d40-c075-4430-8004-02def8a51930",
    "createdDate": "2022-07-12T22:24:55.2735756",
    "lastModifiedBy": null,
    "lastModifiedDate": null
  }
}
```

```json
{
  // Form Type 3
  "type": 3,
  "data": {
    "formId": "1dde7eea-810f-4393-bb7d-08da6455f87a",
    "siteSection": null,
    "applicantSection": null,
    "agentSection": null,
    "conditionProposalSection": null,
    "dischargeConditionSection": null,
    "siteVisitSection": null,
    "adviceSection": null,
    "createdBy": "ee2c4d40-c075-4430-8004-02def8a51930",
    "createdDate": "2022-07-12T22:29:23.2848893",
    "lastModifiedBy": null,
    "lastModifiedDate": null
  }
}
```
<br></br>

#### Update

```js
PUT /api/form/update/{id}/section/{name}
```

##### Update Requests (Generic)
```json
  // Applicant Section
  {
    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "title": "string",
    "firstName": "string",
    "lastName": "string",
    "company": "string",
    "copyFromSiteAddress": true,
    "addressLineOne": "string",
    "addressLineTwo": "string",
    "addressLineThree": "string",
    "town": "string",
    "country": "string",
    "postcode": "string",
    "isAgent": true,
    "email": "string",
    "phone": "string"
  }
```
```json
  // Agent Section
  {
    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "title": "string",
    "firstName": "string",
    "lastName": "string",
    "company": "string",
    "addressLineOne": "string",
    "addressLineTwo": "string",
    "addressLineThree": "string",
    "town": "string",
    "country": "string",
    "postcode": "string",
    "email": "string",
    "phone": "string"
  }
```
```json
  // Site Section
  {
    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "description": "string",
    "hasStarted": true,
    "startDate": "2022-07-04T20:29:04.020Z",
    "hasCompleted": true,
    "completionDate": "2022-07-04T20:29:04.020Z"
  }
```

##### Update Response

```js
204 No Content
```

<br></br>