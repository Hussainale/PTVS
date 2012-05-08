﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

// Guids.cs
// MUST match guids.h
using System;

namespace Microsoft.PythonTools.Django {
    static class GuidList {
        public const string guidDjangoPkgString = "a8637c34-aa55-46e2-973c-9c3e09afc17b";
        public const string guidDjangoCmdSetString = "5b3281a5-d037-4e84-93aa-a6819304dbd9";
        public const string guidDjangoEditorFactoryString = "96108b8f-2a98-4f6b-a6b6-69e04e7b7d3f";

        public static readonly Guid guidDjangoCmdSet = new Guid(guidDjangoCmdSetString);
        public static readonly Guid guidDjangoEditorFactory = new Guid(guidDjangoEditorFactoryString);
    }
}