using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeController : MonoBehaviour
{
    public float fadeDuration = 1f;
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

    public void FadeIn() => StartFade(originalColor.a);
    public void FadeOut() => StartFade(0f);

    private void StartFade(float targetAlpha)
    {
        StartCoroutine(FadeRoutine(targetAlpha));
    }

    IEnumerator FadeRoutine(float targetAlpha)
    {
        float time = 0;
        float startAlpha = fadeImage.color.a;
        while(time < fadeDuration)
        {
            time += Time.deltaTime;
            //prosentuaalinen määrä kauan on aikaa mennyt
            float t = time / fadeDuration;
            //väliaikainen väri
            Color c = fadeImage.color;
            //väliaikainen alpha
            c.a = Mathf.Lerp(startAlpha, targetAlpha, t);
            fadeImage.color = c;
            yield return null;
        }
        Color final = fadeImage.color;
        final.a = targetAlpha;
        fadeImage.color = final;
    }

}
