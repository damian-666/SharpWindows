﻿// Copyright (c) Amer Koleci and contributors.
// Distributed under the MIT license. See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace SharpDirect3D12
{
    /// <summary>
    /// Describes the slot of a root signature version 1.0.
    /// </summary>
    public partial struct RootParameter
    {
        public RootParameterType ParameterType;
        private Union _union;

        public RootDescriptorTable DescriptorTable
        {
            get
            {
                var result = new RootDescriptorTable();
                result.__MarshalFrom(ref _union.DescriptorTable);
                return result;
            }
            set
            {
                value.__MarshalTo(ref _union.DescriptorTable);
            }
        }

        public RootConstants Constants
        {
            get => _union.Constants;
            set => _union.Constants = value;
        }

        public RootDescriptor Descriptor
        {
            get => _union.Descriptor;
            set => _union.Descriptor = value;
        }

        public ShaderVisibility ShaderVisibility;

        [StructLayout(LayoutKind.Explicit, Pack = 0)]
        private struct Union
        {
            [FieldOffset(0)]
            public RootDescriptorTable.__Native DescriptorTable;

            [FieldOffset(0)]
            public RootConstants Constants;

            [FieldOffset(0)]
            public RootDescriptor Descriptor;
        }
    }
}
