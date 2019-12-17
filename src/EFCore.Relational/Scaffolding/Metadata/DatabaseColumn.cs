// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Microsoft.EntityFrameworkCore.Scaffolding.Metadata
{
    /// <summary>
    ///     A simple model for a database column used when reverse engineering an existing database.
    /// </summary>
    public class DatabaseColumn : Annotatable
    {
        /// <summary>
        ///     The table that contains this column.
        /// </summary>
        public virtual DatabaseTable Table { get; [param: NotNull] set; }

        /// <summary>
        ///     The column name.
        /// </summary>
        public virtual string Name { get; [param: NotNull] set; }

        /// <summary>
        ///     Indicates whether or not this column can contain <c>NULL</c> values.
        /// </summary>
        public virtual bool IsNullable { get; set; }

        /// <summary>
        ///     The database/store type of the column.
        /// </summary>
        public virtual string StoreType { get; [param: CanBeNull] set; }

        /// <summary>
        ///     The default constraint for the column, or <c>null</c> if none.
        /// </summary>
        public virtual string DefaultValueSql { get; [param: CanBeNull] set; }

        /// <summary>
        ///     The SQL expression that computes the value of the column, or <c>null</c> if this is not a computed column.
        /// </summary>
        public virtual string ComputedColumnSql { get; [param: CanBeNull] set; }

        /// <summary>
        ///     The column comment, or <c>null</c> if none is set.
        /// </summary>
        public virtual string Comment { get; [param: CanBeNull] set; }

        /// <summary>
        ///     Indicates when values will be generated by the database for this column, or <c>null</c> if
        ///     the database will not generate values.
        /// </summary>
        public virtual ValueGenerated? ValueGenerated { get; set; }

        public override string ToString() => Name;
    }
}
