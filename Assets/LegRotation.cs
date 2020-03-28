using UnityEngine;

public class LegRotation : MonoBehaviour
{
    //Attributes
    public Transform position;
    public int rotationSpeed = 5;

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
    void FixedUpdate()
    {
        //Basic Movement
        if (pressedW)
        {
            if (position.rotation.y != 0)
            {
                position.Rotate(0, -1 * Mathf.Sign(position.rotation.y) * rotationSpeed, 0);
            }
            pressedW = false;
        }
        if (pressedS)
        {
            if (position.rotation.y != 180)
            {
                position.Rotate(0, 1 * Mathf.Sign(position.rotation.y) * rotationSpeed, 0);
            }
            pressedS = false;
        }
        if (pressedA)
        {
            if (position.rotation.y != 90)
            {
                position.Rotate(0, -1 * Mathf.Sign(position.rotation.y) * rotationSpeed, 0);
            }
            pressedA = false;
        }
        if (pressedD)
        {
            if (position.rotation.y != -90)
            {
                position.Rotate(0, -1 * Mathf.Sign(position.rotation.y) * rotationSpeed, 0);
            }
            pressedD = false;
        }
    }
}
