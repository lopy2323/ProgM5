using Unity.VisualScripting;
using UnityEngine;

public class makeball : MonoBehaviour
{
    [SerializeField]private GameObject prefab;
    private Material mat;
    private float elapsedTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        mat = prefab.GetComponent<MeshRenderer>().material;
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randpos1 = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
            CreateBall(color, randpos1);
        }
    }
    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }
    private void CreateBall(Color c, Vector3 postion)
    {
        GameObject ball = Instantiate(prefab, postion, Quaternion.identity);
        Material mat = ball.GetComponent<MeshRenderer>().material;
        mat.color = c;
        Destroy(ball, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        Vector3 randpos = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));

        if (elapsedTime > 1f)
        {
            Color randColor = RandomColor();
            elapsedTime = 0f;
            CreateBall(randColor,randpos);
        }
    }
}
