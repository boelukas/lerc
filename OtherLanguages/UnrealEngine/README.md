### Usage
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