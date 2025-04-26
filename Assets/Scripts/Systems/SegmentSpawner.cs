using System.Collections.Generic;
using UnityEngine;

public class SegmentSpawner : MonoBehaviour
{
    [Header("Segments")]
    public List<GameObject> segmentPrefabs;

    [Header("Spawn Logic")]
    public Transform player;
    public float spawnDistanceAhead = 30f;
    public int maxSegments = 10;

    private List<GameObject> activeSegments = new List<GameObject>();
    private Vector3 nextSpawnPosition;

    private void Start()
    {
        nextSpawnPosition = Vector3.zero;

        // Spawn initial segments
        for (int i = 0; i < maxSegments; i++)
        {
            SpawnNextSegment();
        }
    }

    private void Update()
    {
        // Spawn new segment if player gets close to the end
        float distanceToLast = Vector3.Distance(player.position, nextSpawnPosition);
        if (distanceToLast < spawnDistanceAhead)
        {
            SpawnNextSegment();
        }

        // Cleanup: remove far back segments
        if (activeSegments.Count > maxSegments)
        {
            Destroy(activeSegments[0]);
            activeSegments.RemoveAt(0);
        }
    }

    void SpawnNextSegment()
    {
        // Pick random segment
        GameObject prefab = segmentPrefabs[Random.Range(0, segmentPrefabs.Count)];
        GameObject segment = Instantiate(prefab, nextSpawnPosition, Quaternion.identity);
        activeSegments.Add(segment);

        // Get ExitPoint position for next spawn
        Transform exit = segment.transform.Find("ExitPoint");
        if (exit != null)
        {
            nextSpawnPosition = exit.position;
        }
        else
        {
            // fallback to offset if ExitPoint is missing
            nextSpawnPosition += new Vector3(28f, 0f, 0f);
        }
    }
}
