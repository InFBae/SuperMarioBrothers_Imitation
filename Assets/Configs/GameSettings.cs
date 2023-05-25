using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        InitGameManager();
    }

    private static void InitGameManager()
    {
        if (GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = GameManager.DefaultName };
            gameManager.AddComponent<GameManager>();
        }
    }
}