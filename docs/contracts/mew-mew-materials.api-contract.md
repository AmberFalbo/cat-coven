# MewMewMaterials API Contracts

## Request Contracts

### MewMewDepositContract

| property | type | description | required |
| - | - | - | - |
| meowMage | `MeowMageContract` | The mage making the deposit | `true` |
| reagentName | `string` | The reagent name | `true` |
| quantity | `int` | Quantity of the reagent to be deposited | `true` |

### MewMewGetCacheContract

| property | type | description | required |
| - | - | - | - |
| meowMageId | `string` | The unique id of the mage cache owner | `true` |

### MewMewUpdateCacheContract

| property | type | description | required |
| - | - | - | - |
| cache | `CacheContract` | The cache to be updated | `true` |

## Response Contract

### MewMewResponseContract

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
