using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoroyJudge : MonoBehaviour
{
    GameObject box;
    public GameObject UnityChan;

    // Start is called before the first frame update
    void Start()
    {
        box = GameObject.Find("DestroyBox");
    }

    // Update is called once per frame
    void Update()
    {
        box.transform.position = new Vector3(0, 0, UnityChan.transform.position.z - 7);
    }

    void OnTriggerEnter(Collider collider)
    {
      if(collider.gameObject.tag == "CarTag" ||
         collider.gameObject.tag == "CoinTag" ||
         collider.gameObject.tag == "ConeTag")
      {
            Destroy(collider);
      }
    }
}
