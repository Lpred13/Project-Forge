using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    [SerializeField] private float tempsAvantDestruction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= tempsAvantDestruction)
        {
            Dispose();
        }
    }

    private void Dispose()
    {
        Destroy(this.gameObject);
    }
}
