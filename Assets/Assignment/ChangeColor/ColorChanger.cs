using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChanger : MonoBehaviour
{
    #region New input system
    private PlayerColor testInputs;

    [Header("Game Object Properties")]

    [SerializeField] private Transform GameObject;
    [SerializeField] private Vector3 ColorShift = new Vector3(0.3f, 0f, 0f);

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
            /*GameObject.position += ColorShift;//x,y,z //Vector2(0.3f, 0f) x,y*/
            switch (enumTypes)
            {
                case EnumTypes.OneObject:
                    testGameObjects[0].transform.position += ColorShift;
                    Debug.Log("call OneObject");
                    break;
                case EnumTypes.TwoObject:
                    testGameObjects[0].transform.position += ColorShift;
                    testGameObjects[1].transform.position += ColorShift;
                    Debug.Log("call TwoObject");
                    break;
                case EnumTypes.ThreeObject:
                    testGameObjects[0].transform.position += ColorShift;
                    testGameObjects[1].transform.position += ColorShift;
                    testGameObjects[2].transform.position += ColorShift;
                    Debug.Log("Changed 3 Objects' color");
                    break;
                case EnumTypes.FourObject:
                    testGameObjects[0].transform.position += ColorShift;
                    testGameObjects[1].transform.position += ColorShift;
                    testGameObjects[2].transform.position += ColorShift;
                    testGameObjects[3].transform.position += ColorShift;
                    Debug.Log("Changed 4 Objects' color");
                    break;
                case EnumTypes.FiveObject:
                    testGameObjects[0].transform.position += ColorShift;
                    testGameObjects[1].transform.position += ColorShift;
                    testGameObjects[2].transform.position += ColorShift;
                    testGameObjects[3].transform.position += ColorShift;
                    testGameObjects[4].transform.position += ColorShift;
                    Debug.Log("Changed 5 Objects' color");
                    break;

            }
        };


    }

    #endregion


}
