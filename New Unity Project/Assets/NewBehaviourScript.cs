using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject Bullet;
    public Transform bulletSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //print("Hello World"); 
    }

    // Update is called once per frame
    void Update()
    {
        move();
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if(Input.GetKeyDown(KeyCode.F))
        {
            Fire();
        }
    }

    void move()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        if (this.transform.rotation.eulerAngles.z != 0)
        {
            transform.Rotate(0, 0, -this.transform.eulerAngles.z);
        }

        if (this.transform.rotation.eulerAngles.x >= 70 && this.transform.rotation.eulerAngles.x <= 80)
        {
            transform.Rotate(-1, 0, 0);
        }

        else if (this.transform.rotation.eulerAngles.x <= 310 && this.transform.rotation.eulerAngles.x >= 300)
        {
            transform.Rotate(1, 0, 0);
        }

        else
        {
            transform.Rotate(-v, h, 0);
        }
    }

    void Fire()
    {
        // Create bullet
        var newBullet = (GameObject)Instantiate(Bullet, bulletSpawn.position, bulletSpawn.rotation);

        // add velocity
        newBullet.GetComponent<Rigidbody>().velocity = newBullet.transform.forward * 10;

        // destroy bullet after 2s
        Destroy(newBullet, 2.0f);
    }
}

