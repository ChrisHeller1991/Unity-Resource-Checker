// Resource Checker
// (c) 2012 Simon Oliver / HandCircus / hello@handcircus.com
// (c) 2015 Brice Clocher / Mangatome / hello@mangatome.net
// Public domain, do with whatever you like, commercial or not
// This comes with no warranty, use at your own risk!
// https://github.com/handcircus/Unity-Resource-Checker

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace com.HandCircus.ResourceCheckerPackage
{
	public class MaterialDetails
	{

		public Material material;

		public List<Renderer> FoundInRenderers = new List<Renderer>();
		public List<Graphic> FoundInGraphics = new List<Graphic>();
		public bool instance;
		public bool isgui;
		public bool isSky;

		public MaterialDetails()
		{
			instance = false;
			isgui = false;
			isSky = false;
		}
	}
}