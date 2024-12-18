# Usage
- Add the LercLib folder to Source/ThirdParty
- Referece the library from other modules with:
```c++
PublicDependencyModuleNames.AddRange(new []
		{
			"LercLib"
		});
```
- Include the headers in other modules:
```c++
#include "Lerc_c_api.h"
#include "Lerc_types.h"
```

# VisionOS
- For VisionOS builds, the library has to be added manually to the xcode project
- Open the VisionOS xcode project
- Navigate to the Target with your game name: On the top left under the open file taps, select Games->YourGameName->YourGameName (VisionOS)
- Select under Targets YourGameName and under General/Embedded Content click the + icon
- Add Other
- Add Files
- Navigate to the libLerc.4.dylib and make sure state is Embed & Sign
