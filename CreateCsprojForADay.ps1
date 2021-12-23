$days = @("day3","day4")

foreach ($day in $days)
{
    dotnet new classlib -o $day
    dotnet sln add .\$day\$day.csproj
    cd .\$day\
    dotnet new xunit -o tests-$day
    dotnet add .\tests-$day\tests-$day.csproj reference .\$day.csproj
    cd ..
    dotnet sln add .\$day\tests-$day\tests-$day.csproj
}
Write-Output "The following days have been created: "$days
