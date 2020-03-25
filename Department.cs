using System;
using System.Collections.Generic;

namespace CompositeDemo
{
    public class Department : OfficeComponent
    {
        List<OfficeComponent> _children = new List<OfficeComponent>();
    }
}