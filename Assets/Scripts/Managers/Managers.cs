using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;
    static Managers Instance { get { Init(); return s_instance; } }

    InputManager _inputManager = new InputManager();
    ResourceManager _resourceManager = new ResourceManager();
    public static InputManager InputManager { get { return Instance._inputManager; } }
    public static ResourceManager ResourceManager { get { return Instance._resourceManager; } }

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