using UnityEngine;

public class DichChuyen : MonoBehaviour
{
    [SerializeField] GameObject Cong;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Cong != null)
        {
            transform.position = Cong.GetComponent<CongDichChuyen>().GetDiemDichChuyenDen().position;
        }
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("CongDichChuyen")) 
        {
            Cong = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CongDichChuyen"))
        {
            Cong = null;
        }
    }
}
