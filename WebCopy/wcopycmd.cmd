@ECHO OFF

FOR /f "tokens=2*" %%A in ('REG QUERY "HKCU\Software\Microsoft\Windows\CurrentVersion\App Paths\wcopy.exe" /v "Path"') DO SET CYOWCCMD=%%B

SET "PATH=%CYOWCCMD%;%PATH%"

WCOPY.exe
