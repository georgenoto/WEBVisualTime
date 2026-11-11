param(
    [switch]$NoBuild,
    [switch]$NoRestore,
    [ValidateRange(1, 12)][int]$Processors = 3
)

$workspacePath = Split-Path $PSScriptRoot -Parent
$previousProcessorCount = $env:DOTNET_PROCESSOR_COUNT
$hostProcess = [System.Diagnostics.Process]::GetCurrentProcess()
$previousPriority = $hostProcess.PriorityClass
$verificationExitCode = 0
try {
    $env:DOTNET_PROCESSOR_COUNT = [string]$Processors
    $hostProcess.PriorityClass = 'BelowNormal'
    if (-not $NoBuild) {
        & (Join-Path $PSScriptRoot 'build-local.ps1') -Target All -Processors $Processors -NoRestore:$NoRestore
        if ($LASTEXITCODE -ne 0) { throw 'Application build failed.' }
    }
    foreach ($suite in @('ModelValidation', 'CrudSmoke', 'ClientFlow', 'ArchitectureFlow', 'PrimaImportacion', 'PrimaFlow', 'PrimaPublicacion', 'BeneficioReplica')) {
        $projectPath = Join-Path $workspacePath "tests/$suite/$suite.csproj"
        $testArguments = @('run', '--project', $projectPath, '-p:UseSharedCompilation=false', '-p:RunAnalyzersDuringBuild=false')
        if ($NoRestore) { $testArguments += '--no-restore' }
        & dotnet @testArguments
        if ($LASTEXITCODE -ne 0) { throw "Verification failed: $suite" }
    }
    & node (Join-Path $workspacePath 'tests/cascade-selects.test.cjs')
    if ($LASTEXITCODE -ne 0) { throw 'Cascade lookup verification failed.' }
}
catch {
    Write-Error $_
    $verificationExitCode = 1
}
finally {
    $env:DOTNET_PROCESSOR_COUNT = $previousProcessorCount
    $hostProcess.PriorityClass = $previousPriority
}
exit $verificationExitCode
