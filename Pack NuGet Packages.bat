rmdir /S /Q NuGet

dotnet pack src\ArgumentHelper -c release -o ..\..\NuGet --include-symbols -p:SymbolPackageFormat=snupkg

pause
