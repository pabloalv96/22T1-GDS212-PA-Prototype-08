using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float minValue;
    [SerializeField] float maxValue;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.Range(minValue, maxValue) * Time.deltaTime * speed, Random.Range(minValue, maxValue) * Time.deltaTime * speed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
