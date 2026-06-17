using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        transform.position =
            new Vector3(Mathf.Sin(Time.time) * 5f, 1f, 0f);
    }
}
