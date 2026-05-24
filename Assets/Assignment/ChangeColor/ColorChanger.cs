using System;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{

    [Header("Game Object Properties")]
        

    [Header("Enum types")]
    [SerializeField] private Colors color;

    [Header("Array of Objects")]
    [SerializeField] private Color[] COLOR;
    [SerializeField] private GameObject[] testGameObjects;


    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            switch (color)
            {
                case Colors.White:
                    testGameObjects[0].GetComponent<Renderer>().material.color = COLOR[0];
                    testGameObjects[1].GetComponent<Renderer>().material.color = COLOR[0];
                    testGameObjects[2].GetComponent<Renderer>().material.color = COLOR[0];
                    testGameObjects[3].GetComponent<Renderer>().material.color = COLOR[0];
                    Debug.Log("call OneObject");
                    break;
                case Colors.Black:
                    testGameObjects[0].GetComponent<Renderer>().material.color = COLOR[1];
                    testGameObjects[1].GetComponent<Renderer>().material.color = COLOR[1];
                    testGameObjects[2].GetComponent<Renderer>().material.color = COLOR[1];
                    testGameObjects[3].GetComponent<Renderer>().material.color = COLOR[1];
                    Debug.Log("call OneObject");
                    break;
                case Colors.Default:
                    testGameObjects[0].GetComponent<Renderer>().material.color = COLOR[2];
                    testGameObjects[1].GetComponent<Renderer>().material.color = COLOR[2];
                    testGameObjects[2].GetComponent<Renderer>().material.color = COLOR[2];
                    testGameObjects[3].GetComponent<Renderer>().material.color = COLOR[2];
                    Debug.Log("call OneObject");
                    break;
                

            }
            
        }

    }

    private void OnDisable()
    {
        testGameObjects[0].GetComponent<Renderer>().material.color = COLOR[2];
        testGameObjects[1].GetComponent<Renderer>().material.color = COLOR[2];
        testGameObjects[2].GetComponent<Renderer>().material.color = COLOR[2];
        testGameObjects[3].GetComponent<Renderer>().material.color = COLOR[2];
    }

    private enum Colors
    {
        White,
        Black,
        Default
    }
}
