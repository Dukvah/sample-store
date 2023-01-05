using UnityEngine.Events;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector] public UnityEvent<SCItem> infoPanelOpen = new();
}
