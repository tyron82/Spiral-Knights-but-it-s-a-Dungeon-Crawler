using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Attributes
    public Rigidbody body;
    public Transform position;
    public int movementspeed = 500;

    public bool pressedW = false;
    public bool pressedS = false;
    public bool pressedA = false;
    public bool pressedD = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            pressedW = true;
        }
        if (Input.GetKey("s"))
        {
            pressedS = true;
        }
        if (Input.GetKey("a"))
        {
            pressedA = true;
        }
        if (Input.GetKey("d"))
        {
            pressedD = true;
        }
    }

    // Used to update Physics, rather than Update()
    void FixedUpdate() {
        //Basic Movement
        if(pressedW){
            position.Translate(0, 0, movementspeed * Time.deltaTime, Space.World);
            pressedW = false;
        }
        if (pressedS)
        {
            position.Translate(0, 0, -movementspeed * Time.deltaTime, Space.World);
            pressedS = false;
        }
        if (pressedA)
        {
            position.Translate(-movementspeed * Time.deltaTime, 0, 0, Space.World);
            pressedA = false;
        }
        if (pressedD)
        {
            position.Translate(movementspeed * Time.deltaTime, 0, 0, Space.World);
            pressedD = false;
        }
    }
}
