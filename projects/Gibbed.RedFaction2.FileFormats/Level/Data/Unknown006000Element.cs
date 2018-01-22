﻿/* Copyright (c) 2017 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System.IO;
using Gibbed.IO;
using Newtonsoft.Json;

namespace Gibbed.RedFaction2.FileFormats.Level.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Unknown006000Element : BasicElement
    {
        private uint _Unknown0;

        [JsonProperty("__u0")]
        public uint Unknown0
        {
            get { return this._Unknown0; }
            set { this._Unknown0 = value; }
        }

        public override void Read(Stream input, uint version, Endian endian)
        {
            this._Unknown0 = input.ReadValueU32(endian);
        }

        public override void Write(Stream output, uint version, Endian endian)
        {
            output.WriteValueU32(this._Unknown0, endian);
        }
    }
}
