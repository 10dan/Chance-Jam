using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DiceRoller : MonoBehaviour {
    Transform[] children;
    public int currentTop = 0;
    private void Start() {
        children = new Transform[transform.childCount];
        for (int i = 0; i < gameObject.transform.childCount; i++) {
            children[i] = gameObject.transform.GetChild(i);
        }
    }
    private void Update() { 
        float maxY = -Mathf.Infinity;
        int topFace = 0;
        int count = 0;
        foreach (Transform t in children) {
            if (t.position.y > maxY) {
                maxY = t.position.y;
                topFace = count;
            }
            count++;
        }
        currentTop = topFace + 1;
    }
}
