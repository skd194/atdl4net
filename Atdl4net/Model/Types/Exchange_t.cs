﻿#region Copyright (c) 2010-2011, Cornerstone Technology Limited. http://atdl4net.org
//
//   This software is released under both commercial and open-source licenses.
//
//   If you received this software under the commercial license, the terms of that license can be found in the
//   Commercial.txt file in the Licenses folder.  If you received this software under the open-source license,
//   the following applies:
//
//      This file is part of Atdl4net.
//
//      Atdl4net is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public 
//      License as published by the Free Software Foundation, either version 2.1 of the License, or (at your option) any later version.
// 
//      Atdl4net is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
//      of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more details.
//
//      You should have received a copy of the GNU Lesser General Public License along with Atdl4net.  If not, see
//      http://www.gnu.org/licenses/.
//
#endregion

using System;
using Atdl4net.Diagnostics;

namespace Atdl4net.Model.Types
{
    /// <summary>
    /// String field representing a market or exchange using ISO 10383 Market Identifier Code (MIC) values (see"Appendix 6-C).
    /// </summary>
    public class Exchange_t : String_t
    {
        #region AtdlReferenceType<T> Overrides

        /// <summary>
        /// Validates the supplied value in terms of 'ISO 10383 correctness', i.e., MICs must be 4 characters in length.
        /// </summary>
        /// <param name="value">Value to validate, may be null in which case no validation is applied.</param>
        /// <returns>Value passed in.</returns>
        protected override string ValidateValue(string value)
        {
            if (value != null && value.Length != 4)
                throw ThrowHelper.New<ArgumentException>(this, "Exchange codes must conform to the ISO 10383 standard, i.e., be 4 characters in length");

            return value;
        }

        #endregion
    }
}
