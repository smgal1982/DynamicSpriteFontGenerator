﻿using Microsoft.Xna.Framework.Content.Pipeline;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace DynamicFontGenerator
{
	class DfgContext : ContentProcessorContext
	{
		private readonly Generator _g;

		public override ContentBuildLogger Logger => throw new NotImplementedException();

		public override OpaqueDataDictionary Parameters => throw new NotImplementedException();

		public override TargetPlatform TargetPlatform => throw new NotImplementedException();

		public override GraphicsProfile TargetProfile => _g.GraphicsDevice.GraphicsProfile;

		public override string BuildConfiguration => throw new NotImplementedException();

		public override string OutputFilename => throw new NotImplementedException();

		public override string OutputDirectory => throw new NotImplementedException();

		public override string IntermediateDirectory => throw new NotImplementedException();

		public DfgContext(Generator g)
		{
			_g = g;
		}

		public override void AddDependency(string filename)
		{
			throw new NotImplementedException();
		}

		public override void AddOutputFile(string filename)
		{
			throw new NotImplementedException();
		}

		public override TOutput BuildAndLoadAsset<TInput, TOutput>(ExternalReference<TInput> sourceAsset, string processorName, OpaqueDataDictionary processorParameters, string importerName)
		{
			throw new NotImplementedException();
		}

		public override ExternalReference<TOutput> BuildAsset<TInput, TOutput>(ExternalReference<TInput> sourceAsset, string processorName, OpaqueDataDictionary processorParameters, string importerName, string assetName)
		{
			throw new NotImplementedException();
		}

		public override TOutput Convert<TInput, TOutput>(TInput input, string processorName, OpaqueDataDictionary processorParameters)
		{
			throw new NotImplementedException();
		}
	}
}
