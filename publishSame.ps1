clear
cd D:\CODES\PROJI\WhoooBook
$Version = [string](Get-Content "D:\CODES\VS\BookCompiler\Version.txt")

# Get-ChildItem -Path "D:\CODES\VS\BookCompiler\Installers" -Include * -File -Recurse | foreach { $_.Delete()}
"Compil programs"
cd "D:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\"
 .\MSBuild.exe D:\CODES\VS\BookCompiler\BookCompiler.sln -interactive:False -t:Tools /p:Configuration=Release
 .\MSBuild.exe D:\CODES\VS\BookCompiler\BookCompiler.sln -interactive:False -t:CoverGenerator /p:Configuration=Release
 .\MSBuild.exe D:\CODES\VS\BookCompiler\BookCompiler.sln -interactive:False -t:BookCompiler /p:Configuration=Release

"Compiling Installer"
cd "C:\Program Files (x86)\Inno Setup 6\"
cmd /C .\ISCC.exe D:\CODES\VS\BookCompiler\Installer.iss /DMyAppVersion=$Version

"Sing installers"
cd "D:\Windows Kits\10\bin\10.0.22621.0\x64\"
Get-ChildItem -Path "D:\CODES\VS\BookCompiler\Installers" -Include * -File -Recurse | foreach { .\signtool.exe sign /sha1 A119C1D470F42B1CBA1111C2A56D1D5E20EFE6B4 /fd SHA256 $_}

cd "D:\\CODES\\VS\\BookCompiler"