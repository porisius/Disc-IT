using UnrealBuildTool;

public class DiscIT : ModuleRules
{
	public DiscIT(ReadOnlyTargetRules Rules) : base(Rules)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[] { 
				"Core", 
				"CoreUObject",
				"Engine",
				"HTTP",
				"Json"
			}
		);
	}
}
