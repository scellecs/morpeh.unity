using Scellecs.Morpeh;
using System;
using System.Collections.Generic;
using UnityEngine;

public struct TestDeadEntityComponent : IComponent
{

}

public struct TestBugComponent : IComponent
{

}

[Serializable]
public struct APP : IComponent
{
    public int val;
    public int val2;
    public int val3;
    public int val4;
    public int val5;
    public int val6;
    public int val7;
}

[Serializable]
public struct UComponentTransform : IComponent
{
    public Transform transform;
}

[Serializable]
public struct UComponentMesh : IComponent
{
    public Mesh mesh;
}

[Serializable]
public struct UComponentGameObject : IComponent
{
    public GameObject go;
}

[Serializable]
public struct UComponentMaterial : IComponent
{
    public Material material;
}

[Serializable]
public struct M787 : IComponent
{

}

[Serializable]
public struct m786 : IComponent
{

}

[Serializable]
public struct APP2 : IComponent
{
    public int val;
    public int val2;
    public int val3;
    public int val4;
    public int val5;
    public int val6;
    public int val7;
}

[Serializable]
public struct APP3 : IComponent
{
    public int val;
    public int val2;
    public int val3;
    public int val4;
    public int val5;
    public int val6;
    public int val7;
}

[Serializable]
public struct APP4 : IComponent
{
    public int val;
}

[Serializable]
public struct MA : IComponent
{
    public int val;
    public Vector3 vec;
    public Vector3 vec2;
    public Vector3 vec3;
}

[Serializable]
public struct M2 : IComponent
{
    public int val;
}

[Serializable]
public struct M3 : IComponent
{
    public int val;
}

[Serializable]
public struct M4 : IComponent
{
    public int val;
}

[Serializable]
public struct M5 : IComponent
{
    public int val;
}

[Serializable]
public struct M6 : IComponent
{
    public int val;
}

[Serializable]
public struct M7 : IComponent
{
    public int val;
}

[Serializable]
public struct M786 : IComponent
{
    public List<int> ints;
}

public struct HM : IComponent
{
    public int c;
}

public struct TestComponent0 : IComponent { }
public struct TestComponent1 : IComponent { }
public struct TestComponent2 : IComponent { }
public struct TestComponent3 : IComponent { }
public struct TestComponent4 : IComponent { }
public struct TestComponent5 : IComponent { }
public struct TestComponent6 : IComponent { }
public struct TestComponent7 : IComponent { }
public struct TestComponent8 : IComponent { }
public struct TestComponent9 : IComponent { }
public struct TestComponent11 : IComponent { }
public struct TestComponent12 : IComponent { }
public struct TestComponent13 : IComponent { }
public struct TestComponent14 : IComponent { }
public struct TestComponent1566666666666666666666666666666666666 : IComponent { }
public struct TestComponent16 : IComponent { }
public struct TestComponent21 : IComponent { }
public struct TestComponent22 : IComponent { }
public struct TestComponent23 : IComponent { }
public struct TestComponent24 : IComponent { }
public struct TestComponent25 : IComponent { }
public struct TestComponent26 : IComponent { }
public struct TestComponent31 : IComponent { }
public struct TestComponent32 : IComponent { }
public struct TestComponent33 : IComponent { }
public struct TestComponent34 : IComponent { }
public struct TestComponent35 : IComponent { }
public struct ASCComponent35 : IComponent { }
public struct ASCComponent32 : IComponent { }
public struct ASCComponent33 : IComponent { }
public struct ASCComponent31 : IComponent { }
public struct ASCComponent36 : IComponent { }
public struct ASCComponent2 : IComponent { }
public struct ASCComponent65 : IComponent { }
public struct ASCComponent76 : IComponent { }
public struct ASCComponent12 : IComponent { }
public struct ASCComponent88 : IComponent { }
public struct LTComponent0 : IComponent { }
public struct LTComponent2 : IComponent { }
public struct LTComponent8 : IComponent { }
public struct LTComponent111 : IComponent { }

namespace TestGenerics
{
    [Serializable]
    public struct TestGeneric<T> : IComponent
    {
        public T Value;
    }

    [Serializable]
    public struct TestGenericUltra<T1, T2> : IComponent
    {
        public T1 Value;
        public T2 Value2;
    }
}

namespace TestGenerics2
{
    [Serializable]
    public class SomeNestedType
    {
        public int val1;
        public double val2;
        public float val3;
        public Matrix4x4 val4;
        public string val5;
    }

    [Serializable]
    public class SomeNestedType<T>
    {
        public T Value;
    }
}

