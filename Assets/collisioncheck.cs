using UnityEngine;

public class collisioncheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Detected: " + other.gameObject.name + " at frame:" + Time.frameCount);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision Detected bumb: " + other.gameObject.name + " at frame:" + Time.frameCount);
    }
}
