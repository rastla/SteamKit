@echo off

if not defined DevEnvDir (
    for /f "usebackq tokens=*" %%i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -latest -products * -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath`) do (
        set InstallDir=%%i
    )

    if exist "%InstallDir%\Common7\Tools\vsdevcmd.bat" (
        call "%InstallDir%\Common7\Tools\vsdevcmd.bat"
    )
)

echo "GITHUB_ACTIONS=%GITHUB_ACTIONS%"
echo "GITHUB_ACTION=%GITHUB_ACTION%"
echo "CI=%CI%"
echo "CD=%CD%"
echo "PATH=%PATH%"

where.exe /q vcpkg
if %ERRORLEVEL%==1 (
    if defined GITHUB_ACTIONS (
        if not exist "vcpkg/" (
            git clone --depth 1 "https://github.com/Microsoft/vcpkg.git"
        ) else (
            cd vcpkg
            git pull
            cd ..
        )

        call ".\vcpkg\bootstrap-vcpkg.bat"
        call :add_curr_dir_to_path

        vcpkg integrate install
    ) else (
        echo "vcpkg is required but not found. Please see https://vcpkg.io/en/getting-started to install it"
    )
)

echo "PATH=%PATH%"

:add_curr_dir_to_path
SET "PATH=%CD%\vcpkg;%PATH%"
EXIT /B 0

rem todo: compile or download protoc and generate steammessages_base.pb.{h|cpp}
