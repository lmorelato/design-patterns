dotnet sonarscanner begin /k:"design-patterns" /d:sonar.cs.opencover.reportsPaths="%cd%\coverage.xml"
dotnet build DesignPatterns.sln
OpenCover.Console.exe -register:user -target:"dotnet.exe" -targetargs:"test --logger:trx;LogFileName=results.trx /p:DebugType=full .\tests\DesignPatterns.Tests\DesignPatterns.Tests.csproj" -output:"coverage.xml" -filter:"+[*]* -[*.Tests]*" -oldStyle
dotnet sonarscanner end