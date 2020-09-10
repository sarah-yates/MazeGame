using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerScript : MonoBehaviour
{
    
    public TextMeshProUGUI CountText;
    public GameObject winTextObject;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        setCountText();
        winTextObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            setCountText();
        }

    }

    void setCountText()
    {
        CountText.text = "Count: " + count.ToString();
        if(count >= 6)
        {
            winTextObject.SetActive(true);
        }
        
    }
}
