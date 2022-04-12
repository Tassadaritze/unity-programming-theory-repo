using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionManager : MonoBehaviour
{
    // Amount of magic producers
    private int m_Amount = 1;
    public int Amount
    {
        get { return m_Amount; }
        set
        {
            if (value < 0)
            {
                throw new System.Exception("Tried to set producer amount to negative value");
            }
            else
            {
                m_Amount = value;
            }
        }
    }
    // How much magic one producer makes per second
    protected int production = 1;
    private MagicManager magicManager;
    // Start is called before the first frame update
    void Start()
    {
        // Get Magic Manager instance
        magicManager = GameObject.Find("Magic Manager").GetComponent<MagicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Produce(Amount * production * Time.deltaTime);
    }

    protected virtual void Produce(float magic)
    {
        magicManager.Magic += magic;
    }
}
