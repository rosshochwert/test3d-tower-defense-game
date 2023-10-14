using UnityEngine;

public class CameraController : MonoBehaviour

    public float panSpeed = 30f;
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward*panSpeed);
        }
    }
}
