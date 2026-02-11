using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeController : MonoBehaviour
{
    public float fadeDuration = 0f;
    private Image fadeImage;
    private Color originalColor;
    void Awake()
    {
        fadeImage = GetComponent<Image>();
        if (fadeImage == null)
        {
            Debug.LogError("Missing Image component!");
            return;
        }
        originalColor = fadeImage.color;
    }

    IEnumerator FadeRoutine()
    {
        yield return null;
    }

}
