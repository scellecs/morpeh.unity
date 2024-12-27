using TestGenerics2;
using Scellecs.Morpeh;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#pragma warning disable 0618
public sealed class TestSystem : ISystem
{
    private readonly Mesh mesh;
    private readonly Material material;
    private readonly GameObject go;
    private readonly Transform trs;
    private readonly Button addRemove;
    private readonly Button destroy;

    public World World { get; set; }

    private Entity e1;
    private Entity e3;
    private bool wasClickedAddRemove;
    private bool addComponent = true;

    private bool wasClickedDestroy;
    private Entity testDestroyEnt;

    public TestSystem(Mesh mesh, Material material, GameObject go, Transform trs, Button addRemove, Button destroy)
    {
        this.mesh = mesh;
        this.material = material;
        this.go = go;
        this.trs = trs;
        this.addRemove = addRemove;
        this.destroy = destroy;
    }

    public void OnAwake()
    {
        World.GetStash<TestComponent0>();
        World.GetStash<TestComponent1>();
        World.GetStash<TestComponent2>();
        World.GetStash<TestComponent3>();
        World.GetStash<TestComponent4>();
        World.GetStash<TestComponent5>();
        World.GetStash<TestComponent6>();
        World.GetStash<TestComponent7>();
        World.GetStash<TestComponent8>();
        World.GetStash<TestComponent9>();
        World.GetStash<TestComponent11>();
        World.GetStash<TestComponent12>();
        World.GetStash<TestComponent13>();
        World.GetStash<TestComponent14>();
        World.GetStash<TestComponent1566666666666666666666666666666666666>();
        World.GetStash<TestComponent16>();
        World.GetStash<TestComponent21>();
        World.GetStash<TestComponent22>();
        World.GetStash<TestComponent23>();
        World.GetStash<TestComponent24>();
        World.GetStash<TestComponent25>();
        World.GetStash<TestComponent26>();
        World.GetStash<TestComponent31>();
        World.GetStash<TestComponent32>();
        World.GetStash<TestComponent33>();
        World.GetStash<TestComponent34>();
        World.GetStash<TestComponent35>();
        World.GetStash<ASCComponent35>();
        World.GetStash<ASCComponent32>();
        World.GetStash<ASCComponent33>();
        World.GetStash<ASCComponent31>();
        World.GetStash<ASCComponent36>();
        World.GetStash<ASCComponent2>();
        World.GetStash<ASCComponent65>();
        World.GetStash<ASCComponent76>();
        World.GetStash<ASCComponent12>();
        World.GetStash<ASCComponent88>();
        World.GetStash<LTComponent0>();
        World.GetStash<LTComponent2>();
        World.GetStash<LTComponent8>();
        World.GetStash<LTComponent111>();

        e1 = World.CreateEntity();
        var e2 = World.CreateEntity();
        e1.AddComponent<MA>();
        e1.AddComponent<M2>();
        e1.RemoveComponent<M2>();
        e1.AddComponent<M3>();
        e1.AddComponent<M4>();
        e1.AddComponent<M5>();
        e1.AddComponent<M6>();
        e1.AddComponent<M7>();
        e1.AddComponent<TestComponent14>();
        e1.AddComponent<TestComponent13>();
        e1.AddComponent<TestComponent12>();
        e1.AddComponent<LTComponent0>();
        e1.AddComponent<LTComponent2>();
        e1.AddComponent<LTComponent8>();
        e1.AddComponent<ASCComponent12>();
        e1.AddComponent<ASCComponent31>();
        e1.AddComponent<APP>();
        e1.AddComponent<APP2>();
        e1.AddComponent<APP3>();
        e1.AddComponent<APP4>();

        e1.SetComponent(new M786() { ints = new List<int>() { 1, 2, 5, 6, 7, 8, 11, } });
        e2.AddComponent<MA>();
        e2.AddComponent<M2>();
        e2.SetComponent(new M786() { ints = new List<int>() { 1, 2, 5, 6, 7, 8, 128 } });
        e2.AddComponent<TestComponent0>();

        e3 = World.CreateEntity();

        e3.AddComponent<TestGenerics.TestGeneric<int>>();
        ref var c = ref e3.AddComponent<TestGenerics.TestGeneric<TestGenerics2.SomeNestedType>>();
        c.Value = new TestGenerics2.SomeNestedType();
        ref var c2 = ref e3.AddComponent<TestGenerics.TestGenericUltra<TestGenerics2.SomeNestedType, TestGenerics2.SomeNestedType>>();
        c2.Value = new TestGenerics2.SomeNestedType() { val4 = Matrix4x4.identity };
        c2.Value2 = new TestGenerics2.SomeNestedType() { val3 = 128f };
        ref var c3 = ref e3.AddComponent<TestGenerics.TestGenericUltra<int, float>>();
        ref var c4 = ref e3.AddComponent<TestGenerics.TestGeneric<string>>();
        c4.Value = "...";
        e3.AddComponent<TestComponent0>();
        ref var c5 = ref e3.AddComponent<TestGenerics.TestGeneric<SomeNestedType<float>>>();
        c5.Value = new SomeNestedType<float>() { Value = 656546f };
        e3.AddComponent<m786>();
        e3.AddComponent<M786>();

        var e4 = World.CreateEntity();
        e4.AddComponent<M787>();

        for (int i = 0; i < 200; i++)
        {
            var ent = World.CreateEntity();
            ent.AddComponent<APP2>();
        }

        for (int i = 0; i < 200; i++)
        {
            var ent = World.CreateEntity();
            ent.SetComponent(new UComponentMesh() { mesh = this.mesh });
        }

        for (int i = 0; i < 200; i++)
        {
            var ent = World.CreateEntity();
            ent.SetComponent(new UComponentMaterial() { material = this.material });
        }

        for (int i = 0; i < 200; i++)
        {
            var ent = World.CreateEntity();
            ent.SetComponent(new UComponentGameObject() { go = this.go });
        }

        for (int i = 0; i < 200; i++)
        {
            var ent = World.CreateEntity();
            ent.SetComponent(new UComponentTransform() { transform = this.trs });
        }

        this.addRemove.onClick.AddListener(() => this.wasClickedAddRemove = true);
        this.destroy.onClick.AddListener(() => this.wasClickedDestroy = true);
    }

