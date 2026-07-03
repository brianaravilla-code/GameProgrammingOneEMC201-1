using System.Globalization;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    #region Variables / Parameters
    int level;
    string name;
    bool ischecking;
    float speed;

    float number =0;
    bool isEnable()
    {
        if (number >= 5)
        {
            number = 5;
            return false;
        }
        else
        {
            number += 0.01f;
            return true;
        }
    }
    #endregion

    #region Methods

    private void Awake()
    {
        Debug.Log("This code is Awake!!");
    }
    void Start()
    {
        //Debug.Log("my first unity project");

    }

    private void OnEnable()
    {
        Debug.Log("This code is enable!!");
    }
    private void OnDisable()
    {
        Debug.Log("This code is disable!!");
    }
    void Update() // per frame = 0.2
    {
        // Debug.Log("always Updating per Frame !!!!");
        gameObject.SetActive(isEnable());
    }
    private void FixedUpdate()// per fixed frame = 0.2 / physics system
    {
        //component rigidbod2d/rigidbody
        //component Character Controller
    }
    private void LateUpdate()
    {
        
    }
    #endregion
}
