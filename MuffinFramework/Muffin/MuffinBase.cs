﻿using System.ComponentModel.Composition;

namespace MuffinFramework.Muffin
{
    [InheritedExport(typeof(MuffinBase))]
    public abstract class MuffinBase : LayerBase<MuffinArgs>
    {
    }
}