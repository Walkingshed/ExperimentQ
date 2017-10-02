// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ExperimentQTarget : TargetRules
{
	public ExperimentQTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "ExperimentQ" } );

        bUsesSteam = true;
	}
}
