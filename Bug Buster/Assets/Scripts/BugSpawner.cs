using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSpawner : MonoBehaviour
{
    public GameObject bugPrefab;
    [SerializeField] List<Transform> spawnPos;
    public Bug SpawnBug()
    {
        int spawnPosIndex = Random.Range(0, spawnPos.Count);
        GameObject bugObj = Instantiate(bugPrefab, spawnPos[spawnPosIndex]);
        return bugObj.GetComponent<Bug>();
    }
}
