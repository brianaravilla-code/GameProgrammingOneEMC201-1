using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Material Base;
    [SerializeField] private Material OFF;
    [SerializeField] private Material ON;

    #region New input system
    private PlayerColor testInputs;

    [Header("Game Object Properties")]
    [SerializeField] private Button ColorShift;

    [Header("Enum types")]
    [SerializeField] private EnumTypes enumTypes;

    [Header("Array of Objects")]
    [SerializeField] private GameObject[] testGameObjects;
    private void Awake()
    {
        testInputs = new PlayerColor();
    }

    private void OnEnable()
    {
        testInputs.Enable();
    }

    private void OnDisable()
    {
        testInputs.Disable();
    }

    private void Start()
    {
        testInputs.ChangeColor.ColorShift.performed += ctx =>
        {
            Base.mainTexture = OFF.mainTexture;
                switch (enumTypes)
            {
                case EnumTypes.OneObject:
                    ChangeColors(, Color.red);
                    Debug.Log("call OneObject");
                    break;
            }
        };


    }

    #endregion


}
