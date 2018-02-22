// Copyright 2017 Mike Fricker. All Rights Reserved.
using UnrealBuildTool;

public class StreetMapRuntime : ModuleRules
{    
    public StreetMapRuntime(ReadOnlyTargetRules Target) : base(Target)
    {
       PrivateIncludePaths.Add("StreetMapRuntime/Private");

       PrivateDependencyModuleNames.AddRange( 
               new string[] {
                   "Core",
                   "CoreUObject",
                   "Engine",
                   "RHI",
                   "RenderCore",
                   "ShaderCore",
                   "PropertyEditor"
       });
    }
}
