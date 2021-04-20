$rg = 'arm-introduction-001'
New-AzResourceGroup -Name $rg -Location northeurope -Force

New-AzResourceGroupDeployment `
    -Name 'new-storage' `
    -ResourceGroupName $rg `
    -TemplateFile '01-storage.json'
