# Build instructions

- To build a dynamic library: `cmake ../..`
- To build a static library: `cmake ../.. -DBUILD_SHARED_LIBS=OFF`
- Open the Lerc.sln with Visual Studio
- Select the Release Configuration, x64 and right click on the Lerc Target -> Build
- Copy the content of build/windows/Release to bin/windows and to OtherLanguages/UnrealEngine/LercLib/lib/windows