using UnityEngine;

public class tower : MonoBehaviour
{
    [SerializeField] private GameObject Tower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           int x = Random.Range(1, 30);
           int z = Random.Range(1, 30);
           int scale = Random.Range(1, 4);

            Vector3 pos = new Vector3(x, 0,z);

            Instantiate(Tower, pos, Quaternion.identity).transform.localScale = new Vector3(scale, scale, scale);
        }

    }
}
