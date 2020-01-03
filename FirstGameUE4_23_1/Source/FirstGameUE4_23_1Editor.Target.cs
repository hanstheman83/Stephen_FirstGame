// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FirstGameUE4_23_1EditorTarget : TargetRules
{
	public FirstGameUE4_23_1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "FirstGameUE4_23_1" } );
	}
}
