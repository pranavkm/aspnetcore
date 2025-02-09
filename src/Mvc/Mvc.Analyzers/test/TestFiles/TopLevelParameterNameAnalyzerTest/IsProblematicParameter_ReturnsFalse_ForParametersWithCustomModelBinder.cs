﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Microsoft.AspNetCore.Mvc.Analyzers.TopLevelParameterNameAnalyzerTestFiles
{
    public class IsProblematicParameter_ReturnsFalse_ForParametersWithCustomModelBinder
    {
        public string Model { get; set; }

        public void ActionMethod(
            [ModelBinder(typeof(SimpleTypeModelBinder))] IsProblematicParameter_ReturnsFalse_ForParametersWithCustomModelBinder model) { }
    }
}
