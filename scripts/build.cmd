@echo off

set root=%~dp0%\..
set tools=%root%\tools
set nuget=%tools%\NuGet\nuget.exe
set msbuild=%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe

set slnfile=%root%\DAX.CIM.PhysicalNetworkModel.sln

echo Building %slnfile%

"%msbuild%" "%slnfile%" "/p:Configuration=Release" "/t:rebuild"
