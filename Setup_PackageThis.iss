; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=PackageThisEx
AppVersion=1.3.5
DefaultDirName={localappdata}\PackageThis
DefaultGroupName=PackageThis
UninstallDisplayIcon={localappdata}\PackageThis.exe
Compression=lzma2
SolidCompression=yes
OutputDir=userdocs:Inno Setup Examples Output
OutputBaseFilename=Setup-PackageThis
PrivilegesRequired=lowest

[Files]
Source: "bin\DEBUG\PackageThis.exe"; DestDir: "{app}"
Source: "bin\DEBUG\PackageThis.exe.config"; DestDir: "{app}"

[Icons]
Name: "{group}\PackageThis"; Filename: "{app}\PackageThis.exe"

[Run]
Filename: "{app}\PackageThis.exe"; Flags: postinstall
