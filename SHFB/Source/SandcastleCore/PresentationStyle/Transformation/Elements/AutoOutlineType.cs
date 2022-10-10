﻿//===============================================================================================================
// System  : Sandcastle Tools - Sandcastle Tools Core Class Library
// File    : AutoOutlineType.cs
// Author  : Eric Woodruff  (Eric@EWoodruff.us)
// Updated : 01/26/2022
// Note    : Copyright 2022, Eric Woodruff, All rights reserved
//
// This file contains an enumerated type used to define the auto-outline type
//
// This code is published under the Microsoft Public License (Ms-PL).  A copy of the license should be
// distributed with the code and can be found at the project website: https://GitHub.com/EWSoftware/SHFB.  This
// notice, the author's name, and all copyright notices must remain intact in all applications, documentation,
// and source files.
//
//    Date     Who  Comments
// ==============================================================================================================
// 01/26/2022  EFW  Created the code
//===============================================================================================================

using System;

namespace Sandcastle.Core.PresentationStyle.Transformation.Elements
{
    /// <summary>
    /// This enumerated type defines the auto-outline type
    /// </summary>
    [Serializable]
    public enum AutoOutlineType
    {
        /// <summary>
        /// Top level with related topics section
        /// </summary>
        TopLevel,
        /// <summary>
        /// Top level without the related topics section
        /// </summary>
        TopNoRelated,
        /// <summary>
        /// Subsection
        /// </summary>
        Subsection,
        /// <summary>
        /// Sub-subsection
        /// </summary>
        SubSubsection
    }
}