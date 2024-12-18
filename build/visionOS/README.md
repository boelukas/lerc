# Build instructions

```bash
mkdir build/visionOS 
cd build/visionOS
cmake -G Xcode ../.. -DCMAKE_XCODE_ATTRIBUTE_DEVELOPMENT_TEAM="<AppleDeveloperID>"
```
- Open the generated xcode project
- Add visionOS to Supported Destinations (See the attached xcode_setup.png)
- In the Run Destinations, select your AVP
- Right next to that, select the Lerc Scheme and click edit. In the Info tab, change the build configuration to Release.
- Click run
- Copy the files in buildMac/Release to bin/visionOS and OtherLanguages/UnrealEngine/LercLib/lib/visionOS