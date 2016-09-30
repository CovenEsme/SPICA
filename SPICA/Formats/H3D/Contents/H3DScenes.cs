﻿using SPICA.Formats.H3D.Contents.Scene;
using SPICA.Serialization.BinaryAttributes;

namespace SPICA.Formats.H3D.Contents
{
    class H3DScenes
    {
        [PointerOf("PointerTable")]
        private uint PointerTableAddress;

        [CountOf("Scenes"), CountOf("NameTree", 1)]
        private uint Count;

        [PointerOf("NameTree")]
        private uint NameTreeAddress;

        [TargetSection("DescriptorsSection", 1)]
        public H3DTreeNode[] NameTree;

        [TargetSection("DescriptorsSection", 1), PointerOf("Scenes")]
        private uint[] PointerTable;

        [TargetSection("DescriptorsSection", 4)]
        public H3DScene[] Scenes;

        public H3DScene this[int Index]
        {
            get { return Scenes[Index]; }
            set { Scenes[Index] = value; }
        }
    }
}