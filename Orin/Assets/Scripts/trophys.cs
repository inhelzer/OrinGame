using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trophys : MonoBehaviour
{
    [SerializeField] GameObject bad;
    [SerializeField] GameObject good;
    [SerializeField] GameObject veryGood;
    [SerializeField] float shortDelay = 1f;
    [SerializeField] float longDelay;

   

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBad()
    {
        
        GameObject badObject = 
        Instantiate(bad, transform.position, Quaternion.identity) as GameObject;
        Destroy(badObject, shortDelay);
        
        
    }

    public void CreateGood()
    {
        
        GameObject goodObject =
        Instantiate(good, transform.position, Quaternion.identity) as GameObject;
        Destroy(goodObject, shortDelay);
        


    }

    public void CreateVeryGood()
    {
        GameObject veryGoodObject =
        Instantiate(veryGood, transform.position, Quaternion.identity) as GameObject;
        Destroy(veryGoodObject, shortDelay);
    }
}
