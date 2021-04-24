// Resource Checker
// (c) 2012 Simon Oliver / HandCircus / hello@handcircus.com
// (c) 2015 Brice Clocher / Mangatome / hello@mangatome.net
// Public domain, do with whatever you like, commercial or not
// This comes with no warranty, use at your own risk!
// https://github.com/handcircus/Unity-Resource-Checker

using UnityEngine;
using System.Collections.Generic;

namespace com.HandCircus.ResourceCheckerPackage
{
	public class MeshDetails
	{

		public Mesh mesh;

		public List<MeshFilter> FoundInMeshFilters = new List<MeshFilter>();
		public List<SkinnedMeshRenderer> FoundInSkinnedMeshRenderer = new List<SkinnedMeshRenderer>();
		public List<GameObject> StaticBatchingEnabled = new List<GameObject>();
		public bool instance;

		public MeshDetails()
		{
			instance = false;
		}
	}
}