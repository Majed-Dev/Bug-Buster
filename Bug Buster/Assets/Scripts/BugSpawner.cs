using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSpawner : MonoBehaviour
{
    public GameObject bugPrefab;
    public Bug SpawnBug()
    {
        GameObject bugObj = Instantiate(bugPrefab);

        return bugObj.GetComponent<Bug>();
    }
    public void SpawnBug(Transform transform)
    {
        Instantiate(bugPrefab,transform);
    }
}
