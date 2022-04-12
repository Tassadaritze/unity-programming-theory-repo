using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Responsible for tracking and changing the basic currency type and UI elements related to it
public class MagicManager : MonoBehaviour
{
    private int increment = 1;
    // ENCAPSULATION
    private float m_Magic = 0;
    public float Magic
    {
        get { return m_Magic; }
        set
        {
            if (value < 0)
            {
                throw new System.Exception("Tried to set magic amount to negative value");
            }
            else
            {
                m_Magic = value;
                UpdateDisplay();
            }
        }
    }
    [SerializeField] TextMeshProUGUI magicDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ABSTRACTION
    // Increment basic currency amount by the current value of increment and update the counter for it (increment might be adjusted later by a prestige mechanic)
    public void HandleIncrement()
    {
        Magic += increment;
    }

    protected void UpdateDisplay()
    {
        magicDisplay.SetText("Magic\n\n" + Magic.ToString("n2"));
    }
}
