using System.Collections;
using UnityEngine;

public class TimeScaleFader : MonoBehaviour
{


    public float fadeDuration = 1f;

    public void FadeOut()
    {
        StartCoroutine(FadeTimeScale(0f));
    }

    public void FadeIn()
    {
        StartCoroutine(FadeTimeScale(1f));
    }

    private IEnumerator FadeTimeScale(float targetTimeScale)
    {
        float startTimeScale = Time.timeScale;
        float startTime = Time.realtimeSinceStartup;
        float endTime = startTime + fadeDuration;

        while (Time.realtimeSinceStartup < endTime)
        {
            float normalizedTime = (Time.realtimeSinceStartup - startTime) / fadeDuration;
            Time.timeScale = Mathf.Lerp(startTimeScale, targetTimeScale, normalizedTime);
            yield return null;
        }

        Time.timeScale = targetTimeScale;
    }
}
