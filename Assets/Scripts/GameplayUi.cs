using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameplayUi : MonoBehaviour
{
    public static GameplayUi Instance;
    public Button shootBtn;
    public Button exitBtn;
    public GameObject winPanel;
    void Awake()
    {
        if (!Instance)
            Instance = this;
    }
    void Start()
    {
        Initialize();
    }
    void Initialize()
    {
        SpawnLevel();
        exitBtn.onClick.AddListener(() =>
        {
            DG.Tweening.DOTween.KillAll();
            SceneManager.LoadScene(0);
        });
    }
    void SpawnLevel()
    {
        Instantiate(PersistentData.Instance.assetsHolder.levels[PersistentData.Instance.selectedLevelIndex].gameObject, transform.position, Quaternion.identity);
    }
}