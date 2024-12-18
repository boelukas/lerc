#!/bin/sh
set -e
if test "$CONFIGURATION" = "Debug"; then :
  cd /Users/luk14172/Projects/lerc/build/visionOS
  /opt/homebrew/Cellar/cmake/3.30.5/bin/cmake -E cmake_symlink_library /Users/luk14172/Projects/lerc/build/visionOS/Debug/libLerc.4.dylib /Users/luk14172/Projects/lerc/build/visionOS/Debug/libLerc.4.dylib /Users/luk14172/Projects/lerc/build/visionOS/Debug/libLerc.dylib
fi
if test "$CONFIGURATION" = "Release"; then :
  cd /Users/luk14172/Projects/lerc/build/visionOS
  /opt/homebrew/Cellar/cmake/3.30.5/bin/cmake -E cmake_symlink_library /Users/luk14172/Projects/lerc/build/visionOS/Release/libLerc.4.dylib /Users/luk14172/Projects/lerc/build/visionOS/Release/libLerc.4.dylib /Users/luk14172/Projects/lerc/build/visionOS/Release/libLerc.dylib
fi
if test "$CONFIGURATION" = "MinSizeRel"; then :
  cd /Users/luk14172/Projects/lerc/build/visionOS
  /opt/homebrew/Cellar/cmake/3.30.5/bin/cmake -E cmake_symlink_library /Users/luk14172/Projects/lerc/build/visionOS/MinSizeRel/libLerc.4.dylib /Users/luk14172/Projects/lerc/build/visionOS/MinSizeRel/libLerc.4.dylib /Users/luk14172/Projects/lerc/build/visionOS/MinSizeRel/libLerc.dylib
fi
if test "$CONFIGURATION" = "RelWithDebInfo"; then :
  cd /Users/luk14172/Projects/lerc/build/visionOS
  /opt/homebrew/Cellar/cmake/3.30.5/bin/cmake -E cmake_symlink_library /Users/luk14172/Projects/lerc/build/visionOS/RelWithDebInfo/libLerc.4.dylib /Users/luk14172/Projects/lerc/build/visionOS/RelWithDebInfo/libLerc.4.dylib /Users/luk14172/Projects/lerc/build/visionOS/RelWithDebInfo/libLerc.dylib
fi

