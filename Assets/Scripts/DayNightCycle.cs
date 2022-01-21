using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    bool isActive = false;

    void FixedUpdate()
    {
        if(!isActive)
        {
            StartCoroutine(Rotate(10f));
            isActive = true;
        }
            
    }

    IEnumerator Rotate(float duration)
    {
        float startRotation = transform.eulerAngles.x;
        float endRotation = startRotation + 360.0f;
        float t = 0.0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float yRotation = Mathf.Lerp(startRotation, endRotation, t / duration) % 360.0f;
            transform.rotation = Quaternion.Euler(new Vector3(yRotation, 0, 0));
            yield return null;
        }
        isActive = false;
    }
}
