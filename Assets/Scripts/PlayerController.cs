using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 5.0f;

    void Start()
    {
        Managers.InputManager.KeyAction -= OnKeyboard;
        Managers.InputManager.KeyAction += OnKeyboard;
    }

    void Update()
    {

    }

    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // �ε巴�� ������ȯ, LookRotation�� 3��° ���ڰ��� 0.1f�� �������� �ε巴�� ��ȯ
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.1f);
            transform.Translate(_speed * Time.deltaTime * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.1f);
            transform.Translate(_speed * Time.deltaTime * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.1f);
            transform.Translate(_speed * Time.deltaTime * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.1f);
            transform.Translate(_speed * Time.deltaTime * Vector3.forward);
        }
    }
}
