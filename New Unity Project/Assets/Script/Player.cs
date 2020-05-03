using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float x_diff;
    private float y_diff;
    private float moving_speed;
    private float rot_speed;
    public GameObject obj;
    public Game_Manager game_Manager;

    // Start is called before the first frame update
    void Start()
    {
        x_diff = 0.01f;
        y_diff = 0.01f;
        moving_speed = 20.0f;
        rot_speed = 100.0f;


    }

    // Update is called once per frame
    void Update()
    {
        if(game_Manager.gameStop == false)
        {
            Rotate();
            TransLate();
            Shoot();
        }
       
    }

    void Shoot()
    {
        if(Input.GetKeyUp(KeyCode.Space))
          Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z),Quaternion.identity);




    }

    void TransLate()
    {

        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * this.moving_speed * Time.smoothDeltaTime * keyHorizontal, Space.World);

       // transform.Translate(Vector3.up * this.moving_speed * Time.smoothDeltaTime * keyVertical, Space.World);
    }

    void Rotate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");



        h = h * this.rot_speed * Time.deltaTime;
        v = v * this.rot_speed * Time.deltaTime;


       // this.transform.Rotate(Vector3.back * h);
        this.transform.Rotate(Vector3.right * v);


    }

}
