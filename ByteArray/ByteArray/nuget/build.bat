nuget pack ..\ByteArray.csproj -Prop Configuration=Release

nuget push ByteArray.1.0.0.nupkg -Source https://www.nuget.org/api/v2/package