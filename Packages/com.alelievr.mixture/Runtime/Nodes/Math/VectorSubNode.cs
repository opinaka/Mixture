﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;
using UnityEngine.Rendering;

namespace Mixture
{
	[Documentation(@"
Perform a substraction between a and b vectors.
")]

	[System.Serializable, NodeMenuItem("Math/Vector Sub")]
	public class VectorSubNode : MixtureNode
	{
		// TODO: multi VectorSub port
		public override bool hasSettings => false;
		public override bool showDefaultInspector => true;

		[Input("A"), ShowAsDrawer]
		public Vector4	a;
		
		[Input("B"), ShowAsDrawer]
		public Vector4	b;
		
		[Output("Out")]
		public Vector4	o;

		public override string name => "Sub";
		public override float nodeWidth => MixtureUtils.operatorNodeWidth;

		protected override bool ProcessNode(CommandBuffer cmd)
		{
			o = a - b;
			return true;
		}
	}
}