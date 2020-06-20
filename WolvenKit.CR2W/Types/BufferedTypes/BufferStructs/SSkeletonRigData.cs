﻿using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SSkeletonRigData : CVariable
    {
        [RED] public Vector position { get; set; }
        [RED] public Vector rotation { get; set; }
        [RED] public Vector scale { get; set; }

        public SSkeletonRigData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }



        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SSkeletonRigData(cr2w, parent, name);
        }


        public override string ToString()
        {
            return $"[{position.ToString()}, {rotation.ToString()}, {scale.ToString()}]";
        }
    }
}