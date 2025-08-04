using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float randomVariable = 1f;
    public Transform pipespawnPosition;
    
    private float timer = float.MaxValue;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipes();
            timer = 3f;
        }
    }

    public void StartSpawning()
    {
        enabled = true;
    }

   private void SpawnPipes()
    {
        float yOffset = Random.Range(-randomVariable, randomVariable);
        Vector3 spawnPosition = pipespawnPosition.position + Vector3.up * yOffset;
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
