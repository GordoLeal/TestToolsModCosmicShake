using UnrealBuildTool;

public class TestToolsModTarget : TargetRules
{
	public TestToolsModTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TestToolsMod");
	}
}
