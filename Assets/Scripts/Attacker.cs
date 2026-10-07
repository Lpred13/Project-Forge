using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] private int degats = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision detected with: " + collision.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("Trigger exited with: " + collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("Collision ended with: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Vie vie = collision.GetComponent<Vie>();
            Animator animator = collision.GetComponent<Animator>();

            if (vie != null)
            {
                vie.PrendDegats(degats);
                animator.Play("EnemyAttacked", 0, 0f);




            }
            Debug.Log("Vie: " + collision.GetComponent<Vie>().VieActuelle);
        }
        Destroy(this.gameObject);

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Trigger stay with: " + collision.gameObject.name);
    }

    public void Dispose()
    {
        Destroy(this.gameObject);
    }
}
