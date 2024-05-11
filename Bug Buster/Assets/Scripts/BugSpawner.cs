using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSpawner : MonoBehaviour
{
    public GameObject bugPrefab;
    private float timeAlive;
    [SerializeField] List<Transform> spawnPos;

    void Update()
    {
        timeAlive +=Time.deltaTime;
        CalculateFactors();
    }
    void  Start()
    {
        timeAlive = 1f;
    }
    public Bug SpawnBug()
    {
        int spawnPosIndex = Random.Range(0, spawnPos.Count);
        GameObject bugObj = Instantiate(bugPrefab, spawnPos[spawnPosIndex]);
        return bugObj.GetComponent<Bug>();
    }
    private void CalculateFactors()
    {
        if(WordManager.Instance.spawnCooldown>=1.5f)
        {
        WordManager.Instance.spawnCooldown *= Mathf.Pow(timeAlive,-0.00001f);
        }
    }
}
