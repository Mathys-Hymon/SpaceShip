using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    [SerializeField] private float rotSpeed;
    [SerializeField] private float accel;

    private float speed;

    private void Update()
    {
        transform.position = transform.position + (transform.forward * speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.W))
        {
           if(speed < maxSpeed)
            {
                speed += accel * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if(speed > 0)
            {
                speed -= accel * Time.deltaTime;
            }
        }

        else
        {
            if (speed > 0)
            {
                speed -= accel/5 * Time.deltaTime;
            }
        }

        if(Input.GetKeyDown(KeyCode.A))
        {

        }
        else if(Input.GetKeyDown(KeyCode.D)) 
        { 

        }
    }
}
