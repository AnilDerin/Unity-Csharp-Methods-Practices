using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiate : MonoBehaviour
{


    public float hp = 998.3f;
    public GameObject ornekobjem;
    // private float zaman;

    // Start is called before the first frame update
    void Start()
    {
        //zaman = 0f;
        //Instantiate(ornekobjem);
        //Instantiate(ornekobjem, transform.position, Quaternion.identity);
        //Instantiate(ornekobjem, transform.position, Quaternion.identity);
        //Instantiate(ornekobjem, transform.position, Quaternion.identity);
        // GameObject yeniobjem = Instantiate(ornekobjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        // yeniobjem.GetComponent<BoxCollider>().enabled = false;

    }



    // Update is called once per frame
    void Update()
    {
        //0-100 arasında değerler alır
        print(Mathf.Clamp(hp, 0f, 100f));




        /* if (zaman >= 2)
        {
            GameObject yeniobjem = Instantiate(ornekobjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
            yeniobjem.GetComponent<BoxCollider>().enabled = false;
            zaman = 0;
        }
        else
        {
            zaman += Time.deltaTime;
        }
        */
    }
}
