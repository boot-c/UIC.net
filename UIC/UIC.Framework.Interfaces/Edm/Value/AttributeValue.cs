﻿using UIC.Framework.Interfaces.Edm.Definition;

namespace UIC.Framework.Interfaces.Edm.Value
{
    public interface AttributeValue
    {
        AttribtueDefinition Definition { get;  }
        object Value { get; }
    }
}