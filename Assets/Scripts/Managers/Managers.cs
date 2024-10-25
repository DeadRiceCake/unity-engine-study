using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;
    static Managers Instance { get { Init(); return s_instance; } }

    InputManager _inputManager = new InputManager();
    public static InputManager InputManager { get { return Instance._inputManager; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        _inputManager.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject gameObject = GameObject.Find("@Managers");

            if (gameObject == null)
            {
                gameObject = new GameObject { name = "@Managers" };
                gameObject.AddComponent<Managers>();
            }

            DontDestroyOnLoad(gameObject);
            s_instance = gameObject.GetComponent<Managers>();
        }
    }
}