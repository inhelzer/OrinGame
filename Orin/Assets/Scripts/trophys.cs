using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trophys : MonoBehaviour
{
    [SerializeField] GameObject bad;
    [SerializeField] GameObject good;
    [SerializeField] GameObject veryGood;
    [SerializeField] float shortDelay;
    [SerializeField] float longDelay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bad()
    {
        GameObject badObject = 

        Instantiate(bad, transform.position, Quaternion.identity) as GameObject;
        Destroy(badObject, shortDelay);
    }

    public void Good()
    {
        Instantiate(good, transform.position, Quaternion.identity);
    }

    public void VeryGood()
    {
        Instantiate(veryGood, transform.position, Quaternion.identity);
    }
}
