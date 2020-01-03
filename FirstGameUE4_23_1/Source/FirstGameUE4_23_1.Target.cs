// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FirstGameUE4_23_1Target : TargetRules
{
	public FirstGameUE4_23_1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "FirstGameUE4_23_1" } );
	}
}
