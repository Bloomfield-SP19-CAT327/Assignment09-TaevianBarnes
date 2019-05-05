using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameManager gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        gm.NextLevel();    }
}
