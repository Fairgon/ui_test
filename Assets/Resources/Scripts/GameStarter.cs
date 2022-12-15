using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField]
    private GameObject _petPopup = null;

    [Space]
    [SerializeField]
    private GameObject _tooltips = null;
    [SerializeField]
    private GameObject _additionalLine_1 = null;
    [SerializeField]
    private GameObject _additionalLine_2 = null;

    public void Close()
    {
        _petPopup.SetActive(false);
    }

    public void Open()
    {
        if (_petPopup.activeInHierarchy)
            return;

        _tooltips.SetActive(true);

        _additionalLine_1.SetActive(false);
        _additionalLine_2.SetActive(false);

        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(_petPopup.GetComponent<RectTransform>());

        _petPopup.SetActive(true);

        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(_petPopup.GetComponent<RectTransform>());
    }

    public void OpenNoTooltip()
    {
        if (_petPopup.activeInHierarchy)
            return;

        _tooltips.SetActive(false);

        _additionalLine_1.SetActive(false);
        _additionalLine_2.SetActive(false);

        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(_petPopup.GetComponent<RectTransform>());

        _petPopup.SetActive(true);
    }

    public void OpenMultyTooltip()
    {
        if (_petPopup.activeInHierarchy)
            return;

        _tooltips.SetActive(true);

        _additionalLine_1.SetActive(true);
        _additionalLine_2.SetActive(true);

        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(_petPopup.GetComponent<RectTransform>());

        _petPopup.SetActive(true);
    }
}
