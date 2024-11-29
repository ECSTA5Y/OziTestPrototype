using UnityEngine;
public class PersistentData : MonoBehaviour
{
    public static PersistentData Instance;
    public AssetsHolder assetsHolder;
    [HideInInspector] public int selectedLevelIndex;
    void Awake()
    {
        if (!Instance)
            Instance = this;
        else
            Destroy(gameObject);
    }
}