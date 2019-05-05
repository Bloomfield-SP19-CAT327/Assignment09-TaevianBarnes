using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        GameManager gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
}
