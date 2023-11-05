using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.Rendering.Universal;

public class LuzPiscando : MonoBehaviour
{
    [SerializeField] private Light2D[] luzes;
    public float intensityChangeSpeed = 1.0f; 

    private bool increasingIntensity = true;

    public DoorNumberChange numberChange;

    // Update is called once per frame
    void Update()
    {
        float intensityChange = Time.deltaTime * intensityChangeSpeed;
        foreach (Light2D luz in luzes)
        {
            if (increasingIntensity)
            {
                luz.intensity += intensityChange;
                if (luz.intensity >= 1.0f) // Valor máximo de intensidade
                {
                    increasingIntensity = false;
                }
            }
            else
            {
                luz.intensity -= intensityChange;
                if (luz.intensity <= 0.0f) // Valor mínimo de intensidade
                {
                    increasingIntensity = true;
                    if(numberChange != null)
                    {
                        numberChange.piscadasLuz++;
                    }
                }
            }
        }
    }
}
