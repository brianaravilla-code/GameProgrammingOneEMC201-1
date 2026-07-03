using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private MeshRenderer renderer;
    [SerializeField] private Color color;

    private void Start()
    {
        renderer = transform.GetChild(0).GetComponent<MeshRenderer>();
        renderer.material.color = color;
    }

}
