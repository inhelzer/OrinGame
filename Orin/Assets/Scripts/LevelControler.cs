using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{
    [SerializeField] GameObject endPoint;
    public float levelSpeed;
    public Vector3 endPos;
    public GameObject[] foodParts;
    [SerializeField] GameObject burger;

    public GameObject[] challange;
    [SerializeField] int currentFood = 0;

    // Start is called before the first frame update
    void Start()
    {
        endPos = endPoint.transform.position;
        challange = new GameObject[7];
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
        challange[3] = burger;
        challange[4] = foodParts[Random.Range(2, foodParts.Length)];
        challange[5] = foodParts[Random.Range(2, foodParts.Length)];
        challange[6] = foodParts[1];
        currentFood = 0;
        FindObjectOfType<Challange>().NewCallange();
    }

    public void ChackFood(string name)
    {
        if (challange[currentFood].gameObject.tag != name)
        {
            FindObjectOfType<trophys>().CreateBad();
        }

        if (challange[currentFood].gameObject.tag == name)
        {
            Debug.Log("!!!!!!");
            currentFood++;
            if (currentFood >= 7)
            {
                FindObjectOfType<trophys>().CreateGood();
                CreateChalange();
            }
            
        }

        
    }
}
