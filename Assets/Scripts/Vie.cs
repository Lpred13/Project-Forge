using UnityEngine;

public class Vie : MonoBehaviour
{
    [SerializeField] private int vieMax=5;
    private int vieActuelle;

    public int VieMax { get => vieMax; set => vieMax = value; }
    public int VieActuelle { get => vieActuelle; set => vieActuelle = value; }
    //public bool isAttacked;
    private Animator myController;

    public AnimationClip degatsAnimation;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myController = this.GetComponent<Animator>();
        FullHeal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FullHeal()
    {
        vieActuelle = vieMax;
    }

    public void PrendDegats(int degats)
    {
        vieActuelle -= degats;
        if (vieActuelle <= 0)
        {
            Dispose();
        }
    }

    public void Dispose()
    {
        Destroy(this.gameObject);
    }

    public void IsAttacked(bool attacked)
    {
        myController.SetBool("isAttacked", attacked);
    }
}
