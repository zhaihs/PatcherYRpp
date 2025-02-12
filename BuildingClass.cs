﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatcherYRpp
{
    [StructLayout(LayoutKind.Explicit, Size = 1824)]
    public struct BuildingClass : IOwnAbstractType<BuildingTypeClass>
    {
        Pointer<BuildingTypeClass> IOwnAbstractType<BuildingTypeClass>.OwnType => Type;
        Pointer<AbstractTypeClass> IOwnAbstractType.AbstractType => Type.Convert<AbstractTypeClass>();


        [FieldOffset(0)] public TechnoClass Base;
        [FieldOffset(0)] public RadioClass BaseRadio;
        [FieldOffset(0)] public MissionClass BaseMission;
        [FieldOffset(0)] public ObjectClass BaseObject;
        [FieldOffset(0)] public AbstractClass BaseAbstract;

        [FieldOffset(1312)] public Pointer<BuildingTypeClass> Type;

        [FieldOffset(1757)] public Bool unknown_bool_6DD;

    }
}
