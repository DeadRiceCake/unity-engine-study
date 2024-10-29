using UnityEngine;

public class TestColision : MonoBehaviour
{
    // OnCollisionEnter �ߵ�����
    // 1. ������ Rigidbody�� �־�� �Ѵ�. (IsKinematic: off)
    // 2. ������ Collider�� �־�� �Ѵ�. (IsTrigger: off)
    // 3. ���濡�� Rigidbody�� �־�� �Ѵ�. (IsTrigger: off)
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
