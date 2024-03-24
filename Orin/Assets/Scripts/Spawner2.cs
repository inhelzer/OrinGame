using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject[] foods;
    Coroutine spawnCoroutine;
    [SerializeField] float timeBetweenSpawns;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        timeBetweenSpawns = FindObjectOfType<LevelController2>().levelSpeed;
        foods = new GameObject[9];
        System.Array.Copy(FindObjectOfType<LevelController2>().foodParts, foods, 9);

        spawnCoroutine = StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Vector3 pos = transform.position + new Vector3(Random.Range(-6, 7.5f), 0, 0);
            Instantiate(foods[Random.Range(0, foods.Length)], pos, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(timeBetweenSpawns * 0.5f, timeBetweenSpawns * 1.5f));
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
