﻿// Copyright (c) 2004-2020 Jaroslaw Kowalski <jaak@jkowalski.net>, Kim Christensen, Julian Verdurmen
//  
//  All rights reserved.
//  
//  Redistribution and use in source and binary forms, with or without 
//  modification, are permitted provided that the following conditions 
//  are met:
//  
//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  
//  * Redistributions in binary form must reproduce the above copyright notice,
//    this list of conditions and the following disclaimer in the documentation
//    and/or other materials provided with the distribution. 
//  
//  * Neither the name of Jaroslaw Kowalski nor the names of its 
//    contributors may be used to endorse or promote products derived from this
//    software without specific prior written permission. 
//  
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
//  AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
//  ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
//  LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
//  CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
//  SUBSTITUTE GOODS OR SERVICES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog.Targets
{
    /// <summary>
    /// <see cref="FileTarget"/> may be configured to compress archived files in a custom way
    /// by setting <see cref="FileTarget.FileCompressor"/> before logging your first event.
    /// </summary>
    public interface IArchiveFileCompressor : IFileCompressor
    {
        /// <summary>
        /// Create archiveFileName by compressing fileName.
        /// </summary>
        /// <param name="fileName">Absolute path to the log file to compress.</param>
        /// <param name="archiveFileName">Absolute path to the compressed archive file to create.</param>
        /// <param name="entryName">The name of the file inside the archive.</param>
        void CompressFile(string fileName, string archiveFileName, string entryName);
    }
}
