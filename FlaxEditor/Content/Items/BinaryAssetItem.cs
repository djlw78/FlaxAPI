﻿////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

using System;
using FlaxEngine;

namespace FlaxEditor.Content
{
    /// <summary>
    /// Represents binary asset item.
    /// </summary>
    /// <seealso cref="FlaxEditor.Content.AssetItem" />
    public class BinaryAssetItem : AssetItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryAssetItem"/> class.
        /// </summary>
        /// <param name="path">The asset path.</param>
        /// <param name="id">The asset identifier.</param>
        /// <param name="domain">The asset domain.</param>
        public BinaryAssetItem(string path, Guid id, ContentDomain domain)
            : base(path, id)
        {
            ItemDomain = domain;
        }

        /// <summary>
        /// Gets the asset import path.
        /// </summary>
        /// <param name="importPath">The import path.</param>
        /// <returns>True if failes, otherwise false.</returns>
        public bool GetImportPath(out string importPath)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override ContentDomain ItemDomain { get; }
    }
}