    public void OnUpdate(float deltaTime)
    {
        if (wasClickedAddRemove)
        {
            if (addComponent)
            {
                e3.AddComponent<TestBugComponent>();
            }
            else
            {
                e3.RemoveComponent<TestBugComponent>();
            }
            addComponent = !addComponent;
            wasClickedAddRemove = false;
        }

        if (wasClickedDestroy)
        {
            if (testDestroyEnt == default)
            {
                CreateDestroyEntity();
            }
            else
            {
                World.RemoveEntity(testDestroyEnt);
                this.testDestroyEnt = default;
            }
            wasClickedDestroy = false;
        }

        ref var c = ref e1.GetComponent<MA>();
        c.val += 1;
    }

    private void CreateDestroyEntity()
    {
        this.testDestroyEnt = World.CreateEntity();
        testDestroyEnt.AddComponent<TestDeadEntityComponent>();
        testDestroyEnt.AddComponent<m786>();
        testDestroyEnt.SetComponent(new APP()
        {
            val = (int)Time.time,
        });
    }

    public void Dispose()
    {

    }
}

public sealed class TestSystem33 : ISystem
{
    public World World { get; set; }
    private Stash<TestComponent0> stash0;
    private Stash<TestComponent1> stash1;
    private Stash<TestComponent2> stash2;
    private Stash<TestComponent3> stash3;

    public void Dispose() { }

    public void OnAwake()
    {
        stash0 = World.GetStash<TestComponent0>();
        stash1 = World.GetStash<TestComponent1>();
        stash2 = World.GetStash<TestComponent2>();
        stash3 = World.GetStash<TestComponent3>();

        for (int i = 0; i < 30; i++)
        {
            var entity = World.CreateEntity();
            int componentMask = (i * 1103515245 + 12345) & 0xF;

            if ((componentMask & 1) != 0) stash0.Add(entity);
            if ((componentMask & 2) != 0) stash1.Add(entity);
            if ((componentMask & 4) != 0) stash2.Add(entity);
            if ((componentMask & 8) != 0) stash3.Add(entity);
        }
    }

    public void OnUpdate(float deltaTime)
    {

    }
}
#pragma warning restore 0618
