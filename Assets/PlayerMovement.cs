using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Attributes
    public Rigidbody body;
    public Transform position;
    public int movementspeed = 500;

    // Start is called before the first frame update
    void Start()
    {
        body.AddForce(100,10,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Used to update Physics, rather than Update()
    void FixedUpdate() {
        //Basic Movement
        if(Input.GetKey("w")){
            position.Translate(0, 0, movementspeed * Time.deltaTime);
            //body.AddForce(0, 0, movementspeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            position.Translate(0, 0, -movementspeed * Time.deltaTime);
            //body.AddForce(0, 0, -movementspeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            position.Translate(-movementspeed * Time.deltaTime, 0, 0);
            //body.AddForce(-movementspeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            position.Translate(movementspeed * Time.deltaTime, 0, 0);
            //body.AddForce(movementspeed * Time.deltaTime, 0, 0);
        }
    }
}
