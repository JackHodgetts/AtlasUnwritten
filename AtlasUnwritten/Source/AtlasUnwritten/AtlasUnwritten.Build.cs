// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AtlasUnwritten : ModuleRules
{
	public AtlasUnwritten(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AtlasUnwritten",
			"AtlasUnwritten/Variant_Platforming",
			"AtlasUnwritten/Variant_Platforming/Animation",
			"AtlasUnwritten/Variant_Combat",
			"AtlasUnwritten/Variant_Combat/AI",
			"AtlasUnwritten/Variant_Combat/Animation",
			"AtlasUnwritten/Variant_Combat/Gameplay",
			"AtlasUnwritten/Variant_Combat/Interfaces",
			"AtlasUnwritten/Variant_Combat/UI",
			"AtlasUnwritten/Variant_SideScrolling",
			"AtlasUnwritten/Variant_SideScrolling/AI",
			"AtlasUnwritten/Variant_SideScrolling/Gameplay",
			"AtlasUnwritten/Variant_SideScrolling/Interfaces",
			"AtlasUnwritten/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
