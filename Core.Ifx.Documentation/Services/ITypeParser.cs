﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Core.Ifx.Documentation.Models;

namespace Core.Ifx.Documentation.Services
{
    public interface ITypeParser<T>
    {
        List<T> Parse(List<Type> typesInAssembly, XDocument m_assemblyDocumentation = null);
    }
}