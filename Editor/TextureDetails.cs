// Resource Checker
// (c) 2012 Simon Oliver / HandCircus / hello@handcircus.com
// (c) 2015 Brice Clocher / Mangatome / hello@mangatome.net
// Public domain, do with whatever you like, commercial or not
// This comes with no warranty, use at your own risk!
// https://github.com/handcircus/Unity-Resource-Checker

using System;
using UnityEngine;
using System.Collections.Generic;
using Object = UnityEngine.Object;

namespace com.HandCircus.ResourceCheckerPackage
{
	public class TextureDetails : IEquatable<TextureDetails>
	{
		public bool isCubeMap;
		public int memSizeKB;
		public Texture texture;
		public TextureFormat format;
		public int mipMapCount;
		public List<Object> FoundInMaterials=new List<Object>();
		public List<Object> FoundInRenderers=new List<Object>();
		public List<Object> FoundInAnimators = new List<Object>();
		public List<Object> FoundInScripts = new List<Object>();
		public List<Object> FoundInGraphics = new List<Object>();
		public List<Object> FoundInButtons = new List<Object>();
		public bool isSky;
		public bool instance;
		public bool isgui;
		public TextureDetails()
		{

		}

		public bool Equals(TextureDetails other)
		{
			return texture != null && other.texture != null &&
				texture.GetNativeTexturePtr() == other.texture.GetNativeTexturePtr();
		}

		public override int GetHashCode()
		{
			return (int)texture.GetNativeTexturePtr();
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as TextureDetails);
		}
	}
}