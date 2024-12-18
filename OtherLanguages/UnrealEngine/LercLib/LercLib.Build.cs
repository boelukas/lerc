/* Copyright 2023 Esri
 *
 * Licensed under the Apache License Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.IO;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using UnrealBuildTool;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq;

public class LercLib : ModuleRules
{
	public LercLib(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;

		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "include"));

		if (Target.Platform == UnrealTargetPlatform.Mac)
		{
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "mac", "libLerc.dylib"));
		}
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "windows", "Lerc.lib"));
			PublicDelayLoadDLLs.Add("Lerc.dll");
			RuntimeDependencies.Add(Path.Combine(ModuleDirectory, "lib", "windows", "Lerc.dll"));
		}
		if (Target.Platform == UnrealTargetPlatform.Android)
		{
			AdditionalPropertiesForReceipt.Add("AndroidPlugin", Path.Combine(ModuleDirectory, "LercLib_APL.xml"));
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "android", "libLerc.so"));
		}
		if (Target.Platform == UnrealTargetPlatform.VisionOS)
		{
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "visionOS", "libLerc.dylib"));
		}
	}
}
