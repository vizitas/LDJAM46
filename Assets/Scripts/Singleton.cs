using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T _instance;

    private static object _lock = new object();

    public static T Instance
    {
        get
        {
            //if (applicationIsQuitting)
            //    return null;

            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = (T)FindObjectOfType(typeof(T));

                    if (_instance == null)
                    {
                        GameObject singleton = new GameObject();
                        _instance = singleton.AddComponent<T>();
                        singleton.name = "(singleton) " + typeof(T).ToString();
                    }
                }

                return _instance;
            }
        }
    }

    protected virtual void OnDestroy()
    {
        _instance = null;
    }
}