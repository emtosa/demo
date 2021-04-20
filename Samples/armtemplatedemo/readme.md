# ARM templates key concepts
- JSON format
- Standard properties
- Multiple resources support
- Parameterization
- Outputs
- templated resource
- resource provider versions
- multiple ways of deployment

Sample arm template for a storage account
{
    "type":"Microsoft.Storage/storageAccounts",
    "apiVersion":"2019-06-01",
    "name":"armdemostroage",
    "location":"northeurope",
    "sku":{
        "name":"Standard_LRS"
    },
    "kind":"StorageV2",
    "properties":{
        "accessTier":"Hot"
    }
}

# pre-reqs
install powershell 7.1
install azure powershell

# create sample arm templates
create azure function
create azure storage account


# reference
ARM templates tutorial - https://www.youtube.com/watch?v=Ge_Sp-1lWZ4&t=735s
