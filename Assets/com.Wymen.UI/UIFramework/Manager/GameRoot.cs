﻿using UnityEngine;
namespace UIFramework
{
    public class GameRoot : MonoBehaviour
    {
        void Start()
        {
            UIManager.Instance.PushPanel(UIPanelType.MainMenu);
        }
    }
}
