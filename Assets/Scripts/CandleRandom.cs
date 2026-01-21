using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CandleRandom : MonoBehaviour
{
    [SerializeField] GameObject[] candleSpawns;

    void Start()
    {
        int index = Random.Range(0, candleSpawns.Length);
        candleSpawns[index].SetActive(true);
    }
}
