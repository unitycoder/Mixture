﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;
using System;
using UnityEngine.Rendering;

namespace Mixture
{
	[Documentation(@"
Extract the integer part of the vector.
")]

	[System.Serializable, NodeMenuItem("Math/Vector Truncate")]
	public class VectorTruncateNode : MixtureNode
	{
		// TODO: multi VectorTruncate port
		public override bool hasSettings => false;
		public override bool showDefaultInspector => true;

		[Input("A"), ShowAsDrawer]
		public Vector4	a;
		
		[Output("Out")]
		public Vector4	o;

		public override string name => "Truncate";
		public override float nodeWidth => MixtureUtils.operatorNodeWidth;

		protected override bool ProcessNode(CommandBuffer cmd)
		{
			o = new Vector4((float)Math.Truncate((double)a.x), (float)Math.Truncate((double)a.y), (float)Math.Truncate((double)a.z), (float)Math.Truncate((double)a.w));
			return true;
		}
	}
}