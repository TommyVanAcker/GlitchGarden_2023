using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1.0f;
    [SerializeField] float maxSpawnDelay = 5.0f;
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] Transform parentSpawner;
    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        
        while (spawn)
        {
            
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
        
    }

    private void SpawnAttacker()
    {
        Instantiate<Attacker>(attackerPrefab, parentSpawner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
