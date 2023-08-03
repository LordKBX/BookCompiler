"New build"
$doc = [xml](Get-Content "D:\\CODES\\VS\\BookCompiler\\BookCompiler\\BookCompiler.csproj")

$v = [version]$doc.Project.PropertyGroup.AssemblyVersion
$v = [version]::New($v.Major,$v.Minor,$v.Build,$v.Revision+1)

$AppVersion = $v.ToString()

$doc.Project.PropertyGroup.AssemblyVersion = $AppVersion
$doc.Project.PropertyGroup.FileVersion = $AppVersion
$doc.save("D:\\CODES\\VS\\BookCompiler\\BookCompiler\\BookCompiler.csproj")
Set-Content "D:\CODES\VS\BookCompiler\Version.txt" $v.ToString()

D:\CODES\VS\BookCompiler\publishSame.ps1