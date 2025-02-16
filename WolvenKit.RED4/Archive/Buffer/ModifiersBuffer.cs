﻿using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class ModifiersBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public bool IsParsed { get; set; } = true;
    public List<gameStatModifierData_Deprecated> Entries { get; set; } = new();
}