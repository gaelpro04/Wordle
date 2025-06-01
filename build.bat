REM Ruta gael: "C:\Users\sgsg_\source\repos\DllPro"
REM Ruta gael: "C:\Users\sgsg_\source\repos\Wordle\bin\x86\Debug\net8.0-windows"

REM Ruta Diego: "C:\Users\bombo\OneDrive\Desktop\Arqui\ProyectoFinal\Wordle\DllPro"
REM Ruta Diego: "C:\Users\bombo\OneDrive\Desktop\Arqui\ProyectoFinal\Wordle\bin\x86\Debug\net8.0-windows"

@echo off
cd /d "C:\Users\sgsg_\source\repos\DllPro"

echo === Compilando funciones.c...
cl /c /EHsc funciones.c
if errorlevel 1 goto :error

echo === Generando AsmBridge.dll...
link /DLL /out:DllPro.dll funciones.obj
if errorlevel 1 goto :error

echo === Dumpbin para verificar exports:
dumpbin /exports DllPro.dll

echo === Copiando DLL al proyecto C#...
copy /Y DllPro.dll "C:\Users\sgsg_\source\repos\Wordle\bin\x86\Debug\net8.0-windows"
if errorlevel 1 goto :error

echo === TODO CORRECTO ===
goto :eof

:error
echo * HUBO UN ERROR DURANTE LA COMPILACION *
pause