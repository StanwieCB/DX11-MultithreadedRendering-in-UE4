// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class D3DThreadedRenderingEditorTarget : TargetRules
{
	public D3DThreadedRenderingEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "D3DThreadedRendering" } );
	}
}
