using Scellecs.Morpeh;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Runner : MonoBehaviour
{
    public Mesh mesh;
    public Material material;
    public GameObject gameobject;
    public Transform trs;
    public Button AddRemove;
    public Button destroy;
    public Button worldAdd;
    public Button worldRemove;

    private List<World> worlds;

    private void Start()
    {
        worlds = new List<World>();
        var w2 = World.Default;
        w2.UpdateByUnity = true;
        var sysGr = w2.CreateSystemsGroup();
        sysGr.AddSystem(new TestSystem(mesh, material, gameobject, trs, AddRemove, destroy));
        w2.AddSystemsGroup(0, sysGr);
        this.worlds.Add(w2);
        worldAdd.onClick.AddListener(() => AddWorld());
        worldRemove.onClick.AddListener(() => RemoveWorld());
    }

    private void AddWorld()
    {
        var world = World.Create();
        world.UpdateByUnity = true;
        var sysGr = world.CreateSystemsGroup();
        sysGr.AddSystem(new TestSystem33());
        world.AddSystemsGroup(0, sysGr);
        this.worlds.Add(world);
    }

    private void RemoveWorld()
    {
        if (worlds.Count > 0)
        {
            var random = UnityEngine.Random.Range(1, this.worlds.Count + 1);
            var world = worlds[random - 1];
            world.Dispose();
            this.worlds.RemoveAt(random - 1);
        }
    }
}
