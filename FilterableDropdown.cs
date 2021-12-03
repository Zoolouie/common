using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class FilterableDropdown : MonoBehaviour
{
    [SerializeField] RectTransform dropdownButton;
    [SerializeField] RectTransform templateButton;

    [SerializeField] TMP_InputField searchInput;

    // Start is called before the first frame update
    void Start()
    {
        templateButton.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, dropdownButton.rect.height);
    }
}
