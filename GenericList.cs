﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatcherYRpp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GenericNode
    {
        public static unsafe void Constructor(Pointer<GenericNode> pThis)
        {
            var func = (delegate* unmanaged[Thiscall]<ref GenericNode, void>)0x40E320;
            func(ref pThis.Ref);
        }
        public static unsafe void Destructor(Pointer<GenericNode> pThis)
        {
            var func = (delegate* unmanaged[Thiscall]<ref GenericNode, void>)Helpers.GetVirtualFunctionPointer(pThis, 0);
            func(ref pThis.Ref);
        }

        public IntPtr next;
        public Pointer<GenericNode> Next {  get => next;  set => next = value; }
        public IntPtr previous;
        public Pointer<GenericNode> Previous { get => previous; set => previous = value; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GenericList
    {
        public static unsafe void Constructor(Pointer<GenericNode> pThis)
        {
            var func = (delegate* unmanaged[Thiscall]<ref GenericNode, void>)0x52ACE0;
            func(ref pThis.Ref);
        }
        public static unsafe void Destructor(Pointer<GenericNode> pThis)
        {
            var func = (delegate* unmanaged[Thiscall]<ref GenericNode, void>)Helpers.GetVirtualFunctionPointer(pThis, 0);
            func(ref pThis.Ref);
        }

        public GenericNode First;
        public GenericNode Last;
    };
}
