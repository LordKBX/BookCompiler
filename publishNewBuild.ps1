"New build"
$Version = [string](Get-Content "D:\CODES\VS\BookCompiler\Version.txt")

$tv = $Version.Split(".")

$v = [version]::New([int]$tv[0],[int]$tv[1],[int]$tv[2],[int]$tv[3]+1)
Set-Content "D:\CODES\VS\BookCompiler\Version.txt" $v.ToString()