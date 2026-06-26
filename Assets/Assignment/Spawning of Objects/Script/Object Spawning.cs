using TMPro;
using UnityEngine;

public class ObjectSpawning : MonoBehaviour
{
    [Header("Array of Objects")]
    [SerializeField] private Color[] COLOR;
    [SerializeField] private GameObject[] Object;
    [SerializeField] private TextMeshProUGUI Spawncounter;
    int Spawncount;

    
    // Update is called once per frame
    private void Start()
    {

    }

   
    private void Update()
    {
        
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-2f, 2f);
        float angle = Random.Range(0f, 360f);

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int spawnIndex = Random.Range(Object.Length-1, 0);
            Debug.Log("Object" + spawnIndex);
            int ColorIndex = Random.Range(COLOR.Length-1, 0);
            Debug.Log("Color" + ColorIndex);
            GameObject NEW = Instantiate(Object[spawnIndex]);
            NEW.name = "Spawned Object";
            NEW.transform.SetPositionAndRotation(new Vector3(x, y, 0f), Quaternion.Euler(angle, angle, angle));
            Rigidbody rb = NEW.AddComponent<Rigidbody>();

            MeshRenderer mesh = NEW.GetComponent<MeshRenderer>();
            NEW.GetComponent<Renderer>().material.color = COLOR[ColorIndex];
            Debug.Log("Object Spawned");
            Spawncount++;
            Spawncounter.text = "Number of Spawned Object " + Spawncount;
        }
    }
}
