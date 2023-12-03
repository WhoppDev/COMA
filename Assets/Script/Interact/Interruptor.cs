using System.Collections;
using UnityEngine;

public class Interruptor : MonoBehaviour, IInteractable
{
    public GameObject[] luzes;

    [SerializeField] private Interruptor_Info interruptor;

    private void Start()
    {
        LigarLuzes();
    }

    public void Interact()
    {
        if (interruptor.isInteracting) return;

        interruptor.isInteracting = true;
        interruptor.luzesligadas = !interruptor.luzesligadas;
        LigarLuzes();

        StartCoroutine(ResetInteraction());
    }


        void LigarLuzes()
    {

        if (interruptor.luzesligadas == true)
        {
            foreach (GameObject go in luzes)
            {
                go.SetActive(true);
            }
        }

        if (interruptor.luzesligadas == false)
        {
            foreach (GameObject go in luzes)
            {
                go.SetActive(false);
            }
        }
    }


    private IEnumerator ResetInteraction()
    {
        yield return new WaitForSeconds(0.5f); // Ajuste o tempo conforme necessário
        interruptor.isInteracting = false;
    }


}
