using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    private Rigidbody _playerRb;

    [HideInInspector]
    public Vector3 gravityDirection;

    void Start()
    {

    }
    void Update()
    {
        //applying directional movement
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        Gravity();
    }
    public void Gravity()
    {
        _playerRb.AddForce(gravityDirection * 9.81f * _playerRb.mass);
        transform.rotation = Quaternion.Euler(gravityDirection);
    }
}
