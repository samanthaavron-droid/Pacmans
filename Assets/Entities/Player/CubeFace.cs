using UnityEngine;

public class CubeFace : MonoBehaviour
{
    public Movement player;

    private CameraX _Camera;
    private Transform cameraPosition;

    private Vector3 _gravityDirection;

    void Start()
    {
        GameObject Camera = GameObject.Find("Main Camera");

        _Camera = Camera.GetComponent<CameraX>();
        cameraPosition = transform.GetChild(0);

        //GameObject playerObject = GameObject.Find("Player");
        player = GetComponent<Movement>();

        _gravityDirection = Vector3.down;
    }
    private void OnTriggerEnter(Collider detected)
    {
        if (detected.gameObject.name == "Player")
        {
            _Camera.ChangePosition(cameraPosition);
            player.gravityDirection = _gravityDirection;
        }
    }
}
