@echo off
title Command Executer
color 1b

echo Command Executer by: Toyota IS Service Desk
echo ###########################################
: execute
echo Running Group Policy update on your account
gpupdate.exe /force
%cmd%

ECHO "This script will now self-destruct. Please ignore the next error message"
pause
DEL "%~f0"