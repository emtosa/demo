$rg = 'arm-intro-01'
New-AzResourceGroup -Name $rg -Location westus2 -Force

New-AzResourceGroupDeployment `
    -Name 'new-function' `
    -ResourceGroupName $rg `
    -TemplateFile '01-azurefunction.json'