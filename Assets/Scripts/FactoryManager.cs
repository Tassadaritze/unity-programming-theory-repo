using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class FactoryManager : ProductionManager
{
    private ProductionManager productionManager;
    // Tracks how much of a factory has been made
    private float productionProgress;
    // Start is called before the first frame update
    void Start()
    {
        // Get Production Manager instance
        productionManager = GameObject.Find("Production Manager").GetComponent<ProductionManager>();
    }

    // Update is called once per frame
    void Update()
    {
        productionProgress += Amount * production * Time.deltaTime;
        int toProduce = Mathf.FloorToInt(productionProgress);
        if (toProduce > 0)
        {
            Produce(toProduce);
            productionProgress -= toProduce;
        }
    }

    // POLYMORPHISM
    protected override void Produce(float amount)
    {
        productionManager.Amount += (int)amount;
    }
}
