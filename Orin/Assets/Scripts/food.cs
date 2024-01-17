using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    Vector3 endPos;
    float moveSpeed;
    Vector3 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = FindObjectOfType<LevelControler>().levelSpeed;
        endPos = FindObjectOfType<LevelControler>().endPos;

        moveVector = (endPos - transform.position).normalized * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveVector * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        FindObjectOfType<LevelControler>().ChackFood(gameObject.tag);
        Debug.Log(gameObject.tag);
        Destroy(gameObject);
    }
}
