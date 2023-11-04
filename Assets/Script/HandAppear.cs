using UnityEngine;

public class HandAppear : MonoBehaviour
{
    [SerializeField] private AudioClip _hitSound;

    [SerializeField] private GameObject hand;

    private bool handAppear = true;


    private void Awake()
    {
        if (!CORE.instance.sceneController.handAppear) { return; }

        HandAppearController();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!handAppear) { return; }
        HandAppearController();
        AudioManager.PlaySound(_hitSound);
    }

    private void HandAppearController()
    {

        hand.SetActive(true);
        handAppear = false;
        CORE.instance.sceneController.handAppear = true;
    }
}
