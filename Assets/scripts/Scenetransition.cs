using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenetransition : MonoBehaviour
{
    [SerializeField] private Button newGamebutton;

    private void Start()
    {
        newGamebutton.onClick.AddListener(Rungamescene);
    }
    
    public void Rungamescene()
    {
        //Scene transition
        SceneManager.LoadScene("Spawn");
    }
}
