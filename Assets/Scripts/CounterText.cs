using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterText : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public TextMeshProUGUI winTextObject;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        SetCountText();
        winTextObject.text = "";
    }

        void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 4 )
        {
            winTextObject.text = "You Win!";
        }
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;

            SetCountText();
        }
    }
}
