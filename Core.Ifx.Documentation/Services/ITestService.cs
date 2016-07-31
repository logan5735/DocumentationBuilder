﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ifx.Documentation.Services
{
    /// <summary>
    /// The worst service ever
    /// </summary>
    [ServiceContract]
    public interface ITestService
    {
        /// <summary>
        /// Try parse int
        /// </summary>
        /// <param name="s"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        bool TryParse(string s, out int value);
    }
}