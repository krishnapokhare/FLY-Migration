<#
Code generated by Microsoft (R) PSSwagger 0.3.0
Changes may cause incorrect behavior and will be lost if the code is regenerated.
#>


# If the user supplied -Prefix to Import-Module, that applies to the nested module as well
# Force import the nested module again without -Prefix

Add-Type -AssemblyName System.Web

 enum PreScanType
{
	SharePoint = 0
	Exchange = 1
	Groups = 2
	Teams = 3
	Slack = 4
	Gmail = 5
	GoogleDrive = 6
	FileSystem = 7
	Box = 8
	Dropbox = 9
}

function Get-PreMigrationReport 
{
    param(    
        [Parameter(Mandatory = $false)]
        [string]
        $APIKey,
    
        [Parameter(Mandatory = $false)]
        [string]
        $BaseUri,

        [String]
        $ScopeName,
		
		[PreScanType]
		$Type,
		
        [String]
        $SavePath
		
    )
	$encodeName = [System.Web.HttpUtility]::UrlEncode($ScopeName)
    $response = Invoke-WebRequest -Uri $BaseUri"/api/premigration/plans/downloadreport?name=$encodeName&type=$Type" -Headers @{"Authorization" ="api_key $ApiKey"} -Method Get
	if($response.Headers["Content-Length"].Length -eq 2)
       {
            Write-Host -ForegroundColor Red("Download failed, please check if the information entered is correct. ")
       }else
       {
          $Name = $response.Headers["Content-Disposition"].split(";")[1].split('"')[1]
			$path = "$SavePath\$Name"
			$file = [System.IO.FileStream]::new($path, [System.IO.FileMode]::Create)
			$file.write($response.Content, 0, $response.RawContentLength)
			$file.close()
           return @{content = "Successful download of report."}
       }

}

Export-ModuleMember -Function Get-PreMigrationReport 