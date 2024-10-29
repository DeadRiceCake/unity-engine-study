using UnityEngine;

public class TestColision : MonoBehaviour
{
    // OnCollisionEnter 발동조건
    // 1. 나한테 Rigidbody가 있어야 한다. (IsKinematic: off)
    // 2. 나한테 Collider가 있어야 한다. (IsTrigger: off)
    // 3. 상대방에게 Rigidbody가 있어야 한다. (IsTrigger: off)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
