# MewMewMaterials API Contracts

## Request Contracts

### MewMewDepositContract

```json
{
    "meowMage": {
        "id": "51c6b47c-d4f2-4510-996c-b1315044db5c",
        "name": "Spaceloafs the Handsome",
        "flavorText": "The most Hamsome loaf in the land."
    },
    "reagentName": "catnip",
    "quantity": 5
}
```

| property | type | description | required |
| - | - | - | - |
| meowMage | `MeowMageContract` | The mage making the deposit | `true` |
| reagentName | `string` | The reagent name | `true` |
| quantity | `int` | Quantity of the reagent to be deposited | `true` |

### MewMewGetCacheContract

```json
{
    "meowMageId": "51c6b47c-d4f2-4510-996c-b1315044db5c"
}
```

| property | type | description | required |
| - | - | - | - |
| meowMageId | `string` | The unique id of the mage cache owner | `true` |

### MewMewUpdateCacheContract

```json
{
    "cache": {
        "id": "4864bcc7-8723-4358-bf8f-bd743208cfe5",
        "meowMage": {
            "id": "51c6b47c-d4f2-4510-996c-b1315044db5c",
            "name": "Spaceloafs the Handsome",
            "flavorText": "The most Hamsome loaf in the land."
        },
        "reagents": [
            {
                "id": "a581f910-8872-4d26-b958-bc547bd6e53a",
                "name": "catnip",
                "quantity": "5",
                "flavorText": "Wanna get high?"
            }
        ]
    }
}
```

| property | type | description | required |
| - | - | - | - |
| cache | `CacheContract` | The cache to be updated | `true` |

## Response Contract

### MewMewResponseContract

```json
{
    "statusCode": "Success",
    "cache": {
        "id": "4864bcc7-8723-4358-bf8f-bd743208cfe5",
        "meowMage": {
            "id": "51c6b47c-d4f2-4510-996c-b1315044db5c",
            "name": "Spaceloafs the Handsome",
            "flavorText": "The most Hamsome loaf in the land."
        },
        "reagents": [
            {
                "id": "a581f910-8872-4d26-b958-bc547bd6e53a",
                "name": "catnip",
                "quantity": "5",
                "flavorText": "Wanna get high?"
            }
        ]
    },
    "message": "Successfully added 5 catnip to Spaceloaf's cache."
}
```

| property | type | description | required |
| - | - | - | - |
| statusCode | `StatusCode` | Grpc status code | `true` |
| cache | `CacheContract` | The cache contract contains materials data | `true` |
| message | `string` | Optional response message | `false` |

## Inner Contracts

### CacheContract

| property | type | description | required |
| - | - | - | - |
| id | `string` | unique cache id, string from guid | `true` |
| meowMage | `MeowMageContract` | the meowMageContract has the cache owner data | `true` |
| reagents | `List<ReagentContract>` | A list of reagents in the cache | `true` |

### MeowMageContract

| property | type | description | required |
| - | - | - | - |
| id | `string` | unique mage id, string from guid | `true` |
| name | `string` | The mage's name | `true` |
| flavorText | `string` | Optional flavor text about the mage | `false` |

### ReagentsContract

| property | type | description | required |
| - | - | - | - |
| id | `string` | unique reagent id, string from guid | `true` |
| name | `string` | The reagent's name | `true` |
| quantity | `int` | Quantity of the reagent | `true` |
| flavorText | `string` | Optional flavor text about the reagent | `false` |
