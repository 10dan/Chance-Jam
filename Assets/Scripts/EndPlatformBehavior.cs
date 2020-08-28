using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatformBehavior : MonoBehaviour
{
    [SerializeField] GameObject light;
    [SerializeField] DiceRoller dice;
    [SerializeField] float initIntensity;
    [SerializeField] float changeIntensity;
    [SerializeField] float speed;
    private void Update() {
        light.GetComponent<Light>().intensity = initIntensity + changeIntensity * Mathf.Sin(Time.time*speed);
    }
    private void OnCollisionEnter(Collision collision) {
        if(collision.collider.gameObject.name == "Dice") {
            print(dice.currentTop);
        }
    }
}
