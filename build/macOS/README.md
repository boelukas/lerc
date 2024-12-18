# Build instructions

```bash
mkdir build/macOS 
cd build/macOS
cmake -G Xcode ../.. -DCMAKE_XCODE_ATTRIBUTE_DEVELOPMENT_TEAM="<AppleDeveloperID>"
```
- Open the generated xcode project
- In the Run Destinations, select `My Mac`
- Right next to that, select the Lerc Scheme and click edit. In the Info tab, change the build configuration to Release.
- Click run
- Copy the files in build/macOS/Release to bin/macOS and OtherLanguages/UnrealEngine/LercLib/lib/mac