﻿// Copyright (c) HQ.IO Corporation. All rights reserved.
// Licensed under the Reciprocal Public License, Version 1.5. See LICENSE.md in the project root for license terms.

using System.Reflection;
using Microsoft.CodeAnalysis;

namespace HQ.Remix
{
	public interface IMetadataReferenceResolver
	{
		MetadataReference Resolve(Assembly assembly);
		MetadataReference Resolve(string location);
	}
}