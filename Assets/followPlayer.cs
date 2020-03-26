using UnityEngine;

public class followPlayer : MonoBehaviour
{
   public Transform player;

    public const int offsetX = 0;
    public const int offsetY = 235;
    public const int offsetZ = -160;
    public Vector3 offset = new Vector3(offsetX, offsetY, offsetZ);

    public const int rotationX = 310;
    public const int rotationW = 30;
    public Quaternion rotation = new Quaternion(rotationX,0,0,0);

    void Start() {
        transform.RotateAround(player.position, Vector3.up, 30 * Time.deltaTime); ;
        transform.position = player.position + offset;
    }
    void Update()
    {
        transform.position = player.position + offset;
    }
}
