using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{

    #region Old input system
    /* if (Input.GetKeyDown(KeyCode.D))
     {
         GameObject.position += ChangePositionX;//x,y,z //Vector2(0.3f, 0f) x,y

         Debug.Log("D key pressed");   // Do something
     }
     if (Input.GetKeyDown(KeyCode.A))
     {
         GameObject.position -= ChangePositionX;//x,y,z //Vector2(0.3f, 0f) x,y

         Debug.Log("A key pressed");   // Do something
     }
     if (Input.GetKeyDown(KeyCode.W))
     {
         GameObject.position += ChangePositionY;//x,y,z //Vector2(0.3f, 0f) x,y

         Debug.Log("W key pressed");   // Do something
     }
     if (Input.GetKeyDown(KeyCode.S))
     {
         GameObject.position -= ChangePositionY;//x,y,z //Vector2(0.3f, 0f) x,y

         Debug.Log("S key pressed");   // Do something
     }*/
    #endregion

    #region New input system
    private PlayerTestInput testInputs;

    [Header("Game Object Properties")]

    [SerializeField] private Transform GameObject;
    [SerializeField] private Vector3 ChangePositionX = new Vector3(0.3f, 0f, 0f);
    [SerializeField] private Vector3 ChangePositionY = new Vector3(0f, 0.3f, 0f);

    [Header("Enum types")]
    [SerializeField] private EnumTypes enumTypes;

    [Header("Array of Objects")]
    [SerializeField] private GameObject[] testGameObjects;
    private void Awake()
            {
            testInputs = new PlayerTestInput();
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
            testInputs.TestInput.ChangePositionX.performed += ctx =>
            {
                /*GameObject.position += ChangePositionX;//x,y,z //Vector2(0.3f, 0f) x,y*/
                switch (enumTypes)
                {
                    case EnumTypes.OneObject:
                        testGameObjects[0].transform.position += ChangePositionX;
                        Debug.Log("call OneObject");
                        break;
                    case EnumTypes.TwoObject:
                        testGameObjects[0].transform.position += ChangePositionX;
                        testGameObjects[1].transform.position += ChangePositionX;
                        Debug.Log("call TwoObject");
                        break;
                    case EnumTypes.ThreeObject:
                        testGameObjects[0].transform.position += ChangePositionX;
                        testGameObjects[1].transform.position += ChangePositionX;
                        testGameObjects[2].transform.position += ChangePositionX;
                        Debug.Log("call ThreeObject");
                        break;

                }
            };

            
        }

    #endregion


}   

public enum EnumTypes
{
    OneObject,
    TwoObject,
    ThreeObject
}


