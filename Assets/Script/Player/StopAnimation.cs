using UnityEngine;

public class StopAnimation : MonoBehaviour
{
    public float tempoMaximoParado = 10.0f; // Tempo máximo parado em segundos
    public float tempoParado = 0.0f; // Tempo parado atual
    private bool jogadorParado = false;

    [SerializeField] private Animator anim;


        void Update()
        {
            if (CORE.instance.gameManager.playerMoviment != 0)
            {
                jogadorParado = false;
                tempoParado = 0.0f;
            }
            else
            {
                jogadorParado = true;
                tempoParado += Time.deltaTime;

                if (tempoParado >= tempoMaximoParado)
                {
                anim.SetTrigger("StopAnimation");
                tempoParado = 0;
                }
            }
        }

}
