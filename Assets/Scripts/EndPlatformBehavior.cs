using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatformBehavior : MonoBehaviour
{
    [SerializeField] GameObject light;
    private void Update() {
        light.GetComponent<Light>().intensity = 2 + Mathf.Sin(Time.time*2);
    }
}
