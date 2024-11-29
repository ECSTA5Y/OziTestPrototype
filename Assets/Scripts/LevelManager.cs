using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public List<BotController> aliveBots = new(), deadBots = new();
    void Awake()
    {
        if (!Instance)
            Instance = this;
    }
    public void BotDied(BotController botRef)
    {
        if (aliveBots.Contains(botRef))
            aliveBots.Remove(botRef);
        if (!deadBots.Contains(botRef))
            deadBots.Add(botRef);
        if (aliveBots.Count == 0)
            Invoke(nameof(LevelWon), 4f);
    }
    public void LevelWon()
    {
        GameplayUi.Instance.winPanel.SetActive(true);
    }
}
