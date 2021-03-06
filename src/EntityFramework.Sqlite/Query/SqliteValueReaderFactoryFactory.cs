﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.Relational;

namespace Microsoft.Data.Entity.Sqlite.Query
{
    public class SqliteValueReaderFactoryFactory : ISqliteValueReaderFactoryFactory
    {
        public virtual IRelationalValueReaderFactory CreateValueReaderFactory() => new SqliteValueReaderFactory();
    }
}
