using UnityEngine;

public class MudarScena : MonoBehaviour
{
    [SerializeField] private GameObject normalScene;
    [SerializeField] private GameObject terrifyScene;
    [SerializeField] private GameObject newlight;

    private void Awake()
    {
        if (!CORE.instance.sceneController.terrifyScene) { return; }
        TerrifyScene();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TerrifyScene();
    }

    void TerrifyScene()
    {
        normalScene.SetActive(false);
        terrifyScene.SetActive(true);
        newlight.SetActive(true);
        CORE.instance.sceneController.terrifyScene = true;
    }
}
