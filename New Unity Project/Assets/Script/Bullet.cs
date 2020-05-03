using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float z_pos;
    public GameObject fx_obj;
    public Camera main;

    // Start is called before the first frame update
    void Start()
    {
        z_pos = 0.0f;
     
    }

    // Update is called once per frame
    void Update()
    {
       
        z_pos += 0.1f;
        transform.Translate(0.0f, 0.0f, z_pos * Time.deltaTime);

        if(z_pos > 20.0f)
        {
            Destroy(gameObject, 0);
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag =="Enemy")
        {
            Destroy(gameObject, 0);
            Destroy(col.gameObject, 0);
            Instantiate(fx_obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            main.transform.Rotate(0, -5, 0);
            main.transform.Rotate(0, 5, 0);
            //  Destroy(fx_obj);


        }
    }

}
