#ifndef MyAppVersion
#define MyAppVersion "1.0.0"
#endif
#define MyAppName "BookCompiler"
#define MyAppName2 "CoverGenerator"
#define MyAppPublisher "LordKBX WorkShop"
#define MyAppURL "https://github.com/LordKBX/BookCompiler"
#define MyDir "D:\CODES\VS\BookCompiler"


[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{14440F1F-8F0F-4B0D-8C2A-07608023D99D}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
VersionInfoVersion={#MyAppVersion}

;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={commonpf}\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
DisableWelcomePage=no
; The [Icons] "quicklaunchicon" entry uses {userappdata} but its [Tasks] entry has a proper IsAdminInstallMode Check.
;UsedUserAreasWarning=no
LicenseFile={#MyDir}\LICENSE.txt
; Uncomment the following line to run in non administrative install mode (install for current user only.)
PrivilegesRequired=admin
OutputDir={#MyDir}\Installers
OutputBaseFilename={#MyAppName}-{#MyAppVersion}
Compression=lzma                                              
SolidCompression=yes
;WizardStyle=modern         
ArchitecturesInstallIn64BitMode=x64                   

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"   

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]                                        
Source: ".\{#MyAppName2}\bin\Release\net7.0-windows\*.json"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\{#MyAppName2}\bin\Release\net7.0-windows\*.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\{#MyAppName2}\bin\Release\net7.0-windows\*.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\{#MyAppName2}\bin\Release\net7.0-windows\Resources\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: ".\{#MyAppName2}\bin\Release\net7.0-windows\runtimes\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

Source: ".\{#MyAppName}\bin\Release\net7.0-windows\*.json"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\{#MyAppName}\bin\Release\net7.0-windows\*.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\{#MyAppName}\bin\Release\net7.0-windows\BookCompiler.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\{#MyAppName}\bin\Release\net7.0-windows\Resources\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: ".\{#MyAppName}\bin\Release\net7.0-windows\runtimes\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: ".\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion             
Source: ".\pttb.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files   

[Icons]                                                                                       
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppName}.exe"; WorkingDir: "{app}"       
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppName}.exe"; WorkingDir: "{app}"; Tasks: desktopicon  
Name: "{group}\Uninstall {#MyAppName}"; Filename: "{uninstallexe}"  

[Run]      
Filename: "{app}\{#MyAppName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent 
Filename: "{app}\pttb.exe"; Parameters: """{app}\{#MyAppName}.exe"""; Description: "{cm:CreateQuickLaunchIcon}"; Flags: postinstall skipifsilent 

[UninstallRun]     
Filename: "{app}\pttb.exe"; Parameters: "-u ""{app}\{#MyAppName}.exe"""; Flags: waituntilterminated

