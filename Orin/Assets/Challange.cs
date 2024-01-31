using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Challange : MonoBehaviour
{
    public GameObject[] foodsCallange;
    
    [SerializeField] GameObject[] grafics;
    float gap = 0.38f;
    [SerializeField] Vector3 origin;
    [SerializeField] GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        foodsCallange = new GameObject[7];
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewCallange()
    {
        System.Array.Copy(FindObjectOfType<LevelControler>().challange, foodsCallange, 7);

        

        GameObject currentParent =
        Instantiate(parent, transform.position, Quaternion.identity) as GameObject;

        Instantiate(grafics[0], origin, Quaternion.identity, currentParent.transform);
        Instantiate(grafics[1], origin + new Vector3(0, 6 * gap + 0.1f, 0), Quaternion.identity, currentParent.transform);


        for (int j = 1; j < 6; j++)
        {
            for (int i = 2; i < 9; i++)
            {

                if (foodsCallange[j].tag == grafics[i].tag)
                {
                    GameObject newGrafic =
                    Instantiate(grafics[i], origin + new Vector3(0, j * gap, 0), Quaternion.identity) as GameObject;
                    newGrafic.transform.SetParent(currentParent.transform);
                }
            }
        }


    }

   
}
