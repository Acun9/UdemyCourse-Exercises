using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject player;
    private void Start()
    {
        int SpawnPoint = PlayerPrefs.GetInt("Checkpoint");

        player.transform.position = spawnPoints[SpawnPoint].position;
    }
}
