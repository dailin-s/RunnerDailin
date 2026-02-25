using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DamageFlash : MonoBehaviour
{
    public Image flashImage;
    public float flashDuration = 0.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Flash(){
        StartCoroutine(FlashRoutine());
    }

    IEnumerator FlashRoutine() {
        Color color = flashImage.color;
        color.a = 0.6f;
        flashImage.color = color;

        yield return new WaitForSeconds(flashDuration);

        color.a = 0f;
        flashImage.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
