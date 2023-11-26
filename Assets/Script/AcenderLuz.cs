using System.Collections;
using UnityEngine;

public class AcenderLuz : MonoBehaviour
{
    public GameObject[] luzes;

    public bool luzesligadas = false;

    private bool isInteracting = false;


    void LigarLuzes()
    {

        if (luzesligadas == true)
        {
            foreach (GameObject go in luzes)
            {
                go.SetActive(true);
            }
        }

        if (luzesligadas == false)
        {
            foreach (GameObject go in luzes)
            {
                go.SetActive(false);
            }
        }
    }

    public void IntectableButton()
    {
        if (isInteracting) return;

        isInteracting = true;
        luzesligadas = !luzesligadas;
        LigarLuzes();

        StartCoroutine(ResetInteraction());
    }

    private IEnumerator ResetInteraction()
    {
        yield return new WaitForSeconds(0.5f); // Ajuste o tempo conforme necessário
        isInteracting = false;
    }


}
