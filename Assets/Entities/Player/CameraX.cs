using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraX : MonoBehaviour
{
    [Range(0, 10)]
    public float smoothTime;

    void Start()
    {

    }
    void Update()
    {

    }

    public IEnumerator AnimatePositionChange(Transform pos)
    {
        float elapsedTime = 0f;
        Vector3 startingPos = transform.position;
        Quaternion startingRot = transform.rotation;
        while (elapsedTime < smoothTime)
        {
            transform.position = Vector3.Lerp(startingPos, pos.position, elapsedTime / smoothTime);
            transform.rotation = Quaternion.Lerp(startingRot, pos.rotation, elapsedTime / smoothTime);
            elapsedTime += Time.deltaTime;
            yield return null; // wait for the next frame
        }
        // ensure the final position and rotation are set
        transform.position = pos.position;
        transform.rotation = pos.rotation;
    }
    public void ChangePosition(Transform pos)
    {
        StartCoroutine("AnimatePositionChange",pos);
    }
}
