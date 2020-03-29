using UnityEngine;

public class LegRotation : MonoBehaviour
{
    //Attributes
    public Transform position;
    public int rotationSpeed = 10;
    int[] orientations = new int[] { 0, 45, 90, 135, 180, 225, 270, 315 };
    int[] bigOrientations = new int[] { 360, 405, 450, 495, 180, 225, 270, 315 };
    int[] reverseOrientations = new int[] { 180, 225, 270, 315, 0, 45, 90, 135 };
    int orientationIndex = 0;

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
        orientationIndex = findOrientationIndex();
        Debug.Log(orientationIndex);
        if (orientationIndex != -1 && position.localEulerAngles.y != orientations[orientationIndex])
        {
            switch (orientationIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    if (orientations[orientationIndex] < position.localEulerAngles.y && position.localEulerAngles.y < reverseOrientations[orientationIndex])
                    {
                        position.localEulerAngles = position.localEulerAngles + new Vector3(0, -rotationSpeed, 0);

                    }
                    else
                    {
                        position.localEulerAngles = position.localEulerAngles + new Vector3(0, rotationSpeed, 0);

                    }
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                    if (reverseOrientations[orientationIndex] < position.localEulerAngles.y && position.localEulerAngles.y < orientations[orientationIndex])
                    {
                        position.localEulerAngles = position.localEulerAngles + new Vector3(0, rotationSpeed, 0);

                    }
                    else
                    {
                        position.localEulerAngles = position.localEulerAngles + new Vector3(0, -rotationSpeed, 0);

                    }
                    break;
            }
        }
    }

    //Find Orientation for lowerbody
    //Return -1 when unknown orientation or no input
    //clear input
    int findOrientationIndex()
    {
        //When no negation ex. W & S
        if (!(pressedW && pressedS) && !(pressedA && pressedD))
        {
            if (pressedW && pressedA)
            {
                pressedW = false;
                pressedA = false;
                return 7;
            }
            else if (pressedW && pressedD)
            {
                pressedW = false;
                pressedD = false;
                return 1;
            }
            else if (pressedS && pressedA)
            {
                pressedS = false;
                pressedA = false;
                return 5;
            }
            else if (pressedS && pressedD)
            {
                pressedS = false;
                pressedD = false;
                return 3;
            }
            else if (pressedW)
            {
                pressedW = false;
                return 0;
            }
            else if (pressedS)
            {
                pressedS = false;
                return 4;
            }
            else if (pressedA)
            {
                pressedA = false;
                return 6;
            }
            else if (pressedD)
            {
                pressedD = false;
                return 2;
            }
            else
            {
                pressedW = false;
                pressedS = false;
                pressedA = false;
                pressedD = false;
                return -1;
            }

        }
        else if ((pressedW && pressedS) && !(pressedA && pressedD))
        {
            if (pressedA)
            {
                pressedW = false;
                pressedS = false;
                pressedA = false;
                return 6;
            }
            else if (pressedD)
            {
                pressedW = false;
                pressedS = false;
                pressedD = false;
                return 2;
            }
            else
            {
                pressedW = false;
                pressedS = false;
                pressedA = false;
                pressedD = false;
                return -1;
            }
        }
        else if (!(pressedW && pressedS) && (pressedA && pressedD))
        {
            if (pressedW)
            {
                pressedA = false;
                pressedD = false;
                pressedW = false;
                return 0;
            }
            else if (pressedS)
            {
                pressedA = false;
                pressedD = false;
                pressedS = false;
                return 4;
            }
            else
            {
                pressedW = false;
                pressedS = false;
                pressedA = false;
                pressedD = false;
                return -1;
            }
        }
        else
        {
            pressedW = false;
            pressedS = false;
            pressedA = false;
            pressedD = false;
            return -1;
        }
    }
}
