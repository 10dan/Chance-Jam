using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatformBehavior : MonoBehaviour
{
    [SerializeField] GameObject light;
    [SerializeField] float initIntensity;
    [SerializeField] float changeIntensity;
    [SerializeField] float speed;
    private void Update() {
        light.GetComponent<Light>().intensity = initIntensity + changeIntensity * Mathf.Sin(Time.time*speed);
    }
}
