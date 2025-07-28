using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject squarePrefab;
    private void spawnObject()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, Random.Range(0, 45));
        Instantiate(squarePrefab, new Vector3(Random.Range(0, 3), Random.Range(0, 3), 0), rotation);
    }
    private void Start()
    {
        InvokeRepeating("spawnObject", 0, 3);
    }
}
