using UnityEngine;

public class ObjectSpawning : MonoBehaviour
{
    [Header("Array of Objects")]
    [SerializeField] private Color[] COLOR;
    [SerializeField] private GameObject[] Object;
    
    // Update is called once per frame
    private void Start()
    {

    }

   
    private void Update()
    {
        int spawnIndex = Random.Range(6, -1);
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-2f, 2f);
        float angle = Random.Range(0f, 360f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject NEW = Instantiate(Object[spawnIndex]);
            NEW.name = "Spawned Object";
            NEW.transform.SetPositionAndRotation(new Vector3(x, y, 0f), Quaternion.Euler(angle, angle, angle));
            Rigidbody rb = NEW.AddComponent<Rigidbody>();

            MeshRenderer mesh = NEW.GetComponent<MeshRenderer>();
            NEW.GetComponent<Renderer>().material.color = COLOR[spawnIndex];
            Debug.Log("Object Spawned");
        }
    }
}
