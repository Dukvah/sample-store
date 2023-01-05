using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InformationPanel : MonoBehaviour
{
    [SerializeField] private List<GameObject> showcaseObjects = new();
    
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemPrice;
    [SerializeField] private TextMeshProUGUI itemWeight;

    [SerializeField] private GameObject frame, background;

    private Button _closeButton;
    private SCItem _item;
    
    private void Awake()
    {
        ButtonInitialize();
    }

    private void OnEnable()
    {
        if (GameManager.Instance)
            GameManager.Instance.infoPanelOpen.AddListener(PanelOpener);
    }
    private void OnDisable()
    {
        if (GameManager.Instance)
            GameManager.Instance.infoPanelOpen.RemoveListener(PanelOpener);
    }

    private void ButtonInitialize()
    {
        _closeButton = GetComponentInChildren<Button>();
        _closeButton.onClick.AddListener(PanelCloser);
    }
    private void PanelOpener(SCItem item)
    {
        _item = item;

        itemName.text = _item.itemName;
        itemPrice.text = $"{_item.price}$";
        itemWeight.text = $"{_item.weight} KG";
        
        background.SetActive(true);
        showcaseObjects[item.itemIndex].SetActive(true);
        frame.transform.DOScale(1f, 0.5f);
    }

    private void PanelCloser()
    {
        showcaseObjects[_item.itemIndex].SetActive(false);
        frame.transform.DOScale(0f, 0.5f).OnComplete(() =>
        {
            background.SetActive(false);
        });
    }
}
