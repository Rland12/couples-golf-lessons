using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTarget : MonoBehaviour
{
    static public int Score = 0;
    public Transform[] balls;
    BoxCollider bc;
    // Use this for initialization
    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform b in balls) {
            if (b && bc.bounds.Contains(b.position))
            { 
                Score++;
                Debug.Log(Score);
                Destroy(b.gameObject);
            }
        }

    }
}