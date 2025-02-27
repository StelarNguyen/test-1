using UnityEngine;
using TMPro;

public class XuLyVaCham : MonoBehaviour
{
    public int Mau = 3;
    public int Vang = 0;
    public TextMeshProUGUI TraiTimText;
    public TextMeshProUGUI VangText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VangText.SetText(Vang.ToString());
        TraiTimText.SetText(Mau.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Vang"))
        {
            Vang++;
            VangText.SetText(Vang.ToString());
            Destroy(collision.gameObject);
        }
       if(collision.CompareTag("GaiNhon"))
        {
            Mau--;
            TraiTimText.SetText(Mau.ToString());
        }

    }
}
