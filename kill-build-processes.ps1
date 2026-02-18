# Script para matar processos do MSBuild e compilador C#
Write-Host "Matando processos MSBuild, VBCSCompiler e dotnet..." -ForegroundColor Yellow

Get-Process | Where-Object {
    $_.ProcessName -like "*MSBuild*" -or 
    $_.ProcessName -like "*VBCSCompiler*" -or 
    $_.ProcessName -like "*dotnet*"
} | Stop-Process -Force -ErrorAction SilentlyContinue

Write-Host "Processos finalizados!" -ForegroundColor Green
