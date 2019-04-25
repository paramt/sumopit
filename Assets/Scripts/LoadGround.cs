using UnityEngine;

public class LoadGround : MonoBehaviour
{

    public GameObject circle;

    void Start()
    {
        Instantiate(circle, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
