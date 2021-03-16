<#
Code generated by Microsoft (R) PSSwagger 0.3.0
Changes may cause incorrect behavior and will be lost if the code is regenerated.
#>

<#
.SYNOPSIS
    

.DESCRIPTION
    

.PARAMETER SynchronizeDeletion
    whether to delete the destination migrated e-mails that have been deleted from the source

.PARAMETER PolicyId
    the id of migration policy

.PARAMETER Schedule
    the schedule for the migration

.PARAMETER MigrateFilters
    Whether to migrate Gmail filters to exchange inbox rules

.PARAMETER DatabaseId
    the id of migration database

.PARAMETER PlanGroups
    

.PARAMETER NameLabel
    Large migration projects are often phased over several waves, each containing multiple plans. 
To easily generate migration reports for each project or wave, we recommend the Example name format Business Unit_Wave_Plan

#>
function New-GmailPlanSettingsObject
{
    param(    
        [Parameter(Mandatory = $false)]
        [switch]
        $SynchronizeDeletion,
    
        [Parameter(Mandatory = $false)]
        [string]
        $PolicyId,
    
        [Parameter(Mandatory = $false)]
        [AvePoint.PowerShell.FLYMigration.Models.SimpleSchedule]
        $Schedule,
    
        [Parameter(Mandatory = $false)]
        [switch]
        $MigrateFilters,
    
        [Parameter(Mandatory = $false)]
        [string]
        $DatabaseId,
    
        [Parameter(Mandatory = $false)]
        [string[]]
        $PlanGroups,
    
        [Parameter(Mandatory = $true)]
        [AvePoint.PowerShell.FLYMigration.Models.PlanNameLabel]
        $NameLabel
    )
    
    $Object = New-Object -TypeName AvePoint.PowerShell.FLYMigration.Models.GmailPlanSettingsModel

    $PSBoundParameters.GetEnumerator() | ForEach-Object { 
        if(Get-Member -InputObject $Object -Name $_.Key -MemberType Property)
        {
            $Object.$($_.Key) = $_.Value
        }
    }

    if(Get-Member -InputObject $Object -Name Validate -MemberType Method)
    {
        $Object.Validate()
    }

    return $Object
}