using UnityEngine;
using TMPro;
public class NFTDetails : MonoBehaviour
{
  public string name;
  public string description;
  public int maxSpeed;
  public int acceleration;
  public int nitro;
  public int steeringPower;
  public string color;

  private GameObject detailpanel;
  void Start()
  {
    detailpanel = GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(1).gameObject;
  }

  public void ShowAndSendDatatoUI()
  {
    detailpanel.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Name: " + name;
    detailpanel.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = "Description: " + description;
    detailpanel.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "MaxSpeed: " + maxSpeed;
    detailpanel.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(3).GetComponent<TextMeshProUGUI>().text = "Acceleration: " + acceleration;
    detailpanel.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(4).GetComponent<TextMeshProUGUI>().text = "Nitro: " + nitro;
    detailpanel.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(5).GetComponent<TextMeshProUGUI>().text = "SteeringPower: " + steeringPower;
    detailpanel.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(6).GetComponent<TextMeshProUGUI>().text = "Color: " + color;
    detailpanel.SetActive(true);
  }
}
