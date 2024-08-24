using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class Inventario
{
    public List<string> armarioID;
    public List<string> itemID;

    private string path = "Assets/Inventario.txt";

    public void Save()
    {
        var content = JsonUtility.ToJson(this, true);
        File.WriteAllText(path, content);

    }

    public void Load()
    {
        if (File.Exists(path))
        {
            var content = File.ReadAllText(path);
            var p = JsonUtility.FromJson<Inventario>(content);
            armarioID = p.armarioID;
            itemID = p.itemID;
        }
    }
}
