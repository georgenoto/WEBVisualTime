param(
    [ValidateSet('Web', 'Api', 'All')]
    [string]$Target = 'Web',
    [ValidateRange(1, 12)]
    [int]$Processors = 3,
    [switch]$NoRestore,
    [switch]$FullAnalysis
)

# These limits apply only to this invocation and its child processes.
$workspacePath = Split-Path $PSScriptRoot -Parent
$projectPath = switch ($Target) {
    'Web' { Join-Path $workspacePath 'WEBVisualTime.Web/WEBVisualTime.Web.csproj' }
    'Api' { Join-Path $workspacePath 'WEBVisualTime.WebApi/WEBVisualTime.WebApi.csproj' }
    'All' { Join-Path $workspacePath 'WEBVisualTime.sln' }
}
$previousProcessorCount = $env:DOTNET_PROCESSOR_COUNT
$hostProcess = [System.Diagnostics.Process]::GetCurrentProcess()
$previousPriority = $hostProcess.PriorityClass
$buildExitCode = 1
try {
    $env:DOTNET_PROCESSOR_COUNT = [string]$Processors
    $hostProcess.PriorityClass = 'BelowNormal'
    $buildArguments = @('build', $projectPath, '-m:1', '-p:UseSharedCompilation=false', '-p:ConcurrentBuild=false')
    if ($NoRestore) { $buildArguments += '--no-restore' }
    if (-not $FullAnalysis) { $buildArguments += '-p:RunAnalyzersDuringBuild=false' }
    Write-Host "Building $Target with DOTNET_PROCESSOR_COUNT=$Processors and BelowNormal priority."
    & dotnet @buildArguments
    $buildExitCode = $LASTEXITCODE
}
finally {
    $env:DOTNET_PROCESSOR_COUNT = $previousProcessorCount
    $hostProcess.PriorityClass = $previousPriority
}
exit $buildExitCode
