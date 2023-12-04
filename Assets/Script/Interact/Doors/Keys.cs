using UnityEngine;


[CreateAssetMenu(fileName ="New Key", menuName ="Scriptable/Keys")]
public class Keys : ScriptableObject
{
    public string keyName;
    public bool takeKey = false;
}
