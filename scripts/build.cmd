@echo off

set root=%~dp0%\..
set tools=%root%\tools
set nuget=%tools%\NuGet\nuget.exe
set msbuild=%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe

set projectfile=%root%\DAX.CIM.PhysicalNetworkModel\DAX.CIM.PhysicalNetworkModel.csproj

echo Building %projectfile%

"%msbuild%" "%projectfile%" "/p:Configuration=Release"
