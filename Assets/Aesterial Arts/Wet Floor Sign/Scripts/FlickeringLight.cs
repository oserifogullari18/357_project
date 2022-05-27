using System.Collections;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{

    [SerializeField] private new Light[] light;

    void Start()
    {
        StartCoroutine(Flicker());
    }

    private IEnumerator Flicker()
    {
        yield return new WaitForSeconds(Random.Range(0.05f, 0.1f));
        int randomNumber = Random.Range(0, 10);

        for (int i = 0; i < light.Length; i++)
        {
            if (randomNumber > 4)
            {
                light[i].intensity = 0.0f;
            }
            else if (randomNumber == 4)
            {
                light[i].intensity = 0.1f;
            }
            else if (randomNumber == 3)
            {
                light[i].intensity = 0.2f;
            }
            else
            {
                light[i].intensity = 0.75f;
            }
        }
        StartCoroutine(Flicker());
    }
}