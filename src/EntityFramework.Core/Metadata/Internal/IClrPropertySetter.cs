// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Metadata.Internal
{
    public interface IClrPropertySetter
    {
        void SetClrValue([NotNull] object instance, [CanBeNull] object value);
    }
}
