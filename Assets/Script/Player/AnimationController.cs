using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public float tempoMaximoParado = 10.0f; // Tempo máximo parado em segundos
    public float tempoParado = 0.0f; // Tempo parado atual
    private bool jogadorParado = false;

    public Animator anim;


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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damage"))
        {
            TakeDamage();
            tempoParado = 0.0f;
        }
    }

    public void TakeDamage()
    {
        anim.SetTrigger("takeDamage");
        CORE.instance.gameManager.TakeDamage();
    }

}
