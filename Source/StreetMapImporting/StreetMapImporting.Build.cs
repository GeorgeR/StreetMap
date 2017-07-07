// Copyright 2017 Mike Fricker. All Rights Reserved.
using UnrealBuildTool;

public class StreetMapImporting : ModuleRules
{
   public StreetMapImporting(ReadOnlyTargetRules Target) : base(Target)
   {
      PublicIncludePaths.Add("StreetMapRuntime/Public");

      PrivateIncludePaths.Add("StreetMapImporting/Private");

      PrivateDependencyModuleNames.AddRange(new string[] {
                                                         "Core",
                                                         "CoreUObject",
                                                         "Engine",
                                                         "UnrealEd",
                                                         "XmlParser",
                                                         "AssetTools",
                                                         "Projects",
                                                         "Slate",
                                                         "EditorStyle",
                                                         "SlateCore",
                                                         "PropertyEditor",
                                                         "RenderCore",
                                                         "ShaderCore",
                                                         "RHI",
                                                         "RawMesh",
                                                         "AssetTools",
                                                         "AssetRegistry",
                                                         "StreetMapRuntime"
                                                         });
   }
}
