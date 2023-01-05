using UnityEngine;
using DG.Tweening;

public class Dot : MonoBehaviour
{
    [SerializeField] private SCItem itemObject;
    [SerializeField] private GameObject openText;
    private Camera _cam;

    private void Awake()
    {
        _cam = Camera.main;
    }
    private void Update()
    {
        transform.LookAt(_cam.transform);
    }

    private void OnMouseEnter()
    {
        openText.SetActive(true);
        transform.DOScale(0.035f, 1f);
    }
    private void OnMouseExit()
    {
        openText.SetActive(false);
        transform.DOScale(0.015f, 1f);
    }
    private void OnMouseDown()
    {
        GameManager.Instance.infoPanelOpen.Invoke(itemObject);
    }
}
