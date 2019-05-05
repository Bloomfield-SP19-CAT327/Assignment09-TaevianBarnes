using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameController gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        gc.NextLevel();    }
}
