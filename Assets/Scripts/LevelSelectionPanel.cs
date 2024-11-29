using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelectionPanel : MonoBehaviour
{
    [SerializeField] MainPanel mainPanel;
    [SerializeField] LevelButton buttonPrefab;
    [SerializeField] GridLayoutGroup gridLayout;
    void Start()
    {
        SetUpButtons();
    }
    void SetUpButtons()
    {
        for (int i = 0; i < PersistentData.Instance.assetsHolder.levels.Count; i++)
        {
            LevelButton obj = Instantiate(buttonPrefab, gridLayout.transform);
            obj.SetButton(i);
        }
    }
}