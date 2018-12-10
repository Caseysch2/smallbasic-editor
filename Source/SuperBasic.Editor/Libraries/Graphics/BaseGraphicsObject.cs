﻿// <copyright file="BaseGraphicsObject.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SuperBasic.Editor.Libraries.Graphics
{
    using SuperBasic.Editor.Components;

    internal abstract class BaseGraphicsObject
    {
        protected BaseGraphicsObject()
        {
        }

        public abstract void ComposeTree(TreeComposer composer);
    }
}
