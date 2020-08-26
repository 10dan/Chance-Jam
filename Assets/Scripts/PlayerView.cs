using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour {
    [SerializeField] ParticleSystem explode;
    [SerializeField] GameObject dice;
    Rigidbody diceRB;
    [SerializeField] float explosionForce;
    private void Start() {
        diceRB = dice.GetComponent<Rigidbody>();
    }
    private void Update() {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0)) {
            if (Physics.Raycast(ray, out hit)) {
                Vector3 posHit = ray.origin + hit.distance * ray.direction;
                diceRB.AddExplosionForce(explosionForce, posHit, 10f, 1f);
                Instantiate(explode, posHit, Quaternion.identity);
            }
        }
    }
}
