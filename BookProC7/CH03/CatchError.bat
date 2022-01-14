echo off
rem A batch file for ErrorCode.cs
rem which captures the app's return value.

D:\_Jaime\_GIT\"04 MJGITs"\"04 ProC7"\bin\Debug\ProC7.exe

if %ERRORLEVEL% == "0" goto success

:fail
	echo Thisapplication has failed!
	echo return value = %ERRORLEVEL%
	goto end
:success
	echo This application has succeeded!
	echo return value = %ERRORLEVEL%
	goto end
:end
	echo All done.