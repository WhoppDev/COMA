using UnityEngine;

public class CORE : MonoBehaviour
{
    static public CORE instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = GetComponent<CORE>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
