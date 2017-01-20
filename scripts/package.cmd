@echo off

set version=%1%

if "%version%"=="" (
	echo Please remember to specify a version to package as an argument to this script.
	echo.
	echo For example something like:
	echo.
	echo     package.cmd 1.0.0
	echo.
	echo in order to build version 1.0.0 of the package.

	goto exit_fail
)

set root=%~dp0%\..
set tools=%root%\tools
set nuget=%tools%\NuGet\nuget.exe
set msbuild=%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe
set deploy=%root%\deploy

set nuspecfile=%root%\DAX.CIM.PhysicalNetworkModel\DAX.CIM.PhysicalNetworkModel.nuspec

if exist "%deploy%" (
	rd "%deploy%" /s/q
)

mkdir "%deploy%"

echo Packing %nuspecfile%

"%nuget%" "pack" "%nuspecfile%" "-OutputDirectory" "%deploy%" "-Version" "%version%"


goto exit

:exit_fail

exit /b -1

:exit