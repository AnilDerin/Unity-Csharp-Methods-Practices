using UnityEngine;

public class Transforms : MonoBehaviour
{
    public Transform hedef;



    //static methods

    void Start()
    {
        //transform.rotation = Quaternion.Euler(90, 0, 0);

        // Vector3 ourPosition = new Vector3(140, 70, 90);
        // Quaternion newPosition = Quaternion.Euler(ourPosition);

        // transform.rotation = newPosition;

        transform.rotation = Quaternion.identity;



    }

    void Update()
    {

        /* Vector3 fark = hedef.position - transform.position;

        transform.rotation = Quaternion.LookRotation(fark, Vector3.up);


        float angle = Quaternion.Angle(transform.rotation, hedef.rotation);
        print(angle);

        transform.rotation = Quaternion.Inverse(hedef.rotation);
        */
    }




}
