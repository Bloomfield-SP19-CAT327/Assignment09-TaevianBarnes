using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class GameStats : MonoBehaviour
{
    public int pickUps;
    public int level;
    public float gameTime;
}
