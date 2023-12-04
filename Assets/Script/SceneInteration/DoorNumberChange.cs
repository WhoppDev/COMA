using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorNumberChange : MonoBehaviour
{
    [SerializeField] private GameObject number666, number76;

    public int mudarNumero; //Quantidades de piscadas da luz para mudar de numero
    public int piscadasLuz;

    private int numeroAtual = 1;

    void Update()
    {
        if (piscadasLuz == mudarNumero)
        {
            // Alterna entre os números
            numeroAtual = (numeroAtual == 666) ? 76 : 666;

            // Atualiza a visibilidade dos objetos com base no número atual
            number666.SetActive(numeroAtual == 666);
            number76.SetActive(numeroAtual == 76);

            piscadasLuz = 0;
        }
    }
}
