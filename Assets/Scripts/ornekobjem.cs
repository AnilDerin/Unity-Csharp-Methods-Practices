using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ornekobjem : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 60f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 1.5f);
    }
}
