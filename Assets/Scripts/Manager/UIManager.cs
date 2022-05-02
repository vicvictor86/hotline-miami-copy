using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    [SerializeField] private GameObject bulletQuantityUI;
    [SerializeField] private Gun gun;
    
    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.FindWithTag("Player").GetComponent<Gun>();
    }

    public void UpdateBullet()
    {
        bulletQuantityUI.GetComponent<Text>().text = gun.BulletCount.ToString();
    }
}
