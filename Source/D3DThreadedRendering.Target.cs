// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class D3DThreadedRenderingTarget : TargetRules
{
	public D3DThreadedRenderingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "D3DThreadedRendering" } );
	}
}
