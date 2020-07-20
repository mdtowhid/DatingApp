#
# Module manifest for module 'EntityFrameworkCore'
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'EntityFrameworkCore.psm1'

# Version number of this module.
ModuleVersion = '5.0.0'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = 'c126fb40-c0f1-43ae-8dd0-06bb50512eb2'

# Author of this module
Author = 'Entity Framework Team'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = '(c) .NET Foundation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Entity Framework Core Package Manager Console Tools'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '3.0'

# Name of the Windows PowerShell host required by this module
PowerShellHostName = 'Package Manager Host'

# Minimum version of the Windows PowerShell host required by this module
PowerShellHostVersion = '1.2'

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.0'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = (
    'Add-Migration',
    'Drop-Database',
    'Enable-Migrations',
    'Get-DbContext',
    'Remove-Migration',
    'Scaffold-DbContext',
    'Script-DbContext',
    'Script-Migration',
    'Update-Database'
)

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        # Tags = @()

        # A URL to the license for this module.
        # LicenseUri = ''

        # A URL to the main website for this project.
        # ProjectUri = ''

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        # ReleaseNotes = ''

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

# SIG # Begin signature block
# MIIkXwYJKoZIhvcNAQcCoIIkUDCCJEwCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCBhY3y7qXW4MQTs
# rJ9XyI6H0mNbm5gvKWkqLrB7pWp4qKCCDYUwggYDMIID66ADAgECAhMzAAABUptA
# n1BWmXWIAAAAAAFSMA0GCSqGSIb3DQEBCwUAMH4xCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNpZ25p
# bmcgUENBIDIwMTEwHhcNMTkwNTAyMjEzNzQ2WhcNMjAwNTAyMjEzNzQ2WjB0MQsw
# CQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9u
# ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMR4wHAYDVQQDExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIB
# AQCxp4nT9qfu9O10iJyewYXHlN+WEh79Noor9nhM6enUNbCbhX9vS+8c/3eIVazS
# YnVBTqLzW7xWN1bCcItDbsEzKEE2BswSun7J9xCaLwcGHKFr+qWUlz7hh9RcmjYS
# kOGNybOfrgj3sm0DStoK8ljwEyUVeRfMHx9E/7Ca/OEq2cXBT3L0fVnlEkfal310
# EFCLDo2BrE35NGRjG+/nnZiqKqEh5lWNk33JV8/I0fIcUKrLEmUGrv0CgC7w2cjm
# bBhBIJ+0KzSnSWingXol/3iUdBBy4QQNH767kYGunJeY08RjHMIgjJCdAoEM+2mX
# v1phaV7j+M3dNzZ/cdsz3oDfAgMBAAGjggGCMIIBfjAfBgNVHSUEGDAWBgorBgEE
# AYI3TAgBBggrBgEFBQcDAzAdBgNVHQ4EFgQU3f8Aw1sW72WcJ2bo/QSYGzVrRYcw
# VAYDVR0RBE0wS6RJMEcxLTArBgNVBAsTJE1pY3Jvc29mdCBJcmVsYW5kIE9wZXJh
# dGlvbnMgTGltaXRlZDEWMBQGA1UEBRMNMjMwMDEyKzQ1NDEzNjAfBgNVHSMEGDAW
# gBRIbmTlUAXTgqoXNzcitW2oynUClTBUBgNVHR8ETTBLMEmgR6BFhkNodHRwOi8v
# d3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL2NybC9NaWNDb2RTaWdQQ0EyMDExXzIw
# MTEtMDctMDguY3JsMGEGCCsGAQUFBwEBBFUwUzBRBggrBgEFBQcwAoZFaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNDb2RTaWdQQ0EyMDEx
# XzIwMTEtMDctMDguY3J0MAwGA1UdEwEB/wQCMAAwDQYJKoZIhvcNAQELBQADggIB
# AJTwROaHvogXgixWjyjvLfiRgqI2QK8GoG23eqAgNjX7V/WdUWBbs0aIC3k49cd0
# zdq+JJImixcX6UOTpz2LZPFSh23l0/Mo35wG7JXUxgO0U+5drbQht5xoMl1n7/TQ
# 4iKcmAYSAPxTq5lFnoV2+fAeljVA7O43szjs7LR09D0wFHwzZco/iE8Hlakl23ZT
# 7FnB5AfU2hwfv87y3q3a5qFiugSykILpK0/vqnlEVB0KAdQVzYULQ/U4eFEjnis3
# Js9UrAvtIhIs26445Rj3UP6U4GgOjgQonlRA+mDlsh78wFSGbASIvK+fkONUhvj8
# B8ZHNn4TFfnct+a0ZueY4f6aRPxr8beNSUKn7QW/FQmn422bE7KfnqWncsH7vbNh
# G929prVHPsaa7J22i9wyHj7m0oATXJ+YjfyoEAtd5/NyIYaE4Uu0j1EhuYUo5VaJ
# JnMaTER0qX8+/YZRWrFN/heps41XNVjiAawpbAa0fUa3R9RNBjPiBnM0gvNPorM4
# dsV2VJ8GluIQOrJlOvuCrOYDGirGnadOmQ21wPBoGFCWpK56PxzliKsy5NNmAXcE
# x7Qb9vUjY1WlYtrdwOXTpxN4slzIht69BaZlLIjLVWwqIfuNrhHKNDM9K+v7vgrI
# bf7l5/665g0gjQCDCN6Q5sxuttTAEKtJeS/pkpI+DbZ/MIIHejCCBWKgAwIBAgIK
# YQ6Q0gAAAAAAAzANBgkqhkiG9w0BAQsFADCBiDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEyMDAGA1UEAxMpTWljcm9zb2Z0IFJvb3QgQ2VydGlm
# aWNhdGUgQXV0aG9yaXR5IDIwMTEwHhcNMTEwNzA4MjA1OTA5WhcNMjYwNzA4MjEw
# OTA5WjB+MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UE
# BxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSgwJgYD
# VQQDEx9NaWNyb3NvZnQgQ29kZSBTaWduaW5nIFBDQSAyMDExMIICIjANBgkqhkiG
# 9w0BAQEFAAOCAg8AMIICCgKCAgEAq/D6chAcLq3YbqqCEE00uvK2WCGfQhsqa+la
# UKq4BjgaBEm6f8MMHt03a8YS2AvwOMKZBrDIOdUBFDFC04kNeWSHfpRgJGyvnkmc
# 6Whe0t+bU7IKLMOv2akrrnoJr9eWWcpgGgXpZnboMlImEi/nqwhQz7NEt13YxC4D
# dato88tt8zpcoRb0RrrgOGSsbmQ1eKagYw8t00CT+OPeBw3VXHmlSSnnDb6gE3e+
# lD3v++MrWhAfTVYoonpy4BI6t0le2O3tQ5GD2Xuye4Yb2T6xjF3oiU+EGvKhL1nk
# kDstrjNYxbc+/jLTswM9sbKvkjh+0p2ALPVOVpEhNSXDOW5kf1O6nA+tGSOEy/S6
# A4aN91/w0FK/jJSHvMAhdCVfGCi2zCcoOCWYOUo2z3yxkq4cI6epZuxhH2rhKEmd
# X4jiJV3TIUs+UsS1Vz8kA/DRelsv1SPjcF0PUUZ3s/gA4bysAoJf28AVs70b1FVL
# 5zmhD+kjSbwYuER8ReTBw3J64HLnJN+/RpnF78IcV9uDjexNSTCnq47f7Fufr/zd
# sGbiwZeBe+3W7UvnSSmnEyimp31ngOaKYnhfsi+E11ecXL93KCjx7W3DKI8sj0A3
# T8HhhUSJxAlMxdSlQy90lfdu+HggWCwTXWCVmj5PM4TasIgX3p5O9JawvEagbJjS
# 4NaIjAsCAwEAAaOCAe0wggHpMBAGCSsGAQQBgjcVAQQDAgEAMB0GA1UdDgQWBBRI
# bmTlUAXTgqoXNzcitW2oynUClTAZBgkrBgEEAYI3FAIEDB4KAFMAdQBiAEMAQTAL
# BgNVHQ8EBAMCAYYwDwYDVR0TAQH/BAUwAwEB/zAfBgNVHSMEGDAWgBRyLToCMZBD
# uRQFTuHqp8cx0SOJNDBaBgNVHR8EUzBRME+gTaBLhklodHRwOi8vY3JsLm1pY3Jv
# c29mdC5jb20vcGtpL2NybC9wcm9kdWN0cy9NaWNSb29DZXJBdXQyMDExXzIwMTFf
# MDNfMjIuY3JsMF4GCCsGAQUFBwEBBFIwUDBOBggrBgEFBQcwAoZCaHR0cDovL3d3
# dy5taWNyb3NvZnQuY29tL3BraS9jZXJ0cy9NaWNSb29DZXJBdXQyMDExXzIwMTFf
# MDNfMjIuY3J0MIGfBgNVHSAEgZcwgZQwgZEGCSsGAQQBgjcuAzCBgzA/BggrBgEF
# BQcCARYzaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9kb2NzL3ByaW1h
# cnljcHMuaHRtMEAGCCsGAQUFBwICMDQeMiAdAEwAZQBnAGEAbABfAHAAbwBsAGkA
# YwB5AF8AcwB0AGEAdABlAG0AZQBuAHQALiAdMA0GCSqGSIb3DQEBCwUAA4ICAQBn
# 8oalmOBUeRou09h0ZyKbC5YR4WOSmUKWfdJ5DJDBZV8uLD74w3LRbYP+vj/oCso7
# v0epo/Np22O/IjWll11lhJB9i0ZQVdgMknzSGksc8zxCi1LQsP1r4z4HLimb5j0b
# pdS1HXeUOeLpZMlEPXh6I/MTfaaQdION9MsmAkYqwooQu6SpBQyb7Wj6aC6VoCo/
# KmtYSWMfCWluWpiW5IP0wI/zRive/DvQvTXvbiWu5a8n7dDd8w6vmSiXmE0OPQvy
# CInWH8MyGOLwxS3OW560STkKxgrCxq2u5bLZ2xWIUUVYODJxJxp/sfQn+N4sOiBp
# mLJZiWhub6e3dMNABQamASooPoI/E01mC8CzTfXhj38cbxV9Rad25UAqZaPDXVJi
# hsMdYzaXht/a8/jyFqGaJ+HNpZfQ7l1jQeNbB5yHPgZ3BtEGsXUfFL5hYbXw3MYb
# BL7fQccOKO7eZS/sl/ahXJbYANahRr1Z85elCUtIEJmAH9AAKcWxm6U/RXceNcbS
# oqKfenoi+kiVH6v7RyOA9Z74v2u3S5fi63V4GuzqN5l5GEv/1rMjaHXmr/r8i+sL
# gOppO6/8MO0ETI7f33VtY5E90Z1WTk+/gFcioXgRMiF670EKsT/7qMykXcGhiJtX
# cVZOSEXAQsmbdlsKgEhr/Xmfwb1tbWrJUnMTDXpQzTGCFjAwghYsAgEBMIGVMH4x
# CzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRt
# b25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01p
# Y3Jvc29mdCBDb2RlIFNpZ25pbmcgUENBIDIwMTECEzMAAAFSm0CfUFaZdYgAAAAA
# AVIwDQYJYIZIAWUDBAIBBQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQw
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIFMp
# m7Ip1Gy/7E48ra2NJYzfkENb2J/Af8tzIsblRzp7MEIGCisGAQQBgjcCAQwxNDAy
# oBSAEgBNAGkAYwByAG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20wDQYJKoZIhvcNAQEBBQAEggEALzpyhsXmaN5BA7JDEk30P9+lS3I29X4PRCw2
# tUxmzqYaqC8SMGHQQe7M6AWkavloXtkJ5TsdOBsPl23B6zxtk0kvdGmEJBghZ4d1
# tclALV4J51gqR2u9vOA1tCIwM/mDxw+hV3Hw8qOMxohf5MPdSgb3DCcWCScd7/EM
# 8lWHpStPUVVG4XCaQlrEolqNJ5qC749tFO3C3BElI2LI09po+d5pTjb/NhQmOGGu
# MC2UtFXJgQ/dMWJe+vmbVV7kG8vxLUkr1wio14OzZIW9hL3jmo+cZYYGUSb8WCUp
# rMIIylH6lpJO0Dchfsjm4MfopNWwCCt59v5mRC7rvcHaPB1RX6GCE7owghO2Bgor
# BgEEAYI3AwMBMYITpjCCE6IGCSqGSIb3DQEHAqCCE5MwghOPAgEDMQ8wDQYJYIZI
# AWUDBAIBBQAwggFYBgsqhkiG9w0BCRABBKCCAUcEggFDMIIBPwIBAQYKKwYBBAGE
# WQoDATAxMA0GCWCGSAFlAwQCAQUABCCxUFZYWL5lvaxn3zli78IFJg3bt1dExrBZ
# pFIgFU9lqQIGXnptO3iIGBMyMDIwMDMzMTE5MTAwNS41ODdaMAcCAQGAAgH0oIHU
# pIHRMIHOMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UE
# BxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSkwJwYD
# VQQLEyBNaWNyb3NvZnQgT3BlcmF0aW9ucyBQdWVydG8gUmljbzEmMCQGA1UECxMd
# VGhhbGVzIFRTUyBFU046MzFDNS0zMEJBLTdDOTExJTAjBgNVBAMTHE1pY3Jvc29m
# dCBUaW1lLVN0YW1wIFNlcnZpY2Wggg8iMIIE9TCCA92gAwIBAgITMwAAAP4B8LUe
# /+n5rQAAAAAA/jANBgkqhkiG9w0BAQsFADB8MQswCQYDVQQGEwJVUzETMBEGA1UE
# CBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9z
# b2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQ
# Q0EgMjAxMDAeFw0xOTA5MDYyMDQxMDhaFw0yMDEyMDQyMDQxMDhaMIHOMQswCQYD
# VQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEe
# MBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSkwJwYDVQQLEyBNaWNyb3Nv
# ZnQgT3BlcmF0aW9ucyBQdWVydG8gUmljbzEmMCQGA1UECxMdVGhhbGVzIFRTUyBF
# U046MzFDNS0zMEJBLTdDOTExJTAjBgNVBAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFNlcnZpY2UwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDaA/Vk1M0v
# e7yZ/JfM5DIL6YNagd4HOmll6Sm3yP0Y4iRpQ8v+q6uitl8OmZqFS/pyejnDV8MA
# rXQpFh35P6h8IuO9xhB4Q68qApWCo1OOQ+wLfKCK9pDwadAorXLVMMXjLXceM2Bn
# YxNsk4W8WmggQSuuA6vbGq/mxWaTqsZKvQ66oxZyz9hsG7B1Qg1a8Fl/5YmXpb+2
# SODeNzs9Jr3LMQg03KOteVeljxaAHU2Im7f+3nn9HKbtBP8QFd0iWW61xwF57WmQ
# OIzN1T4M8MSdzPNRus8Yn0fjb806L2Yandt4bV+3ORTLyN+2kwOmM+TA+MhEcQqU
# RYaOB4pzS2+xAgMBAAGjggEbMIIBFzAdBgNVHQ4EFgQU9+MLMiDM5WTEVcXjZwgi
# lb2UEuQwHwYDVR0jBBgwFoAU1WM6XIoxkPNDe3xGG8UzaFqFbVUwVgYDVR0fBE8w
# TTBLoEmgR4ZFaHR0cDovL2NybC5taWNyb3NvZnQuY29tL3BraS9jcmwvcHJvZHVj
# dHMvTWljVGltU3RhUENBXzIwMTAtMDctMDEuY3JsMFoGCCsGAQUFBwEBBE4wTDBK
# BggrBgEFBQcwAoY+aHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraS9jZXJ0cy9N
# aWNUaW1TdGFQQ0FfMjAxMC0wNy0wMS5jcnQwDAYDVR0TAQH/BAIwADATBgNVHSUE
# DDAKBggrBgEFBQcDCDANBgkqhkiG9w0BAQsFAAOCAQEARAqk7hiliv/M8BBnYQ1A
# /pOcovWgUqnEK7afDA5tQXjWMxSmrr8kXsH9YqBbFL/cezAnBF40nn2ZfHfhPpNN
# WKZWLrnLo2N4UJT22A9xNd9nrSWQm8uxUxTb/picYXuf+93eU6CPLkqz7/Sbuj1M
# Qq91NDVwOv2bLAtNu0taPv3jlfrcRieONfs6bXZ5KHIz3LD7fuGmft7pwnF3S+uW
# X3UtI49Advj7ofhNAf1A66GNIL9fAAstGNlmk4NsnzaBdIx1FmBgDbN9rlFtn5AT
# 58hVdgmrv0ucty+LWRaGK7nlwJE+NztZ9p6eKrK6UC8ChF/zPusD2Ok5+KR+MOQV
# 9jCCBnEwggRZoAMCAQICCmEJgSoAAAAAAAIwDQYJKoZIhvcNAQELBQAwgYgxCzAJ
# BgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25k
# MR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xMjAwBgNVBAMTKU1pY3Jv
# c29mdCBSb290IENlcnRpZmljYXRlIEF1dGhvcml0eSAyMDEwMB4XDTEwMDcwMTIx
# MzY1NVoXDTI1MDcwMTIxNDY1NVowfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldh
# c2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBD
# b3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIw
# MTAwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQCpHQ28dxGKOiDs/BOX
# 9fp/aZRrdFQQ1aUKAIKF++18aEssX8XD5WHCdrc+Zitb8BVTJwQxH0EbGpUdzgkT
# jnxhMFmxMEQP8WCIhFRDDNdNuDgIs0Ldk6zWczBXJoKjRQ3Q6vVHgc2/JGAyWGBG
# 8lhHhjKEHnRhZ5FfgVSxz5NMksHEpl3RYRNuKMYa+YaAu99h/EbBJx0kZxJyGiGK
# r0tkiVBisV39dx898Fd1rL2KQk1AUdEPnAY+Z3/1ZsADlkR+79BL/W7lmsqxqPJ6
# Kgox8NpOBpG2iAg16HgcsOmZzTznL0S6p/TcZL2kAcEgCZN4zfy8wMlEXV4WnAEF
# TyJNAgMBAAGjggHmMIIB4jAQBgkrBgEEAYI3FQEEAwIBADAdBgNVHQ4EFgQU1WM6
# XIoxkPNDe3xGG8UzaFqFbVUwGQYJKwYBBAGCNxQCBAweCgBTAHUAYgBDAEEwCwYD
# VR0PBAQDAgGGMA8GA1UdEwEB/wQFMAMBAf8wHwYDVR0jBBgwFoAU1fZWy4/oolxi
# aNE9lJBb186aGMQwVgYDVR0fBE8wTTBLoEmgR4ZFaHR0cDovL2NybC5taWNyb3Nv
# ZnQuY29tL3BraS9jcmwvcHJvZHVjdHMvTWljUm9vQ2VyQXV0XzIwMTAtMDYtMjMu
# Y3JsMFoGCCsGAQUFBwEBBE4wTDBKBggrBgEFBQcwAoY+aHR0cDovL3d3dy5taWNy
# b3NvZnQuY29tL3BraS9jZXJ0cy9NaWNSb29DZXJBdXRfMjAxMC0wNi0yMy5jcnQw
# gaAGA1UdIAEB/wSBlTCBkjCBjwYJKwYBBAGCNy4DMIGBMD0GCCsGAQUFBwIBFjFo
# dHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vUEtJL2RvY3MvQ1BTL2RlZmF1bHQuaHRt
# MEAGCCsGAQUFBwICMDQeMiAdAEwAZQBnAGEAbABfAFAAbwBsAGkAYwB5AF8AUwB0
# AGEAdABlAG0AZQBuAHQALiAdMA0GCSqGSIb3DQEBCwUAA4ICAQAH5ohRDeLG4Jg/
# gXEDPZ2joSFvs+umzPUxvs8F4qn++ldtGTCzwsVmyWrf9efweL3HqJ4l4/m87WtU
# VwgrUYJEEvu5U4zM9GASinbMQEBBm9xcF/9c+V4XNZgkVkt070IQyK+/f8Z/8jd9
# Wj8c8pl5SpFSAK84Dxf1L3mBZdmptWvkx872ynoAb0swRCQiPM/tA6WWj1kpvLb9
# BOFwnzJKJ/1Vry/+tuWOM7tiX5rbV0Dp8c6ZZpCM/2pif93FSguRJuI57BlKcWOd
# eyFtw5yjojz6f32WapB4pm3S4Zz5Hfw42JT0xqUKloakvZ4argRCg7i1gJsiOCC1
# JeVk7Pf0v35jWSUPei45V3aicaoGig+JFrphpxHLmtgOR5qAxdDNp9DvfYPw4Ttx
# Cd9ddJgiCGHasFAeb73x4QDf5zEHpJM692VHeOj4qEir995yfmFrb3epgcunCaw5
# u+zGy9iCtHLNHfS4hQEegPsbiSpUObJb2sgNVZl6h3M7COaYLeqN4DMuEin1wC9U
# JyH3yKxO2ii4sanblrKnQqLJzxlBTeCG+SqaoxFmMNO7dDJL32N79ZmKLxvHIa9Z
# ta7cRDyXUHHXodLFVeNp3lfB0d4wwP3M5k37Db9dT+mdHhk4L7zPWAUu7w2gUDXa
# 7wknHNWzfjUeCLraNtvTX4/edIhJEqGCA7AwggKYAgEBMIH+oYHUpIHRMIHOMQsw
# CQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9u
# ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSkwJwYDVQQLEyBNaWNy
# b3NvZnQgT3BlcmF0aW9ucyBQdWVydG8gUmljbzEmMCQGA1UECxMdVGhhbGVzIFRT
# UyBFU046MzFDNS0zMEJBLTdDOTExJTAjBgNVBAMTHE1pY3Jvc29mdCBUaW1lLVN0
# YW1wIFNlcnZpY2WiJQoBATAJBgUrDgMCGgUAAxUAAqPIT1b2kOi1YyB25zHpa3Pn
# nAyggd4wgdukgdgwgdUxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9u
# MRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRp
# b24xKTAnBgNVBAsTIE1pY3Jvc29mdCBPcGVyYXRpb25zIFB1ZXJ0byBSaWNvMScw
# JQYDVQQLEx5uQ2lwaGVyIE5UUyBFU046NERFOS0wQzVFLTNFMDkxKzApBgNVBAMT
# Ik1pY3Jvc29mdCBUaW1lIFNvdXJjZSBNYXN0ZXIgQ2xvY2swDQYJKoZIhvcNAQEF
# BQACBQDiLToaMCIYDzIwMjAwMzMxMTE0MDEwWhgPMjAyMDA0MDExMTQwMTBaMHcw
# PQYKKwYBBAGEWQoEATEvMC0wCgIFAOItOhoCAQAwCgIBAAICHBQCAf8wBwIBAAIC
# Gz0wCgIFAOIui5oCAQAwNgYKKwYBBAGEWQoEAjEoMCYwDAYKKwYBBAGEWQoDAaAK
# MAgCAQACAxbjYKEKMAgCAQACAwehIDANBgkqhkiG9w0BAQUFAAOCAQEANDHTXUhP
# mVQlpMyh8o9VWAdbOzcpoNvOsbTBlGWybS/IIUEINgBh9l8BiOSnC70W/Kqq185Q
# fyMSE7FmbPW3UuXkKgIf2lq1HMwNawcTI5iWALevOD2eWa71u4BDt1+rU1KF4xHU
# t7uyp6gLPh6xVh3l14+xyF5mDjkndjbtSqoCjtcTVHCqrwqW9hr8wSruEXSViTDY
# u+KKeHBf3J83RSPAtTa3WL8K0dxFvbnoH5m6XWHXPHKS0uLpqYE4Tej4KSdjUz+m
# dlWBXHSusBth8FMGoZMUkEvA4+iI+mgfW6ao8r93nz5N67inv8786q0AsbptFeUG
# 6kmeG70g9B4UOjGCAvUwggLxAgEBMIGTMHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQI
# EwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3Nv
# ZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBD
# QSAyMDEwAhMzAAAA/gHwtR7/6fmtAAAAAAD+MA0GCWCGSAFlAwQCAQUAoIIBMjAa
# BgkqhkiG9w0BCQMxDQYLKoZIhvcNAQkQAQQwLwYJKoZIhvcNAQkEMSIEIFpcQmLe
# 4GxKKJCHHOKuaDQG5soUhA3JozhO06TlUhqUMIHiBgsqhkiG9w0BCRACDDGB0jCB
# zzCBzDCBsQQUAqPIT1b2kOi1YyB25zHpa3PnnAwwgZgwgYCkfjB8MQswCQYDVQQG
# EwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwG
# A1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQg
# VGltZS1TdGFtcCBQQ0EgMjAxMAITMwAAAP4B8LUe/+n5rQAAAAAA/jAWBBSBMGCr
# /wT4uh60eQ+qBCspd5gxGDANBgkqhkiG9w0BAQsFAASCAQC/nL41FKtmXj5hs839
# qyivCIPeiaACcIs8yvpi/yLqD5qweXPykH7giatnTJcT1KU+wcF8xyPAqtDAcIis
# BgIbOtJQ0DGjuarlMmhz/2P53TfhNX+yrBFNjEEKt5CeppPFhJEP1z7a6htBgwhz
# fge3LYjhbNz/WWCpfeL3Krqs1f3FUBozaVighuOoqsqLYq6BpxBF93NDbmnzseSe
# VGpYJCzwMau/oWX48X/cpxh+8/ewF4Etk7uXYwoJkGmlZWDxcs16rNBypN1EBQ7q
# IbJDtXF8UJc9NAfObufYCGanS5byzc3DEArUx6E0vsG3+qJUwYoT7O1yOq6ls3xq
# +S3E
# SIG # End signature block
