using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    GameObject cannon;
    GameObject rotationPoint;
    public GameObject bullet;
    Vector3 rotationAxis;
    Transform rotation;
    float rotationSpeed = 10f;
   
    // Start is called before the first frame update
    void Start()
    {
        cannon = GameObject.Find("turret_cannon");
        rotationPoint = GameObject.Find("rotationPoint");
        rotationAxis = new Vector3(0, 0, 1);
        rotation = cannon.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && (rotation.eulerAngles.z < 180 || rotation.eulerAngles.z > 359))
        {
            Debug.Log("A pressed");
            cannon.transform.RotateAround(rotationPoint.transform.position, rotationAxis, rotationSpeed * Time.deltaTime);
            Debug.Log(rotation.eulerAngles.z);
        }
        
        if (Input.GetKey(KeyCode.D) && (rotation.eulerAngles.z > 0 && rotation.eulerAngles.z < 181))
        {
            Debug.Log("D pressed");
            cannon.transform.RotateAround(rotationPoint.transform.position, rotationAxis, -rotationSpeed * Time.deltaTime);
            Debug.Log(rotation.eulerAngles.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            GameObject newBullet = Instantiate(bullet, cannon.transform.position, cannon.transform.rotation);
            BulletBehaviour newBulletBehaviour = newBullet.GetComponent<BulletBehaviour>();
            newBulletBehaviour.Shoot();
        }
    }
}
