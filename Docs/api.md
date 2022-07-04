### API
*04-07-2022*

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
      - GetById Request
      - GetById Response
    - **UpdateTypeA**
      - UpdateTypeA Request
      - UpdateTypeA Response
    - **UpdateTypeB**
      - UpdateTypeB Request
      - UpdateTypeB Response
    - **etc.**

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
GET /api/form/get/{id}
```


##### Get Response

```js
200 OK
```

```json
{
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
<br></br>

#### UpdateTypeA

```js
PUT /api/form/update/typea/{id}
```

##### Update Request
```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "applicantSection": {
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
  },
  "agentSection": {
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
  },
  "proposalSection": {
    "description": "string",
    "hasStarted": true,
    "startDate": "2022-07-04T20:29:04.020Z",
    "hasCompleted": true,
    "completionDate": "2022-07-04T20:29:04.020Z"
  },
  "siteSection": {
    "autoPopulated": true,
    "houseNumber": "string",
    "propertyName": "string",
    "addressLineOne": "string",
    "addressLineTwo": "string",
    "addressLineThree": "string",
    "town": "string",
    "postcode": "string",
    "easting": "string",
    "northing": "string",
    "description": "string"
  },
  "accessSection": {
    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "newVehicleAccess": true,
    "newAlteredPedestrianAccess": true,
    "affectingRightOfWay": true,
    "drawingReferenceNumbers": "string"
  },
  "adviceSection": {
    "adviceSought": true,
    "contactTitle": "string",
    "contactFirstName": "string",
    "contactLastName": "string",
    "referenceNumber": "string",
    "date": "2022-07-04T20:29:04.020Z",
    "adviceDescription": "string"
  },
  "treeAndHedgeSection": {
    "fallingTreesHedge": true,
    "fallingTreeHedgeReference": "string",
    "treeHedgeRemoved": true,
    "treeHedgeRemovedReference": "string"
  },
  "parkingSection": {
    "affectingParking": true,
    "parkingDescription": "string"
  },
  "authorityMemberSection": {
    "isRelated": true,
    "relatedInformation": "string"
  },
  "materialSection": {
    "materialsRequired": true,
    "materialTypes": [
      {
        "name": "string",
        "existingMaterial": "string",
        "proposedMaterial": "string"
      }
    ],
    "additionalInformation": true,
    "documentReference": "string"
  },
  "ownershipCertificationSection": {
    "selectedCertificate": 0,
    "soleOwner": true,
    "isAgriculturalHolding": true,
    "giveAppropriateNotice": true,
    "giveSomeNotice": true,
    "certificateA": {
      "role": 0,
      "title": "string",
      "firstName": "string",
      "lastName": "string",
      "declarationDate": "2022-07-04T20:29:04.020Z",
      "declarationMade": true
    },
    "certificateB": {
      "certifies": true,
      "role": 0,
      "title": "string",
      "firstName": "string",
      "lastName": "string",
      "declarationDate": "2022-07-04T20:29:04.020Z",
      "declarationMade": true
    },
    "certificateC": {
      "stepsTakenDescription": "string",
      "publishedInPaper": "string",
      "publishedDate": "2022-07-04T20:29:04.020Z",
      "role": 0,
      "title": "string",
      "firstName": "string",
      "lastName": "string",
      "declarationDate": "2022-07-04T20:29:04.020Z",
      "declarationMade": true
    },
    "certificateD": {
      "stepsTaken": "string",
      "publishedInPaper": "string",
      "publishedDate": "2022-07-04T20:29:04.020Z",
      "role": 0,
      "title": "string",
      "firstName": "string",
      "lastName": "string",
      "declarationDate": "2022-07-04T20:29:04.020Z",
      "declarationMade": true
    },
    "persons": [
      {
        "certificateId": 0,
        "name": "string",
        "houseName": "string",
        "houseNumber": "string",
        "addressLineOne": "string",
        "addressLineTwo": "string",
        "addressLineThree": "string",
        "town": "string",
        "postcode": "string",
        "noticeServed": "2022-07-04T20:29:04.020Z"
      }
    ]
  },
  "siteVisitSection": {
    "siteVisible": true,
    "appointmentContactType": 0,
    "title": "string",
    "firstName": "string",
    "lastName": "string",
    "phone": "string",
    "email": "string"
  }
}
```


##### Update Response

```js
204 No Content
```

<br></br>

#### UpdateTypeB

```js
PUT /api/form/update/typeb/{id}
```

##### Update Request
```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "applicantSection": {
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
  },
  "agentSection": {
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
  },
  "proposalSection": {
    "description": "string",
    "hasStarted": true,
    "startDate": "2022-07-04T20:34:08.773Z",
    "hasCompleted": true,
    "completionDate": "2022-07-04T20:34:08.773Z"
  },
  "siteSection": {
    "autoPopulated": true,
    "houseNumber": "string",
    "propertyName": "string",
    "addressLineOne": "string",
    "addressLineTwo": "string",
    "addressLineThree": "string",
    "town": "string",
    "postcode": "string",
    "easting": "string",
    "northing": "string",
    "description": "string"
  },
  "adviceSection": {
    "adviceSought": true,
    "contactTitle": "string",
    "contactFirstName": "string",
    "contactLastName": "string",
    "referenceNumber": "string",
    "date": "2022-07-04T20:34:08.773Z",
    "adviceDescription": "string"
  },
  "accessSection": {
    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "newVehicleAccess": true,
    "newAlteredPedestrianAccess": true,
    "affectingRightOfWay": true,
    "drawingReferenceNumbers": "string"
  },
  "wasteSection": {
    "storeCollectWaste": true,
    "storeCollectWasteDetails": "string",
    "storeCollectRecyclableWaste": true,
    "storeCollectRecyclableWasteDetails": "string"
  },
  "authorityMemberSection": {
    "isRelated": true,
    "relatedInformation": "string"
  },
  "materialSection": {
    "materialsRequired": true,
    "materialTypes": [
      {
        "name": "string",
        "existingMaterial": "string",
        "proposedMaterial": "string"
      }
    ],
    "additionalInformation": true,
    "documentReference": "string"
  },
  "parkingSection": {
    "affectingParking": true,
    "parkingDescription": "string"
  },
  "foulSewageSection": {
    "otherMethod": "string",
    "connectingToExistingDrainage": true,
    "documentReferences": "string",
    "mainsSewer": true,
    "septicTank": true,
    "packageTreatmentPlant": true,
    "cessPit": true,
    "other": true,
    "unknown": true
  },
  "floodRiskSection": {
    "isFloodRisk": true,
    "proximityOfWatercourse": true,
    "increaseFloodRisk": true,
    "sustainableDrainage": true,
    "existingWaterCourse": true,
    "soakaway": true,
    "mainSewer": true,
    "pondLake": true
  },
  "biodiversitySection": {
    "protectedSpecies": 0,
    "designatedSite": 0,
    "featuresOfGeological": 0
  },
  "existingUseSection": {
    "currentUseDescription": "string",
    "isVacant": true,
    "lastUseDescription": "string",
    "useEnded": "2022-07-04T20:34:08.773Z",
    "landToBeContaminated": true,
    "partLandToBeContaminated": true,
    "useSusceptibleToContamination": true
  },
  "treeAndHedgeSection": {
    "fallingTreesHedge": true,
    "fallingTreeHedgeReference": "string",
    "treeHedgeRemoved": true,
    "treeHedgeRemovedReference": "string"
  },
  "tradeEffluentSection": {
    "disposeTradeWaste": true,
    "tradeWasteDescription": true
  },
  "employmentSection": {
    "isEmploymentChanged": true,
    "existingFullTime": "string",
    "existingPartTime": "string",
    "existingTotalFullTimeEquivalent": "string",
    "proposedFullTime": "string",
    "proposedPartTime": "string",
    "proposedTotalFullTimeEquivalent": "string"
  },
  "openingHoursSection": {
    "isRelevant": true,
    "useClasses": [
      {
        "type": 0,
        "isKnown": true,
        "mtoFStart": "2022-07-04T20:34:08.773Z",
        "mtoFEnd": "2022-07-04T20:34:08.773Z",
        "saturdayStart": "2022-07-04T20:34:08.773Z",
        "saturdayEnd": "2022-07-04T20:34:08.773Z",
        "specialStart": "2022-07-04T20:34:08.773Z",
        "specialEnd": "2022-07-04T20:34:08.773Z"
      }
    ]
  },
  "industrialMachinerySection": {
    "processesAndProducts": "string",
    "doesInvolveIndustrialCommercial": true,
    "isProposalWasteManagementDevelopment": true,
    "wasteManagementDetails": [
      {
        "wasteManagementType": "string",
        "totalVoidCapacityVolumeUnit": "string",
        "maxAnnualOperationalThroughputVolumeUnit": "string",
        "totalVoidCapacity": 0,
        "maxAnnualOperationalThroughput": 0
      }
    ],
    "wasteStreamDetails": [
      {
        "wasteStreamType": "string",
        "maxAnnualOperationalThroughputVolumeUnit": "string",
        "maxAnnualOperationalThroughput": 0
      }
    ]
  },
  "hazardousSubstanceSection": {
    "involvesHazardousSubstances": true,
    "substances": [
      {
        "name": "string",
        "amount": 0
      }
    ]
  },
  "ownershipCertificationSection": {
    "selectedCertificate": 0,
    "soleOwner": true,
    "isAgriculturalHolding": true,
    "giveAppropriateNotice": true,
    "giveSomeNotice": true,
    "certificateA": {
      "role": 0,
      "title": "string",
      "firstName": "string",
      "lastName": "string",
      "declarationDate": "2022-07-04T20:34:08.773Z",
      "declarationMade": true
    },
    "certificateB": {
      "certifies": true,
      "role": 0,
      "title": "string",
      "firstName": "string",
      "lastName": "string",
      "declarationDate": "2022-07-04T20:34:08.773Z",
      "declarationMade": true
    },
    "certificateC": {
      "stepsTakenDescription": "string",
      "publishedInPaper": "string",
      "publishedDate": "2022-07-04T20:34:08.773Z",
      "role": 0,
      "title": "string",
      "firstName": "string",
      "lastName": "string",
      "declarationDate": "2022-07-04T20:34:08.773Z",
      "declarationMade": true
    },
    "certificateD": {
      "stepsTaken": "string",
      "publishedInPaper": "string",
      "publishedDate": "2022-07-04T20:34:08.773Z",
      "role": 0,
      "title": "string",
      "firstName": "string",
      "lastName": "string",
      "declarationDate": "2022-07-04T20:34:08.773Z",
      "declarationMade": true
    },
    "persons": [
      {
        "certificateId": 0,
        "name": "string",
        "houseName": "string",
        "houseNumber": "string",
        "addressLineOne": "string",
        "addressLineTwo": "string",
        "addressLineThree": "string",
        "town": "string",
        "postcode": "string",
        "noticeServed": "2022-07-04T20:34:08.773Z"
      }
    ]
  },
  "siteVisitSection": {
    "siteVisible": true,
    "appointmentContactType": 0,
    "title": "string",
    "firstName": "string",
    "lastName": "string",
    "phone": "string",
    "email": "string"
  }
}
```


##### Update Response

```js
204 No Content
```

