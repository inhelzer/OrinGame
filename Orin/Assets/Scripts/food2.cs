using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food2 : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = FindObjectOfType<LevelController2>().levelGravity;
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            FindObjectOfType<LevelController2>().ChackFood(gameObject.tag);
            Destroy(gameObject);
        }
    }


    private void OnMouseDown()
    {
        FindObjectOfType<LevelControler>().ChackFood(gameObject.tag);
        Debug.Log(gameObject.tag);
        
    }
}
