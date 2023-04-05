using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LocationSpawner : MonoBehaviour
{
	[SerializeField] GameObject spawnPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawnPrefab, spawnPrefab.transform);
        }
    }

}
