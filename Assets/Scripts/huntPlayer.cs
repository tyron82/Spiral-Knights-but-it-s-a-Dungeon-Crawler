using UnityEngine;

public class huntPlayer : MonoBehaviour
{

    public Transform player;
    public int movementspeed = 5;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = player.transform.position - transform.position;
        direction = new Vector3(Mathf.Sign(direction.x), 0, Mathf.Sign(direction.z));
        transform.Translate(direction);

    }
}
