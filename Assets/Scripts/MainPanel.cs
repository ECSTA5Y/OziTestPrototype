using UnityEngine;
using UnityEngine.UI;
public class MainPanel : MonoBehaviour
{
    [SerializeField] Button playButton;
    [SerializeField] LevelSelectionPanel levelSelectionPanel;
    void Start()
    {
        playButton.onClick.AddListener(()=>
        {
            levelSelectionPanel.gameObject.SetActive(true);
        });
    }
}