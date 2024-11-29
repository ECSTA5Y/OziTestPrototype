using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class LevelButton : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public void SetButton(int levelIndex)
    {
        text.text = (levelIndex+1).ToString();
        GetComponent<Button>().onClick.AddListener(() =>
        {
            PersistentData.Instance.selectedLevelIndex = levelIndex;
            SceneManager.LoadScene(1);
        });
    }
}