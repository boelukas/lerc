# Build Instructions
```bash
cd build
mkdir android
cd android
cmake ../.. -DANDROID_ABI=arm64-v8a -DANDROID_PLATFORM=android-29 -DANDROID_NDK=/Users/luk14172/Library/Android/sdk/ndk/25.1.8937393 -DCMAKE_TOOLCHAIN_FILE=/Users/luk14172/Library/Android/sdk/ndk/25.1.8937393/build/cmake/android.toolchain.cmake -G Ninja
ninja
```
- Copy the generated libLerc.so to bin/android and OtherLanguages/UnrealEngine/LercLib/lib/android
