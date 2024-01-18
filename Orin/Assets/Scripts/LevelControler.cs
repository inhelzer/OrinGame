using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{
    [SerializeField] GameObject endPoint;
    public float levelSpeed;
    public Vector3 endPos;
    public GameObject[] foodParts;
    [SerializeField] GameObject goodJob;

    [SerializeField] GameObject[] challange;
    [SerializeField] int currentFood = 0;

    // Start is called before the first frame update
    void Start()
    {
        endPos = endPoint.transform.position;
        challange = new GameObject[6];
        CreateChalange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateChalange()
    {
        challange[0] = foodParts[0];
        challange[1] = foodParts[Random.Range(2, foodParts.Length)];
        challange[2] = foodParts[Random.Range(2, foodParts.Length)];
        challange[3] = foodParts[Random.Range(2, foodParts.Length)];
        challange[4] = foodParts[Random.Range(2, foodParts.Length)];
        challange[5] = foodParts[1];
    }

    public void ChackFood(string name)
    {
        if (challange[currentFood].gameObject.tag == name)
        {
            Debug.Log("!!!!!!");
            if(currentFood > 6)
            {
                currentFood++;
            }
            else
            {
                FindObjectOfType<trophys>().Good();
            }
        }

        else
        {
            FindObjectOfType<trophys>().Bad();
        }
    }
}
