using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] foods;
    Coroutine spawnCoroutine;
    [SerializeField] float timeBetweenSpawns;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        
        foods = new GameObject[7];
        System.Array.Copy(FindObjectOfType<LevelControler>().foodParts, foods, 7);

        spawnCoroutine = StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while(true)
        {
            Instantiate(foods[Random.Range(0, foods.Length)], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(timeBetweenSpawns * 0.7f, timeBetweenSpawns * 1.5f));
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
