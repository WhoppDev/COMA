using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elevator : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject ElevatorHUD;
    [SerializeField] private GameObject SelectButton;

    [SerializeField] private AudioClip _hitSound;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Animator anim;


    public void Interact()
    {
        ElevatorHUD.SetActive(true);
    }

    private void Update()
    {
        StartCoroutine(SelectButtonEffect());
    }

    private IEnumerator SelectButtonEffect()
    {
        Image buttonImage = SelectButton.GetComponent<Image>();
        if (buttonImage == null) yield break; 

        bool increasingAlpha = true; 

        while (true) 
        {
            float alpha = buttonImage.color.a * 255; 
            if (increasingAlpha)
            {
                while (alpha < 255)
                {
                    alpha += Time.deltaTime * 100;
                    alpha = Mathf.Clamp(alpha, 95, 255); 
                    buttonImage.color = new Color(buttonImage.color.r, buttonImage.color.g, buttonImage.color.b, alpha / 255);
                    yield return null;
                }
                increasingAlpha = false; 
            }
            else
            {

                while (alpha > 95)
                {
                    alpha -= Time.deltaTime * 100;
                    alpha = Mathf.Clamp(alpha, 95, 255);
                    buttonImage.color = new Color(buttonImage.color.r, buttonImage.color.g, buttonImage.color.b, alpha / 255);
                    yield return null;
                }
                increasingAlpha = true; 
            }
        }
    }







    public void TerceiroAndar()
    {
        AudioManager.PlaySound(_hitSound);
        ElevatorHUD.SetActive(false);
        StartCoroutine(AbrirElevador());

    }

    public void SegundoAndar()
    {
        //Aqui a logica de colocar o botão
    }

    public void AndarZero()
    {
        //Aqui a logica de andar desativado
    }

    public IEnumerator AbrirElevador()
    {
        yield return new WaitWhile(() => _audioSource.isPlaying);
        anim.SetBool("isOpen", true);
    }


}
